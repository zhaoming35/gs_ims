using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Admin
{
    public partial class FmProjectCostCorrect : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.ProjectCostManager manager = new Logic.ProjectCostManager();

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查找");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "修改");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Stop, "终止合同");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmProjectCostCorrect()
        {
            InitializeComponent();
            ucProjectCostList1.SelectValueChange += UcProjectCostList1_SelectValueChange;
        }

        private void UcProjectCostList1_SelectValueChange(object sender, object obj)
        {
            if (this.ucProjectCostList1.CurrentSelectValue == null) { return; }

            Model.Info_project_Cost info = this.ucProjectCostList1.CurrentSelectValue as Model.Info_project_Cost;

            ucProjectCostInfo1.SetDataSource(info);
        }

        protected override void Query(ToolStripButton sender)
        {
            FmOrderFind fmOrderNo = new FmOrderFind();
            fmOrderNo.FindOrderNoList = (odrNo) => 
            {
                return manager.QueryCommitCostWithOrdNo(odrNo);
            };

            fmOrderNo.SelectValue += (obj) =>
            {
                Model.Info_OrderMain info = obj as Model.Info_OrderMain;

                ucProjectCostInfo1.Clear();
                ucProjectCostList1.Clear();

                List <Model.Info_project_Cost> list = manager.FindTheDoneProjectCost(info.Odr_No);
                ucProjectCostList1.SetDataSource(list);

            };

            fmOrderNo.ShowDialog();
        }

        protected override void Save(ToolStripButton sender)
        {
            if (this.ucProjectCostList1.CurrentSelectValue == null) { return; }

            Model.Info_project_Cost info = this.ucProjectCostList1.CurrentSelectValue as Model.Info_project_Cost;

            string msg = string.Format("确定修改:{0},{1}工程费用?", info.Odr_No, info.Odr_Prt_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (this.ucProjectCostInfo1.AdminEdit(sender))
                {
                    Model.Info_project_Cost info_OrderMain = this.ucProjectCostInfo1.CurrentSelectValue as Model.Info_project_Cost;

                    this.SetButtonClickResultTip(sender, "保存成功");
                }
            }
        }



    }
}
