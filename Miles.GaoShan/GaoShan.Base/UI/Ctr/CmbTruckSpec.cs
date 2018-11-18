using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTruckSpec : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTruckSpec()
        {
            InitializeComponent();
        }

        Logic.TruckInfoManager truckInfoManager = new Logic.TruckInfoManager();

        public void LoadData()
        {
            List<Model.Tb_truck_info> list = truckInfoManager.FindAll();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_truck_info.Table.Truck_Name, "货车规格", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_truck_info.Table.Truck_Length, "长度", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_truck_info.Table.Truck_Load, "载重", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_truck_info.Table.Per_Cost, "每公里费用", true));

            this.SetDataSource(list, columnsMap, Model.Tb_truck_info.Table.Truck_Name, Model.Tb_truck_info.Table.Truck_Name);


        }
    }
}
