using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public  class Info_mtl_kind: Tb_mtl_kind
    {

        public string ParentName { get; set; }

        public List<Info_mtl_kind> Children = new List<Info_mtl_kind>();

        public List<Model.Info_mtl_item> Items = new List<Info_mtl_item>();
    }
}
