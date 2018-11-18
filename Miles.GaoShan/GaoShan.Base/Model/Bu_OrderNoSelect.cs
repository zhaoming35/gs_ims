using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    //[TableAttribute("tb_order_main", "gaoshan_db")]
    //[Serializable]
    public class Bu_OrderNoSelect
    {
        [Description("合同类型文本")]
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        [Description("合同Id")]
        [DataFieldAttribute("odr_Id", "bigint", "合同Id")]
        public long Odr_Id
        {
            get;set;
        }

        [Description("合同编码")]
        [DataFieldAttribute("odr_No", "varchar", "合同编码")]
        public string Odr_No
        {
            get;set;
        }

        [Description("合同类型")]
        [DataFieldAttribute("odr_Type", "int", "合同类型")]
        public int Odr_Type
        {
            get;set;
        }

        [Description("合同产品名称")]
        [DataFieldAttribute("odr_Prt_Name", "varchar", "合同产品名称")]
        public string Odr_Prt_Name
        {
            get;set;
        }

        [Description("甲方(需方)")]
        [DataFieldAttribute("jia_Name", "varchar", "甲方(需方)")]
        public string Jia_Name
        {
            get;set;
        }

        [DataFieldAttribute("odr_Date", "datetime", "合同日期")]
        public DateTime Odr_Date
        {
            get;set;
        }

    }
}
