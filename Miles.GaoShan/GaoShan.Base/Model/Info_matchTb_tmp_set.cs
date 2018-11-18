using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public  class Info_matchTb_tmp_set: Tb_matchTb_tmp_set
    {
        public Dictionary<string,string> SetItems
        {
            get
            {
                if (string.IsNullOrEmpty(this.Set_Items))
                {
                    return new Dictionary<string, string>();
                }

                Dictionary<string, string> itemSpec = (Dictionary<string, string>)JsonConvert.DeserializeObject(this.Set_Items, typeof(Dictionary<string, string>));
                return itemSpec;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Set_Items = strSerializeJSON;
            }
        }




    }
}
