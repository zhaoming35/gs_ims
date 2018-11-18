using Miles.IMSFramework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbDeptRole : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbDeptRole()
        {
            InitializeComponent();
        }

        public void LoadData(string deptCode)
        {
            List<Sm_dept_role> list =Miles.Coro.ORM.Repository.SingleRepository
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
            .ToList<Sm_dept_role>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Miles.IMSFramework.Model.Sm_dept_role.Table.Role_Name, "职位", true));

            this.SetDataSource(list, columnsMap, Miles.IMSFramework.Model.Sm_dept_role.Table.Role_Id, Miles.IMSFramework.Model.Sm_dept_role.Table.Role_Name);


        }
    }
}
