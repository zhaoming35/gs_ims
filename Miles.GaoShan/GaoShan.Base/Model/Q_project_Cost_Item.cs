using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Q_project_Cost_Item: Info_project_Cost_Item
    {


        [Description("合同编码")]
        [DataFieldAttribute("odr_No", "varchar", "合同编码")]
        public string Odr_No
        {
            get;set;
        }

        [Description("业务员名称")]
        [DataFieldAttribute("employ_Name", "varchar", "业务员名称")]
        public string Employ_Name
        {
            get;set;
        }

        [Description("合同产品名称")]
        [DataFieldAttribute("odr_Prt_Name", "varchar", "合同产品名称")]
        public string Odr_Prt_Name
        {
            get;set;
        }

        [Description("操作日期")]
        [DataFieldAttribute("oper_Date", "datetime", "操作日期")]
        public DateTime Oper_Date
        {
            get;set;
        }

        [Description("合同类型")]
        [DataFieldAttribute("odr_Type", "int", "合同类型")]
        public int Odr_Type
        {
            get;set;
        }

        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }
    }
}
