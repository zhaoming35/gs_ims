using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbFinActInfo : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbFinActInfo()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Model.Tb_fin_act> list = Miles.Coro.ORM.Repository.SingleRepository.Query()
                .From<Model.Tb_fin_act>()
                .ToSelect().EndSelect()
                .ToOrderBy()
                .ASC(Model.Tb_fin_act.Table.Define_Code)
                .EndOrderBy()
                .ToQuery()
                .ToList<Model.Tb_fin_act>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_fin_act.Table.Pay_Name, "内部名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_fin_act.Table.Pay_Act_Name, "账户名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_fin_act.Table.Pay_Bank_Name, "开户行", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_fin_act.Table.Pay_Act_No, "账号", true));


            this.SetDataSource(list, columnsMap, Model.Tb_fin_act.Table.Pay_Id, Model.Tb_fin_act.Table.Pay_Name);


        }
    }
}
