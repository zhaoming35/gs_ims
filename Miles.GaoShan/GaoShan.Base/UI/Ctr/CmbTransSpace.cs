using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransSpace : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransSpace()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Model.DecValueText> result = new List<Model.DecValueText>();

            Model.DecValueText valueText3 = new Model.DecValueText();
            valueText3.Value = 3;
            valueText3.Text = "3米间距";
            result.Add(valueText3);

            Model.DecValueText valueText5 = new Model.DecValueText();
            valueText5.Value = 5;
            valueText5.Text = "5米间距";
            result.Add(valueText5);


            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("Text", "间距", true));

            this.SetDataSource(result, columnsMap, "Value", "Text");

        }
    }
}
