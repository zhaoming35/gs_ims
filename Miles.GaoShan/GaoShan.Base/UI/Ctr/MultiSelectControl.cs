using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Miles.App.Entity.Model;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class MultiSelectControl : Miles.Framework.UI.Controls.MultiSelectComboBox
    {
        public MultiSelectControl()
        {
            InitializeComponent();
        }


        public void LoadData(string kind)
        {
            List<Tb_enum> dt = Enum.EnumText.GetEnumManager().FindKindAllInfo(kind);
            this.SetDataSource(dt, Tb_enum.Table.Enum_Text, GetKeyFormObj);
        }

        private string GetKeyFormObj(object obj)
        {
            Tb_enum t = obj as Tb_enum;
            return t.Enum_Text;
        }
    }
}
