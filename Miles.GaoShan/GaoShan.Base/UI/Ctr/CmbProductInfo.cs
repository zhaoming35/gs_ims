using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbProductInfo : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbProductInfo()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            List<Model.Info_product_info> dt = Miles.Coro.ORM.Repository.SingleRepository.Query()
                .From<Model.Tb_product_info>()
                .ToSelect()
                .EndSelect()
                .ToWhere()
                .EndWhere()
                .ToOrderBy()
                .ASC(Model.Tb_product_info.Table.Seq_No)
                .EndOrderBy()
                .ToQuery()
               .ToList<Model.Info_product_info>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_product_info.Table.Product_Name, "产品名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_product_info.Table.Product_Unit, "产品单位", false));

            this.SetDataSource(dt, columnsMap, Model.Tb_product_info.Table.Product_Id, Model.Tb_product_info.Table.Product_Name);
        

        }
    }
}
