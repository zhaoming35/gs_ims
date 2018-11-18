using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public  class Info_store_out: Tb_store_out
    {
        public List<Info_store_out_item> Items = new List<Info_store_out_item>();
    }
}
