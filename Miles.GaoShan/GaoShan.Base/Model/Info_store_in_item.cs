using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_store_in_item: Tb_store_in_item
    {
        public decimal Already_InQty { get; set; }
        public decimal Already_OutQty { get; set; }

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
