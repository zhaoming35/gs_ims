using GaoShan.Sales.Doc;
using Miles.Framework.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Template.UI
{
    public partial class FmTemplateManager :  Miles.Framework.UI.Forms.FmMdi
    {
        Logic.TmpManager tmpManager = new Logic.TmpManager();

        protected override void InitToolBtn()
        {

            //this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "预览模板");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "预览模板");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "页面设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Note, "合同页脚");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmTemplateManager()
        {
            InitializeComponent();
            this.ucTmpList1.SelectValueChange += UcTmpList1_SelectValueChange;
            this.ucPartInfo1.SelectValueChange += UcPartInfo1_SelectValueChange;
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Note)
            {
                Note(sender);
            }
        }

        private void Note(ToolStripButton sender)
        {
            FmTmpMainInfo fm = new FmTmpMainInfo();
            fm.SelectValue += (obj) => 
            {

            };
            fm.ShowDialog();
        }

        protected override void PrintDialog(ToolStripButton sender)
        {
            //Miles.Coro.Common.Print.PrintConfigManager.PrintDialog(Doc.DocBuilder.ReportName);//this.GetType().FullName);
            sender.Tag = Doc.DocBuilder.ReportName;
            base.PrintDialog(sender);
        }


        protected override void PrintPreview(ToolStripButton sender)
        {

            Model.Info_tmp info = this.ucTmpList1.CurrentSelectValue as Model.Info_tmp;
            if (info==null||info.Parts.Count==0) { return; }

            DocBuilder docBuilder = new DocBuilder(info);

            DocBuilder.PrintDocPreview(docBuilder.ToStream(), Doc.DocBuilder.ReportName);

            //Aspose.Words.Document doc = new Aspose.Words.Document(docBuilder.ToStream());
            ////Aspose.Words.Rendering.AsposeWordsPrintDocument printDocument = new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc);
            //using (System.Drawing.Printing.PrintDocument printDoc = Miles.Coro.Common.Print.PrintConfigManager.ApplyPrintSettings(new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc), Doc.DocBuilder.ReportName))
            //{
            //    PrintPreviewDialog previewDlg = new PrintPreviewDialog();
            //    previewDlg.Document = printDoc;
            //    previewDlg.ShowInTaskbar = true;
            //    previewDlg.MinimizeBox = true;
            //    previewDlg.PrintPreviewControl.Zoom = 1.5d;
            //    previewDlg.WindowState = FormWindowState.Maximized;
            //    previewDlg.ShowDialog();
            //}
        }

        private void UcPartInfo1_SelectValueChange(object sender, object obj)
        {
            this.ucPartBody1.Clear();
            Model.Tb_tmp_part info = obj as Model.Tb_tmp_part;

            this.ucPartBody1.SetDataSource(info);
        }

        private void UcTmpList1_SelectValueChange(object sender, object obj)
        {
            this.d_TmpName.Text = null;
            this.d_TmpExplain.Text = null;
            this.ucPartBody1.Clear();
            this.ucPartInfo1.Clear();
            if (obj == null) { return; }

            Model.Info_tmp info = obj as Model.Info_tmp;
            d_TmpName.Text = info.Tmp_Name;
            d_TmpExplain.Text = info.Tmp_Explain;

            if (info.Parts.Count == 0)
            {
                //info.Parts = tmpManager.GetAllParts(info.Tmp_Id);
                info.Parts = (List<Model.Tb_tmp_part>)Miles.Framework.UI.Function.MForm.ShowWaitBackground("正在读取文件...", QueryAllParts, info.Tmp_Id);
            }

            ucPartInfo1.InfoTmp = info;
            ucPartInfo1.SetDataSource(info.Parts);
        }

        object QueryAllParts(object tmpId)
        {
            //System.Threading.Thread.Sleep(1000*3);
            return tmpManager.GetAllParts((long)tmpId);
        }

        protected override void LazyInit()
        {
            LoadAllTmpMain();
        }

        private void LoadAllTmpMain()
        {
            List<Model.Info_tmp> list = tmpManager.GetAllTmp();

            ucTmpList1.SetDataSource(list);
        }


    }
}
