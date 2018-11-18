
using GaoShan.Sales.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Store.UI.Ctr
{
    public partial class CmbMtlKind : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbMtlKind()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Tb_mtl_kind> dt = GaoShan.Sales.Cache.LogicCache.DicMtlKind.Values.ToList<Tb_mtl_kind>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_mtl_kind.Table.Kind_Code, "编码", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Tb_mtl_kind.Table.Kind_Name, "名称", true));

            this.SetDataSource(dt, columnsMap, Tb_mtl_kind.Table.Kind_Code, Tb_mtl_kind.Table.Kind_Name);


        }
    }
}
