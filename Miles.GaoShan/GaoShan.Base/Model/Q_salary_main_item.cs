using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Q_salary_main_item: Info_salary_main_item
    {
        [Description("发放金额")]
        [DataFieldAttribute("Salary_Grant", "decimal", "发放金额", true)]
        public decimal Salary_Grant
        {
            get; set;
        }

        public decimal SalaryCost
        {
            get { return this.Cal_Value * this.Cal_base_Salary * this.Salary_Ratio/100; }
        }

        [Description("计算比例值")]
        [DataFieldAttribute("cal_Value", "decimal", "计算比例值", true)]
        public decimal Cal_Value
        {
            get; set;
        }

        [Description("计算基数")]
        [DataFieldAttribute("cal_base_Salary", "decimal", "计算基数", true)]
        public decimal Cal_base_Salary
        {
            get; set;
        }

        [Description("计算日期")]
        [DataFieldAttribute("oper_Date", "datetime", "计算日期",true)]
        public DateTime Oper_Date
        {
            get;set;
        }
    }
}
