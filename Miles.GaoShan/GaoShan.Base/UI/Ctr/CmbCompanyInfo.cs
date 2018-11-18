using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbCompanyInfo : Miles.Framework.UI.Controls.MComboBox
    {
        public CmbCompanyInfo()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            List<Model.Tb_company_act> list = Miles.Coro.ORM.Repository.SingleRepository.Query()
                .From<Model.Tb_company_act>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_company_act.Table.Valid_Flag, 1)
                .EndWhere()
                .ToQuery()
                .ToList<Model.Tb_company_act>();

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_company_act.Table.Define_Name, "内部名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_company_act.Table.Act_Name, "供方名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_company_act.Table.Act_FaRen, "法人", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_company_act.Table.Act_Phone, "电话", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_company_act.Table.Act_Adress, "地址", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(Model.Tb_company_act.Table.Pay_Tax_Code, "纳税人识别码", true));

            this.SetDataSource(list, columnsMap, Model.Tb_company_act.Table.Act_Id, Model.Tb_company_act.Table.Define_Name);


        }
    }
}
