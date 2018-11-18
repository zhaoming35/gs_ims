using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class LinkBillManager : LogicManager<Model.Info_link_bill>
    {
        public override bool Add(Info_link_bill t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_link_bill info)
        {
          return  this.BatchTrans().Append<long>(
               (r, id) =>
               {
                   if (r.Remove<Model.Tb_link_bill>()
                   .Where().And(Model.Tb_link_bill.Table.LinkBill_Id, info.LinkBill_Id)
                   .EndWhere()
                   .Save() < 1)
                   {
                       return false;
                   }
                   return true;
               }, info.LinkBill_Id).Append<long>(
               (r, id) =>
               {
                   if (r.Remove<Model.Tb_link_bill_tent>()
                   .Where().And(Model.Tb_link_bill_tent.Table.LinkBill_Id, info.LinkBill_Id)
                   .EndWhere()
                   .Save() < 0)
                   {
                       return false;
                   }
                   return true;
               }, info.LinkBill_Id)
               .Save();
        }

        public Info_link_bill FindSelfMayCancelBill(string employ_Code, string odrNo)
        {
            List<Info_link_bill> list = this.Repository.Query().From<Model.Tb_link_bill>()
                    .ToSelect().EndSelect()
                    .ToWhere()
                    .And(Model.Tb_link_bill.Table.Employ_Code, employ_Code)
                    .And(Model.Tb_link_bill.Table.LinkBill_Type,(int)Enum.LinkBillType.Normal)
                    .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid) //可能出厂的状态
                    .And(Model.Tb_link_bill.Table.Odr_No, odrNo)
                    .EndWhere()
                    .ToQuery()
                    .LeftJoin<Model.Tb_link_bill_tent>()
                    .On(Model.Tb_link_bill.Table.LinkBill_Id, Model.Tb_link_bill_tent.Table.LinkBill_Id)
                    .JoinTable()
                    .ToSelect()
                    .Select(Model.Tb_link_bill_tent.Table.LinkBill_Id, true)
                    .EndSelect()
                    .ToQuery()
                    .QueryOneMany<Info_link_bill, Info_link_bill_tent, Info_link_bill>((m, t) =>
                    {
                        if (t.LinkBill_Id != 0) { m.Items.Add(t); }
                            return m;
                    }, Model.Tb_link_bill.Table.LinkBill_Id);

                    return (list==null||list.Count==0)?null:list[0];
        }

        public List<Info_link_bill> QuerySelfLinkRecord(string employCode, object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_link_bill>()
             .Select().End().Where()
             .And(Model.Tb_link_bill.Table.Employ_Code, employCode)
            .StartGroup()
            .Or(Model.Tb_link_bill.Table.Bill_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.GenState.Valid)
            .Or(Model.Tb_link_bill.Table.Bill_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.GenState.Termination)
            .StartGroup();

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_link_bill.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_link_bill.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_link_bill.Table.Odr_No, odrNo);
            }

            return wherePart
               .End()
               .ToQuery()
               .ToList<Info_link_bill>();
        }

        public List<Info_link_bill> GetNeedCreateOutStore()
        {
            List<Info_link_bill> list = this.Repository.Query().From<Model.Tb_link_bill>()
 .ToSelect().EndSelect()
 .ToWhere()
 .And(Model.Tb_link_bill.Table.LinkBill_Type, (int)Enum.LinkBillType.Normal)  //只对正常单
 .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
 //.And(Model.Tb_link_bill.Table.Is_MatchTb, (int)Enum.IsFlag.Yes)  //不需要配套表的限制
 .And(Model.Tb_link_bill.Table.Is_OutStore, (int)Enum.IsFlag.No)
 .EndWhere()
 .ToQuery()
 .LeftJoin<Model.Tb_link_bill_tent>()
 .On(Model.Tb_link_bill.Table.LinkBill_Id, Model.Tb_link_bill_tent.Table.LinkBill_Id)
 .JoinTable()
 .ToSelect()
 .Select(Model.Tb_link_bill_tent.Table.LinkBill_Id, true)
 .EndSelect()
 .ToQuery()
 .QueryOneMany<Info_link_bill, Info_link_bill_tent, Info_link_bill>((m, t) =>
 {
     if (t.LinkBill_Id != 0) { m.Items.Add(t); }
     return m;
 }, Model.Tb_link_bill.Table.LinkBill_Id);

            return list;
        }

        public List<Info_link_bill> GetNeedCreateBackStore()
        {
            //范围要从出库表中来找，
          return this.Repository.Find().From<Tb_store_out>()
                .Where()
                .And(Tb_store_out.Table.StoreOut_State,(int)Enum.OutStoreState.Valid)
                .End()
                .InnerJoin<Tb_link_bill>()
                .On(Tb_store_out.Table.LinkBill_Id, Tb_link_bill.Table.LinkBill_Id)
                .JoinTable()
                .Select().End()
                .Where()
                .And(Model.Tb_link_bill.Table.LinkBill_Type, (int)Enum.LinkBillType.Normal)  //只对正常单
                .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
                //.And(Model.Tb_link_bill.Table.Is_OutStore, (int)Enum.IsFlag.Yes)  //不是整单都出库的，只要出库的就应该回库
                .And(Model.Tb_link_bill.Table.Odr_Type, 2)
                .And(Model.Tb_link_bill.Table.Is_BackStore, (int)Enum.IsFlag.No)
                .End()
                .LeftJoin<Model.Tb_link_bill_tent>()
                .On(Model.Tb_link_bill.Table.LinkBill_Id, Model.Tb_link_bill_tent.Table.LinkBill_Id)
                .JoinTable()
                .Select()
                .Field(Model.Tb_link_bill_tent.Table.LinkBill_Id, true)
                .End()
                .ToQuery()
                .QueryOneMany<Info_link_bill, Info_link_bill_tent, Info_link_bill>((m, t) =>
                    {
                        if (t.LinkBill_Id != 0) { m.Items.Add(t); }
                            return m;
                    }, Model.Tb_link_bill.Table.LinkBill_Id);

        }

        public bool CancelBill(Info_link_bill info)
        {
            return processManager.CancelLinkBill(info);
        }

        public Info_link_bill FindSelfMayBackBill(string employ_Code, string odrNo)
        {
            return this.Repository.Query().From<Model.Tb_link_bill>()
.ToSelect().EndSelect()
.ToWhere()
.And(Model.Tb_link_bill.Table.Employ_Code, employ_Code)
.And(Model.Tb_link_bill.Table.LinkBill_Type, (int)Enum.LinkBillType.Normal)
.And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
.And(Model.Tb_link_bill.Table.Odr_No, odrNo)
.EndWhere()
.ToQuery()
.First<Info_link_bill>();
        }

        public bool SetDoneCarriage(Info_link_bill info)
        {
            return this.Repository.Update<Model.Tb_link_bill>()
      .Set()
      .Field(Model.Tb_link_bill.Table.Is_Carriage, (int)Enum.IsFlag.Yes)
      .EndSet()
      .Where()
      .And(Model.Tb_link_bill.Table.LinkBill_Id, info.LinkBill_Id)
      .EndWhere()
      .Save() > 0 ? true : false;
        }

        public bool SetDoneMatchTb(Info_link_bill info)
        {
            return this.Repository.Update<Model.Tb_link_bill>()
           .Set()
           .Field(Model.Tb_link_bill.Table.Is_MatchTb, (int)Enum.IsFlag.Yes)
           .EndSet()
           .Where()
           .And(Model.Tb_link_bill.Table.LinkBill_Id, info.LinkBill_Id)
           .EndWhere()
           .Save() > 0 ? true : false;
        }

        public bool BackBill(Info_link_bill info)
        {
            return processManager.BackLinkBill(info);
        }

        public List<Info_link_bill> FindSelfLinkBillList(string employ_Code)
        {
            return this.Repository.Query().From<Model.Tb_link_bill>()
      .ToSelect().EndSelect()
      .ToWhere()
      .And(Model.Tb_link_bill.Table.Employ_Code, employ_Code)
      .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.New)
      .EndWhere()
      .ToQuery()
      .ToList<Info_link_bill>();
        }

        public List<Info_link_bill_tent> GetLinkItems(long linkBill_Id)
        {
            return this.Repository.Query().From<Model.Tb_link_bill_tent>()
.ToSelect().EndSelect()
.ToWhere()
.And(Model.Tb_link_bill_tent.Table.LinkBill_Id, linkBill_Id)
.EndWhere()
.ToQuery()
.ToList<Info_link_bill_tent>();
        }

        public bool SaveLinkBillAll(Info_link_bill info)
        {
            ExeBatchTrans batchTrans = this.BatchTrans();

            batchTrans
               .Append<long>(
               (r, id) =>
               {
                   if (r.Remove<Model.Tb_link_bill>()
                   .Where().And(Model.Tb_link_bill.Table.LinkBill_Id, info.LinkBill_Id)
                   .EndWhere()
                   .Save() < 0)
                   {
                       return false;
                   }
                   return true;
               }, info.LinkBill_Id).Append<long>(
               (r, id) =>
               {
                   if (r.Remove<Model.Tb_link_bill_tent>()
                   .Where().And(Model.Tb_link_bill_tent.Table.LinkBill_Id, info.LinkBill_Id)
                   .EndWhere()
                   .Save() < 0)
                   {
                       return false;
                   }
                   return true;
               }, info.LinkBill_Id)
               .Append<Tb_link_bill>
               (
                 (r, i) =>
                 {
                     return Add(r, i);
                 }, info);


            int seqNo = 1;
            foreach (var item in info.Items)
            {
                batchTrans.Append<Tb_link_bill_tent>
                (
                  (r, i) =>
                  {
                      i.LinkBill_Id = info.LinkBill_Id;
                      i.Item_Id = NewId();
                      i.Item_Seq = seqNo;
                      return Add(r, i);
                  }, item);
               
                seqNo++;
            }


            return  batchTrans.Save(); 
        }

        public List<Info_link_bill> FindNotBuildProjectCostList()
        {
            List<Info_link_bill> list = this.Repository.Query().From<Model.Tb_link_bill>()
     .ToSelect().EndSelect()
     .ToWhere()
     .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
     .And(Model.Tb_link_bill.Table.Is_ProjectCost, (int)Enum.IsFlag.No)
     .EndWhere()
     .ToQuery()
     .LeftJoin<Model.Tb_link_bill_tent>()
     .On(Model.Tb_link_bill.Table.LinkBill_Id, Model.Tb_link_bill_tent.Table.LinkBill_Id)
     .JoinTable()
     .ToSelect()
     .Select(Model.Tb_link_bill_tent.Table.LinkBill_Id, true)
     .EndSelect()
     .ToQuery()
     .QueryOneMany<Info_link_bill, Info_link_bill_tent, Info_link_bill>((m, t) =>
     {
         if (t.LinkBill_Id != 0) { m.Items.Add(t); }
         return m;
     }, Model.Tb_link_bill.Table.LinkBill_Id);

            return list;
        }

        public List<Info_link_bill> GetNeedCreateMatchTb()
        {
            List<Info_link_bill> list = this.Repository.Query().From<Model.Tb_link_bill>()
 .ToSelect().EndSelect()
 .ToWhere()
 .And(Model.Tb_link_bill.Table.LinkBill_Type, (int)Enum.LinkBillType.Normal)  //只对正常单
 .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
 .And(Model.Tb_link_bill.Table.Is_MatchTb, (int)Enum.IsFlag.No)
 .EndWhere()
 .ToQuery()
 .LeftJoin<Model.Tb_link_bill_tent>()
 .On(Model.Tb_link_bill.Table.LinkBill_Id, Model.Tb_link_bill_tent.Table.LinkBill_Id)
 .JoinTable()
 .ToSelect()
 .Select(Model.Tb_link_bill_tent.Table.LinkBill_Id, true)
 .EndSelect()
 .ToQuery()
 .QueryOneMany<Info_link_bill, Info_link_bill_tent, Info_link_bill>((m, t) =>
 {
     if (t.LinkBill_Id != 0) { m.Items.Add(t); }
     return m;
 }, Model.Tb_link_bill.Table.LinkBill_Id);

            return list;
        }

        public List<Info_link_bill> GetNeedCreateCarriage()
        {
            List<Info_link_bill> list = this.Repository.Query().From<Model.Tb_link_bill>()
 .ToSelect().EndSelect()
 .ToWhere()
 .And(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
 .And(Model.Tb_link_bill.Table.Is_Carriage, (int)Enum.IsFlag.No)
 .EndWhere()
 .ToQuery()
 .LeftJoin<Model.Tb_link_bill_tent>()
 .On(Model.Tb_link_bill.Table.LinkBill_Id, Model.Tb_link_bill_tent.Table.LinkBill_Id)
 .JoinTable()
 .ToSelect()
 .Select(Model.Tb_link_bill_tent.Table.LinkBill_Id, true)
 .EndSelect()
 .ToQuery()
 .QueryOneMany<Info_link_bill, Info_link_bill_tent, Info_link_bill>((m, t) =>
 {
     if (t.LinkBill_Id != 0) { m.Items.Add(t); }
     return m;
 }, Model.Tb_link_bill.Table.LinkBill_Id);

            return list;
        }

        Logic.ProcessManager processManager = new ProcessManager();
        public bool Commit(Info_link_bill info)
        {
            return processManager.CommitLinkBill(info);
        }

        public Info_link_bill FindLinkBillInfo(long linkBill_Id)
        {
            List < Info_link_bill > list= this.Repository.Query().From<Model.Tb_link_bill>()
.ToSelect().EndSelect()
.ToWhere()
.And(Model.Tb_link_bill.Table.LinkBill_Id, linkBill_Id)
.EndWhere()
.ToQuery()
.LeftJoin<Model.Tb_link_bill_tent>()
.On(Model.Tb_link_bill.Table.LinkBill_Id,Model.Tb_link_bill_tent.Table.LinkBill_Id)
.JoinTable()
.ToSelect()
.Select(Model.Tb_link_bill_tent.Table.LinkBill_Id,true)
.EndSelect()
.ToQuery()
.QueryOneMany<Info_link_bill,Info_link_bill_tent, Info_link_bill>((m,t)=>
{
    if (t.LinkBill_Id!=0) { m.Items.Add(t); }
    return m;
},Model.Tb_link_bill.Table.LinkBill_Id);

            return list != null && list.Count > 0 ? list[0] : null;

        }
    }
}
