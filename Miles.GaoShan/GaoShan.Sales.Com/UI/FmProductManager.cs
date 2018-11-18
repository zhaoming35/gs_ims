using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Com.UI
{
    public partial class FmProductManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.ProductManager productManager = new Logic.ProductManager();
        Logic.ProductPropertyManager productPropertyManager = new Logic.ProductPropertyManager();

        public FmProductManager()
        {
            InitializeComponent();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.mDataGrid1.CurrentRowChanged += MDataGrid1_CurrentRowChanged;
            this.btnDeletePro.Click += BtnDeletePro_Click;
            this.btnEditPro.Click += BtnEditPro_Click;
            this.btnAddPro.Click += BtnAddPro_Click;
        }

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        private void BtnAddPro_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            Model.Tb_product_info info = mDataGrid1.GetCurrentEntity() as Model.Tb_product_info;
            if (info == null) { return; }

            FmProductPropertyInfo fm = new FmProductPropertyInfo();
            fm.lblProductName.Text = info.Product_Name;
            fm.Tag = info.Product_Id;
            fm.SelectValue += FmProperty_SelectValue;
            fm.ShowDialog();
        }

        private void FmProperty_SelectValue(object obj)
        {
            MDataGrid1_CurrentRowChanged(null,null);
        }

        private void BtnEditPro_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            Model.Tb_product_info productInfo = mDataGrid1.GetCurrentEntity() as Model.Tb_product_info;
            if (productInfo == null) { return; }

            if (mDataGrid2.DataSource == null) { return; }

            Model.Tb_product_property info = mDataGrid2.GetCurrentEntity() as Model.Tb_product_property;

            FmProductPropertyInfo fm = new FmProductPropertyInfo(info);
            fm.lblProductName.Text = productInfo.Product_Name;
            fm.Tag = productInfo.Product_Id;
            fm.SelectValue += FmProperty_SelectValue;
            fm.ShowDialog();
        }

        private void BtnDeletePro_Click(object sender, EventArgs e)
        {
            if (mDataGrid2.DataSource == null) { return; }

            Model.Tb_product_property info = mDataGrid2.GetCurrentEntity() as Model.Tb_product_property;

            string msg = string.Format("确定删除:{0}信息?", info.Property_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (productPropertyManager.Remove(info))
                {
                    MDataGrid1_CurrentRowChanged(null, null);
                }
            }
        }

        private void MDataGrid1_CurrentRowChanged(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            Model.Tb_product_info info = mDataGrid1.GetCurrentEntity() as Model.Tb_product_info;
            if (info == null) { return; }
            List<Model.Tb_product_property> list= productPropertyManager.FindAll(info.Product_Id);
            mDataGrid2.SetDataSource<Model.Tb_product_property>(list);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            Model.Tb_product_info info = mDataGrid1.GetCurrentEntity() as Model.Tb_product_info;

            string msg = string.Format("确定删除:{0}信息?", info.Product_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (productManager.Remove(info))
                {
                    LoadAllProductData();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            Model.Tb_product_info info = mDataGrid1.GetCurrentEntity() as Model.Tb_product_info;

            FmProductInfo fm = new FmProductInfo(info);
            fm.SelectValue += Fm_SelectValue;
            fm.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmProductInfo fm = new FmProductInfo();
            fm.SelectValue += Fm_SelectValue;
            fm.ShowDialog();
        }

        private void Fm_SelectValue(object obj)
        {
            LoadAllProductData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAllProductData();
        }

        private void LoadAllProductData()
        {
            List<Model.Tb_product_info> list = productManager.FindAll();
            mDataGrid1.SetDataSource<Model.Tb_product_info>(list);
        }
    }
}
