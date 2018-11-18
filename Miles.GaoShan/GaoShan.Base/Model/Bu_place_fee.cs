using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    /// <summary>
    /// 运费查询使用
    /// </summary>
    public class Bu_place_fee: Info_place_fee
    {
        [Description("载重")]
        [DataFieldAttribute("truck_Load", "decimal", "载重",true)]
        public decimal Truck_Load
        {
            get;set;
        }

        [Description("每公里费用")]
        [DataFieldAttribute("per_Cost", "decimal", "每公里费用",true)]
        public decimal Per_Cost
        {
            get;set;
        }

        [Description("车载长度")]
        [DataFieldAttribute("truck_Length", "decimal", "车载长度",true)]
        public decimal Truck_Length
        {
            get;set;
        }

    }
}
