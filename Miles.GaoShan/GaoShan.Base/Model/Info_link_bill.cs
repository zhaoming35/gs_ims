using Miles.Coro.ORM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_link_bill: Tb_link_bill
    {
        [Description("合同类型文本")]
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        [Description("联络单类型")]
        public string LinkBillTypeText
        {
            get
            {
                if (this.LinkBill_Type == 0) { return "正常单"; }
                else { return "取消单"; }
            }
        }

        //[Description("业务员名字")]
        //public string Employ_Name { get; set; }

        [Description("业务员名字电话")]
        public string Employ_Name_Phone { get { return this.Employ_Name + "/" + this.Employ_Phone; } }

        public List<Model.Info_link_bill_tent> Items = new List<Info_link_bill_tent>();

        
        [Description("活动持续时间")]
        public string Use_ContinuedTime
        {
            get
            {
                if (System.Data.SqlTypes.SqlDateTime.MinValue.Value.Equals(this.Let_Use_SDate)
                        || System.Data.SqlTypes.SqlDateTime.MinValue.Value.Equals(this.Let_Use_EDate))
                {
                    return "";
                }
                return this.Let_Use_SDate.ToString("MM月dd日") + "-" + this.Let_Use_EDate.ToString("MM月dd日");
            }
        }


        [Description("拆卸开始及结束时间")]
        public string Rm_ContinuedTime
        {
            get {

                if (System.Data.SqlTypes.SqlDateTime.MinValue.Value.Equals(this.Let_Rm_SDate)
                    || System.Data.SqlTypes.SqlDateTime.MinValue.Value.Equals(this.Let_Rm_EDate))
                {
                    return "";
                }

                return this.Let_Rm_SDate.ToString("MM月dd日") + "-" + this.Let_Rm_EDate.ToString("MM月dd日"); }
        }

        [Description("提供资料绑定数据")]
        public string ProvideInfo
        {
            get
            {
                return ToDisplayText(this.Provide_Info);
            }
        }


        //其它所有的都要这么改，对应的excel位置变量修改
        private string ToDisplayText(string strValue)
        {
            if (string.IsNullOrEmpty(strValue)) { return null; }

            Dictionary<string, bool> dicProvideInfo = (Dictionary<string, bool>)JsonConvert.DeserializeObject(strValue, typeof(Dictionary<string, bool>));

            StringBuilder sb = new StringBuilder();
            foreach (var v in dicProvideInfo)
            {
                sb.Append(v.Key);
                if (v.Value)
                {
                    sb.Append("（√）");
                }
                else
                {
                    sb.Append("（ ）");
                }
            }

            return sb.ToString();
        }
    }
}
