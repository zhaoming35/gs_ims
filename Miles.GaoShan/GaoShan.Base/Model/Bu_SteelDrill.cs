using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Bu_SteelDrill
    {
        public decimal Length { get; set; }
        public string LengthUnit { get; set; }
        public string StandardText { get; set; }
        public int StandardState { get; set; }
        public string ScrewText { get; set; }
        public int ScrewState { get; set; }
        public Bu_SteelDrill()
        {
            this.ScrewText = "螺纹钢";
            this.StandardText = "标准的";
            this.LengthUnit = "米";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.StandardText);
            if (StandardState == 1)
            {
                sb.Append("（√）");
            }
            else
            {
                sb.Append("（ ）");
            }

            sb.Append(this.ScrewText);
            if (ScrewState == 1)
            {
                sb.Append("（√）");
            }
            else
            {
                sb.Append("（ ）");
            }
            sb.Append("注：写明钢钎长度");
            sb.Append(Length);
            sb.Append(LengthUnit);
            return sb.ToString();
        }
    }
}
