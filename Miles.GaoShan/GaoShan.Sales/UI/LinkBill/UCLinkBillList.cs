using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;

namespace GaoShan.Sales.UI.LinkBill
{
    public partial class UCLinkBillList : UCBase
    {
        public UCLinkBillList()
        {
            InitializeComponent();
      
        }
        protected override void LazyInit()
        {
            LoadContractType();
            this.mDataGridNvl.CurrentRowChanged += new EventHandler(mDataGridNvl_CurrentRowChanged);
            this.txtSearchCode.TextChanged += new EventHandler(txtSearch_TextChanged);
            this.mDataGridNvl.CellClick += new DataGridViewCellEventHandler(mDataGridNvl_CellClick);
        }

        void mDataGridNvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mDataGridNvl_CurrentRowChanged(sender, e);
        }

        public void UpdateCurrentValue(Model.Info_link_bill info)
        {
            this.mDataGridNvl.EditCurrentItem<Model.Info_link_bill>(info);
        }

        void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null) { return; }

            ComboBox_SelectedValueChanged(sender, e);
        }

        void mDataGridNvl_CurrentRowChanged(object sender, EventArgs e)
        {
            if (this.mDataGridNvl.CurrentRow == null) { return; }

            Model.Info_link_bill info = mDataGridNvl.GetCurrentEntity() as Model.Info_link_bill;
            this.DoSelectValueEvent(info);
        }

        public override void SetDataSource(object dataSource)
        {
            base.SetDataSource(dataSource);

            this.mDataGridNvl.Clear();

            List<Model.Info_link_bill> list = dataSource as List<Model.Info_link_bill>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Model.Info_link_bill>(list);
        }

        public override void Clear()
        {
            this.selectValue = null;
            this.dataSource = null;
            this.mDataGridNvl.Clear();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
     
        }


        private void LoadContractType()
        {
            System.Data.DataTable dt = Enum.EnumSet.GetOrderTypeSet(true);

            this.cmbOrderType.ComboBox.DataSource = dt;
            this.cmbOrderType.ComboBox.DisplayMember = dt.Columns[1].ColumnName;
            this.cmbOrderType.ComboBox.ValueMember = dt.Columns[0].ColumnName;
            //this.cmbOrderType.ComboBox.SelectedIndex = 0;
            this.cmbOrderType.ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);

        }

        void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null) { return; }

            int orderType = (int)cmbOrderType.ComboBox.SelectedValue;

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchCode.Text))
            {
                mDataGridNvl.SetFilter<Model.Info_link_bill>(delegate (Model.Info_link_bill p) { return p.Odr_Type == orderType|| orderType==-1; });
            }
            else
            {
                mDataGridNvl.SetFilter<Model.Info_link_bill>(delegate (Model.Info_link_bill p)
                {
                    if (orderType!=-1&&p.Odr_Type!= orderType)
                    {
                        return false;
                    }

                    if (!p.Odr_No.Contains(txtSearchCode.Text))
                    {
                        return false;
                    }

                    if (!Miles.Coro.Common.StringUtils.GetFirstPinyin(p.Jia_Name).Contains(txtSearchCustomer.Text) &&
                        !p.Jia_Name.Contains(txtSearchCustomer.Text))
                    {
                        return false;
                    }

                    return true;

                });

            }
        }





    }
}
