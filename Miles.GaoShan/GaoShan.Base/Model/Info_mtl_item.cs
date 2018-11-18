using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_mtl_item: Tb_mtl_item
    {
        [DataFieldAttribute("kind_Name", "varchar", "物料类型名称",true)]
        public string Kind_Name { get; set; }

 
    }
}
