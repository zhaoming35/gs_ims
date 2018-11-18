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
    public partial class UCOutOrderList : GaoShan.Sales.UI.UC.UCBase
    {
        public UCOutOrderList()
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

        public void UpdateCurrentValue(Model.Info_store_out info)
        {
            this.mDataGridNvl.EditCurrentItem<Model.Info_store_out>(info);
        }

        void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null) { return; }

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchCode.Text))
            {
                mDataGridNvl.SetFilter<Model.Info_store_out>(null);
            }
            else
            {
                mDataGridNvl.SetFilter<Model.Info_store_out>(delegate (Model.Info_store_out p)
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

            Model.Info_store_out info = mDataGridNvl.GetCurrentEntity() as Model.Info_store_out;
            this.DoSelectValueEvent(info);
        }

        public override void SetDataSource(object dataSource)
        {
            base.SetDataSource(dataSource);

            this.mDataGridNvl.Clear();

            List<Model.Info_store_out> list = dataSource as List<Model.Info_store_out>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Model.Info_store_out>(list);
        }

        public override void Clear()
        {
            this.selectValue = null;
            this.dataSource = null;
            this.mDataGridNvl.Clear();
        }


    }
}
