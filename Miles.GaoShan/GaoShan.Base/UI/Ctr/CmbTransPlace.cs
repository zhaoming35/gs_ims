using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTransPlace : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTransPlace()
        {
            InitializeComponent();
        }

        public void LoadData(long parentId=0)
        {
            List<Model.Info_place_info> list = new List<Model.Info_place_info>();

            this.Clear();
            if (parentId == 0) { list = Cache.LogicCache.GetAllProvince(); }
            else { list = Cache.LogicCache.GetAllChildren(parentId); }

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_place_info.Table.Place_Name, "地点", true));

            this.SetDataSource(list, columnsMap, Model.Tb_place_info.Table.Place_Id, Model.Tb_place_info.Table.Place_Name);

        }
    }
}
