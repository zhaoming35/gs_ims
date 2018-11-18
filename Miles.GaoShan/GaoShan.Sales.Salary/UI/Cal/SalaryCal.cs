using GaoShan.Sales.Model;
using GaoShan.Sales.UI.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Salary.UI.Cal
{
    public abstract class SalaryCal
    {
 
        public abstract bool HasSalary();
        //public abstract bool DoCal();

        protected Logic.SalaryCalManager calManager = new Logic.SalaryCalManager(); 
        protected Logic.SalaryTmpManager tmpManager = new Logic.SalaryTmpManager();
        protected Info_salary_tmp tmpSalary;
        protected int odrType;
        protected string odrNoMain;
        protected decimal buildCost;
        protected Dictionary<string, object> dicParms = new Dictionary<string, object>();
        private List<CalParmResult> listCalProcess = new List<CalParmResult>();
        protected Model.Bu_CalSalaryGen salaryGen;
        protected Model.Info_salary_main salaryMain;

        /// <summary>
        /// 计算的比例值
        /// </summary>
        protected decimal calValue = 0;

        /// <summary>
        /// 减去费用的总金额,计算提成金额基数
        /// </summary>
        protected decimal calBaseSalary;

        public SalaryCal(int odrType, string odrNoMain, Model.Bu_CalSalaryGen salaryGen)
        {
            this.salaryGen = salaryGen;
            this.odrNoMain = odrNoMain;
            this.odrType = odrType;
            this.tmpSalary =tmpManager.FindThe(odrType);
        }

        protected bool InitVars()
        {
            //得到关系人
            Miles.IMSFramework.Model.Sm_employee employeeClinch = Cache.LogicCache.DicEmployee[salaryGen.Employ_Code];
            long roleId = employeeClinch.Role_Id;
            Model.Info_dept_role roleInfo = Cache.LogicCache.DicSalaryDeptRole[roleId];

            salaryMain = Miles.Coro.Common.Utils.CopyToOther<Bu_CalSalaryGen, Model.Info_salary_main>(salaryGen);
            List<PostSalary> salaries = new List<PostSalary>();

            string parentCode = employeeClinch.Parent_Code;
            while (!string.IsNullOrEmpty(parentCode))
            {
                Miles.IMSFramework.Model.Sm_employee parent = Cache.LogicCache.DicEmployee[parentCode];
                Model.Info_dept_role roleParent = Cache.LogicCache.DicSalaryDeptRole[parent.Role_Id];

                PostSalary postSalary = new PostSalary();
                postSalary.Employ_Code = parentCode;
                postSalary.Level = roleParent.Level;
                postSalary.Role_Id = roleParent.Role_Id;

                salaries.Add(postSalary);

                parentCode = parent.Parent_Code;
            }
            salaryMain.RelatedMan = salaries;

            //buildCost = calManager.GetBuildCost(this.odrNoMain);
            AddParm("Tot_Cost", salaryGen.Tot_Cost,"合同总金额");
            AddParm("Part_Cost", salaryGen.Part_Cost,"配套金额");
            AddParm("Sales_Cost", salaryGen.Sales_Cost, "销售费用");
            AddParm("Tax_Cost", salaryGen.Tax_Cost, "税费");
            AddParm("Freight_Cost", salaryGen.Freight_Cost, "运费金额");
            AddParm("Rent_Cost", salaryGen.Rent_Cost, "外租金");
            AddParm("Build_Cost", salaryGen.Build_Cost, "搭建费用");
            AddParm("Discount_Cost", salaryGen.Discount_Cost, "优惠金额");

            return true;
        }

        protected void AddSalaryItem(string employCode, int salaryKind, decimal salaryRatio)
        {
            Model.Info_salary_main_item itemSalary = new Info_salary_main_item();
            itemSalary.Employ_Code = employCode;
            itemSalary.Odr_No_Main = this.odrNoMain;
            itemSalary.Salary_Ratio = salaryRatio;
            itemSalary.Salary_Kind = salaryKind;
            salaryMain.Items.Add(itemSalary);

        }

        protected void AddParm(string name, object value,string text)
        {
           listCalProcess.Add(new CalParmResult(name,text,(decimal)value));
           dicParms.Add("${" + name + "}", value);
        }

        protected void ParseFormula(List<VarCal> varCals)
        {
            var vars = varCals.OrderBy(v => v.Level).ToList<VarCal>();
            foreach (var v in vars)
            {
                object value = ReportTemplateBase.ParseFormula(v.Formula, dicParms);

                value=Math.Round((decimal)value, 2);

                AddParm(v.Name, value,v.Text);
            }
        }

        public bool DoCal()
        {
            //获得相关人的提成费用
            //部门奖励
            var deptRoles = from item in tmpSalary.DeptAward
                            group item by item.Role into g
                            select g.Key;

            foreach (var role in deptRoles)
            {
                var rangeDept = from item in tmpSalary.DeptAward
                                where item.Role == role
                                orderby item.DL ascending
                                select item;

                decimal ratio = 0;
                foreach (var v in rangeDept)
                {
                    if (v.UL == 0)
                    {
                        if (calValue >= v.DL)
                        {
                            ratio = v.RT;
                            break;
                        }
                    }
                    else
                    {
                        if (calValue >= v.DL && calValue <= v.UL)
                        {
                            ratio = v.RT;
                            break;
                        }
                    }
                }

                //得到部门奖角色
                var deptMan = from item in salaryMain.RelatedMan
                              where item.Role_Id == role
                              select item;

                //记录部门奖提成信息
                foreach (var m in deptMan)
                {
                    AddSalaryItem(m.Employ_Code, 2, ratio);
                }

            }


            var organRoles = from item in tmpSalary.OrganAward
                             group item by item.Role into g
                             select g.Key;

            foreach (var role in organRoles)
            {
                var rangeOrgan = from item in tmpSalary.OrganAward
                                 where item.Role == role
                                 orderby item.DL ascending
                                 select item;

                decimal ratio = 0;
                foreach (var v in rangeOrgan)
                {
                    if (v.UL == 0)
                    {
                        if (calValue >= v.DL)
                        {
                            ratio = v.RT;
                            break;
                        }
                    }
                    else
                    {
                        if (calValue >= v.DL && calValue <= v.UL)
                        {
                            ratio = v.RT;
                            break;
                        }
                    }
                }

                //得到组织奖角色
                var organMan = from item in salaryMain.RelatedMan
                               where item.Role_Id == role
                               select item;

                //记录组织奖提成信息
                foreach (var m in organMan)
                {
                    AddSalaryItem(m.Employ_Code, 3, ratio);
                }

            }

            //得到副总经理
            //得到总经理
            //得到副总监
            //得到总监
            salaryMain.CalProcess = listCalProcess;
            return calManager.Save(salaryMain);
        }
    }

    public class SalaryCalSales : SalaryCal
    {
        public SalaryCalSales(int odrType, string odrNoMain, Model.Bu_CalSalaryGen salaryGen)
           : base(odrType, odrNoMain, salaryGen)
        {

        }

        public override bool HasSalary()
        {
            if (!InitVars())
            {
                return false;
            }

            //销售单价-总价最高价项目的单价
            List<Model.Info_fin_order_item> items = salaryGen.Items;// calManager.GetOrderAllProductItems(this.odrNoMain);
            var maxItem = items.OrderByDescending(it=>it.Item_Total).First<Model.Info_fin_order_item>();
            //销售指导价
            decimal guidePrice = salaryGen.GuidePrice;
            if (guidePrice < 0)
            {
                string msg = string.Format("{0} 没有维护指导单价,不能进行提成运算",maxItem.Item_Name);
                MessageBox.Show(msg);   
                return false;
            }

            AddParm("Item_Count", maxItem.Item_Count,"最高单价项目数量");
            AddParm("Guide_Price", guidePrice, "销售指导价");

            salaryMain.Guide_Price = guidePrice;
            ParseFormula(tmpSalary.VarCals);

            calValue  = Math.Round((decimal)dicParms["${Ratio_Price}"]*100,2);
            calBaseSalary = Math.Round((decimal)dicParms["${Gross_Rofit}"], 2);

            salaryMain.Cal_Value = Math.Round(calValue/100, 2); 
            salaryMain.Cal_base_Salary = calBaseSalary;

            //判断是否符合成交人提成比例
            var rangeEmploy = from item in tmpSalary.SalesMan
                              orderby item.DL ascending
                              select item;

            decimal ratio = 0;
            foreach (var v in rangeEmploy)
            {
                if (v.UL == 0)
                {
                    if (calValue >= v.DL)
                    {
                        ratio = v.RT;
                        break;
                    }
                }
                else
                {
                    if (calValue >= v.DL&& calValue<=v.UL)
                    {
                        ratio = v.RT;
                        break;
                    }
                }
            }

            salaryMain.Cal_pay_Cost = salaryGen.Pay_Cost;
            salaryMain.Cal_tot_Cost = salaryGen.Tot_Cost;

            AddSalaryItem(salaryGen.Employ_Code,1, ratio);

            return ratio > 0;
        }
    }

    public class SalaryCalLease : SalaryCal
    {
        public SalaryCalLease(int odrType, string odrNoMain, Model.Bu_CalSalaryGen salaryGen)
            : base(odrType, odrNoMain, salaryGen)
        {
           
        }

        public override bool HasSalary()
        {
            if (!InitVars())
            {
                return false;
            }

            ParseFormula(tmpSalary.VarCals);

            calValue = Math.Round((decimal)dicParms["${Profit_Margin}"] * 100, 2);
            calBaseSalary = Math.Round((decimal)dicParms["${Gross_Rofit}"], 2);

            salaryMain.Cal_Value = Math.Round(calValue / 100, 2);
            salaryMain.Cal_base_Salary = calBaseSalary;

            //判断是否符合成交人提成比例
            var rangeEmploy = from item in tmpSalary.SalesMan
                              orderby item.DL ascending
                              select item;

            decimal ratio = 0;
            foreach (var v in rangeEmploy)
            {
                if (v.UL == 0)
                {
                    if (calValue >= v.DL)
                    {
                        ratio = v.RT;
                        break;
                    }
                }
                else
                {
                    if (calValue >= v.DL && calValue <= v.UL)
                    {
                        ratio = v.RT;
                        break;
                    }
                }
            }

            salaryMain.Cal_pay_Cost = salaryGen.Pay_Cost;
            salaryMain.Cal_tot_Cost = salaryGen.Tot_Cost;

            AddSalaryItem(salaryGen.Employ_Code, 1, ratio);

            return ratio > 0;
        }

    }

}
