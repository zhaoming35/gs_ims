using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.App.Entity.Logic
{
    public abstract class LogicManager<T> : DbManager, ILogicManager<T>
    {

        public abstract bool Add(T t);

        public abstract bool Remove(T t);

        public virtual bool Update(T tNew, T tOld)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> FindAll(params object[] parms)
        {
            throw new NotImplementedException();
        }

        public virtual T FindThe(params object[] parms)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> FindDefine(params object[] parms)
        {
            throw new NotImplementedException();
        }
    }
}
