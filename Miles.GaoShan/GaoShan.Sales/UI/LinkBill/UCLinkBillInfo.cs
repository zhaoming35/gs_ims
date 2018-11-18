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
using GaoShan.Sales.Model;
using unvell.ReoGrid;
using Newtonsoft.Json;

namespace GaoShan.Sales.UI.LinkBill
{
    public partial class UCLinkBillInfo : UCBase
    {
        Logic.LinkBillManager manager = new Logic.LinkBillManager();
        Miles.ReoGrid.ReportTemplate reportTmpBillInfo = new Miles.ReoGrid.ReportTemplate();
        Miles.ReoGrid.ReportTemplate reportTmpItem = new Miles.ReoGrid.ReportTemplate();

        public UCLinkBillInfo()
        {
            InitializeComponent();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.reoGridControl1.CurrentWorksheet.SelectionMode = unvell.ReoGrid.WorksheetSelectionMode.Cell;
        }

        List<Info_link_bill_tent> GetItems()
        {
            List<Info_link_bill_tent> items = new List<Info_link_bill_tent>();
            for (int row=2;row< reportTmpBillInfo.Sheet.RowCount;)
            {
                unvell.ReoGrid.Cell cell = reportTmpBillInfo.Sheet.Cells[row, 0];
                Info_link_bill_tent item = cell.Tag as Info_link_bill_tent;
                if (item != null)
                {
                    items.Add(item);
                }

                row += 17;
            }

            return items;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            RangePosition pos = this.reoGridControl1.CurrentWorksheet.SelectionRange;
            unvell.ReoGrid.Cell cell = reportTmpBillInfo.Sheet.Cells[pos.Row, pos.Col];
            Info_link_bill_tent item = cell.Tag as Info_link_bill_tent;
            if (item == null) { return; }
            if (this.GetItems().Count > 1)
            {
                reportTmpBillInfo.Sheet.DeleteRows(cell.Row, 17);
            }
            else
            {
                SetItemCellValue(new Info_link_bill_tent(), 2,true);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            RangePosition pos = this.reoGridControl1.CurrentWorksheet.SelectionRange;
            unvell.ReoGrid.Cell cell = this.reoGridControl1.CurrentWorksheet.Cells[pos.Row, pos.Col];
            Info_link_bill_tent item= cell.Tag as Info_link_bill_tent;
            if (item == null) { return; }
            FmLinkBillInfo fmLinkBill = new FmLinkBillInfo(item);
            fmLinkBill.SelectValue += (obj) =>
            {
                Info_link_bill_tent info = obj as Info_link_bill_tent;
                int rowOffset = pos.Row;

                SetItemCellValue(info, rowOffset);
            };
            fmLinkBill.ShowDialog();
        }

        public override bool Save(ToolStripButton sender)
        {
            Dictionary<Control, string> dicEmptyCtrs = this.GetValidEmptyCtrs();
            if (dicEmptyCtrs.Count > 0)
            {
                foreach (var ctr in dicEmptyCtrs.Keys)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(ctr, dicEmptyCtrs[ctr], 1000);
                    return false;
                }
            }

            if (this.GetItems().Count < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.reoGridControl1, "产品列表不能为空", 1000);
                return false;
            }

            Model.Info_link_bill info = this.GetDataBind<Model.Info_link_bill>();

            Model.Info_link_bill updateNew = this.selectValue as Model.Info_link_bill;

            updateNew.LinkBill_Name = info.LinkBill_Name;
            updateNew.Project_Man = info.Project_Man;
            updateNew.Duty_Info = info.Duty_Info;
            updateNew.Supplier_Floor = info.Supplier_Floor;
            updateNew.Supplier_Carpet = info.Supplier_Carpet;
            updateNew.Is_put_tool = info.Is_put_tool;
            updateNew.Special_info = info.Special_info;
            updateNew.Provide_Info = info.Provide_Info;
            updateNew.Build_Way = info.Build_Way;

            if (updateNew.Odr_Type == 1)
            {
                updateNew.Let_Bud_EDate = info.Let_Bud_EDate;
                updateNew.Let_Bud_SDate = info.Let_Bud_SDate;
            }

            updateNew.Items =  GetItems();

            return manager.SaveLinkBillAll(updateNew);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmLinkBillInfo fmLinkBill = new FmLinkBillInfo();
            fmLinkBill.SelectValue += (obj) =>
            {
                Info_link_bill_tent info = obj as Info_link_bill_tent;
                int rowOffset = 2;// this.reoGridControl1.CurrentWorksheet.RowCount;
                InsertBillItem(rowOffset);

                SetItemCellValue(info, rowOffset);
            };
            fmLinkBill.ShowDialog();
        }

        protected override void LazyInit()
        {
            d_ProvideInfo.LoadData("lld_Provide_Info");
            cmbBuildWay1.LoadData();
            InitTmpBillItem();
        }

