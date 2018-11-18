using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_matchTb_item: Tb_matchTb_item
    {
        public decimal ItemWeight { get { return this.Item_Count * this.Mtl_Weight; } }
    }
}
