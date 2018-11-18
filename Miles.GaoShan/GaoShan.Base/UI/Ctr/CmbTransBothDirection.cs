﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Miles.App.Entity.Model;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransBothDirection : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransBothDirection()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Tb_enum> dt = Enum.EnumText.GetEnumManager().FindKindAllInfo("Trans_Both_Direction");

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_enum.Table.Enum_Text, "往返状态", true));

            this.SetDataSource(dt, columnsMap, Tb_enum.Table.Enum_Value, Tb_enum.Table.Enum_Text);


        }
    }
}