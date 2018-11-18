using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbMtlInfo : Miles.Framework.UI.Controls.MComboBox
    {
        //Logic.MtlManager mtlManager = new Logic.MtlManager();

        public CmbMtlInfo()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //List<Model.Info_mtl_item> dt = mtlManager.GetAllItems();

            List<Model.Info_mtl_item> dt = Cache.LogicCache.DicMtlItem.Values.ToList<Model.Info_mtl_item>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Info_mtl_item.Table.Mtl_Code, "物料编码", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Info_mtl_item.Table.Mtl_Name, "物料名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Info_mtl_item.Table.Mtl_Spec, "物料规格", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("Kind_Name", "物料类别", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Info_mtl_item.Table.Mtl_Unit, "单位", false));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Info_mtl_item.Table.Mtl_Weight, "单重", false));
            this.SetDataSource(dt, columnsMap, Model.Info_mtl_item.Table.Mtl_Code, Model.Info_mtl_item.Table.Mtl_Name);


        }
    }
}
