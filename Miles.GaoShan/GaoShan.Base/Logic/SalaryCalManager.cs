using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class SalaryCalManager : LogicManager<Model.Info_salary_main>
    {
        public override bool Add(Info_salary_main t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_salary_main t)
        {
            throw new NotImplementedException();
        }

        public Bu_CalSalaryGen FindTheCalSalaryGenList(string odrNoMain)
        {
            List<Info_fin_order_gen> list = this.Repository.Find()
              .From<Model.Tb_fin_order_gen>()
              .Select().End()
              .Where()
              .And(Tb_fin_order_gen.Table.Odr_No_Main, odrNoMain)
              .And(Tb_fin_order_gen.Table.Tot_Cost, Miles.Coro.ORM.DbCompareChar.More, 0)
              .AndField(Tb_fin_order_gen.Table.Pay_Cost, Miles.Coro.ORM.DbCompareChar.MoreEqual, Tb_fin_order_gen.Table.Tot_Cost)
              .End()
              .ToQuery()
              .ToList<Info_fin_order_gen>();

            var queryMain = from item in list
                            where item.Odr_Type != 4
                            select item;

            Dictionary<string, Bu_CalSalaryGen> dicSalary = new Dictionary<string, Bu_CalSalaryGen>();

            foreach (var v in queryMain)
            {
                Bu_CalSalaryGen salaryGen = Miles.Coro.Common.Utils.CopyToOther<Info_fin_order_gen, Bu_CalSalaryGen>(v);
                dicSalary.Add(v.Odr_No_Main, salaryGen);
            }

            var queryAdd = from item in list
                           where item.Odr_Type == 4
                           select item;

            foreach (var v in queryAdd)
            {
                if (dicSalary.ContainsKey(v.Odr_No_Main))
                {
                    dicSalary[v.Odr_No_Main].Tot_Cost += v.Tot_Cost;
                    dicSalary[v.Odr_No_Main].Pay_Cost += v.Pay_Cost;
                }
            }

            return dicSalary.Values.ToList<Bu_CalSalaryGen>().First<Bu_CalSalaryGen>();

        }

        public List<Bu_CalSalaryGen> QueryNeedCalSalaryGenList()
        {
            List<Info_fin_order_gen> list = this.Repository.Find()
              .From<Model.Tb_fin_order_gen>()
              .Select().End()
              .Where()
              .And(Tb_fin_order_gen.Table.Is_Salary, (int)Enum.IsFlag.No)
              .And(Tb_fin_order_gen.Table.Tot_Cost, Miles.Coro.ORM.DbCompareChar.More, 0)
              .AndField(Tb_fin_order_gen.Table.Pay_Cost, Miles.Coro.ORM.DbCompareChar.MoreEqual, Tb_fin_order_gen.Table.Tot_Cost)
              .End()
              .ToQuery()
              .ToList<Info_fin_order_gen>();

            var queryMain = from item in list
                            where item.Odr_Type != 4
                            select item;

            Dictionary<string, Bu_CalSalaryGen> dicSalary = new Dictionary<string, Bu_CalSalaryGen>();

            foreach (var v in queryMain)
            {
                Bu_CalSalaryGen salaryGen = Miles.Coro.Common.Utils.CopyToOther<Info_fin_order_gen, Bu_CalSalaryGen>(v);
                dicSalary.Add(v.Odr_No_Main, salaryGen);
            }

            var queryAdd = from item in list
                           where item.Odr_Type == 4
                           select item;

            foreach (var v in queryAdd)
            {
                if (dicSalary.ContainsKey(v.Odr_No_Main))
                {
                    dicSalary[v.Odr_No_Main].Tot_Cost += v.Tot_Cost;
                    dicSalary[v.Odr_No_Main].Pay_Cost += v.Pay_Cost;
                }
            }

            return dicSalary.Values.ToList<Bu_CalSalaryGen>();

        }



        Logic.GenManager genManager = new Logic.GenManager();
        public List<Info_fin_order_gen> QuerySalaryGens(string odrNoMain)
        {
            List<Info_fin_order_gen> list = this.Repository.Find().From<Model.Tb_fin_order_gen>()
              .Select().End().Where()
              .And(Model.Tb_fin_order_gen.Table.Odr_No_Main, odrNoMain)
              .And(Model.Tb_fin_order_gen.Table.Is_Salary, (int)Enum.IsFlag.Yes)
              .And(Model.Tb_fin_order_gen.Table.Gen_State, Miles.Coro.ORM.DbCompareChar.Equal, (int)Enum.GenState.Valid)
              .End()
              .ToQuery()
              .ToList<Info_fin_order_gen>();

            foreach (var v in list)
            {
                v.BuildItems = genManager.GetBuildItems(v.Odr_No);
                v.FreightItems = genManager.GetFreightItems(v.Odr_No);
            }

            return list;
        }

        public List<Q_salary_main_item> QuerySalaryItemsQRecord(string odrNoMain)
        {
            List<Q_salary_main_item> list = this.Repository.Find()
                 .From<Model.Tb_salary_main>()
                 .Select()
                 .Field(Model.Tb_salary_main.Table.Odr_No_Main, true)
                 .End()
                .Where()
              .And(Model.Tb_salary_main.Table.Odr_No_Main, odrNoMain)
              .End()
              .InnerJoin<Model.Tb_salary_main_item>()
              .On(Model.Tb_salary_main.Table.Odr_No_Main, Model.Tb_salary_main_item.Table.Odr_No_Main)
              .JoinTable()
              .Select().End()
              .ToQuery()
              .ToList<Q_salary_main_item>();

            foreach (var v in list)
            {
                List<Tb_salary_grant_item> grantItems = this.Repository.Find()
                  .From<Model.Tb_salary_grant_item>()
                  .Select()
                  .End()
                  .Where()
                  .And(Tb_salary_grant_item.Table.Odr_No_Main, v.Odr_No_Main)
                  .And(Tb_salary_grant_item.Table.Employ_Code, v.Employ_Code)
                  .End()
                  .ToQuery()
                  .ToList<Tb_salary_grant_item>();

                decimal sum = grantItems.Sum(it => it.Salary_Grant);
                v.Salary_Grant = sum;
            }

            return list;
        }

        public List<Info_salary_main> QuerySalaryMainRecord(object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find()
                .From<Model.Tb_salary_main>()
             .Select().End().Where();

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_salary_main.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_salary_main.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_salary_main.Table.Odr_No_Main, odrNo);
            }

            return wherePart.End()
               .ToQuery()
               .ToList<Info_salary_main>();
        }

        public bool AddGrantItem(Info_salary_grant_item item)
        {
            item.Record_Id = NewId();
            return this.Add(Repository, item);
        }

        public List<Info_salary_grant_item> GetSalaryGrantList(string odrNoMain, string employCode)
        {
            return this.Repository.Find()
                .From<Tb_salary_grant_item>()
                .Select().End()
                .Where()
                .And(Tb_salary_grant_item.Table.Odr_No_Main,odrNoMain)
                .And(Tb_salary_grant_item.Table.Employ_Code,employCode)
                .End()
                .ToQuery()
                .ToList<Info_salary_grant_item>();
        }

        public List<Q_salary_main_item> GetNoGrantDoneSalary()
        {
            string sql = SQL.SqlManager.Intance.GetSql("SalaryCalManager.GetNoGrantDoneSalary");

            return this.Repository.Find().QuerySingle<Q_salary_main_item>(sql);
        }

        public List<Info_fin_order_item> GetOrderAllProductItems(string odrNoMain)
        {
           return this.Repository.Find().From<Tb_fin_order_gen>()
                 .Where()
                 .And(Tb_fin_order_gen.Table.Odr_No_Main, odrNoMain)
                 .And(Tb_fin_order_gen.Table.Gen_State, (int)Enum.GenState.Valid)
                 .And(Tb_fin_order_gen.Table.Tot_Cost, Miles.Coro.ORM.DbCompareChar.More, 0)
                 .End()
                 .InnerJoin<Tb_fin_order_item>()
                 .On(Tb_fin_order_gen.Table.Odr_No, Tb_fin_order_item.Table.Odr_No)
                 .JoinTable()
                 .Select()
                 .End()
                 .ToQuery()
                 .ToList<Info_fin_order_item>();

        }

        public List<Info_project_Cost_Item> GetBuildItems(string odrNoMain)
        {
            List<Info_project_Cost_Item> list = this.Repository.Find()
                  .From<Tb_fin_order_gen>()
                  .Where()
                  .And(Tb_fin_order_gen.Table.Odr_No_Main, odrNoMain)
                  .And(Tb_fin_order_gen.Table.Gen_State, (int)Enum.GenState.Valid)
                  .And(Tb_fin_order_gen.Table.Tot_Cost, Miles.Coro.ORM.DbCompareChar.More, 0)
                  .End()
                  .InnerJoin<Tb_project_Cost>()
                  .On(Tb_fin_order_gen.Table.Odr_No, Tb_project_Cost.Table.Odr_No)
                  .JoinTable()
                  .Where()
                  .And(Tb_project_Cost.Table.Cost_State, (int)Enum.ProjectCostState.Valid)
                  .End()
                  .InnerJoin<Tb_project_Cost_Item>()
                  .On(Tb_project_Cost.Table.LinkBill_Id, Tb_project_Cost_Item.Table.LinkBill_Id)
                  .JoinTable()
                  .Select()
                  .End()
                  .InnerJoin<Tb_expend_item>()
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


            return list;

            //decimal sum = 0;

            //sum = list.Sum(item => item.SumCost);

            //return sum;
        }

        public List<Info_carriage_bill> GetFreightItems(string odrNoMain)
        {
            return this.Repository.Find()
                  .From<Tb_fin_order_gen>()
                  .Where()
                  .And(Tb_fin_order_gen.Table.Odr_No_Main, odrNoMain)
                  .And(Tb_fin_order_gen.Table.Gen_State, (int)Enum.GenState.Valid)
                  .And(Tb_fin_order_gen.Table.Tot_Cost, Miles.Coro.ORM.DbCompareChar.More, 0)
                  .End()
                  .InnerJoin<Tb_carriage_bill>()
                  .On(Tb_fin_order_gen.Table.Odr_No, Tb_carriage_bill.Table.Odr_No)
                  .JoinTable()
                  .Where()
                  .And(Tb_carriage_bill.Table.Carriage_State, (int)Enum.CarriageState.Valid)
                  .End()
                  .Select()
                  .End()
                  .ToQuery()
                  .ToList<Info_carriage_bill>();
        }

        public List<Bu_CalSalaryGen> QueryChangeCalSalaryMainList()
        {
            //提成表中，成交金额，增加了的合同，或者，已付金额减少了的合同
            /*
             SELECT
	t.Odr_No_Main,
	t.pay_Cost,
	t.tot_Cost,
	s.cal_pay_Cost,
	s.cal_tot_Cost,
	s.related_Man,
  f.odr_Type,
  f.employ_Code,
  f.jia_Name,
  f.odr_Prt_Name
FROM
	(
		SELECT
			SUM (tot_Cost) AS tot_Cost,
			SUM (pay_Cost) AS pay_Cost,
			Odr_No_Main
		FROM
			tb_fin_order_gen
		WHERE
			is_Salary = 1
		GROUP BY
			Odr_No_Main
	) t
INNER JOIN tb_salary_main s ON t.Odr_No_Main = s.Odr_No_Main
INNER JOIN tb_fin_order_gen f on t.Odr_No_Main=f.odr_No
WHERE
	t.tot_Cost > s.cal_tot_Cost
OR t.pay_Cost < s.cal_pay_Cost
             
             */

            string sql = SQL.SqlManager.Intance.GetSql("SalaryCalManager.QueryChangeCalSalaryMainList");

            List<Bu_CalSalaryGen> result = this.Repository.Find().QuerySingle<Bu_CalSalaryGen>(sql);

            return result;

        }

        public bool Save(Info_salary_main salaryMain)
        {
            ExeBatchTrans exeBatchTrans= this.BatchTrans();

            exeBatchTrans.Append<string>((r,id)=> 
            {
                if (r.Remove<Tb_salary_main>()
                .Where()
                .And(Tb_salary_main.Table.Odr_No_Main, id)
                .EndWhere().Save() < 0) { return false; }

                if (r.Remove<Tb_salary_main_item>()
                .Where()
                .And(Tb_salary_main_item.Table.Odr_No_Main, id)
                .EndWhere().Save() < 0) { return false; }

                return true;
            },salaryMain.Odr_No_Main);

            exeBatchTrans.Append<Info_salary_main>((r,info)=> 
            {
                return this.Add(r, info);
            }, salaryMain);

            foreach(var v in salaryMain.Items)
            {
                exeBatchTrans.Append<Info_salary_main_item>((r, item) =>
                {
                    return this.Add(r, item);
                }, 
                v);
            }

            exeBatchTrans.Append<string>((r, mainCode) =>
            {
                return r.Update<Tb_fin_order_gen>()
                .Set()
                .Field(Tb_fin_order_gen.Table.Is_Salary,(int)Enum.IsFlag.Yes)
                .EndSet()
                .Where()
                .And(Tb_fin_order_gen.Table.Odr_No_Main,mainCode)
                .EndWhere()
                .Save() > 0;
            }, salaryMain.Odr_No_Main);

                      
            return exeBatchTrans.Save();
        }

        public override Info_salary_main FindThe(params object[] parms)
        {
            string odrNoMain = (string)parms[0];

            return this.Repository.Find()
                .From<Tb_salary_main>()
                .Where()
                .And(Tb_salary_main.Table.Odr_No_Main, odrNoMain)
                .End()
                .Select().End()
                .ToQuery()
                .First<Info_salary_main>();
        }
    }
}
