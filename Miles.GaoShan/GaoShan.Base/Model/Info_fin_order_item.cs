using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_fin_order_item: Tb_fin_order_item
    {
        public decimal Item_Total {

            get { return this.Item_Count * this.Item_Price; }
        }

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
