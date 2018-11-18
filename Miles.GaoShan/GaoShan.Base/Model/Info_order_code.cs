using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_order_code: Tb_order_code
    {
        public string OrderTypeCode { get; set; }

        public override string ToString()
        {
            return string.Format("{0}/{1}-{2}-{3}", this.Employ_Code, this.Order_Date, Seq_No.ToString().PadLeft(2, '0'), OrderTypeCode);

        }
    }
}
