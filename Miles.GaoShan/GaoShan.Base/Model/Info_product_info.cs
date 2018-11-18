using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_product_info : Tb_product_info
    {
        public decimal Procuct_Count { get; set; }
        public List<Model.Info_product_property> Items = new List<Info_product_property>();
        public string Item_Type {get;set;}
    }
}
