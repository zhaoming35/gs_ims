using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    [TableAttribute("test", "gaoshan_db")]
    public class DbDecValue
    {
        [Description("数值")]
        [DataFieldAttribute("value", "decimal", "数值")]
        public decimal Value { get; set; }
    }
}
