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

namespace GaoShan.Sales.UI.Win
{
    public partial class FmReoGridShow : Miles.Framework.UI.Forms.FmMdi
    {
        public FmReoGridShow()
        {
            InitializeComponent();
        }

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToXLS, "导出");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        Miles.ReoGrid.ReportTemplateBind reportBindShow = null;
        object dataSource = null;
        public void SetReportBind(Miles.ReoGrid.ReportTemplateBind reportBindShow,object dataSource)
        {
            this.dataSource = dataSource;
            this.reportBindShow = reportBindShow;
            //this.reportBindShow.GridControl = this.reoGridControl1;
            this.reportBindShow.Show(this.dataSource, this.reoGridControl1);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.ExportToXLS)
            {
                if (this.reportBindShow == null) { return; }
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = @"Excel文件|*.xlsx";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.reoGridControl1.Save(sfd.FileName);
                }
            }
        }

        protected override void Print(ToolStripButton sender)
        {
            if (this.reportBindShow == null) { return; }

            reportBindShow.Print(this.dataSource);
        }

        protected override void PrintPreview(ToolStripButton sender)
        {
            if (this.reportBindShow == null) { return; }

            reportBindShow.PrintPreview(this.dataSource);
        }

        protected override void PrintDialog(ToolStripButton sender)
        {
            if (this.reportBindShow == null) { return; }

            sender.Tag = reportBindShow.ReportName;
            base.PrintDialog(sender);
        }

    }
}
