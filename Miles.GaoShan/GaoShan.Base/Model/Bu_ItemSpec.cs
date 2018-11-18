using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    /// <summary>
    /// 规格json对象
    /// </summary>
    public class Bu_ItemSpec
    {
        public List<Model.Info_product_property> Items { get; set; }

        public Bu_ItemSpec()
        {
            if (this.Items == null) { this.Items = new List<Info_product_property>(); }
        }

        public void AddItem(Info_product_property pro)
        {
            this.Items.Add(pro);
        }

        public void AddItems(IEnumerable<Info_product_property> pros)
        {
            this.Items.AddRange(pros);
        }

        public override string ToString()
        {
            var query = from e in Items
                        orderby e.Property_Seq ascending
                        select e;

            StringBuilder sb = new StringBuilder();
            foreach(var v in query)
            {
                if (v.Is_Spec != 1) { continue; }
                if (sb.Length > 0) { sb.Append("/"); }
                sb.Append(v.Property_Name + v.Property_Value + v.Property_Unit);
            }

            return sb.ToString();
        }
    }




}
