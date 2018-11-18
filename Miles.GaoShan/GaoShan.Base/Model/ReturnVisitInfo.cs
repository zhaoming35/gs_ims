using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    [TableAttribute("tb_test", "gaoshan_db")]
    [Serializable]
    public class ReturnVisitInfo
    {
        public int SelectFlag { get; set; }

        [Description("项目Id")]
        [DataFieldAttribute("item_Id", "bigint", "项目Id", true)]
        public long Item_Id
        {
            get; set;
        }

        [Description("项目类型")]
        [DataFieldAttribute("item_type", "int", "项目类型", true)]
        public int item_type
        {
            get; set;
        }

        [Description("项目编码")]
        [DataFieldAttribute("Odr_No", "string", "项目编码", true)]
        public string Odr_No
        {
            get; set;
        }


        [Description("费用金额")]
        [DataFieldAttribute("tot_cost", "decimal", "费用金额", true)]
        public decimal Tot_Cost
        {
            get; set;
        }

        [Description("费用类别")]
        [DataFieldAttribute("cost_type", "string", "费用类别", true)]
        public string Cost_Type
        {
            get; set;
        }

        [Description("联系电话")]
        [DataFieldAttribute("phone", "string", "联系电话", true)]
        public string Phone
        {
            get; set;
        }

        [Description("记录日期")]
        [DataFieldAttribute("oper_Date", "DateTime", "记录日期", true)]
        public DateTime Oper_Date
        {
            get; set;
        }
    }
}
