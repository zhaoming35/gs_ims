using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_project_Cost_Item: Tb_project_Cost_Item
    {
        public decimal SumCost { get { return this.Item_Price * this.Item_Qty; } }

        //[Description("联络单状态")]
        //[DataFieldAttribute("cost_State", "int", "联络单状态",true)]
        //public int Cost_State
        //{
        //    get;set;
        //}

        /// <summary>
        ///提成计算标记
        /// </summary>
        [Description("提成计算标记")]
        [DataFieldAttribute("define_Flag", "int", "提成计算标记",true)]
        public int Define_Flag
        {
            get; set;
        }
    }
}
