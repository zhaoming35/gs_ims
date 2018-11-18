using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;

namespace GaoShan.Sales.Template.UI
{
    public partial class UCTmpList : UCBase
    {
        public int OrderType 
        {
            get { return (int)d_OrderType.ComboBox.SelectedValue;}
        }

        Logic.TmpManager tmpManager = new Logic.TmpManager();

        public UCTmpList()
        {
            InitializeComponent();
            this.mDataGridNvl.CurrentRowChanged += new EventHandler(mDataGridNvl_CurrentRowChanged);
            this.txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            this.mDataGridNvl.CellClick += new DataGridViewCellEventHandler(mDataGridNvl_CellClick);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnEdit.Click += new EventHandler(btnEdit_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
     
        }

        protected override void LazyInit()
        {
            LoadOrderType();
        }

        private void LoadOrderType()
        {
            System.Data.DataTable dt = Enum.EnumSet.GetOrderTypeSet(true);

            d_OrderType.ComboBox.DataSource = dt;
            d_OrderType.ComboBox.DisplayMember = dt.Columns[1].ColumnName;
            d_OrderType.ComboBox.ValueMember = dt.Columns[0].ColumnName;
            //d_OrderType.ComboBox.SelectedIndex = 0;
            d_OrderType.ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);
        }

        void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null) { return; }

            txtSearch_TextChanged(sender, e);

        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp;
            if (Miles.Framework.UI.Function.Dialog.ShowWarningYesNo("确定要删除：" + info.Tmp_Name + "信息?"))
            {
                if (tmpManager.Remove(info))
                {
                    mDataGridNvl.DeleteCurrentItem<Model.Info_tmp>();
                }
            }
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGridNvl.CurrentRow == null) { return; }
            Model.Info_tmp info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp;
            //int id = (int)d_OrderType.ComboBox.SelectedValue;
            FmTmpInfo fm = new FmTmpInfo(info);
            //fm.SetOrderType(id);
            fm.SelectValue += new Miles.Framework.UI.Forms.FmCustomInfo.SelectValueHandler(fmEdit_SelectValue);
            fm.ShowDialog();
        }

        void fmEdit_SelectValue(object obj)
        {
            Model.Info_tmp info = obj as Model.Info_tmp;
            mDataGridNvl.EditCurrentItem<Model.Info_tmp>(info);
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            int id = (int)d_OrderType.ComboBox.SelectedValue;
            FmTmpInfo fm = new FmTmpInfo();
            //fm.SetOrderType(id);
            fm.SelectValue += new Miles.Framework.UI.Forms.FmCustomInfo.SelectValueHandler(fmAdd_SelectValue);
            fm.ShowDialog();
        }

        void fmAdd_SelectValue(object obj)
        {
            Model.Info_tmp info = obj as Model.Info_tmp;
            mDataGridNvl.AddItem<Model.Info_tmp>(info);
        }

        void mDataGridNvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mDataGridNvl_CurrentRowChanged(sender, e);
        }

        void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mDataGridNvl.DataSource == null|| d_OrderType.ComboBox.SelectedValue==null) { return; }
            int orderType = (int)d_OrderType.ComboBox.SelectedValue; 
            List<Model.Info_tmp> list = dataSource as List<Model.Info_tmp>;

            if (!Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearch.Text))
            {
                mDataGridNvl.SetFilter<Model.Info_tmp>(delegate(Model.Info_tmp p)
                {
                    if (orderType != -1 && p.Order_Type != orderType)
                    {
                        return false;
                    }

                    return  (p.Tmp_Name.Contains(txtSearch.Text) || p.Tmp_Explain.Contains(txtSearch.Text));
                });
            }
            else
            {
                mDataGridNvl.SetFilter<Model.Info_tmp>(delegate (Model.Info_tmp p) { return p.Order_Type == orderType || orderType == -1; });
            }
        }

        void mDataGridNvl_CurrentRowChanged(object sender, EventArgs e)
        {
            if (this.mDataGridNvl.CurrentRow == null) { this.DoSelectValueEvent(null); return; }

            Model.Info_tmp info = mDataGridNvl.GetCurrentEntity() as Model.Info_tmp;
            this.DoSelectValueEvent(info);
        }

        public override void SetDataSource(object dataSource)
        {
            base.SetDataSource(dataSource);

            this.mDataGridNvl.Clear();

            List<Model.Info_tmp> list = dataSource as List<Model.Info_tmp>;

            if (list != null)
                this.mDataGridNvl.SetDataSource<Model.Info_tmp>(list);

            ComboBox_SelectedValueChanged(null, null);
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





    }
}
