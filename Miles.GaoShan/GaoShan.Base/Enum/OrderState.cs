using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Enum
{
    /// <summary>
    /// 订单流转状态
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// 作废
        /// </summary>
        Invalid=-1,
        /// <summary>
        /// 新建，未提交
        /// </summary>
        New=0,
        /// <summary>
        /// 提交
        /// </summary>
        Commit=1,
        /// <summary>
        /// 审核通过
        /// </summary>
        Pass=2,
        /// <summary>
        /// 手工终止
        /// </summary>
        Termination=3

    }
}
