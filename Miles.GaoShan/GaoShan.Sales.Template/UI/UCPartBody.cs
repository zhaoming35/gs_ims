using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Xceed.Words.NET;
using GaoShan.Sales.UI.UC;

namespace GaoShan.Sales.Template.UI
{
    public partial class UCPartBody : UCBase
    {
        Logic.TmpManager tmpManager = new Logic.TmpManager();


        public UCPartBody()
        {
            InitializeComponent();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnSave.Click += new EventHandler(btnSave_Click);
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

        MemoryStream streamBody = null;
        private void BtnAdd_Click(object sender, EventArgs e)
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
                //    this.richEditControl1.LoadDocument(filename);
                //}
            }
        }


        void btnSave_Click(object sender, EventArgs e)
        {
            Model.Tb_tmp_part info = dataSource as Model.Tb_tmp_part;

            if (streamBody==null||streamBody.Length < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mRichEditOnly1, "文本不能为空", 1000);
                return;
            }

            info.Part_File = streamBody.ToArray();

            if (!tmpManager.SavePartBody(info))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.btnSave.Owner, "保存失败", 500, Miles.Framework.UI.Function.MForm.ToolTipSite.FollowMouse);

                return;
            }

            Miles.Framework.UI.Function.MForm.SetToolTip(this.btnSave.Owner, "保存成功", 500, Miles.Framework.UI.Function.MForm.ToolTipSite.FollowMouse);
            this.DoSelectValueEvent(info);
        }

        public override void Clear()
        {
            this.mRichEditOnly1.ResetText();
        }

        public override void SetDataSource(object dataSource)
        {
            base.SetDataSource(dataSource);

            this.selectValue = dataSource;
            this.mRichEditOnly1.ResetText();
            Model.Tb_tmp_part info = dataSource as Model.Tb_tmp_part;

            if (info == null) { return; }

            if (info.Part_File != null)
            {
                streamBody = Doc.DocBuilder.LoadCtrViewDoc(this.mRichEditOnly1, new MemoryStream(info.Part_File));
                //streamBody = new MemoryStream(info.Part_File);
                //using (DocX document = DocX.Load(streamBody))
                //{
                //    string filename = System.IO.Path.Combine("Report", "tmp.docx");
                //    document.SaveAs(filename);
                //    this.richEditControl1.LoadDocument(filename);
                //}

          
            }
            else
            {
                string filename = System.IO.Path.Combine("Report", "init.docx");
                if (File.Exists(filename))
                {
                    this.mRichEditOnly1.LoadDocument(filename);
                }



                //using (DocX document = DocX.Create(filename))
                //{

                //    Miles.Coro.Common.Print.PrintPageInfo pageInfo = Miles.Coro.Common.Print.PrintConfigManager.GetPrintPageInfo(this.ReportName);

                //    //按照设定好的页面大小来配置，可以做一个模板，读取
                //    document.PageWidth = Miles.Coro.Common.Print.PrintHelper.FromInchToPt(pageInfo.PageWidth);
                //    document.PageHeight = Miles.Coro.Common.Print.PrintHelper.FromInchToPt(pageInfo.PageHeight);

                //    document.PageLayout.Orientation =pageInfo.Landscape? Xceed.Words.NET.Orientation.Landscape:Xceed.Words.NET.Orientation.Portrait;

                //    // Set the document margins.
                //    document.MarginLeft = Miles.Coro.Common.Print.PrintHelper.FromInchToPt(pageInfo.MarginLeft);
                //    document.MarginRight = Miles.Coro.Common.Print.PrintHelper.FromInchToPt(pageInfo.MarginRight);
                //    document.MarginTop = Miles.Coro.Common.Print.PrintHelper.FromInchToPt(pageInfo.MarginTop);
                //    document.MarginBottom = Miles.Coro.Common.Print.PrintHelper.FromInchToPt(pageInfo.MarginBottom);

                //    document.Save();
                //}

                //using (var ms = new MemoryStream())
                //{
                //    using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                //    {
                //        var data = new byte[fs.Length];
                //        fs.Read(data, 0, (int)fs.Length);
                //        ms.Write(data, 0, (int)fs.Length);
                //    }
                //    ms.Seek(0, SeekOrigin.Begin);

                //    this.richEditControl1.LoadDocument(ms, DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
                //}
            }

        }

    }
}
