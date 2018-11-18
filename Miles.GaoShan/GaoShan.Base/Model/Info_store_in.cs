using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_store_in: Tb_store_in
    {
        public List<Info_store_in_item> Items = new List<Info_store_in_item>();
    }
}
