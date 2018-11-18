using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;
using System.IO;
using Xceed.Words.NET;

namespace GaoShan.Sales.UI.Order
{
    public partial class UCOrderProtocol : UCBase
    {
        private MemoryStream streamBody = null;
        public MemoryStream StreamBody { get { return streamBody; } }
        public Func<MemoryStream> GetTmpStreamBody;

        public UCOrderProtocol()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.btnSyn.Click += BtnSyn_Click;
            this.btnImport.Click += BtnImport_Click;
            this.btnExport.Click += BtnExport_Click;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (streamBody == null) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = @"模板文件|*.docx";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (DocX document = DocX.Load(streamBody))
                {
                    document.SaveAs(sfd.FileName);
                    Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnExport, "导出完成", 1000);

                }
            }
        }
    
        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = @"模板文件|*.docx";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                streamBody = Doc.DocBuilder.LoadCtrViewDoc(this.mRichEditOnly1, dialog.FileName);
                //using (DocX document = DocX.Load(dialog.FileName))
                //{
                //    streamBody = new MemoryStream();
                //    document.SaveAs(streamBody);
                //    string filename = System.IO.Path.Combine("Report", "tmp.docx");
                //    document.SaveAs(filename);
                //    this.mRichEditSimple1.LoadDocument(filename);
                //}
            }
        }

        private void BtnSyn_Click(object sender, EventArgs e)
        {
            if (GetTmpStreamBody == null) { throw new Exception("GetTmpStreamBody is null"); }

            streamBody = GetTmpStreamBody();
            if (streamBody == null)
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSyn, "请选择合同模板", 1000);
                return;
            }

            LoadStreamBody();

        }

        private void LoadStreamBody()
        {
            //using (DocX document = DocX.Load(streamBody))
            //{
            //    string filename = System.IO.Path.Combine("Report", "tmp.docx");
            //    document.SaveAs(filename);
            //    this.mRichEditSimple1.LoadDocument(filename);
            //}

            Doc.DocBuilder.LoadCtrViewDoc(this.mRichEditOnly1, streamBody);
        }

        public override void SetDataSource(object dataSource)
        {
            streamBody = dataSource as MemoryStream;
            if (streamBody == null) { throw new Exception("dataSource is null"); }
            LoadStreamBody();
        }

        public void SynStreamBody()
        {
            BtnSyn_Click(null, EventArgs.Empty);
        }

        public void ResetText()
        {
            this.mRichEditOnly1.ResetText();
        }

    }
}
