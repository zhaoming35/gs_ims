using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class ProjectCostManager : LogicManager<Model.Info_project_Cost>
    {
        public override bool Add(Info_project_Cost t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_project_Cost t)
        {
            throw new NotImplementedException();
        }

        public List<Info_project_Cost> FindTheDoneProjectCost(string odrNo)
        {
            return this.Repository.Find().From<Model.Tb_project_Cost>()
                .Select().End()
                .Where()
            .And(Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.Valid)
            .And(Tb_project_Cost.Table.Odr_No,odrNo)
            .End()
            .LeftJoin<Model.Tb_project_Cost_Item>()
            .On(Model.Tb_project_Cost.Table.LinkBill_Id, Model.Tb_project_Cost_Item.Table.LinkBill_Id)
            .JoinTable()
            .Select()
            .Field(Model.Tb_project_Cost_Item.Table.LinkBill_Id, true)
            .End()
            .ToQuery()
            .QueryOneMany<Info_project_Cost, Info_project_Cost_Item, Info_project_Cost>
            ((m, i) =>
            {
                if (i.Item_Id != 0)
                    m.Items.Add(i);
                return m;
            }, Model.Info_project_Cost.Table.LinkBill_Id);
        }

        public List<Info_project_Cost> FindNotDone()
        {
            return this.Repository.Query().From<Model.Tb_project_Cost>()
            .ToSelect().EndSelect()
            .ToWhere()
            .And(Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.New)
            .EndWhere()
            .ToQuery()
            .LeftJoin<Model.Tb_project_Cost_Item>()
            .On(Model.Tb_project_Cost.Table.LinkBill_Id, Model.Tb_project_Cost_Item.Table.LinkBill_Id)
            .JoinTable()
            .ToSelect()
            .Select(Model.Tb_project_Cost_Item.Table.LinkBill_Id, true)
            .EndSelect()
            .ToQuery()
            .QueryOneMany<Info_project_Cost, Info_project_Cost_Item, Info_project_Cost>
            ((m, i) =>
            {
                if (i.Item_Id != 0)
                    m.Items.Add(i);
                return m;
            }, Model.Info_project_Cost.Table.LinkBill_Id);
        }

        public List<Info_OrderMain> QueryCommitCostWithOrdNo(string odrNo)
        {
           return this.Repository.Find().From<Tb_order_main>()
                .Select().End()
                .InnerJoin<Tb_project_Cost>()
                .On(Tb_order_main.Table.Odr_No, Tb_project_Cost.Table.Odr_No)
                .JoinTable()
                .Where()
                .And(Tb_project_Cost.Table.Cost_State,(int)Enum.ProjectCostState.Valid)
                .AndLike(Tb_project_Cost.Table.Odr_No, odrNo)
                .End()
                .ToQuery()
                .ToList<Info_OrderMain>();
        }

        /// <summary>
        /// 只是修改明细费用
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool CorrectCost(Info_project_Cost info)
        {
            return this.BatchTrans()
               .Append<long>((r, id) =>
               {
                   if (r.Remove<Model.Tb_project_Cost_Item>()
                   .Where()
                   .And(Model.Tb_project_Cost_Item.Table.LinkBill_Id, id)
                   .EndWhere().Save() < 0)
                   {
                       return false;
                   }
                   return true;
               }, info.LinkBill_Id)
                 .Append<Model.Info_project_Cost>(
                 (r, t) =>
                 {
                     foreach (var v in t.Items)
                     {
                         v.LinkBill_Id = info.LinkBill_Id;
                         v.Item_Id = NewId();
                         if (!r.Add(v))
                         {
                             return false;
                         }
                     }
                     return true;
                 }, info
                 )
                 .Save();
        }

        public List<Q_project_Cost_Item> QuerySelfCostItemRecord(string employCode,object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find()
                    .From<Model.Tb_project_Cost>()
                    .Select()
                    .Field(Model.Tb_project_Cost.Table.Odr_No)
                    .Field(Model.Tb_project_Cost.Table.Odr_Prt_Name)
                    .Field(Model.Tb_project_Cost.Table.Odr_Type)
                    .Field(Model.Tb_project_Cost.Table.Oper_Date)
                    .Field(Model.Tb_project_Cost.Table.Employ_Name)
                    .End()
                    .Where()
                    .And(Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.Valid)
                    .And(Tb_project_Cost.Table.Employ_Code, employCode);

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_project_Cost.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_project_Cost.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_project_Cost.Table.Odr_No, odrNo);
            }

            return wherePart.End().LeftJoin<Model.Tb_project_Cost_Item>()
                    .On(Model.Tb_project_Cost.Table.LinkBill_Id, Model.Tb_project_Cost_Item.Table.LinkBill_Id)
                    .JoinTable()
                    .Select()
                    .End()
                    .LeftJoin<Model.Tb_expend_item>()
                    .On(Model.Tb_project_Cost_Item.Table.Item_Value, Model.Tb_expend_item.Table.Item_Value)
                    .JoinTable()
                    .Select()
                    .Field(Model.Tb_expend_item.Table.Define_Flag)
                    .End()
                    .ToQuery().ToList<Q_project_Cost_Item>();

        }

        public List<Q_project_Cost_Item> QueryCostItemRecord(object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find()
                    .From<Model.Tb_project_Cost>()
                    .Select()
                    .Field(Model.Tb_project_Cost.Table.Odr_No)
                    .Field(Model.Tb_project_Cost.Table.Odr_Prt_Name)
                    .Field(Model.Tb_project_Cost.Table.Odr_Type)
                    .Field(Model.Tb_project_Cost.Table.Oper_Date)
                    .Field(Model.Tb_project_Cost.Table.Employ_Name)
                    .End()
                    .Where()
                    .And(Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.Valid);

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_project_Cost.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_project_Cost.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_project_Cost.Table.Odr_No, odrNo);
            }

            return wherePart.End().LeftJoin<Model.Tb_project_Cost_Item>()
                    .On(Model.Tb_project_Cost.Table.LinkBill_Id, Model.Tb_project_Cost_Item.Table.LinkBill_Id)
                    .JoinTable()
                    .Select()
                    .End()
                    .LeftJoin<Model.Tb_expend_item>()
                    .On(Model.Tb_project_Cost_Item.Table.Item_Value, Model.Tb_expend_item.Table.Item_Value)
                    .JoinTable()
                    .Select()
                    .Field(Model.Tb_expend_item.Table.Define_Flag)
                    .End()
                    .ToQuery().ToList<Q_project_Cost_Item>();

        }


        public bool Save(Info_project_Cost info)
        {
            return this.BatchTrans()
                        .Append<long>((r, id) =>
                        {

                            if (r.Remove<Model.Tb_project_Cost>()
                            .Where()
                            .And(Model.Tb_project_Cost.Table.LinkBill_Id, id)
                            .EndWhere().Save() < 0)
                            {
                                return false;
                            }
                            return true;
                        }, info.LinkBill_Id)
                .Append<long>((r, id) =>
                {

                    if (r.Remove<Model.Tb_project_Cost_Item>()
                    .Where()
                    .And(Model.Tb_project_Cost_Item.Table.LinkBill_Id, id)
                    .EndWhere().Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }, info.LinkBill_Id)
                  .Append<Model.Info_project_Cost>(
                  (r, t) =>
                  {
                      return this.Add(r, info);
                  }, info
                  )
                  .Append<Model.Info_project_Cost>(
                  (r, t) =>
                  {
                      foreach (var v in t.Items)
                      {
                          v.LinkBill_Id = info.LinkBill_Id;
                          v.Item_Id = NewId();
                          if (!r.Add(v))
                          {
                              return false;
                          }
                      }
                      return true;
                  }, info
                  )
                 .Append<long>((r, id) =>
                 {
                     if (r.Update<Model.Tb_link_bill>()
                     .Set()
                     .Field(Model.Tb_link_bill.Table.Is_ProjectCost,(int)Enum.IsFlag.Yes)
                     .EndSet()
                    .Where()
                    .And(Model.Tb_link_bill.Table.LinkBill_Id, id)
                    .EndWhere().Save() < 0)
                     {
                         return false;
                     }
                     return true;
                 }, info.LinkBill_Id)
                  .Save();
        }

        public bool CommitProjectCost(Info_project_Cost info)
        {
            return this.BatchTrans()
                   .Append<long>((r, id) =>
                   {
                       if (r.Update<Model.Tb_project_Cost>()
                       .Set()
                       .Field(Model.Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.Valid)
                       .EndSet()
                      .Where()
                      .And(Model.Tb_project_Cost.Table.LinkBill_Id, id)
                      .EndWhere().Save() < 0)
                       {
                           return false;
                       }
                       return true;
                   }, info.LinkBill_Id)
                  .Save();
        }
    }
}
