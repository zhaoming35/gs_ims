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

namespace GaoShan.Sales.UI.Carriage
{
    public partial class UCCarriageList : UCBase
    {
        public UCCarriageList()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.mDataGridNvl.CurrentRowChanged += new EventHandler(mDataGridNvl_CurrentRowChanged);
            this.txtSearchCode.TextChanged += new EventHandler(txtSearch_TextChanged);
            this.mDataGridNvl.CellClick += new DataGridViewCellEventHandler(mDataGridNvl_CellClick);
        }

        void mDataGridNvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mDataGridNvl_CurrentRowChanged(sender, e);
        }

        public void UpdateCurrentValue(Model.Info_carriage_bill info)
        {
            this.mDataGridNvl.EditCurrentItem<Model.Info_carriage_bill>(info);
        }

        void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null) { return; }

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchCode.Text))
            {
                mDataGridNvl.SetFilter<Model.Info_carriage_bill>(null);
            }
            else
            {
                mDataGridNvl.SetFilter<Model.Info_carriage_bill>(delegate (Model.Info_carriage_bill p)
                {
                    if (!p.Odr_No.Contains(txtSearchCode.Text))
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

            Model.Info_carriage_bill info = mDataGridNvl.GetCurrentEntity() as Model.Info_carriage_bill;
            this.DoSelectValueEvent(info);
        }

        public override void SetDataSource(object dataSource)
        {
            base.SetDataSource(dataSource);

            this.mDataGridNvl.Clear();

            List<Model.Info_carriage_bill> list = dataSource as List<Model.Info_carriage_bill>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Model.Info_carriage_bill>(list);
        }

        public override void Clear()
        {
            this.selectValue = null;
            this.dataSource = null;
            this.mDataGridNvl.Clear();
        }
    }
}
