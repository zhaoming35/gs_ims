using Miles.Framework.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Carriage
{
    public partial class FmCarriageManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.LinkBillManager linkManager = new Logic.LinkBillManager();

        Logic.CarriageManager manager = new Logic.CarriageManager();

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToXLS, "导出联络单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "完成");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
   
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "运输单预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmCarriageManager()
        {
            InitializeComponent();
            this.ucCarriageList1.SelectValueChange += UcCarriageList1_SelectValueChange;
        }

        private void UcCarriageList1_SelectValueChange(object sender, object obj)
        {
            if (ucCarriageList1.CurrentSelectValue == null) { return; }
            Model.Info_carriage_bill info = ucCarriageList1.CurrentSelectValue as Model.Info_carriage_bill;
            ucCarriageInfo1.SetDataSource(info);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.DocumentAdd)
            {
                DocumentAdd(sender);
            }
            else if (buttonType == ButtonType.ExportToXLS)
            {
                ExportToXLS(sender);
            }
            else if (buttonType == ButtonType.Document)
            {
                Document(sender);
            }
            else if (buttonType == ButtonType.DocumentRemove)
            {
                DocumentRemove(sender);
            }
            else if (buttonType == ButtonType.Commit)
            {
                Commit(sender);
            }
            else if (buttonType == ButtonType.Check)
            {
                Check(sender);
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

        private void Check(ToolStripButton sender)
        {
            if (ucLinkBillPend1.CurrentSelectValue == null) { return; }
            Model.Info_link_bill info = ucLinkBillPend1.CurrentSelectValue as Model.Info_link_bill;
            string msg = string.Format("确定完成项目:{0},{1}的所有运输单?", info.Odr_No, info.LinkBill_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (linkManager.SetDoneCarriage(info))
                {
                    LazyInit();
                }
            }
        }

        private void Commit(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 1) { return; }
            if (ucCarriageInfo1.CurrentSelectValue == null) { return; }
            Model.Info_carriage_bill info = ucCarriageInfo1.CurrentSelectValue as Model.Info_carriage_bill;

            if (manager.Commit(info))
            {
                LoadNoDoneCarriage();
                this.SetButtonClickResultTip(sender, "提交成功");
            }
        }

        private void DocumentRemove(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 1) { return; }
            if (ucCarriageList1.CurrentSelectValue == null) { return; }
            Model.Info_carriage_bill info = ucCarriageList1.CurrentSelectValue as Model.Info_carriage_bill;

            string msg = string.Format("确定删除:{0},{1}运输单?", info.Odr_No, info.Carriage_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    LazyInit();
                    this.SetButtonClickResultTip(sender, "删除成功");
                }
            }
        }

        private void Document(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 1) { return; }
            if (this.ucCarriageInfo1.CurrentSelectValue == null) { return; }

            Model.Info_carriage_bill info = ucCarriageInfo1.CurrentSelectValue as Model.Info_carriage_bill;

            Win.FmReoGridShow fmReoGridShow = new Win.FmReoGridShow();

            fmReoGridShow.SetReportBind(new Report.FmCarriageManagerReport(), info);
            fmReoGridShow.ShowDialog();
        }

        private void ExportToXLS(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 0) { return; }
            if (ucLinkBillPend1.CurrentSelectValue == null) { return; }

            ucLinkBillPend1.Export();
        }

        private void DocumentAdd(ToolStripButton sender)
        {
            //if (ucLinkBillPend1.CurrentSelectValue == null) { return; }
            Model.Info_link_bill info = ucLinkBillPend1.CurrentSelectValue as Model.Info_link_bill;


            this.tabControl1.SelectedIndex = 0;
            FmCarriageCreate fm = new FmCarriageCreate(info);
            fm.SelectValue += (obj) => {

                this.tabControl1.SelectedIndex = 1;
                LoadNoDoneCarriage();

            };
            fm.ShowDialog();


        }

        protected override void Save(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 1) { return; }
            if (ucCarriageInfo1.CurrentSelectValue == null) { return; }

            if (ucCarriageInfo1.Save(sender)) { this.SetButtonClickResultTip(sender, "保存成功"); }
        }

        protected override void SetTabControls()
        {
            this.ucCarriageInfo1.SetTabControls(this.tabControlSeq);

        }

        protected override void LazyInit()
        {
            LoadNeedCreateCarriage();
            LoadNoDoneCarriage();
        }

        private void LoadNoDoneCarriage()
        {
          ucCarriageInfo1.Clear();
          ucCarriageList1.Clear();
          List<Model.Info_carriage_bill> list= manager.GetNoDoneCarriage();
          ucCarriageList1.SetDataSource(list);
        }

        private void LoadNeedCreateCarriage()
        {
            ucLinkBillPend1.Clear();
            List<Model.Info_link_bill> list = linkManager.GetNeedCreateCarriage();
            ucLinkBillPend1.SetDataSource(list);
        }
    }
}
