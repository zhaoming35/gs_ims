using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_order_item: Tb_order_item
    {
        public string ProductCountUnit { get { return this.Product_Count + this.Product_Unit; } }

        public Bu_ItemSpec ItemSpec
        {
            get
            {
                if (string.IsNullOrEmpty(this.Item_Spec))
                {
                    return new Bu_ItemSpec();
                }

                Bu_ItemSpec itemSpec = (Bu_ItemSpec)JsonConvert.DeserializeObject(this.Item_Spec, typeof(Bu_ItemSpec));
                return itemSpec;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Item_Spec = strSerializeJSON;
            }
        }

    }
}
