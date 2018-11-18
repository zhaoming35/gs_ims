using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miles.App.Entity.Model;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransportNature : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransportNature()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Tb_enum> dt = Enum.EnumText.GetEnumManager().FindKindAllInfo("Transport_Nature");

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_enum.Table.Enum_Text, "运输性质", true));

            this.SetDataSource(dt, columnsMap, Tb_enum.Table.Enum_Value, Tb_enum.Table.Enum_Text);

        }
    }
}
