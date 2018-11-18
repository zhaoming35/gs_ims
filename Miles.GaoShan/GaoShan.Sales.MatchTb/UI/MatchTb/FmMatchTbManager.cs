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
using Miles.Framework.UI;

namespace GaoShan.Sales.MatchTb.UI
{
    public partial class FmMatchTbManager : Miles.Framework.UI.Forms.FmMdi
    {
        //[LogicAttribute("哈哈")]
        //[LogicAttribute("哈哈")]
        //public string MyTest { get; set; }
        Logic.MatchTbManager manager = new Logic.MatchTbManager();

        Logic.LinkBillManager linkManager = new Logic.LinkBillManager();

        public FmMatchTbManager()
        {
            InitializeComponent();
            this.ucMacchTbList1.SelectValueChange += UcMacchTbList1_SelectValueChange;
        }

        private void UcMacchTbList1_SelectValueChange(object sender, object obj)
        {
            Model.Info_matchTb infoTb = obj as Model.Info_matchTb;
            ucMatchTbInfo1.SetDataSource(infoTb);
        }

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToXLS, "导出联络单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "完成");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "配套表预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.DocumentAdd)
            {
                DocumentAdd(sender);
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
            else if (buttonType == ButtonType.ExportToXLS)
            {
                ExportToXLS(sender);
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
            LoadAll();
        }

        private void Check(ToolStripButton sender)
        {
            if (ucLinkBillPend1.CurrentSelectValue == null) { return; }
            Model.Info_link_bill info = ucLinkBillPend1.CurrentSelectValue as Model.Info_link_bill;
            string msg = string.Format("确定完成项目:{0},{1}的所有配套表?", info.Odr_No, info.LinkBill_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (linkManager.SetDoneMatchTb(info))
                {
                    LoadAll();
                }
            }
        }

        private void ExportToXLS(ToolStripButton sender)
        {
            if (ucLinkBillPend1.CurrentSelectValue == null) { return; }

            ucLinkBillPend1.Export();
        }

        private void Commit(ToolStripButton sender)
        {
            if (ucMacchTbList1.CurrentSelectValue == null) { return; }
            Model.Info_matchTb info = ucMacchTbList1.CurrentSelectValue as Model.Info_matchTb;
            string msg = string.Format("确定提交:{0},{1}配套表?", info.Odr_No, info.MatchTb_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Commit(info))
                {
                    LoadAll();
                }
            }
        }

        private void DocumentRemove(ToolStripButton sender)
        {
            if (ucMacchTbList1.CurrentSelectValue == null) { return; }
            Model.Info_matchTb info = ucMacchTbList1.CurrentSelectValue as Model.Info_matchTb;
            string msg = string.Format("确定删除:{0},{1}配套表?", info.Odr_No, info.MatchTb_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    LoadAll();
                }
            }
        }

        private void Document(ToolStripButton sender)
        {
            if (ucMatchTbInfo1.CurrentSelectValue == null) { return; }

            Model.Info_matchTb info = ucMatchTbInfo1.CurrentSelectValue as Model.Info_matchTb;

            GaoShan.Sales.UI.Win.FmReoGridShow fmReoGridShow = new GaoShan.Sales.UI.Win.FmReoGridShow();

            fmReoGridShow.SetReportBind(new GaoShan.Sales.UI.Report.FmMatchTbManagerReport(), info);
            fmReoGridShow.ShowDialog();
        }

        private void DocumentAdd(ToolStripButton sender)
        {
            if (ucLinkBillPend1.CurrentSelectValue == null) { return; }
            Model.Info_link_bill info = ucLinkBillPend1.CurrentSelectValue as Model.Info_link_bill;


            this.tabControl1.SelectedIndex = 0;
            FmMatchTbCreate fm = new FmMatchTbCreate(info);
            fm.SelectValue += (obj) => {

                this.tabControl1.SelectedIndex = 1;
                LoadNoDoneMatchTb();

            };
            fm.ShowDialog();
        }

        protected override void Save(ToolStripButton sender)
        {
            if (ucMatchTbInfo1.CurrentSelectValue == null) { return; }

            if (ucMatchTbInfo1.Save(sender)) { this.SetButtonClickResultTip(sender, "保存成功"); }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAll();
        }

        private void LoadAll()
        {
            ucMacchTbList1.Clear();
            ucLinkBillPend1.Clear();
            ucMatchTbInfo1.Clear();
            LoadNeedCreateMatchTb();
            LoadNoDoneMatchTb();
        }

        private void LoadNoDoneMatchTb()
        {
            List<Model.Info_matchTb> list = manager.GetNoDoneMatchTb();
            ucMacchTbList1.SetDataSource(list);
        }


        private void LoadNeedCreateMatchTb()
        {
           List<Model.Info_link_bill> list= linkManager.GetNeedCreateMatchTb();
            ucLinkBillPend1.SetDataSource(list);
        }
    }
}
