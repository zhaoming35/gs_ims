using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_OrderMain: Tb_order_main
    {

        public string OrderStateText
        {
            get
            {
                return Enum.EnumText.GetOrderStateText(this.Odr_State);
            }
        }

        public Model.Info_order_code OrderCode { get; set; }

        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        public Dictionary<string, string> FieldExtend
        {
            get
            {
                if (string.IsNullOrEmpty(this.Col_Extend))
                {
                    return new Dictionary<string, string>();
                }

                Dictionary<string, string> dic = (Dictionary<string, string>)JsonConvert.DeserializeObject(this.Col_Extend, typeof(Dictionary<string, string>));
                return dic;
            }

            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Col_Extend = strSerializeJSON;
            }

        }

        public List<Info_order_item> Items = new List<Info_order_item>();

        /// <summary>
        /// 合同条款部分
        /// </summary>
        public byte[] Odr_Clause
        {
            get;set;
        }

        //public byte[] Odr_Pay
        //{
        //    get; set;
        //}

        public byte[] Odr_BodyText
        {
            get; set;
        }

        public object Tag { get; set; }
    }
}
