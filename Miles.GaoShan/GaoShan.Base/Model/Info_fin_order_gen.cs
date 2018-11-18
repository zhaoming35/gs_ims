using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_fin_order_gen : Tb_fin_order_gen
    {
        public decimal Build_Cost
        {
            get
            {
                //var queryCommit = from item in BuildItems
                //                  where item.Cost_State == (int)Enum.ProjectCostState.Valid
                //                  select item;


                return BuildItems.Sum(e => e.SumCost);
            }
        }
        public List<Model.Info_project_Cost_Item> BuildItems = new List<Info_project_Cost_Item>();

        public decimal Freight_Cost
        {
            get { return FreightItems.Sum(e => e.Carriage_Cost); }
        }

        public List<Model.Info_carriage_bill> FreightItems = new List<Model.Info_carriage_bill>();


        [Description("合同类型文本")]
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        [Description("业务员名字")]
        public string Employ_Name
        {
            get
            {
                return Cache.LogicCache.DicEmployee.ContainsKey(this.Employ_Code) ? Cache.LogicCache.DicEmployee[this.Employ_Code].Employ_Name : null;
            }
        }

        public List<Model.Info_fin_order_item> Items = new List<Info_fin_order_item>();

        [Description("支付信息")]
        [DataFieldAttribute("odr_Pay", "varchar", "", true)]
        public string Pay_info { get; set; }




    }
}
