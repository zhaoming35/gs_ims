using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Quote.UI
{
    public class CalResult
    {
        public decimal max_Length { get; set; }
        public decimal tent_Weight { get; set; }
        public decimal add_Weight_Sum { get; set; }
        public decimal Weight_Sum { get {return this.tent_Weight + this.add_Weight_Sum; } }
        
            
            
    }
}
