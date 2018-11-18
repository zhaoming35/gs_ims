using Aspose.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<object, object> dic = new Dictionary<object, object>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            for(int i = 0; i < 4; i++)
            {
                dic.Add(i, i);
            }

            object key = 1;
            bool bl = dic.ContainsKey(key);
            object value=  dic[key];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.LoadFormat = LoadFormat.WordML;
            Aspose.Words.Document doc = new Aspose.Words.Document("tmpTest.docx", loadOptions);

            using (Aspose.Words.Rendering.AsposeWordsPrintDocument printDocument = new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc))
            {
                //PageSettings ps = Miles.Coro.Common.Print.PrintConfigManager.GetPageSettings(Doc.DocBuilder.ReportName);
                //printDocument.DefaultPageSettings = ps;

                PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                previewDlg.Document = printDocument;
                previewDlg.ShowInTaskbar = true;
                previewDlg.MinimizeBox = true;
                previewDlg.PrintPreviewControl.Zoom = 1.5d;
                previewDlg.WindowState = FormWindowState.Maximized;
                previewDlg.ShowDialog();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    //dialog.Multiselect = true;//该值确定是否可以选择多个文件
        //    dialog.Title = "请选择文件";
        //    dialog.Filter = @"模板文件|*.xlsx";
        //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        this.reoGridControl1.Reset();
        //        reoGridControl1.Load(dialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
        //        //reoGridControl1.CurrentWorksheet.RowCount = (int)info.Row_Count;
        //        //reoGridControl1.CurrentWorksheet.ColumnCount = (int)info.Column_Count;
        //    }
        //}
    }
}
