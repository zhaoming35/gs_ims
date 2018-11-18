using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.App.Entity.Logic
{
    /// <summary>
    /// 基本数据库操作逻辑接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILogicManager<T>
    {
        bool Add(T t);

        bool Remove(T t);

        bool Update(T tNew, T tOld);

        List<T> FindAll(params object[] parms);

        List<T> FindDefine(params object[] parms);

        T FindThe(params object[] parms);

    }
}
