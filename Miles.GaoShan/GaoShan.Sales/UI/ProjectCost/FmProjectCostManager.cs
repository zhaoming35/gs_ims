using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miles.Framework.UI.Forms;

namespace GaoShan.Sales.UI.ProjectCost
{
    public partial class FmProjectCostManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.ProjectCostManager manager = new Logic.ProjectCostManager();
        Logic.LinkBillManager linkBillManager = new Logic.LinkBillManager();

        public FmProjectCostManager()
        {
            InitializeComponent();
            this.ucLinkBillList1.SelectValueChange += UcLinkBillList1_SelectValueChange;
            this.ucProjectCostList1.SelectValueChange += UcProjectCostList1_SelectValueChange;
        }

        Model.Info_link_bill currentLinkBill = null;

        private void UcLinkBillList1_SelectValueChange(object sender, object obj)
        {
            if (this.ucLinkBillList1.CurrentSelectValue == null) { return; }
            Model.Info_link_bill info = this.ucLinkBillList1.CurrentSelectValue as Model.Info_link_bill;
            currentLinkBill = info;
            Model.Info_project_Cost infoProject = Miles.Coro.Common.Utils.CopyToOther<Model.Info_link_bill, Model.Info_project_Cost>(info);

            ucProjectCostInfo1.SetDataSource(infoProject);
        }

        private void UcProjectCostList1_SelectValueChange(object sender, object obj)
        {
            if (this.ucProjectCostList1.CurrentSelectValue == null) { return; }

            Model.Info_project_Cost info = this.ucProjectCostList1.CurrentSelectValue as Model.Info_project_Cost;

            ucProjectCostInfo1.SetDataSource(info);

            currentLinkBill = linkBillManager.FindLinkBillInfo(info.LinkBill_Id);
        }

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "联络单预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
    
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void Save(ToolStripButton sender)
        {
            if (ucProjectCostInfo1.CurrentSelectValue == null) { return; }

            if (this.ucProjectCostInfo1.Save(sender))
            {
                Model.Info_project_Cost info_OrderMain = this.ucProjectCostInfo1.CurrentSelectValue as Model.Info_project_Cost;

                LazyInit();
                this.SetButtonClickResultTip(sender, "保存成功");
                tabControl1.SelectedIndex = 1;
            }
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {

            if (buttonType == ButtonType.Document)
            {
                Document(sender);
            }
            else if (buttonType == ButtonType.Commit)
            {
                Commit(sender);
            }
            else if (buttonType == ButtonType.Reload)
            {
                Reload(sender);
            }
        }

        private void Reload(ToolStripButton sender)
        {
            LazyInit();
        }

        private void Commit(ToolStripButton sender)
        {
            if (ucProjectCostInfo1.CurrentSelectValue == null) { return; }
            Model.Info_project_Cost info = this.ucProjectCostInfo1.CurrentSelectValue as Model.Info_project_Cost;
          
            if (manager.CommitProjectCost(info))
            {
                LazyInit();
                this.SetButtonClickResultTip(sender, "提交成功");
                tabControl1.SelectedIndex = 1;
            }
        }


        private void Document(ToolStripButton sender)
        {

            if (currentLinkBill == null) { return; }

            Win.FmReoGridShow fmReoGridShow = new Win.FmReoGridShow();
            fmReoGridShow.SetReportBind(new Report.FmLinkBillManagerReport(), currentLinkBill);
            fmReoGridShow.ShowDialog();
        }

        protected override void SetTabControls()
        {
            this.ucProjectCostInfo1.SetTabControls(this.tabControlSeq);

        }

        protected override void LazyInit()
        {
            Clear();

            LoadNotDoneProjectCost();

            LoadNotBuildLinkBill();
        }

        private void LoadNotBuildLinkBill()
        {
            List<Model.Info_link_bill> list = linkBillManager.FindNotBuildProjectCostList();
        
            ucLinkBillList1.SetDataSource(list);
        }

        private void Clear()
        {
            this.ucProjectCostList1.Clear();
            this.ucLinkBillList1.Clear();
            this.ucProjectCostInfo1.Clear();
        }
        
        /// <summary>
        /// 加载自己的合同，没提交的合同
        /// </summary>
        private void LoadNotDoneProjectCost()
        {
         
            //Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_project_Cost> list = manager.FindNotDone();
            ucProjectCostList1.SetDataSource(list);
        }
    }
}
