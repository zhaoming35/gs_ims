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

namespace GaoShan.Sales.UI.Fin
{
    public partial class FmOrderIncomeQuery : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.GenManager manager = new Logic.GenManager();

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }
        public FmOrderIncomeQuery()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            beginDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd 00:00:00");
            endDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd 23:59:59");
            cmbOrderType1.LoadData();
        }

  
        //protected override void PrintDialog(ToolStripButton sender)
        //{
        //    //Miles.Coro.Common.Print.PrintConfigManager.PrintDialog(Doc.DocBuilder.ReportName);//this.GetType().FullName);
        //    sender.Tag = Doc.DocBuilder.ReportName;
        //    base.PrintDialog(sender);
        //}

        //Logic.TmpManager tmpManager = new Logic.TmpManager();

        //protected override void PrintPreview(ToolStripButton sender)
        //{

        //    if (this.ucIncomeList1.CurrentSelectValue == null) { return; }

        //    Model.Info_OrderMain info = ucIncomeList1.CurrentSelectValue as Model.Info_OrderMain;

        //    Model.Info_tmp tmpInfo = tmpManager.GetTheTmpAllInfo(info.Tmp_Id);
        //    Doc.DocBuilder docBuilder = new Doc.DocBuilder(tmpInfo, info);

        //    Aspose.Words.Document doc = new Aspose.Words.Document(docBuilder.ToStream(info.Odr_Clause));

        //    using (Aspose.Words.Rendering.AsposeWordsPrintDocument printDocument = new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc))
        //    {
        //        PageSettings ps = Miles.Coro.Common.Print.PrintConfigManager.GetPageSettings(Doc.DocBuilder.ReportName);
        //        printDocument.DefaultPageSettings = ps;

        //        PrintPreviewDialog previewDlg = new PrintPreviewDialog();
        //        previewDlg.Document = printDocument;
        //        previewDlg.ShowInTaskbar = true;
        //        previewDlg.MinimizeBox = true;
        //        previewDlg.PrintPreviewControl.Zoom = 1.5d;
        //        previewDlg.WindowState = FormWindowState.Maximized;
        //        previewDlg.ShowDialog();
        //    }
        //}

        //protected override void Print(ToolStripButton sender)
        //{
        //    if (this.ucIncomeList1.CurrentSelectValue == null) { return; }

        //    Model.Info_OrderMain info = ucIncomeList1.CurrentSelectValue as Model.Info_OrderMain;

        //    Model.Info_tmp tmpInfo = tmpManager.GetTheTmpAllInfo(info.Tmp_Id);
        //    Doc.DocBuilder docBuilder = new Doc.DocBuilder(tmpInfo, info);

        //    Aspose.Words.Document doc = new Aspose.Words.Document(docBuilder.ToStream(info.Odr_Clause));

        //    doc.Print();
        //}


        protected override void Query(ToolStripButton sender)
        {
            List<Model.Info_fin_order_gen> list = manager.QueryOrderIncomeRecord(beginDate.Value,endDate.Value,txtOrderNo.Text,cmbOrderType1.SelectKey);
            mDataGrid1.SetDataSource<Model.Info_fin_order_gen>(list);
        }


    }
}
