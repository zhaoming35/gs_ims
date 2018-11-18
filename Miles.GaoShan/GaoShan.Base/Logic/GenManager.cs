using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;

namespace GaoShan.Sales.Logic
{
    public class GenManager : LogicManager<Model.Info_fin_order_gen>
    {
        public override bool Add(Info_fin_order_gen t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_fin_order_gen t)
        {
            throw new NotImplementedException();
        }

        public List<Info_fin_order_gen> FindSelfNotCommitGenList(string employ_Code)
        {
            return this.Repository.Query().From<Model.Tb_fin_order_gen>()
                  .ToSelect().EndSelect()
                  .ToWhere()
                  .And(Model.Tb_fin_order_gen.Table.Employ_Code, employ_Code)
                  .And(Model.Tb_fin_order_gen.Table.Gen_State,(int)Enum.GenState.New)
                  .EndWhere()
                  .ToQuery()
                  .LeftJoin<Model.Tb_order_text>()
                  .On(Model.Tb_fin_order_gen.Table.Odr_No,Model.Tb_order_text.Table.Odr_No)
                  .JoinTable()
                  .ToSelect()
                  .Select(Model.Tb_order_text.Table.Odr_Pay)
                  .EndSelect()
                  .ToQuery()
                  .ToList<Info_fin_order_gen>();
        }

        public List<Info_project_Cost_Item> GetBuildItems(string odrNo)
        {
            return Repository.Find().From<Tb_project_Cost>()
                .Where()
                .And(Tb_project_Cost.Table.Odr_No,odrNo)
                .And(Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.Valid)
                .End()
                .LeftJoin<Tb_project_Cost_Item>()
                .On(Tb_project_Cost.Table.LinkBill_Id, Tb_project_Cost_Item.Table.LinkBill_Id)
                .JoinTable()
                .Select()
                .End()
                .LeftJoin<Tb_expend_item>()
                .On(Tb_project_Cost_Item.Table.Item_Value, Tb_expend_item.Table.Item_Value)
                .JoinTable()
                .Where()
                .And(Tb_expend_item.Table.Define_Flag,(int)Enum.IsFlag.Yes)
                .End()
                .Select()
                .Field(Tb_expend_item.Table.Define_Flag)
                .End()
                .ToQuery()
                .ToList<Info_project_Cost_Item>();
        }

        public List<Info_carriage_bill> GetFreightItems(string odrNo)
        {
            return Repository.Find().From<Tb_carriage_bill>()
      .Where()
      .And(Tb_carriage_bill.Table.Odr_No, odrNo)
      .And(Tb_carriage_bill.Table.Carriage_State, (int)Enum.CarriageState.Valid)
      .End()
      .Select()
      .End()
      .ToQuery()
      .ToList<Info_carriage_bill>();
        }

        public List<Info_fin_order_gen> FindAllNoSalaryGenList()
        {
            return this.Repository.Find()
                .From<Model.Tb_fin_order_gen>()
                .Select().End()
                .Where()
                .And(Model.Tb_fin_order_gen.Table.Is_Salary, (int)Enum.IsFlag.No)
                .And(Model.Tb_fin_order_gen.Table.Gen_State, (int)Enum.GenState.Valid)
                .End()
                .LeftJoin<Model.Tb_order_text>()
                .On(Model.Tb_fin_order_gen.Table.Odr_No, Model.Tb_order_text.Table.Odr_No)
                .JoinTable()
                .Select()
                .Field(Model.Tb_order_text.Table.Odr_Pay)
                .End()
                .ToQuery()
                .ToList<Info_fin_order_gen>();
                

        }

        public List<Info_fin_order_gen> QuerySelfGenRecord(string employCode, object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_fin_order_gen>()
             .Select().End().Where()
             .And(Model.Tb_fin_order_gen.Table.Employ_Code, employCode)
            .StartGroup()
            .Or(Model.Tb_fin_order_gen.Table.Gen_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.GenState.Valid)
            .Or(Model.Tb_fin_order_gen.Table.Gen_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.GenState.Termination)
            .StartGroup();

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_fin_order_gen.Table.Gen_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_fin_order_gen.Table.Gen_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_fin_order_gen.Table.Odr_No, odrNo);
            }

