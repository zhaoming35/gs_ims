using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_project_Cost: Tb_project_Cost
    {
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        [Description("联络单类型")]
        public string LinkBillTypeText
        {
            get
            {
                if (this.LinkBill_Type == 0) { return "正常单"; }
                else { return "取消单"; }
            }
        }

        public List<Info_project_Cost_Item> Items = new List<Info_project_Cost_Item>();
    }
}
