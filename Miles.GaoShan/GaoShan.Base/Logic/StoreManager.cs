using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GaoShan.Sales.Logic;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;


namespace GaoShan.Sales.Logic
{
    public class StoreManager : LogicManager<Model.Info_store_main>
    {
        MatchTbManager matchTbManager = new MatchTbManager();

        public override bool Add(Info_store_main t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_store_main t)
        {
            throw new NotImplementedException();
        }

        public override List<Info_store_main> FindAll(params object[] parms)
        {
            return this.Repository.Query().From<GaoShan.Sales.Model.Tb_mtl_item>()
                .ToSelect().EndSelect()
                .ToQuery()
                .LeftJoin<Model.Tb_store_main>()
                .On(GaoShan.Sales.Model.Tb_mtl_item.Table.Mtl_Code, Model.Tb_store_main.Table.Mtl_Code)
                .JoinTable()
                .ToSelect()
                .Select(Model.Tb_store_main.Table.Mtl_Code,true)
                .EndSelect()
                .ToQuery()
                .ToList<Info_store_main>();
        }

        public List<Info_store_in_item> GetInItems(long linkBill_Id)
        {
            //之前出库的数量
            Dictionary<string, decimal> dicOutItems = FindDoneOutItems(linkBill_Id);
            //已经入库数量
            Dictionary<string, decimal> dicInItems = FindDoneInItems(linkBill_Id);
            //预入库的数量
            Dictionary<string, Info_store_in_item> dicPreItems = new Dictionary<string, Info_store_in_item>();
            foreach (string mtlCode in dicOutItems.Keys)
            {
                if (!dicPreItems.ContainsKey(mtlCode))
                {
                    Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[mtlCode];
                    Info_store_in_item item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Info_store_in_item>(mtl);
                    item.Already_OutQty = dicOutItems[mtlCode];
                    item.Already_InQty = 0;

                    dicPreItems.Add(mtlCode, item);
                }
                else
                {
                    dicPreItems[mtlCode].Already_OutQty += dicOutItems[mtlCode];
                }
            }

            foreach (string mtlCode in dicInItems.Keys)
            {
                if (!dicPreItems.ContainsKey(mtlCode))
                {
                    Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[mtlCode];
                    Info_store_in_item item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Info_store_in_item>(mtl);
                    item.Already_OutQty = 0;
                    item.Already_InQty = dicInItems[mtlCode];

                    dicPreItems.Add(mtlCode, item);
                }
                else
                {
                    dicPreItems[mtlCode].Already_InQty+= dicInItems[mtlCode];
                }
            }

            return dicPreItems.Values.ToList<Info_store_in_item>();
        }

        public List<Q_store_out_item> QueryStoreOutRecord(object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_store_out>()
             .Select()
             .Field(Model.Tb_store_out.Table.StoreOut_Id, true)
             .End()
             .Where()
             .And(Model.Tb_store_out.Table.StoreOut_State, (int)Enum.OutStoreState.Valid);

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_store_out.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_store_out.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_store_out.Table.Odr_No, odrNo);
            }
          
            List<Q_store_out_item> list = wherePart
             .End()
             .InnerJoin<Model.Tb_store_out_item>()
             .On(Model.Tb_store_out.Table.StoreOut_Id, Model.Tb_store_out_item.Table.StoreOut_Id)
             .JoinTable()
             .Select().End()
             .Where()
             .And(Model.Tb_store_out_item.Table.Mtl_Qty, Miles.Coro.ORM.DbCompareChar.More, 0)
             .End()
             .ToQuery()
             .ToList<Q_store_out_item>();

            for (int i = 0; i < list.Count; i++)
            {
                Q_store_out_item item = list[i];
                Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[item.Mtl_Code];
                item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Q_store_out_item>(mtl, item);
            }