           return  wherePart.End()
              .LeftJoin<Model.Tb_order_text>()
              .On(Model.Tb_fin_order_gen.Table.Odr_No, Model.Tb_order_text.Table.Odr_No)
              .JoinTable()
              .Select()
              .Field(Model.Tb_order_text.Table.Odr_Pay)
              .End()
              .ToQuery()
              .ToList<Info_fin_order_gen>();
        }

        public Info_fin_order_gen FindTheVaildGen(string odrNo)
        {
            List<Info_fin_order_gen> list = this.Repository.Query().From<Model.Tb_fin_order_gen>()
      .ToSelect().EndSelect()
      .ToWhere()
      .And(Model.Tb_fin_order_gen.Table.Odr_No, odrNo)
      .And(Model.Tb_fin_order_gen.Table.Gen_State, (int)Enum.GenState.Valid)
      .EndWhere()
      .ToQuery()
      .LeftJoin<Model.Tb_order_text>()
      .On(Model.Tb_fin_order_gen.Table.Odr_No, Model.Tb_order_text.Table.Odr_No)
      .JoinTable()
      .ToSelect()
      .Select(Model.Tb_order_text.Table.Odr_Pay)
      .EndSelect()
      .ToQuery()
      .LeftJoin<Tb_fin_order_item>()
      .On(Model.Tb_fin_order_gen.Table.Odr_No, Model.Tb_fin_order_item.Table.Odr_No)
      .JoinTable()
      .ToSelect()
      .Select(Model.Tb_fin_order_item.Table.Odr_No, true)
      .EndSelect()
      .ToQuery()
      .QueryOneMany<Info_fin_order_gen, Info_fin_order_item, Info_fin_order_gen>((g, i) =>
     {
         if (i.Item_Id != 0)
         {
             g.Items.Add(i);
         }
         return g;
     }, Model.Tb_fin_order_gen.Table.Odr_No);

            return list != null && list.Count > 0 ? list[0] : null;
        }

        public List<Info_fin_order_item> GetGenItems(string odrNo)
        {
            return this.Repository.Query().From<Model.Tb_fin_order_item>()
       .ToSelect().EndSelect()
       .ToWhere()
       .And(Model.Tb_fin_order_item.Table.Odr_No, odrNo)
       .EndWhere()
       .ToQuery()
       .ToList<Info_fin_order_item>();
        }

        public bool SaveGenAll(Info_fin_order_gen info)
        {
            ExeBatchTrans batchTrans = this.BatchTrans();

            batchTrans
               .Append<string>(
               (r, id) =>
               {
                   if (r.Remove<Model.Info_fin_order_gen>()
                   .Where().And(Model.Info_fin_order_gen.Table.Odr_No, info.Odr_No)
                   .EndWhere()
                   .Save() < 0)
                   {
                       return false;
                   }
                   return true;
               }, info.Odr_No).Append<string>(
               (r, id) =>
               {
                   if (r.Remove<Model.Tb_fin_order_item>()
                   .Where().And(Model.Tb_fin_order_item.Table.Odr_No, info.Odr_No)
                   .EndWhere()
                   .Save() < 0)
                   {
                       return false;
                   }
                   return true;
               }, info.Odr_No)
               .Append<Info_fin_order_gen>
               (
                 (r, i) =>
                  {
                   return Add(r, i);
                  }, info)
              ;
            int seqNo = 1;
            foreach(var item in info.Items)
            {
               batchTrans.Append<Tb_fin_order_item>
               (
                 (r, i) =>
                 {
                     i.Odr_No = info.Odr_No;
                     i.Item_Id = NewId();
                     i.Item_Seq = seqNo;
                     return Add(r, i);
                 }, item)
              ;

                seqNo++;
            }

            return batchTrans.Save();

        }

        public List<Info_fin_order_gen> QueryOrderIncomeRecord(DateTime beginTime, DateTime endTime, string odrNo, object odrType)
        {
            Miles.Coro.ORM.IWhereSelect whereSelect =
                  this.Repository.Query().From<Tb_fin_order_gen>()
                  .ToSelect().EndSelect()
                  .ToWhere()
                  .And(Tb_fin_order_gen.Table.Pay_Cost,Miles.Coro.ORM.DbCompareChar.More, new Miles.Coro.ORM.MDbParameter("PayCost", 0))
                  .And(Tb_fin_order_gen.Table.Gen_Date, Miles.Coro.ORM.DbCompareChar.More, new Miles.Coro.ORM.MDbParameter("beginTime", beginTime))
                  .And(Tb_fin_order_gen.Table.Gen_Date, Miles.Coro.ORM.DbCompareChar.Less, new Miles.Coro.ORM.MDbParameter("endTime", endTime));

            if (!string.IsNullOrEmpty(odrNo))
            {
                whereSelect.AndLike(Tb_fin_order_gen.Table.Odr_No, odrNo);
            }

            if (odrType != null)
            {
                int intOrderType = -1;
                int.TryParse(odrType.ToString(), out intOrderType);
                whereSelect.And(Tb_fin_order_gen.Table.Odr_Type, intOrderType);
            }

            return whereSelect.EndWhere().ToQuery().ToList<Info_fin_order_gen>();
        }

        public bool Commit(Info_fin_order_gen infoGen)
        {
            return this.Repository.Update<Tb_fin_order_gen>()
                    .Set()
                    .Field(Tb_fin_order_gen.Table.Gen_State, (int)Enum.GenState.Valid)
                    .EndSet()
                    .Where()
                    .And(Tb_fin_order_gen.Table.Odr_No, infoGen.Odr_No)
                    .EndWhere()
                    .Save() < 1 ? false : true;
        }
    }
}
