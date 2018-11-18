using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_matchTb : Tb_matchTb
    {
        [Description("合同类型文本")]
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        [Description("拆除时间")]
        public string Rm_Time
        {
            get
            {

                if (this.Odr_Type == 2)
                {
                    return this.Let_Rm_SDate.ToString("yyyy-MM-dd") + "至" + this.Let_Rm_EDate.ToString("yyyy-MM-dd");

                }else
                {
                    return "";
                }

            }
        }

        [Description("搭建时间")]
        public string Bud_Date
        {
            get
            {
                //if (this.Odr_Type ==1)
                //{
                //    return this.Let_Bud_SDate.ToString("yyyy-MM-dd HH");
                //}
                //else  
                if (this.Odr_Type == 2)
                {
                    return this.Let_Bud_SDate.ToString("yyyy-MM-dd") + "至" + this.Let_Bud_EDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    return "";
                }
            }
        }

        public List<Model.Info_matchTb_item> Items = new List<Info_matchTb_item>();
    }
}
