using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    /// <summary>
    /// 提成计算结果各种过程值
    /// </summary>
    public class CalParmResult
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public decimal Value { get; set; }

        public CalParmResult()
        {
        }

        public CalParmResult(string name, string text, decimal value)
        {
            Name = name;
            Text = text;
            Value = value;
        }
    }
}
