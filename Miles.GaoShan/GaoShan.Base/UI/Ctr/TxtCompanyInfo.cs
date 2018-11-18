using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class TxtCompanyInfo : Miles.Framework.UI.Controls.MTextBoxAutoList
    {
        public TxtCompanyInfo()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.PopupWidth = -1;
            this.SelectedItemBackColor = System.Drawing.Color.LightSteelBlue;
            this.SelectedItemForeColor = System.Drawing.SystemColors.ControlText;
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

            foreach(var v in list)
            {
                this.AddItem(v,v.Act_Name, v.Act_Name,
                    Miles.Coro.Common.StringUtils.GetFirstPinyin(v.Act_Name), v.Define_Code, v.Act_Adress, Miles.Coro.Common.StringUtils.GetFirstPinyin(v.Act_Adress));
            }
           
        }
    }
}
