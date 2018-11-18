using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Q_store_out_item: Tb_store_out_item
    {
        public string StoreOutType
        {
            get { return Enum.EnumText.GetStoreOutTypeText(this.StoreOut_Type); }
        }

        /// <summary>
        ///合同编码
        /// </summary>
        [Description("合同编码")]
        [DataFieldAttribute("odr_No", "varchar", "合同编码")]
        public string Odr_No
        {
            get; set;
        }

        [Description("出库类型")]
        [DataFieldAttribute("storeOut_Type", "int", "出库类型")]
        public int StoreOut_Type
        {
            get; set;
        }

        [Description("操作日期")]
        [DataFieldAttribute("oper_Date", "datetime", "操作日期")]
        public DateTime Oper_Date
        {
            get; set;
        }

        [DataFieldAttribute("kind_Name", "varchar", "物料类型名称", true)]
        public string Kind_Name { get; set; }

        [Description("物料名称")]
        [DataFieldAttribute("mtl_Name", "varchar", "物料名称", true)]
        public string Mtl_Name
        {
            get; set;
        }

        [Description("物料规格")]
        [DataFieldAttribute("mtl_Spec", "varchar", "物料规格", true)]
        public string Mtl_Spec
        {
            get; set;
        }

        [Description("物料单位")]
        [DataFieldAttribute("mtl_Unit", "varchar", "物料单位", true)]
        public string Mtl_Unit
        {
            get; set;
        }

        [Description("单重")]
        [DataFieldAttribute("mtl_Weight", "decimal", "单重", true)]
        public decimal Mtl_Weight
        {
            get; set;
        }
    }
}
