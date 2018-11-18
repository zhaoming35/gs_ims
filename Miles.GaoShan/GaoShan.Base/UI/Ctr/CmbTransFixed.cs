using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransFixed : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransFixed()
        {
            InitializeComponent();
        }

        Logic.FinTransportTmpManager manager = new Logic.FinTransportTmpManager();

        public void LoadData()
        {
            Model.Info_fin_transport_tmp infoTmp = manager.FindThe();

            List<Model.TransFixedItem> list = infoTmp.TransFixed;

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("Name", "固定方式", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("UnitWeight", "单重", false));

            this.SetDataSource(list, columnsMap, "Name", "Name");

        }
    }
}