        private void InitTmpBillItem()
        {
            reportTmpItem.DefineInit = (report) =>
            {
                Stream streamItem = Miles.Coro.Common.Utils.GetClassPathStream(this.GetType(), "GaoShan.Sales.UI.LinkBill.LinkBillItem.xlsx");

                report.TemplateStream = streamItem;
                report.InitColumnCount = 7;
                report.InitRowCount = 17;
            };

            reportTmpItem.DefineBeforeFormatGrid = (report, reoGrid) =>
            {
                // hide sheet tab control
                reoGrid.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, false);

                // hide row header and column header
                reoGrid.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.View_ShowHeaders, false);

                // set entire worksheet read-only
                reoGrid.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, true);

            };

            reportTmpItem.Bind(null, null);
        }

        public override void SetTabControls(Miles.Framework.UI.Forms.TabControlSeq tabControlSeq)
        {
            this.tabControlSeq.AddContainer(this.groupBox1);
        }

        public override void Clear()
        {
            base.Clear();
            InitTmpBillInfo();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);
            base.selectValue = dataSource;
            if (dataSource == null) { return; }

            Model.Info_link_bill info = dataSource as Model.Info_link_bill;
            this.Tag = info.LinkBill_Id;
            this.SetDataBind(dataSource);

            if (info.Odr_Type == 1)
            {
                label40.Visible = true;
                d_letBudSDate.Visible = true;
                label39.Visible = true;
                d_letBudEDate.Visible = true;
            }
            else
            {
                label40.Visible = false;
                d_letBudSDate.Visible = false;
                label39.Visible = false;
                d_letBudEDate.Visible = false;
            }

            //商品列表添加
            for (int i = 0; i < info.Items.Count; i++)
            {
                int rowOffset = 2;// + i * 17;
                Model.Info_link_bill_tent item = info.Items[i];
                if (i > 0)
                {
                    InsertBillItem(rowOffset);
                }

                SetItemCellValue(item, rowOffset);
            }

        }

        private void InitTmpBillInfo()
        {

            reportTmpBillInfo.DefineInit = (report) => 
            {
                Stream stream = Miles.Coro.Common.Utils.GetClassPathStream(this.GetType(), "GaoShan.Sales.UI.LinkBill.LinkBillHead.xlsx");

                //reportTmpBillInfo.Load(stream, 19, 7, this.reoGridControl1);
                report.TemplateStream = stream;
                report.InitRowCount = 19;
                report.InitColumnCount = 7;

            };

            reportTmpBillInfo.DefineAfterFormatGrid = (report,reoGrid) => 
            {
                reoGrid.CurrentWorksheet.FreezeToCell(2, 0, unvell.ReoGrid.FreezeArea.Top);

                report.SetGridBorderLine();
                report.AutoFitAllColumnWidth();
                report.AutoFitAllRowHeight();
            };


            reportTmpBillInfo.Bind(null, this.reoGridControl1);
        }

        private void SetItemCellValue(Info_link_bill_tent item, int rowOffset, bool isEmpty = false)
        {
            List<unvell.ReoGrid.Cell> cellsTmp = reportTmpItem.GetAllMergedCells();

            foreach (var v in cellsTmp)
            {
                int realRow = v.Row + rowOffset;
                string varText = Report.ReportTemplateBase.FindVarString(v.DisplayText);
                if (varText != null)
                {
                    if (isEmpty)
                    {
                        Cell cell = reportTmpBillInfo.Sheet.Cells[realRow, v.Column];
                        cell.Data = "";
                    }
                    else
                    {
                        Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;
                        string dataField = varText.Substring(2, varText.Length - 3);
                        object value = memberAccessor.GetValue(item, dataField);
                        if (value != null)
                        {
                            Cell cell = reportTmpBillInfo.Sheet.Cells[realRow, v.Column];
                            Miles.ReoGrid.ReportTemplate.SetCellValue(cell, value, item);
                        }
                    }
                }
                else
                {
                    Cell cell = reportTmpBillInfo.Sheet.Cells[realRow, v.Column];
                    cell.Data = v.Data;// value;
                }
            }

            if (!isEmpty)
            {
                reportTmpBillInfo.AutoFitAllColumnWidth();
                reportTmpBillInfo.AutoFitAllRowHeight();
            }

            reportTmpBillInfo.SetGridBorderLine();
        }

        private void InsertBillItem(int rowOffset)
        {
            List<unvell.ReoGrid.Cell> cellsTmp = reportTmpItem.GetAllMergedCells();
   
            reportTmpBillInfo.Sheet.InsertRows(rowOffset, 17);

            Miles.ReoGrid.ReportTemplate.SetItemGroupMergedCell(reportTmpBillInfo.Sheet, rowOffset, 0, cellsTmp);
        }
    }
}
