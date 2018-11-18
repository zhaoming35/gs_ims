using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransEdgeHeight : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransEdgeHeight()
        {
            InitializeComponent();
        }

        Logic.FinTransportTmpManager manager = new Logic.FinTransportTmpManager();

        public void LoadData()
        {
            Model.Info_fin_transport_tmp infoTmp = manager.FindThe();

            List<Model.DecValue> list = infoTmp.EdgeHeight;

            List<Model.DecValueText> result = new List<Model.DecValueText>();
            foreach(var v in list)
            {
                Model.DecValueText valueText = new Model.DecValueText();
                valueText.Value = v.Value;
                valueText.Text = v.Value + "米边高";
                result.Add(valueText);
            }



            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("Text", "边高", true));

            this.SetDataSource(result, columnsMap, "Value", "Text");

        }
    }
}
