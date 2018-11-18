using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public class CmbTmpTheType : Miles.Framework.UI.Controls.MComboBox
    {
        public void LoadData(int orderType)
        {

            List<Model.Tb_tmp_info> dt = Miles.Coro.ORM.Repository.SingleRepository.Query()
                .From<Model.Tb_tmp_info>()
                .ToSelect()
                .EndSelect()
                .ToWhere()
                .And(Model.Tb_tmp_info.Table.Order_Type, orderType)
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
