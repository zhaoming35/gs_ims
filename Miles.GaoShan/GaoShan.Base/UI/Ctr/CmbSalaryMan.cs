using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbSalaryMan : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbSalaryMan()
        {
            InitializeComponent();
        }

        Logic.EmployManager manager = new Logic.EmployManager();

        public void LoadData()
        {
            List<Miles.IMSFramework.Model.Sm_employee> lt = manager.GetDeptEmploys("004"); ;

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Miles.IMSFramework.Model.Sm_employee.Table.Employ_Name, "员工姓名", true));

            this.SetDataSource(lt, columnsMap, Miles.IMSFramework.Model.Sm_employee.Table.Employ_Code, Miles.IMSFramework.Model.Sm_employee.Table.Employ_Name);

        }
    }
}
