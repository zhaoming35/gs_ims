using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Enum
{
    /// <summary>
    ///出库状态
    /// </summary>
    public enum OutStoreState
    {      /// <summary>
           /// 未提交
           /// </summary>
        New = 0,
        /// <summary>
        /// 提交生效
        /// </summary>
        Valid = 1
    }
}
