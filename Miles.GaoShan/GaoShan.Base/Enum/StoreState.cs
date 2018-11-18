using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Enum
{
    /// <summary>
    /// 库存状态
    /// </summary>
    public enum StoreState
    {
        /// <summary>
        /// 正常状态
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 库存锁定
        /// </summary>
        LockStore = 1,
        /// <summary>
        /// 提交单
        /// </summary>
        Commit = 2

    }
}
