using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Enum;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class OrderManager : LogicManager<Model.Info_OrderMain>
    {

        public override bool Add(Info_OrderMain t)
        {
            throw new NotImplementedException();
        }

        public List<Info_OrderMain> QuerySelfCheckOrderRecord(string employCode, object beginTime, object endTime, string odrNo)
        {

            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_order_main>()
             .Select().End().Where()
            .Or(Model.Tb_order_main.Table.Odr_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.OrderState.Pass)
            .Or(Model.Tb_order_main.Table.Odr_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.OrderState.Termination)
            .StartGroup();

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_order_main.Table.Odr_No, odrNo);
            }

            return wherePart.End()
                .InnerJoin<Miles.IMSFramework.Model.Sm_employee>()
                .On(Model.Tb_order_main.Table.Oper_Code, Miles.IMSFramework.Model.Sm_employee.Table.Employ_Code)
                .JoinTable()
                .Where()
                .And(Miles.IMSFramework.Model.Sm_employee.Table.Parent_Code, employCode)
                .End().ToQuery().ToList<Info_OrderMain>();
        }


        public List<Info_OrderMain> QuerySelfOrderRecord(string employCode, object beginTime, object endTime,string odrNo)
        {

            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_order_main>()
               .Select().End().Where()
               .And(Model.Tb_order_main.Table.Oper_Code, employCode)
               .And(Model.Tb_order_main.Table.Odr_State, Miles.Coro.ORM.DbCompareChar.NotEqual, (int)Enum.OrderState.New);
               //.StartGroup()
               //.Or(Model.Tb_order_main.Table.Odr_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.OrderState.Pass)
               //.Or(Model.Tb_order_main.Table.Odr_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.OrderState.Termination)
               //.StartGroup();

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_order_main.Table.Odr_No, odrNo);

            }

            return wherePart.End().ToQuery().ToList<Info_OrderMain>();
        }

        public List<Info_OrderMain> QuerySelfNormalOrderRecord(string employ_Code, DateTime beginTime, DateTime endTime)
        {
            return this.Repository.Query().From<Model.Tb_order_main>()
           .ToSelect().EndSelect()
       .ToWhere()
       .And(Model.Tb_order_main.Table.Oper_Code, employ_Code)
       .And(Model.Tb_order_main.Table.Odr_State,(int)Enum.OrderState.Pass)
       .And(Model.Tb_order_main.Table.Odr_Date,Miles.Coro.ORM.DbCompareChar.More,new Miles.Coro.ORM.MDbParameter("startTime", beginTime))
       .And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.Less, new Miles.Coro.ORM.MDbParameter("endTime", endTime))
       .EndWhere()
       .ToQuery().ToList<Info_OrderMain>();
        }

        public int GetMaxSeq(string odr_No)
        {
            object value = this.Repository.Query().From<Model.Tb_order_main>()
            .ToSelect()
            .Select(Model.Tb_order_main.Table.Odr_Seq)
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_order_main.Table.Odr_No, odr_No)
            .EndWhere()
            .ToQuery()
            .Max();

            return value == null ? -1 : (int)value;
        }

        Logic.ProcessManager processManager = new ProcessManager();
        public bool CommitOrder(Info_OrderMain info)
        {
            return processManager.CommitOrder(info);
        }

        public bool CheckOrderPass(Info_OrderMain info)
        {
            return processManager.AdoptOrder(info);
        }

        public bool CheckOrderNoPass(Info_OrderMain info, string msg = "合同审核不通过")
        {
            info.Tag = msg;
            return processManager.RejectOrder(info);
        }

        public bool OrderTermination(Info_OrderMain info)
        {
            return processManager.TerminationOrder(info);
        }


        public Info_OrderMain FindTheOrderInfo(string orderNo)
        {
           return this.Repository.Query()
                .From<Model.Tb_order_main>()
                .ToSelect()
                .EndSelect()
                .ToWhere()
                .And(Model.Tb_order_main.Table.Odr_No, orderNo)
                .EndWhere()
                .ToQuery()
                .First<Info_OrderMain>();
        }

        public List<Info_OrderMain> FindChildNeedCheckOrder(string userName)
        {
            return this.Repository.Query()
                .From<Model.Tb_order_main>()
                .ToSelect()
                .EndSelect()
                .ToWhere()
                .And(Model.Tb_order_main.Table.Odr_State,(int)Enum.OrderState.Commit)
                .EndWhere()
                .ToQuery()
                .InnerJoin<Miles.IMSFramework.Model.Sm_employee>()
                .On(Model.Tb_order_main.Table.Oper_Code, Miles.IMSFramework.Model.Sm_employee.Table.Employ_Code)
                .JoinTable()
                .ToWhere()
                .And(Miles.IMSFramework.Model.Sm_employee.Table.Parent_Code, userName)
                .EndWhere()
                .ToQuery()
                .ToList<Info_OrderMain>();
        }

        public List<Info_OrderMain> QueryTerminationOrderRecord(DateTime beginTime, DateTime endTime)
        {
            return this.Repository.Query().From<Model.Tb_order_main>()
 .ToSelect().EndSelect()
.ToWhere()
.And(Model.Tb_order_main.Table.Odr_State, (int)Enum.OrderState.Termination)
.And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.More, new Miles.Coro.ORM.MDbParameter("startTime", beginTime))
.And(Model.Tb_order_main.Table.Odr_Date, Miles.Coro.ORM.DbCompareChar.Less, new Miles.Coro.ORM.MDbParameter("endTime", endTime))
.EndWhere()
.ToQuery().ToList<Info_OrderMain>();
        }

      

        //public List<Bu_OrderNoSelect> FindOrderMainByOdrNo(string odrNo, int state, string userName = null)
        //{
        //    Miles.Coro.ORM.IWhereSelect whereSelect = this.Repository.Query()
        //        .From<Model.Tb_order_main>()
        //        .ToSelect().EndSelect()
        //        .ToWhere()
        //        .And(Model.Tb_order_main.Table.Odr_No, odrNo)
        //        .And(Model.Tb_order_main.Table.Odr_State, state);

        //    if (userName != null)
        //    {
        //        whereSelect.And(Model.Tb_order_main.Table.Oper_Code, userName);
        //    }

        //    return whereSelect.EndWhere()
        //        .ToOrderBy()
        //        .ASC(Model.Tb_order_main.Table.Odr_Date)
        //        .EndOrderBy()
        //        .ToQuery().ToList<Bu_OrderNoSelect>();
        //}

        //public Info_OrderMain FindTheOrderInfo(string orderNo)
        //{
        //    List<Info_OrderMain> list = this.Repository.Query()
        //        .From<Model.Tb_order_main>()
        //        .ToSelect()
        //        .EndSelect()
        //        .ToWhere()
        //        .And(Model.Tb_order_main.Table.Odr_No, orderNo)
        //        .EndWhere()
        //        .ToQuery()
        //        .LeftJoin<Model.Tb_order_item>()
        //        .On(Model.Tb_order_main.Table.Odr_No, Model.Tb_order_main.Table.Odr_No)
        //        .JoinTable()
        //        .ToSelect()
        //        .Select(Model.Tb_order_item.Table.Odr_No, true)
        //        .EndSelect()
        //        .ToQuery()
        //        .QueryOneMany<Info_OrderMain, Info_order_item, Info_OrderMain>((m, i) => { if (i.Item_Id != 0) m.Items.Add(i); return m; }, Model.Tb_order_main.Table.Odr_No);

        //    return list != null && list.Count > 0 ? list[0] : null;
        //}
        #region 公用部分

        public byte[] GetOrderBodyText(string Odr_No)
        {
            Model.Tb_order_text orderText = this.Repository.Query().From<Model.Tb_order_text>()
         .ToSelect().EndSelect()
     .ToWhere()
     .And(Model.Tb_order_text.Table.Odr_No, Odr_No)
     .EndWhere()
     .ToQuery().First<Tb_order_text>();

            return orderText != null ? orderText.Odr_Text : null;
        }

        public byte[] GetOrderClause(string Odr_No)
        {
            Model.Tb_order_text orderText = this.Repository.Query().From<Model.Tb_order_text>()
             .ToSelect().EndSelect()
             .ToWhere()
             .And(Model.Tb_order_text.Table.Odr_No, Odr_No)
             .EndWhere()
             .ToQuery().First<Tb_order_text>();

            return orderText != null ? orderText.Odr_Clause : null;
        }

        public List<Model.Info_order_item> GetOrderItems(string Odr_No)
        {
            List<Model.Info_order_item> list = this.Repository.Query().From<Model.Tb_order_item>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_order_item.Table.Odr_No, Odr_No)
                .EndWhere()
                .ToQuery().ToList<Info_order_item>();

            return list;
        }
        #endregion

        #region 业务员合同拟定部分

        public Tb_order_main FindTheOrderMain(string odrNo)
        {
            return this.Repository.Query().From<Model.Tb_order_main>()
                    .ToSelect().EndSelect()
                    .ToWhere()
                    .And(Model.Tb_order_main.Table.Odr_No, odrNo)
                    .EndWhere()
                    .ToQuery().First<Info_OrderMain>();
        }


        public override bool Remove(Info_OrderMain t)
        {
            return this.BatchTrans().Append<string>(
             (r, id) =>
             {
                 if (r.Remove<Model.Tb_order_main>()
                    .Where().And(Model.Tb_order_main.Table.Odr_No, t.Odr_No)
                    .EndWhere()
                    .Save() < 1)
                 {
                     return false;
                 }
                 return true;
             }, t.Odr_No).Append<string>(
             (r, id) =>
             {
                 if (r.Remove<Model.Tb_order_item>()
                .Where().And(Model.Tb_order_item.Table.Odr_No, t.Odr_No)
                .EndWhere()
                .Save() < 1)
                 {
                     return false;
                 }
                 return true;
             }, t.Odr_No)
                          .Append<string>(
                (r, id) =>
                {
                    if (r.Remove<Model.Tb_order_text>()
                    .Where().And(Model.Tb_order_text.Table.Odr_No, t.Odr_No)
                    .EndWhere()
                    .Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }, t.Odr_No).Save();

        }

        public bool SaveOrderAllInfo(Info_OrderMain info, bool isUpdate = false)
        {
            Doc.DocBuilder docBuilder = new Doc.DocBuilder(info);
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;
            string Oper_Code = user.Employ_Code;

            ExeBatchTrans batchTrans = this.BatchTrans();

            if (isUpdate)
            {
                batchTrans.Append<string>(
                (r, id) =>
                {
                    if (r.Remove<Model.Tb_order_main>()
                    .Where().And(Model.Tb_order_main.Table.Odr_No, info.Odr_No)
                    .EndWhere()
                    .Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }, info.Odr_No).Append<string>(
                (r, id) =>
                {
                    if (r.Remove<Model.Tb_order_item>()
                    .Where().And(Model.Tb_order_item.Table.Odr_No, info.Odr_No)
                    .EndWhere()
                    .Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }, info.Odr_No)
                .Append<string>(
                (r, id) =>
                {
                    if (r.Remove<Model.Tb_order_text>()
                    .Where().And(Model.Tb_order_text.Table.Odr_No, info.Odr_No)
                    .EndWhere()
                    .Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }, info.Odr_No);

            }

            if (!isUpdate)
            {
                //追加合同
                if (info.Odr_Type == 4)
                {
                    //更新主合同的seq_No
                    batchTrans.Append<string>
                    ((r, oldCode) =>
                    {
                        //更新合同编码生成
                        if (r.Update<Model.Tb_order_main>()
                             .Set()
                             .Increase(Model.Tb_order_main.Table.Odr_Seq, 1)
                             .EndSet()
                             .Where().And(Model.Tb_order_main.Table.Odr_No, oldCode)
                             .EndWhere()
                             .Save() < 0)
                        {
                            return false;
                        }
                        return true;
                    }, info.Odr_No_Main);
                }
                else
                {
                    batchTrans.Append<string>
                     ((r, c) =>
                     {
                         //更新合同编码生成
                         if (r.Update<Model.Tb_order_code>()
                              .Set()
                              .Increase(Model.Tb_order_code.Table.Seq_No, 1)
                              .EndSet()
                              .Where().And(Model.Tb_order_code.Table.Employ_Code, c).EndWhere()
                              .Save() < 0)
                         {
                             return false;
                         }
                         return true;
                     }, Oper_Code);
                }
            }

            return batchTrans.Append<Model.Tb_order_main>(
                 (r, t) =>
                 {
                     return this.Add(r, t);// r.Add(t);
                 }, info
                 ).Append<Model.Info_OrderMain>(
                 (r, t) =>
                 {
                     foreach (var v in t.Items)
                     {
                         v.Odr_No = t.Odr_No;
                         v.Item_Id = NewId();
                         if (!r.Add(v))
                         {
                             return false;
                         }
                     }
                     return true;
                 }, info
                 )
                 .Append<Model.Info_OrderMain>(
                 (r, t) =>
                 {
                     Model.Tb_order_text orderText = new Tb_order_text();
                     orderText.Odr_No = info.Odr_No;
                     orderText.Odr_Clause = info.Odr_Clause;
                     orderText.Odr_Pay = docBuilder.GetOrderPay();
                     orderText.Odr_Text = docBuilder.ToStream(info.Odr_Clause).ToArray();

                     return r.Add(orderText);
                 }, info
                 )
                 .Save();
        }

        public List<Info_OrderMain> FindSelfNotCommitOrders(string userName)
        {
            return this.Repository.Query().From<Model.Tb_order_main>()
                  .ToSelect().EndSelect()
              .ToWhere()
              .And(Model.Tb_order_main.Table.Oper_Code, userName)
              .And(Model.Tb_order_main.Table.Odr_State, (int)Enum.OrderState.New)
              .EndWhere()
              .ToQuery().ToList<Info_OrderMain>();
        } 


        #endregion
    }
}
