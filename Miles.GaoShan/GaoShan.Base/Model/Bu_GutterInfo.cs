using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    /// <summary>
    /// 天沟信息
    /// </summary>
    public class Bu_GutterInfo
    {

        public string Width_Unit { get; set; }
        public string Length_Unit { get; set; }

        public decimal Width_Value { get; set; }
        public decimal Length_Value { get; set; }


        public Bu_GutterInfo() { this.Width_Unit = "米"; this.Length_Unit = "米"; }

        public override string ToString()
        {
            return string.Format("宽度{0}{1}  长度{2}{3}",this.Width_Value,this.Width_Unit,this.Length_Value,this.Length_Unit);
        }
    }
}
