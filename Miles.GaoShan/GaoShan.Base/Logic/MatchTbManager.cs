using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class MatchTbManager : LogicManager<Model.Info_matchTb>
    {
        public override bool Add(Info_matchTb t)
        {
            t.MatchTb_Id = NewId();
            t.MatchTb_State =(int)Enum.MatchTbState.New;
            return this.Add(this.Repository,t);
        }

        public override bool Remove(Info_matchTb info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Remove<Model.Tb_matchTb>()
                .Where().And(Model.Tb_matchTb.Table.MatchTb_Id, id)
                .EndWhere()
                .Save() < 1)
                {
                    return false;
                }
                return true;
            }, info.MatchTb_Id)
            .Append<long>((r, id) =>
            {
                if (r.Remove<Model.Tb_matchTb_item>()
                .Where().And(Model.Tb_matchTb_item.Table.MatchTb_Id, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, info.MatchTb_Id);

            return exeBatchTrans.Save();
        }

        public List<Info_matchTb> FindAllLinkMatchTbs(long linkBill_Id)
        {
            List<Info_matchTb> list = this.Repository.Query().From<Model.Tb_matchTb>()
                  .ToSelect().EndSelect()
                  .ToWhere()
                  .And(Model.Tb_matchTb.Table.LinkBill_Id, linkBill_Id)
                  .EndWhere()
                  .ToQuery()
                  .LeftJoin<Model.Tb_matchTb_item>()
                  .On(Model.Tb_matchTb.Table.MatchTb_Id, Model.Tb_matchTb_item.Table.MatchTb_Id)
                  .JoinTable()
                  .ToSelect()
                  .Select(Model.Tb_matchTb_item.Table.MatchTb_Id, true)
                  .EndSelect()
                   .ToOrderBy()
                  .ASC(Model.Tb_matchTb_item.Table.Mtl_Code)
                  .EndOrderBy()
                  .ToQuery()
                  .QueryOneMany<Info_matchTb, Info_matchTb_item, Info_matchTb>(
                  (m, i) => {
                      if (i.MatchTb_Id != 0) { m.Items.Add(i); }
                      return m;
                  }
                  , Model.Tb_matchTb.Table.MatchTb_Id
                  );

            return list;
        }

        public List<Info_matchTb> QueryMatchTbRecord(object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_matchTb>()
            .Select().End().Where()
            .And(Model.Tb_matchTb.Table.MatchTb_State, (int)Enum.MatchTbState.Valid);

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_matchTb.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_matchTb.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_matchTb.Table.Odr_No, odrNo);
            }

            return wherePart.End().ToQuery().ToList<Info_matchTb>();
        }

        public List<Model.Info_matchTb_item> GetMatchTbItems(long matchTbId)
        {
            return this.Repository.Find().From<Model.Tb_matchTb_item>()
                .Select().End()
                .Where()
                .And(Model.Tb_matchTb_item.Table.MatchTb_Id, matchTbId)
                .End()
                .ToQuery()
                .ToList<Model.Info_matchTb_item>();

        }

        public Dictionary<string, DbDecValue> FindDoneLinkMatchTbItems(long linkBill_Id)
        {
            return this.Repository.Find().From<Model.Tb_matchTb>()
                  .Where()
                  .And(Model.Tb_matchTb.Table.LinkBill_Id, linkBill_Id)
                  .And(Model.Tb_matchTb.Table.MatchTb_State, (int)Enum.MatchTbState.Valid)
                  .End()
                  .InnerJoin<Model.Tb_matchTb_item>()
                  .On(Model.Tb_matchTb.Table.MatchTb_Id, Model.Tb_matchTb_item.Table.MatchTb_Id)
                  .JoinTable()
                  .Select()
                  .Field(Model.Tb_matchTb_item.Table.Mtl_Code)
                  .Sum(Model.Tb_matchTb_item.Table.Item_Count, "Value")
                  .End()
                  .GroupBy()
                  .The(Model.Tb_matchTb_item.Table.Mtl_Code)
                  .End()
                  .OrderBy()
                  .ASC(Model.Tb_matchTb_item.Table.Mtl_Code)
                  .End()
                  .ToQuery()
                  .ToMapKeyItem<string, DbDecValue>(Model.Tb_matchTb_item.Table.Mtl_Code);

        }

        public List<Info_matchTb> FindDoneLinkMatchTbs(long linkBill_Id)
        {
            List<Info_matchTb> list = this.Repository.Query().From<Model.Tb_matchTb>()
                  .ToSelect().EndSelect()
                  .ToWhere()
                  .And(Model.Tb_matchTb.Table.LinkBill_Id, linkBill_Id)
                  .And(Model.Tb_matchTb.Table.MatchTb_State, (int)Enum.MatchTbState.Valid)
                  .EndWhere()
                  .ToQuery()
                  .LeftJoin<Model.Tb_matchTb_item>()
                  .On(Model.Tb_matchTb.Table.MatchTb_Id, Model.Tb_matchTb_item.Table.MatchTb_Id)
                  .JoinTable()
                  .ToSelect()
                  .Select(Model.Tb_matchTb_item.Table.MatchTb_Id, true)
                  .EndSelect()
                   .ToOrderBy()
                  .ASC(Model.Tb_matchTb_item.Table.Mtl_Code)
                  .EndOrderBy()
                  .ToQuery()
                  .QueryOneMany<Info_matchTb, Info_matchTb_item, Info_matchTb>(
                  (m, i) => {
                      if (i.MatchTb_Id != 0) { m.Items.Add(i); }
                      return m;
                  }
                  , Model.Tb_matchTb.Table.MatchTb_Id
                  );

            return list;
        }

        public bool Save(Model.Info_matchTb info)
        {
          ExeBatchTrans exeBatchTrans=  this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Remove<Model.Tb_matchTb>()
                .Where().And(Model.Tb_matchTb.Table.MatchTb_Id, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, info.MatchTb_Id)
            .Append<long>((r, id) =>
            {
                if (r.Remove<Model.Tb_matchTb_item>()
                .Where().And(Model.Tb_matchTb_item.Table.MatchTb_Id, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, info.MatchTb_Id)
            .Append<Model.Info_matchTb>((r, m) =>
             {
                return this.Add(r,m);
             }, info);

            foreach (var v in info.Items)
            {
                exeBatchTrans.Append<Info_matchTb_item>((r, item) =>
                {
                    item.Item_Id = NewId();
                    return this.Add(r,item);
                }, v);
            }

            return exeBatchTrans.Save();
        }

        public bool Commit(Info_matchTb info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<Info_matchTb>((r, i) => {
                return r.Update<Model.Tb_matchTb>()
                 .Set().Field(Model.Tb_matchTb.Table.MatchTb_State, (int)Enum.MatchTbState.Valid)
                 .EndSet()
                 .Where()
                 .And(Model.Tb_matchTb.Table.MatchTb_Id, i.MatchTb_Id)
                 .EndWhere()
                 .Save() > 0 ? true : false;

            }, info);


            return exeBatchTrans.Save();
        }

        public List<Info_matchTb> GetNoDoneMatchTb()
        {
            List<Info_matchTb> list = this.Repository.Query().From<Model.Tb_matchTb>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_matchTb.Table.MatchTb_State,(int)Enum.MatchTbState.New)
                .EndWhere()
                .ToQuery()
                .LeftJoin<Model.Tb_matchTb_item>()
                .On(Model.Tb_matchTb.Table.MatchTb_Id, Model.Tb_matchTb_item.Table.MatchTb_Id)
                .JoinTable()
                .ToSelect()
                .Select(Model.Tb_matchTb_item.Table.MatchTb_Id,true)
                .EndSelect()
                 .ToOrderBy()
                .ASC(Model.Tb_matchTb_item.Table.Mtl_Code)
                .EndOrderBy()
                .ToQuery()
                .QueryOneMany<Info_matchTb, Info_matchTb_item, Info_matchTb>(
                (m, i) => {
                    if (i.MatchTb_Id != 0) { m.Items.Add(i); }
                    return m;
                }
                , Model.Tb_matchTb.Table.MatchTb_Id
                );

            return list;
        }
    }
}
