using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.Store.UI.UC
{
    public partial class UCOutOrder : GaoShan.Sales.UI.UC.UCBase
    {
        GaoShan.Sales.Logic.MatchTbManager matchTbManager = new Sales.Logic.MatchTbManager();

        public UCOutOrder()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.mDataGridNvl.CurrentRowChanged += new EventHandler(mDataGridNvl_CurrentRowChanged);
            this.mDataGridMatchTb.CurrentRowChanged += MDataGridMatchTb_CurrentRowChanged;
            this.txtOrderNo.TextChanged += TxtOrderNo_TextChanged;
        }

        private void TxtOrderNo_TextChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null) { return; }

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtOrderNo.Text))
            {
                mDataGridNvl.SetFilter<Model.Info_link_bill>(null);
            }
            else
            {
                mDataGridNvl.SetFilter<Model.Info_link_bill>(delegate (Model.Info_link_bill p)
                {

                    if (!p.Odr_No.Contains(txtOrderNo.Text))
                    {
                        return false;
                    }

                    return true;

                });

            }
        }

        private void MDataGridMatchTb_CurrentRowChanged(object sender, EventArgs e)
        {
            if (mDataGridMatchTb.CurrentRow == null) { return; }
            GaoShan.Sales.Model.Info_matchTb info = mDataGridMatchTb.GetCurrentEntity() as GaoShan.Sales.Model.Info_matchTb;

            Sales.UI.Report.FmMatchTbManagerReport report = new Sales.UI.Report.FmMatchTbManagerReport();
            //report.GridControl = this.reoGridMatchTb;
            report.Show(info, this.reoGridMatchTb);
        }

        void mDataGridNvl_CurrentRowChanged(object sender, EventArgs e)
        {
            this.mDataGridMatchTb.Clear();
            if (this.mDataGridNvl.CurrentRow == null) { return; }

            Info_link_bill info = mDataGridNvl.GetCurrentEntity() as Info_link_bill;
            Sales.UI.Report.FmLinkBillManagerReport report = new Sales.UI.Report.FmLinkBillManagerReport();

            //report.GridControl = this.reoGridLink;
            report.Show(info, this.reoGridLink);

            List<GaoShan.Sales.Model.Info_matchTb> ltMatchTb = matchTbManager.FindAllLinkMatchTbs(info.LinkBill_Id);
            mDataGridMatchTb.SetDataSource<GaoShan.Sales.Model.Info_matchTb>(ltMatchTb);

            this.DoSelectValueEvent(info);
        }

        public override void Clear()
        {
            this.selectValue = null;
            this.dataSource = null;
            this.mDataGridMatchTb.Clear();
            this.mDataGridNvl.Clear();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);

            List<Info_link_bill> list = dataSource as List<Info_link_bill>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Info_link_bill>(list);
        }


        public void ExportLink()
        {
            if (this.mDataGridNvl.CurrentRow == null) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = @"Excel文件|*.xlsx";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.reoGridLink.Save(sfd.FileName);
                MessageBox.Show("导出完成");
            }
        }

        public void ExportMatchTb()
        {
            if (this.mDataGridMatchTb.CurrentRow == null) { return; }
            List<GaoShan.Sales.Model.Info_matchTb> ltMatchTb = mDataGridMatchTb.GetDataSource<GaoShan.Sales.Model.Info_matchTb>();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择配套表保存路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;

                foreach (GaoShan.Sales.Model.Info_matchTb info in ltMatchTb)
                {
                    Sales.UI.Report.FmMatchTbManagerReport report = new Sales.UI.Report.FmMatchTbManagerReport();

                    report.Show(info, this.reoGridMatchTb);
                    string fileName = System.IO.Path.Combine(path, info.MatchTb_Name + ".xlsx");
                    this.reoGridMatchTb.Save(fileName);
                }
                MessageBox.Show("导出完成");
            }
        }

    }
}
