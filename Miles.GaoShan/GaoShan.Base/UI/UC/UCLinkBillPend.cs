using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.UC
{
    public partial class UCLinkBillPend : UC.UCBase
    {
        public UCLinkBillPend()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.mDataGridNvl.CurrentRowChanged += new EventHandler(mDataGridNvl_CurrentRowChanged);
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

        void mDataGridNvl_CurrentRowChanged(object sender, EventArgs e)
        {
            if (this.mDataGridNvl.CurrentRow == null) { return; }

            Model.Info_link_bill info = mDataGridNvl.GetCurrentEntity() as Model.Info_link_bill;
            Report.FmLinkBillManagerReport report = new Report.FmLinkBillManagerReport();

            //report.GridControl = this.reoGridLink;
            report.Show(info, this.reoGridLink);

            this.DoSelectValueEvent(info);
        }

        public void Export()
        {
            if (this.mDataGridNvl.CurrentRow == null) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = @"Excel文件|*.xlsx";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.reoGridLink.Save(sfd.FileName);
            }
        }

        public override void Clear()
        {
            reoGridLink.Reset();
            this.selectValue = null;
            this.dataSource = null;
            this.mDataGridNvl.Clear();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);

            List<Model.Info_link_bill> list = dataSource as List<Model.Info_link_bill>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Model.Info_link_bill>(list);
        }
    }
}
