using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Miles.App.Entity.Model;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbCompanyAccount : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbCompanyAccount()
        {
            InitializeComponent();
        }
 
        public void LoadData()
        {
            List<Tb_enum> dt = Enum.EnumText.GetEnumManager().FindKindAllInfo("Fin_CompanyAccount");

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_enum.Table.Enum_Text, "入账账户", true));

            this.SetDataSource(dt, columnsMap, Tb_enum.Table.Enum_Value, Tb_enum.Table.Enum_Text);

        }
    }
}
