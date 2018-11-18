using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Enum
{
    /// <summary>
    /// 运输单状态
    /// </summary>
    public enum CarriageState
    {       
        /// <summary>
             /// 作废
             /// </summary>
        Invalid = -1,
        /// <summary>
        /// 新建，为提交
        /// </summary>
        New = 0,
        /// <summary>
        /// 生效
        /// </summary>
        Valid = 1,
        /// <summary>
        /// 手工终止
        /// </summary>
        Termination = 3
    }
}
