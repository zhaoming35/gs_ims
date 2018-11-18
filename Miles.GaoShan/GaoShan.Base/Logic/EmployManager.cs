using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.App.Entity.Logic;
using Miles.IMSFramework.Model;

namespace GaoShan.Sales.Logic
{
    public class EmployManager : DbManager
    {
        public Sm_employee GetEmployee(string employ_Code)
        {
            return this.Repository.Query().From<Sm_employee>().ToSelect().EndSelect()
                .ToWhere()
                .And(Sm_employee.Table.Employ_Code, employ_Code)
                .EndWhere().ToQuery().First<Sm_employee>();
        }

        public  List<Sm_employee> GetDeptEmploys(string deptCode)
        {
            return this.Repository.Find().From<Sm_employee>()
                 .Where()
                 .And(Sm_employee.Table.Dept_Code, deptCode)
                 .End()
                 .ToQuery()
                 .ToList<Sm_employee>();
        }

        public Dictionary<string, Sm_employee> GetAllEmployee()
        {
            return this.Repository.Query().From<Sm_employee>().ToSelect().EndSelect()
                     .ToWhere()
                     .EndWhere().ToQuery().ToMapKeyItem<string, Sm_employee>(Sm_employee.Table.Employ_Code);
        }

        public Dictionary<long, Model.Info_dept_role> GetDeptRole(string deptCode)
        {
            return  Miles.Coro.ORM.Repository.SingleRepository
                   .Query()
                    .From<Sm_dept_role>()
                    .ToSelect()
                    .EndSelect()
                    .ToWhere()
                    .And(Sm_dept_role.Table.Dept_Code, deptCode)
                    .EndWhere()
                    .ToOrderBy()
                    .ASC(Sm_dept_role.Table.Level)
                    .EndOrderBy()
                    .ToQuery()
                    .ToMapKeyItem<long, Model.Info_dept_role>(Sm_dept_role.Table.Role_Id);
        }
    }
}
