using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Miles.Coro.ORM;

namespace Miles.App.Entity.Logic
{
    public class DbManager
    {
        Miles.Coro.ORM.Repository repository = null;
        protected Miles.Coro.ORM.Repository Repository
        {
            get { if (repository == null) { repository = Miles.Coro.ORM.Repository.SingleRepository; } return repository; }
        }



        public void SetOperateInfo(object obj, List<string> operCodes = null, List<string> operDates = null)
        {
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;
            string Oper_Code = user.Employ_Code;
            DateTime Oper_Date = Repository.DbManager.GetSystemDate();
            List<string> listCodes = new List<string>();
            if (operCodes != null)
            {
                foreach (var v in operCodes)
                {
                    listCodes.Add(v.ToLower());
                }
            }

            List<string> listDates = new List<string>();
            if (operDates != null)
            {
                foreach (var v in operDates)
                {
                    listDates.Add(v.ToLower());
                }
            }

            foreach (PropertyInfo info in obj.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance))
            {
                if (info.IsDefined(typeof(DataFieldAttribute), false))
                {
                    DataFieldAttribute attribute = (DataFieldAttribute)Attribute.GetCustomAttribute(info, typeof(DataFieldAttribute));

                    if (listCodes.Contains(attribute.FieldName.ToLower()))
                    {
                        Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance.SetValue(obj, info.Name, Oper_Code);
                    }

                    if (listDates.Contains(attribute.FieldName.ToLower()))
                    {
                        Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance.SetValue(obj, info.Name, Oper_Date);
                    }
                }
            }
        }

        public bool Add(Miles.Coro.ORM.Repository repository, object obj, List<string> operCodes = null, List<string> operDates = null)
        {
            List<string> listCodes = new List<string>();
            listCodes.Add("Oper_Code");
            if (operCodes != null) { listCodes.AddRange(operCodes); }

            List<string> listDates = new List<string>();
            listDates.Add("Oper_Date");
            if (operDates != null) { listDates.AddRange(operDates); }

            SetOperateInfo(obj, listCodes, listDates);
            return repository.Add(obj);
        }

        protected long NewId() { return Miles.Coro.Common.Utils.GuidToInt64(); }

        /// <summary>
        /// 执行批量操作
        /// </summary>
        /// <returns></returns>
        public ExeBatchTrans BatchTrans()
        {
            return new ExeBatchTrans(this.Repository);
        }



    }


    public class ExeBatchTrans
    {
        Miles.Coro.ORM.Repository repository = null;
        List<ITransFun> funList = new List<ITransFun>();

        public ExeBatchTrans(Miles.Coro.ORM.Repository repository) { this.repository = repository; }

        public ExeBatchTrans Append<T>(Func<Miles.Coro.ORM.Repository, T, bool> exeFun, object parm)
        {
            funList.Add(new TransFun<T>(exeFun, parm));
            return this;
        }

        public bool Save()
        {
            try
            {
                repository.DbManager.BeginTransaction();

                for (int i = 0; i < funList.Count; i++)
                {
                    var fun = funList[i].ExeFun;

                    object objBool = fun.DynamicInvoke(repository, funList[i].Parm);
                    //Func<Miles.Coro.ORM.Repository, object, bool> funReal = (Func<Miles.Coro.ORM.Repository, object, bool>)fun;
                    if (!(bool)objBool)
                    {
                        repository.DbManager.RollBack();
                        return false;
                    }
                }

                repository.DbManager.Commit();
                return true;
            }
            catch (Exception)
            {
                if (repository != null)
                    repository.DbManager.RollBack();
            }
            return false;

        }
    }

    public class TransFun<T> : ITransFun
    {
        public Delegate ExeFun { get; set; }

        public object Parm { get; set; }


        public TransFun(Func<Repository, T, bool> exeFun, object parm)
        {
            this.ExeFun = exeFun;
            this.Parm = parm;
        }
    }

    public interface ITransFun
    {
        Delegate ExeFun { get; set; }

        object Parm { get; set; }
    }

}
