using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class SalaryTmpManager : LogicManager<Model.Info_salary_tmp>
    {
        public override bool Add(Info_salary_tmp t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_salary_tmp t)
        {
            throw new NotImplementedException();
        }

        public override Info_salary_tmp FindThe(params object[] parms)
        {
            int salaryType = (int)parms[0];

            Info_salary_tmp info= this.Repository.Query().From<Model.Tb_salary_tmp>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_salary_tmp.Table.Salary_Type, salaryType)
                .EndWhere()
                .ToQuery()
                .First<Info_salary_tmp>();

            if (info == null) { info = new Info_salary_tmp(); info.Salary_Type = salaryType; }

            return info;
        }

        public bool Save(Info_salary_tmp tmp)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<int>((r, id) =>
            {
                if (r.Remove<Tb_salary_tmp>()
                .Where()
                .And(Tb_salary_tmp.Table.Salary_Type, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }

                return true;
            }, tmp.Salary_Type);

            exeBatchTrans.Append<Info_salary_tmp>((r, info) =>
            {
                return this.Add(r,info);

            }, tmp);

            return exeBatchTrans.Save();
        }
    }
}
