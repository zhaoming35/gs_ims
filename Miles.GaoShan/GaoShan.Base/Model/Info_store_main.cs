using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_store_main: Tb_store_main
    {
        [Description("分类编码")]
        [DataFieldAttribute("kind_Code", "varchar", "分类编码",true)]
        public string Kind_Code
        {
            get;set;
        }
        //[DataFieldAttribute("kind_Name", "varchar", "物料类型名称", true)]
        public string Kind_Name { get { return GaoShan.Sales.Cache.LogicCache.DicMtlKind[this.Kind_Code].Kind_Name;} }

        [Description("物料名称")]
        [DataFieldAttribute("mtl_Name", "varchar", "物料名称",true)]
        public string Mtl_Name
        {
            get;set;
        }

        [Description("物料规格")]
        [DataFieldAttribute("mtl_Spec", "varchar", "物料规格", true)]
        public string Mtl_Spec
        {
            get;set;
        }

        [Description("物料单位")]
        [DataFieldAttribute("mtl_Unit", "varchar", "物料单位", true)]
        public string Mtl_Unit
        {
            get;set;
        }

    }
}
