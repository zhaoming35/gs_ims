﻿using Miles.App.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbPayPart : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbPayPart()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Tb_enum> dt = Enum.EnumText.GetEnumManager().FindKindAllInfo("Pay_Part");

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_enum.Table.Enum_Text, "付款方", true));

            this.SetDataSource(dt, columnsMap, Tb_enum.Table.Enum_Value, Tb_enum.Table.Enum_Text);

        }
    }
}
