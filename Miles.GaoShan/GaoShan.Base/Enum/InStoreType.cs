using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Enum
{
    /// <summary>
    /// 入库类型
    /// </summary>
    public enum InStoreType
    {
        /// <summary>
        /// 租赁回库入库
        /// </summary>
        OrderBackIn=1,
        /// <summary>
        /// 直接入库
        /// </summary>
        DirIn=2
    }
}
