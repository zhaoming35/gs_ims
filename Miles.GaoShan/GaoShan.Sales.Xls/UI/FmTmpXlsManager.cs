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

namespace GaoShan.Sales.Xls.UI
{
    public partial class FmTmpXlsManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.TmpXlsManager manager = new Logic.TmpXlsManager();

        public FmTmpXlsManager()
        {
            InitializeComponent();
        }

        protected override void InitToolBtn()
        {

            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改订单");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        private void LoadPrintSetting()
        {
            PageSettings ps = Miles.Coro.Common.Print.PrintConfigManager.GetPageSettings(this.GetType().FullName);
            if (ps != null)
            {
                this.reoGridControl1.CurrentWorksheet.PrintSettings.ApplySystemPageSettings(ps);
                this.reoGridControl1.CurrentWorksheet.ClearAllPageBreaks();
            }

        }

        protected override void PrintPreview(ToolStripButton sender)
        {
            LoadPrintSetting();

            this.reoGridControl1.CurrentWorksheet.ResetAllPageBreaks();

            this.reoGridControl1.CurrentWorksheet.PrintableRange = new unvell.ReoGrid.RangePosition(0, 0, this.reoGridControl1.CurrentWorksheet.RowCount, this.reoGridControl1.CurrentWorksheet.ColumnCount);

            using (var session = this.reoGridControl1.CurrentWorksheet.CreatePrintSession())
            {

                using (System.Drawing.Printing.PrintDocument doc = session.PrintDocument)
                {
                    PageSettings ps = Miles.Coro.Common.Print.PrintConfigManager.GetPageSettings(this.GetType().FullName);
                    doc.DefaultPageSettings = ps;
                    doc.PrinterSettings.PrinterName = ps.PrinterSettings.PrinterName;
                    //打印预览
                    using (PrintPreviewDialog ppd = new PrintPreviewDialog())
                    {
                        ppd.StartPosition = FormStartPosition.CenterScreen;
                        ppd.WindowState = FormWindowState.Maximized;
                        ppd.SetBounds(0, 0, 1024, 768);
                        ppd.Document = doc;
                        ppd.PrintPreviewControl.Zoom = 1.5d;
                        ppd.ShowDialog();
                    }
                }

            }
        }

        protected override void PrintDialog(ToolStripButton sender)
        {
            base.PrintDialog(sender);
            //public bool SetPageSetting(PageSettings ps)
            //{
            //    this.reoGridControl1.CurrentWorksheet.PrintSettings.ApplySystemPageSettings(ps);
            //    this.reoGridControl1.CurrentWorksheet.ClearAllPageBreaks();
            //    return Miles.Coro.Common.Print.PrintConfigManager.SavePageSetting(reportName, ps);
            //}
        }

        protected override void LazyInit()
        {
            LoadAllTmp();
            this.mDataGridNvl.CurrentRowChanged += MDataGridNvl_CurrentRowChanged;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnImport.Click += BtnImport_Click;
            this.btnOther.Click += BtnOther_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnBind.Click += BtnBind_Click;
            this.btnExport.Click += BtnExport_Click;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = @"Excel文件|*.xlsx";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.reoGridControl1.Save(sfd.FileName);
            }
        }

        private void BtnBind_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;
            FmMapXlsManager fmMapXlsManager = new FmMapXlsManager();
            fmMapXlsManager.Tag = info;
            fmMapXlsManager.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;

            using (MemoryStream stream = new MemoryStream())
            {
                reoGridControl1.Save(stream, unvell.ReoGrid.IO.FileFormat.Excel2007);
                info.Tmp_Body = stream.ToArray();
            }


            List<Model.Tb_tmp_xls_var> vars = new List<Model.Tb_tmp_xls_var>();

            int rowCount = (int)info.Row_Count;
            int colCount = (int)info.Column_Count;
            List<unvell.ReoGrid.Cell> cellsTmp = Miles.ReoGrid.ReportTemplateBind.GetRangeMergedCells(this.reoGridControl1.CurrentWorksheet, 0, 0, rowCount, colCount);
            foreach (unvell.ReoGrid.Cell cell in cellsTmp)
            {
                string str = GaoShan.Sales.UI.Report.ReportTemplateBase.FindVarString(cell.DisplayText);
                if (str != null)
                {
                    Model.Tb_tmp_xls_var v = new Model.Tb_tmp_xls_var();
                    //v.Var_Id= Miles.Coro.Common.Utils.GuidToInt64();
                    v.Tmp_Id = info.Tmp_Id;
                    v.Var_Text = str;
                    vars.Add(v);
                }
            }

            info.Vars = vars;

            if (manager.SaveBodyAndVars(info))
            {
                LoadAllTmp();
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSave, "保存成功");
            }
        }

        private void BtnOther_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;

            FmTmpXlsInfo fmTmpXlsInfo = new FmTmpXlsInfo(info);
            fmTmpXlsInfo.SelectValue += (obj) =>
            {
                LoadAllTmp();
            };
            fmTmpXlsInfo.ShowDialog();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;

            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = @"模板文件|*.xlsx";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.reoGridControl1.Reset();
                reoGridControl1.Load(dialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                reoGridControl1.CurrentWorksheet.RowCount = (int)info.Row_Count;
                reoGridControl1.CurrentWorksheet.ColumnCount = (int)info.Column_Count;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmTmpXlsInfo fmTmpXlsInfo = new FmTmpXlsInfo();
            fmTmpXlsInfo.SelectValue += (obj) =>
            {
                LoadAllTmp();
            };
            fmTmpXlsInfo.ShowDialog();
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;

            FmTmpXlsInfo fmTmpXlsInfo = new FmTmpXlsInfo(info);
            fmTmpXlsInfo.SelectValue += (obj) =>
            {
                LoadAllTmp();
            };
            fmTmpXlsInfo.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;

            string msg = string.Format("确定删除:{0}信息?", info.Tmp_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    LoadAllTmp();
                }
            }
        }

        private void MDataGridNvl_CurrentRowChanged(object sender, EventArgs e)
        {
            reoGridControl1.Reset();

            Model.Info_tmp_xls info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp_xls;
            if (info == null)
            {
                return;
            }

            //if (info.Tmp_Body == null)
            //{
            //    info.Tmp_Body = manager.GetTheTmpBody(info.Tmp_Id);
            //}

            if (info.Tmp_Body != null)
            {
                reoGridControl1.Load(new MemoryStream(info.Tmp_Body), unvell.ReoGrid.IO.FileFormat.Excel2007);
                reoGridControl1.CurrentWorksheet.RowCount = (int)info.Row_Count;
                reoGridControl1.CurrentWorksheet.ColumnCount = (int)info.Column_Count;
            }
        }

        private void LoadAllTmp()
        {
            List<Model.Info_tmp_xls> list = manager.FindAllTmp();
            mDataGridNvl.SetDataSource<Model.Info_tmp_xls>(list);
        }



    }
}
