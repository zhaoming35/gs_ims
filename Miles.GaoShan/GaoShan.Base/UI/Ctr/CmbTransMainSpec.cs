using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransMainSpec : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransMainSpec()
        {
            InitializeComponent();
        }


        Logic.FinTransportTmpManager manager = new Logic.FinTransportTmpManager();

        public void LoadData()
        {
            Model.Info_fin_transport_tmp infoTmp = manager.FindThe();

            List<Model.StringValue> list = infoTmp.MainSpec;

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("Value", "主材规格", true));

            this.SetDataSource(list, columnsMap, "Value", "Value");

        }
    }
}
