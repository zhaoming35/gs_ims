using Miles.Framework.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Quote.UI
{
    public partial class FmProductQuote : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.XlsDocManager manager = new Logic.XlsDocManager();

        protected override void InitToolBtn()
        {
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToXLS, "导出");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }
        public FmProductQuote()
        {
            InitializeComponent();
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.ExportToXLS)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = @"Excel文件|*.xlsx";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.reoGridControl1.Save(sfd.FileName);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBox_SelectedValueChanged(null, EventArgs.Empty);
        }

        protected override void LazyInit()
        {
            LoadContractType();
        }

        private void LoadContractType()
        {
            List<Model.Info_xls_doc> list = manager.FindAllTmp();
      
            this.cmbBillType.ComboBox.DataSource = list;
            this.cmbBillType.ComboBox.DisplayMember = Model.Info_xls_doc.Table.Tmp_Name;
            this.cmbBillType.ComboBox.ValueMember = Model.Info_xls_doc.Table.Tmp_Id;
            this.cmbBillType.ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);
            this.cmbBillType.ComboBox.SelectedIndex = 0;
        }

        void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            //long tmpId = (long)cmbBillType.ComboBox.SelectedValue;
           Model.Info_xls_doc info = cmbBillType.ComboBox.SelectedItem as Model.Info_xls_doc;
            if (info == null) { return; }

            this.reoGridControl1.Reset();
            this.reoGridControl1.Load(new MemoryStream(info.Tmp_Body), unvell.ReoGrid.IO.FileFormat.Excel2007);
            // set entire worksheet read-only
            //this.reoGridControl1.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, true);
            List<string> inputColList = new List<string>();
            string[] inputCols = info.Input_Cols.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (inputCols != null)
            {
                foreach (var v in inputCols)
                {
                    string name = v.Substring(0, v.IndexOf("."));
                    string rows = v.Substring(v.IndexOf(".") + 1);
                    string begingRow = rows.Substring(0, rows.IndexOf(":"));
                    string endRow = rows.Substring(rows.IndexOf(":") + 1);
                    int bRow = int.Parse(begingRow);
                    int eRow = int.Parse(endRow);
                    for (int i = bRow; i <= eRow; i++)
                    {
                        string columnName = name + i;
                        inputColList.Add(columnName);
                    }
                }

                for (int col = 0; col < info.Column_Count; col++)
                {
                    for (int row = 0; row < info.Row_Count; row++)
                    {
                        string columnName = unvell.ReoGrid.RGUtility.ToAddress(row, col, true);
                        bool isReadOnly = true;
                        if (inputColList.Contains(columnName))
                        {
                            isReadOnly = false;
                        }

                        this.reoGridControl1.CurrentWorksheet.Cells[row, col].IsReadOnly = isReadOnly;

                    }

                }






            }
        }


    }
}