            return list;
        }

        public List<Q_store_in_item> QueryStoreInRecord(object beginTime, object endTime,string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_store_in>()
           .Select()
           .Field(Model.Tb_store_in.Table.StoreIn_Id, true)
           .End()
           .Where()
           .And(Model.Tb_store_in.Table.StoreIn_State, (int)Enum.InStoreState.Valid);

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_store_in.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_store_in.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_store_in.Table.Odr_No, odrNo);
            }

            List<Q_store_in_item> list= wherePart.End()
           .InnerJoin<Model.Tb_store_in_item>()
           .On(Model.Tb_store_in.Table.StoreIn_Id, Model.Tb_store_in_item.Table.StoreIn_Id)
           .JoinTable()
           .Select().End()
           .Where()
           .And(Model.Tb_store_in_item.Table.Mtl_Qty, Miles.Coro.ORM.DbCompareChar.More, 0)
           .End()
           .ToQuery()
           .ToList<Q_store_in_item>();

            for (int i = 0; i < list.Count; i++)
            {
                Q_store_in_item item = list[i];
                Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[item.Mtl_Code];
                item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Q_store_in_item>(mtl, item);
            }

            return list;
        }

        public List<Info_store_out_item> QueryOutItems(long linkBillId)
        {
            List<Info_store_out_item> list = this.Repository.Query().From<Tb_store_out>()
                .ToWhere()
                .And(Tb_store_out.Table.StoreOut_State,(int)Enum.OutStoreState.Valid)
                .And(Tb_store_out.Table.LinkBill_Id, linkBillId)
                .EndWhere()
                .ToQuery()
                .LeftJoin<Tb_store_out_item>()
                .On(Tb_store_out.Table.StoreOut_Id, Tb_store_out_item.Table.StoreOut_Id)
                .JoinTable()
                .ToSelect()
                .Select(Tb_store_out_item.Table.StoreOut_Id, true)
                .EndSelect()
                .ToQuery()
              .ToList<Info_store_out_item>();

            for (int i = 0; i < list.Count; i++)
            {
                Info_store_out_item item = list[i];
                Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[item.Mtl_Code];
                item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Info_store_out_item>(mtl, item);
            }

            return list;
        }

        public bool DoneBackOrder(Info_link_bill info)
        {
            //更新项目联络单完成标志位
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Update<Tb_link_bill>()
                .Set().Field(Tb_link_bill.Table.Is_BackStore, (int)Enum.IsFlag.Yes)
                .EndSet()
                .Where()
                .And(Tb_link_bill.Table.LinkBill_Id,id)
                .EndWhere()
                .Save() < 1)
                {
                    return false;
                }

                return true;
            }, info.LinkBill_Id);

            return exeBatchTrans.Save();
        }

        public bool DoneOut(Info_link_bill link)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Update<Tb_link_bill>()
                .Set().Field(Tb_link_bill.Table.Is_OutStore, (int)Enum.IsFlag.Yes)
                .EndSet()
                .Where()
                .And(Tb_link_bill.Table.LinkBill_Id, id)
                .EndWhere()
                .Save() < 1)
                {
                    return false;
                }

                return true;
            }, link.LinkBill_Id);

            return exeBatchTrans.Save();
        }

        public List<Info_store_in> FindNotDoneInDir()
        {
            List<Info_store_in> list = this.Repository.Query().From<Tb_store_in>()
                 .ToSelect().EndSelect()
                 .ToWhere()
                 .And(Tb_store_in.Table.StoreIn_State, (int)Enum.InStoreState.New)
                 .And(Tb_store_in.Table.StoreIn_Type,(int)Enum.InStoreType.DirIn)
                 .EndWhere()
                 .ToQuery()
                 .LeftJoin<Tb_store_in_item>()
                 .On(Tb_store_in.Table.StoreIn_Id, Tb_store_in_item.Table.StoreIn_Id)
                 .JoinTable()
                 .ToSelect()
                 .Select(Tb_store_in_item.Table.StoreIn_Id, true)
                 .EndSelect()
                 .ToQuery()
                 .QueryOneMany<Info_store_in, Info_store_in_item, Info_store_in>(
                 (m, i) => {
                     if (i.StoreIn_Id != 0) { m.Items.Add(i); }
                     return m;
                 }
                 , Tb_store_in.Table.StoreIn_Id
                 );

            foreach (Info_store_in info in list)
            {
                for (int i = 0; i < info.Items.Count; i++)
                {
                    Info_store_in_item item = info.Items[i];
                    Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[item.Mtl_Code];
                    item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Info_store_in_item>(mtl, item);
                }
            }

            return list;
        }

        private Dictionary<string, decimal> FindDoneInItems(long linkBill_Id)
        {
            List<Info_store_in_item> list = this.Repository.Query().From<Tb_store_in_item>()
                  .ToSelect().EndSelect()
                  .ToQuery()
                  .LeftJoin<Tb_store_in>()
                  .On(Tb_store_in_item.Table.StoreIn_Id, Tb_store_in.Table.StoreIn_Id)
                  .JoinTable()
                  .ToWhere()
                  .And(Tb_store_in.Table.LinkBill_Id, linkBill_Id)
                  .And(Tb_store_in.Table.StoreIn_State, (int)Enum.InStoreState.Valid)
                  .EndWhere()
                  .ToQuery()
                  .ToList<Info_store_in_item>();

            Dictionary<string, decimal> dics = new Dictionary<string, decimal>();
            foreach (Info_store_in_item item in list)
            {
                if (!dics.ContainsKey(item.Mtl_Code))
                {
                    dics.Add(item.Mtl_Code, 0);
                }

                dics[item.Mtl_Code] += item.Mtl_Qty;
            }

            return dics;
        }

        public List<Info_store_out_item> GetOutItems(long linkBill_Id)
        {
            //根据配套部的项目，查询
            List<Info_matchTb> ltMatchTb = matchTbManager.FindDoneLinkMatchTbs(linkBill_Id);
            //已经出库的数据
            Dictionary<string, decimal> dicOutItems = FindDoneOutItems(linkBill_Id);
            Dictionary<string, Info_store_out_item> dicPreItems = new Dictionary<string, Info_store_out_item>();
            foreach(Info_matchTb matchTb in ltMatchTb)
            {
                foreach(Info_matchTb_item matchTbItem in matchTb.Items)
                {
                    if (!dicPreItems.ContainsKey(matchTbItem.Mtl_Code))
                    {
                        Info_store_out_item item = Miles.Coro.Common.Utils.CopyToOther<Info_matchTb_item, Info_store_out_item>(matchTbItem);
                        item.Item_Id = 0;
                        item.Mtl_Qty = 0;
                        item.Plan_OutQty = 0;
                        item.Already_OutQty = dicOutItems.ContainsKey(matchTbItem.Mtl_Code) ? dicOutItems[matchTbItem.Mtl_Code] : 0;
                        dicPreItems.Add(matchTbItem.Mtl_Code, item);
                    }

                    dicPreItems[matchTbItem.Mtl_Code].Plan_OutQty += matchTbItem.Item_Count;
                }
            }

            return dicPreItems.Values.ToList<Info_store_out_item>();
        }

 

        public List<Info_store_in> FindNotDoneBackOrder()
        {
            List<Info_store_in> list = this.Repository.Query().From<Tb_store_in>()
                 .ToSelect().EndSelect()
                 .ToWhere()
                 .And(Tb_store_in.Table.StoreIn_State, (int)Enum.InStoreState.New)
                 .And(Tb_store_in.Table.StoreIn_Type, (int)Enum.InStoreType.OrderBackIn)
                 .EndWhere()
                 .ToQuery()
                 .LeftJoin<Tb_store_in_item>()
                 .On(Tb_store_in.Table.StoreIn_Id, Tb_store_in_item.Table.StoreIn_Id)
                 .JoinTable()
                 .ToSelect()
                 .Select(Tb_store_in_item.Table.StoreIn_Id, true)
                 .EndSelect()
                 .ToQuery()
                 .QueryOneMany<Info_store_in, Info_store_in_item, Info_store_in>(
                 (m, i) => {
                     if (i.StoreIn_Id != 0) { m.Items.Add(i); }
                     return m;
                 }
                 , Tb_store_in.Table.StoreIn_Id
                 );

            foreach (Info_store_in info in list)
            {
                for (int i = 0; i < info.Items.Count; i++)
                {
                    Info_store_in_item item = info.Items[i];
                    Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[item.Mtl_Code];
                    item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Info_store_in_item>(mtl, item);
                }
            }

            return list;
        }

        public bool RemoveIn(Info_store_in info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<long>((r, id) =>
            {
                return r.Remove<Tb_store_in>().Where().And(Tb_store_in.Table.StoreIn_Id, id)
                .EndWhere().Save() > 0 ? true : false;

            }, info.StoreIn_Id);

            exeBatchTrans.Append<long>((r, id) =>
            {
                return r.Remove<Tb_store_in_item>().Where().And(Tb_store_in_item.Table.StoreIn_Id, id)
                .EndWhere().Save() > 0 ? true : false;

            }, info.StoreIn_Id);


            return exeBatchTrans.Save();
        }

        public List<Info_store_out> FindNotDoneOutOrder()
        {
            List<Info_store_out> list = this.Repository.Query().From<Tb_store_out>()
                 .ToSelect().EndSelect()
                 .ToWhere()
                 .And(Tb_store_out.Table.StoreOut_State, (int)Enum.OutStoreState.New)
                 .And(Tb_store_out.Table.StoreOut_Type,(int)Enum.OutStoreType.OrderOut)
                 .EndWhere()
                 .ToQuery()
                 .LeftJoin<Tb_store_out_item>()
                 .On(Tb_store_out.Table.StoreOut_Id, Tb_store_out_item.Table.StoreOut_Id)
                 .JoinTable()
                 .ToSelect()
                 .Select(Tb_store_out_item.Table.StoreOut_Id, true)
                 .EndSelect()
                 .ToQuery()
                 .QueryOneMany<Info_store_out, Info_store_out_item, Info_store_out>(
                 (m, i) => {
                     if (i.StoreOut_Id != 0) { m.Items.Add(i); }
                     return m;
                 }
                 , Tb_store_out.Table.StoreOut_Id
                 );

            foreach(Info_store_out info in list)
            {
                for(int i=0;i<info.Items.Count;i++)
                {
                    Info_store_out_item item = info.Items[i];
                    Info_mtl_item mtl = Cache.LogicCache.DicMtlItem[item.Mtl_Code];
                    item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Info_store_out_item>(mtl,item);
                }
            }

            return list;
        }

        public bool CommitIn(Info_store_in info)
        {
            //修改状态
            //更正库存数量
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Update<Tb_store_in>()
                .Set().Field(Tb_store_in.Table.StoreIn_State, (int)Enum.InStoreState.Valid)
                .EndSet()
                .Where()
                .And(Tb_store_in.Table.StoreIn_Id, info.StoreIn_Id)
                .EndWhere()
                .Save() < 1)
                {
                    return false;
                }

                return true;
            }, info.StoreIn_Id);

            foreach (Info_store_in_item item in info.Items)
            {
                exeBatchTrans.Append<Info_store_in_item>((r, t) =>
                {
                    if (r.Update<Tb_store_main>()
                        .Set()
                        .Increase(Tb_store_main.Table.Mtl_Qty, item.Mtl_Qty)
                        .EndSet()
                        .Where()
                        .And(Tb_store_main.Table.Mtl_Code, item.Mtl_Code)
                        .EndWhere()
                        .Save() < 1)
                    {
                        return false;
                    }

                    return true;
                }, item);
            }

            return exeBatchTrans.Save();
        }

        public bool CommitOut(Info_store_out info)
        {
            //修改状态
            //更正库存数量
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Update<Tb_store_out>()
                .Set().Field(Tb_store_out.Table.StoreOut_State, (int)Enum.OutStoreState.Valid)
                .EndSet()
                .Where()
                .And(Tb_store_out.Table.StoreOut_Id, info.StoreOut_Id)
                .EndWhere()
                .Save() < 1)
                {
                    return false;
                }

                return true;
            }, info.StoreOut_Id);

            foreach (Info_store_out_item item in info.Items)
            {
                exeBatchTrans.Append<Info_store_out_item>((r, t) =>
                {
                    if (r.Update<Tb_store_main>()
                        .Set()
                        .Decrease(Tb_store_main.Table.Mtl_Qty,item.Mtl_Qty)
                        .EndSet()
                        .Where()
                        .And(Tb_store_main.Table.Mtl_Code, item.Mtl_Code)
                        .EndWhere()
                        .Save() < 1)
                    {
                        return false;
                    }

                    return true;
                }, item);
            }

            return exeBatchTrans.Save();
        }

        public bool SaveOut(Info_store_out info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<long>((r, id) =>
            {
                if( r.Remove<Tb_store_out>()
                .Where()
                .And(Tb_store_out.Table.StoreOut_Id, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, info.StoreOut_Id);

            exeBatchTrans.Append<long>((r, id) =>
            {
                if( r.Remove<Tb_store_out_item>()
                .Where()
                .And(Tb_store_out_item.Table.StoreOut_Id, id)
                .EndWhere().Save() < 0)
                {
                    return false;
                }

                return true;

            }, info.StoreOut_Id);

            info.StoreOut_Id = NewId();
            exeBatchTrans.Append<Info_store_out>((r, i) =>
                              {
                                  return this.Add(r, i);
                              }, info);

            foreach (Info_store_out_item item in info.Items)
            {
                exeBatchTrans.Append<Tb_store_out_item>((r, t) =>
                {
                    t.Item_Id = NewId();
                    t.StoreOut_Id = info.StoreOut_Id;
                    return this.Add(r, t);
                }, item);
            }

            return exeBatchTrans.Save();

        }

        public bool RemoveOut(Info_store_out info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<long>((r,id)=> 
            {
                return r.Remove<Tb_store_out>().Where().And(Tb_store_out.Table.StoreOut_Id, id)
                .EndWhere().Save() > 0 ? true : false;
                
            },info.StoreOut_Id);

            exeBatchTrans.Append<long>((r, id) =>
            {
                return r.Remove<Tb_store_out_item>().Where().And(Tb_store_out_item.Table.StoreOut_Id, id)
                .EndWhere().Save() > 0 ? true : false;

            }, info.StoreOut_Id);


            return exeBatchTrans.Save();
        }

        //public bool AddStoreOut(Info_store_out info)
        //{
        //    info.StoreOut_Id = NewId();

        //    ExeBatchTrans exeBatchTrans = this.BatchTrans()
        //          .Append<Info_store_out>((r, i) =>
        //          {
        //              return this.Add(r, i);
        //          }, info);

        //    foreach(Info_store_out_item item in info.Items)
        //    {
        //        exeBatchTrans.Append<Tb_store_out_item>((r,t)=> 
        //        {
        //            t.Item_Id = NewId();
        //            t.StoreOut_Id = info.StoreOut_Id;
        //            return this.Add(r, t);
        //        },item);
        //    }
        //    return exeBatchTrans.Save();
        //}

        private Dictionary<string, decimal> FindDoneOutItems(long linkBill_Id)
        {
            List<Info_store_out_item> list = this.Repository.Query().From<Tb_store_out_item>()
                 .ToSelect().EndSelect()
                 .ToQuery()
                 .LeftJoin<Tb_store_out>()
                 .On(Tb_store_out_item.Table.StoreOut_Id, Tb_store_out.Table.StoreOut_Id)
                 .JoinTable()
                 .ToWhere()
                 .And(Tb_store_out.Table.LinkBill_Id,linkBill_Id)
                 .And(Tb_store_out.Table.StoreOut_State, (int)Enum.OutStoreState.Valid)
                 .EndWhere()
                 .ToQuery()
                 .ToList<Info_store_out_item>();

            Dictionary<string, decimal> dics = new Dictionary<string,decimal>();
            foreach(Info_store_out_item item in list)
            {
                if (!dics.ContainsKey(item.Mtl_Code))
                {
                    dics.Add(item.Mtl_Code, 0);
                }

                dics[item.Mtl_Code] += item.Mtl_Qty;
            }

            return dics;
        }


        public bool SaveIn(Info_store_in info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Remove<Tb_store_in>()
                .Where()
                .And(Tb_store_in.Table.StoreIn_Id, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, info.StoreIn_Id);

            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Remove<Tb_store_in_item>()
                .Where()
                .And(Tb_store_in_item.Table.StoreIn_Id, id)
                .EndWhere().Save() < 0)
                {
                    return false;
                }

                return true;

            }, info.StoreIn_Id);

            info.StoreIn_Id = NewId();
            exeBatchTrans.Append<Info_store_in>((r, i) =>
            {
                return this.Add(r, i);
            }, info);

            foreach (Info_store_in_item item in info.Items)
            {
                exeBatchTrans.Append<Tb_store_in_item>((r, t) =>
                {
                    t.Item_Id = NewId();
                    t.StoreIn_Id = info.StoreIn_Id;
                    return this.Add(r, t);
                }, item);
            }

            return exeBatchTrans.Save();
        }

        //public bool AddStoreIn(Info_store_in info)
        //{
        //    info.StoreIn_Id = NewId();

        //    ExeBatchTrans exeBatchTrans = this.BatchTrans()
        //          .Append<Info_store_in>((r, i) =>
        //          {
        //              return this.Add(r, i);
        //          }, info);

        //    foreach (Info_store_in_item item in info.Items)
        //    {
        //        exeBatchTrans.Append<Tb_store_in_item>((r, t) =>
        //        {
        //            t.Item_Id = NewId();
        //            t.StoreIn_Id = info.StoreIn_Id;
        //            return this.Add(r, t);
        //        }, item);
        //    }
        //    return exeBatchTrans.Save();
        //}

        public int GetStoreState()
        {
            Model.Tb_store_state info = this.Repository.Query()
                .From<Model.Tb_store_state>()
                .ToSelect().EndSelect()
                .ToQuery()
                .First<Model.Tb_store_state>();

            return info != null ? info.State : 0;
        }

        public List<Info_store_check> GetCheckStore()
        {
           return this.Repository.Query().From<Tb_store_check>()
                 .ToSelect().EndSelect()
                 .ToQuery()
                 .LeftJoin<Tb_mtl_item>()
                 .On(Tb_store_check.Table.Mtl_Code, Tb_mtl_item.Table.Mtl_Code)
                 .JoinTable()
                 .ToSelect()
                 .Select(Tb_mtl_item.Table.Mtl_Code,true)
                 .EndSelect()
                 .ToQuery()
                 .ToList<Info_store_check>();
        }

        public bool StartCheckStore()
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            //更新库存状态为盘库锁定
            exeBatchTrans.Append<int>((r,s)=> 
            {
                return DoUpdateStoreState(r, Enum.StoreState.LockStore);
            },0);


            //清理盘库表数据
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoClearCheckStore(r);
            }, 0);

            //将库存表数据复制到盘库表中
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoCopyStoreToCheckStore(r);
            }, 0);
          
            return exeBatchTrans.Save();
        }

        private bool DoClearCheckStore(Miles.Coro.ORM.Repository repository)
        {
            if (repository.Remove<Model.Tb_store_check>().Save() >= 0)
            {
                return true;
            }

            return false;
        }

        private bool DoCopyStoreToCheckStore(Miles.Coro.ORM.Repository repository)
        {
            List < Model.Info_store_main> list = this.FindAll();


            foreach (Model.Info_store_main info in list)
            {

                Model.Tb_store_check item = new Tb_store_check();
                item.Check_Qty = info.Mtl_Qty;
                item.Mtl_Code = info.Mtl_Code;
                item.Mtl_Qty = info.Mtl_Qty;
                item.Store_Room = info.Store_Room;
                if (!repository.Add(item))
                {
                    return false;
                }

            }

            return true;
        }

        private bool DoUpdateStoreState(Miles.Coro.ORM.Repository repository, Enum.StoreState storeState)
        {
            if (repository.Update<Tb_store_state>()
                .Set()
                .Field(Model.Tb_store_state.Table.State, (int)storeState)
                .EndSet()
                .Save() > 0)
            {

                return true;
            }

            return false;
        }

        public bool SaveCheckStore(List<Model.Info_store_check> list)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoSaveCheckStore(r, list);
            }, 0);

            return exeBatchTrans.Save();
        }

        private bool DoSaveCheckStore(Miles.Coro.ORM.Repository repository, List<Model.Info_store_check> list)
        {
            foreach (Model.Info_store_check info in list)
            {
                if (repository.Update< Tb_store_check>()
                    .Set().Field(Model.Tb_store_check.Table.Check_Qty, info.Check_Qty)
                    .EndSet()
                    .Where()
                    .And(Model.Tb_store_check.Table.Mtl_Code, info.Mtl_Code)
                    .EndWhere()
                    .Save() < 1)
                {

                    return false;
                }

            }

            return true;
        }

        public bool CommitCheckStore(List<Model.Info_store_check> list)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoSaveCheckStore(r, list);
            }, 0);


            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoUpdateStoreState(r, Enum.StoreState.Commit);
            }, 0);

            return exeBatchTrans.Save();
        }

        public bool CancelCheckStore()
        {

            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            //更新库存状态为
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoUpdateStoreState(r, Enum.StoreState.Normal);
            }, 0);

            //清理盘库表数据
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoClearCheckStore(r);
            }, 0);

            return exeBatchTrans.Save();
        }

        public bool PermitCheckStore(List<Model.Info_store_check> list)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            //更新库存状态为
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoUpdateStoreState(r, Enum.StoreState.Normal);
            }, 0);

            //清理盘库表数据
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoClearCheckStore(r);
            }, 0);

            //更新库存
            exeBatchTrans.Append<List<Model.Info_store_check>>((r, lt) =>
            {
                return DoSyncCheckStoreToStore(r,lt);
            }, list);

            //记录日志
            exeBatchTrans.Append<List<Model.Info_store_check>>((r, lt) =>
            {
                return DoLogCheckStore(r, lt);
            }, list);

            //清理盘库表
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoClearCheckStore(r);
            }, 0);

            return exeBatchTrans.Save();

        }

        private bool DoLogCheckStore(Miles.Coro.ORM.Repository repository, List<Model.Info_store_check> list)
        {
            if (list != null)
            {

                if (repository.Remove<Model.Tb_store_check_log>().Save() < 1)
                {
                    return false;
                }

                foreach (Model.Info_store_check info in list)
                {
                    Model.Tb_store_check_log item = Miles.Coro.Common.Utils.CopyToOther<Model.Info_store_check, Model.Tb_store_check_log>(info);
                    if (!repository.Add(item))
                    {
                        return false;
                    }

                }
            }

            return true;
        }

        private bool DoSyncCheckStoreToStore(Miles.Coro.ORM.Repository repository, List<Model.Info_store_check> list)
        {
            if (list != null)
            {
                if (repository.Remove<Model.Tb_store_main>().Save() < 1)
                {
                    return false;
                }

                foreach (Model.Info_store_check info in list)
                {
                    Model.Tb_store_main item = new Model.Tb_store_main();
                    item.Mtl_Qty = info.Check_Qty;
                    item.Mtl_Code = info.Mtl_Code;
                    item.Store_Room = info.Store_Room;
                    if (!repository.Add(item))
                    {
                        return false;
                    }

                }
            }

            return true;
        }

        public bool RejectCheckStore()
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            //更新库存状态为
            exeBatchTrans.Append<int>((r, s) =>
            {
                return DoUpdateStoreState(r, Enum.StoreState.LockStore);
            }, 0);

            return exeBatchTrans.Save();
        }

    }
}
