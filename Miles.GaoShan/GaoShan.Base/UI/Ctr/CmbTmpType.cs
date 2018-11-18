using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbTmpType : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbTmpType()
        {
            InitializeComponent();
        }
        public void LoadData()
        {

            List<Model.Tb_tmp_info> dt = Miles.Coro.ORM.Repository.SingleRepository.Query()
                .From<Model.Tb_tmp_info>()
                .ToSelect()
                .EndSelect()
                .ToWhere()
                .And(Model.Tb_tmp_info.Table.Order_Type,Miles.Coro.ORM.DbCompareChar.NotEqual, new Miles.Coro.ORM.MDbParameter("orderType",4))
                .EndWhere()
                .ToOrderBy()
                .ASC(Model.Tb_tmp_info.Table.Order_Type)
                .EndOrderBy()
                .ToQuery()
                .ToList<Model.Tb_tmp_info>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_tmp_info.Table.Tmp_Name, "名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_tmp_info.Table.Tmp_Explain, "说明", true));

            this.SetDataSource(dt, columnsMap, Model.Tb_tmp_info.Table.Tmp_Id, Model.Tb_tmp_info.Table.Tmp_Name);

        }
    }
}
