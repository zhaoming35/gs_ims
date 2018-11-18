using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public  class Bu_CalSalaryGen: Info_fin_order_gen
    {
        /// <summary>
        /// 销售指导价
        /// </summary>
        public decimal GuidePrice { get; set; }

        [Description("计算提成时合同总金额")]
        [DataFieldAttribute("cal_tot_Cost", "decimal", "计算提成时合同总金额")]
        public decimal Cal_tot_Cost
        {
            get;set;
        }

        [Description("计算提成时支付总金额")]
        [DataFieldAttribute("cal_pay_Cost", "decimal", "计算提成时支付总金额")]
        public decimal Cal_pay_Cost
        {
            get;set;
        }
    }
}
