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
    public partial class UCBackOrder : GaoShan.Sales.UI.UC.UCBase
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        public UCBackOrder()
        {
            InitializeComponent();
        }

        public override void Clear()
        {
            this.selectValue = null;
            this.dataSource = null;
            this.reoGridLink.Reset();
            this.mDataGridItem.Clear();
            this.mDataGridNvl.Clear();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);

            List<Info_link_bill> list = dataSource as List<Info_link_bill>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Info_link_bill>(list);

            //LoadOutItem();

        }

        protected override void LazyInit()
        {
            this.mDataGridNvl.CurrentRowChanged += new EventHandler(mDataGridNvl_CurrentRowChanged);
            this.txtOrderNo.TextChanged += TxtOrderNo_TextChanged;
        }

        private void mDataGridNvl_CurrentRowChanged(object sender, EventArgs e)
        {
            this.mDataGridItem.Clear();
            if (this.mDataGridNvl.CurrentRow == null) { return; }
            Info_link_bill info = mDataGridNvl.GetCurrentEntity() as Info_link_bill;

            Sales.UI.Report.FmLinkBillManagerReport report = new Sales.UI.Report.FmLinkBillManagerReport();

            //report.GridControl = this.reoGridLink;
            report.Show(info, this.reoGridLink);

            List<Info_store_out_item> items=manager.QueryOutItems(info.LinkBill_Id);
            mDataGridItem.SetDataSource<Info_store_out_item>(items);

            this.DoSelectValueEvent(info);
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





    }
}
