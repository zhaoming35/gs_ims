using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using GaoShan.Sales.Model;
using Miles.App.Entity.Model;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbExpendItem : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbExpendItem()
        {
            InitializeComponent();
        }

        Logic.ExpendItemManager manager = new Logic.ExpendItemManager();

        public void LoadData()
        {
            List<Tb_expend_item> dt = manager.FindAll();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_expend_item.Table.Item_Name, "支出项目", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_expend_item.Table.Define_Flag, "参与提成计算", true));

            this.SetDataSource(dt, columnsMap, Tb_expend_item.Table.Item_Value, Tb_expend_item.Table.Item_Name);

        }
    }
}
