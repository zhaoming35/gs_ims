using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Order
{
    public partial class FmOrderItemInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.ProductPropertyManager propertyManager = new Logic.ProductPropertyManager();
        public FmOrderItemInfo()
        {
            InitializeComponent();
        }

        public FmOrderItemInfo(Model.Info_order_item info) : base(info)
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) { return; }
            cmbProductInfo1.LoadData();
            cmbProductInfo1.SelectItemEvent += CmbProductInfo1_SelectItemEvent;

            if (!blNewFlag)
            {
                this.cmbProductInfo1.Enabled = false;
                Model.Info_order_item info = this.modelObj as Model.Info_order_item;
                this.SetDataBind(this.modelObj);
                dropDownProductSpec1.SetDataSource(info.ItemSpec.Items);
            }
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lblType.Visible = false;
            d_ProductType.Visible = false;
            this.cmbProductInfo1.Focus();
        }

        private void CmbProductInfo1_SelectItemEvent(object obj)
        {
            if (obj == null) { return; }
            Model.Info_product_info info = obj as Model.Info_product_info;

            if (info.Product_Name.Equals("篷房"))
            {
                lblType.Visible = true;
                d_ProductType.Visible = true;
            }
            else
            {
                lblType.Visible = false;
                d_ProductType.Visible = false;
            }

            List<Model.Info_product_property> list = propertyManager.FindAllInfo(info.Product_Id);

            dropDownProductSpec1.SetDataSource(list);
        }

        protected override bool BtnOkClick()
        {
            if (cmbProductInfo1.SelectKey==null)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.cmbProductInfo1, "产品名称不能为空", 1000);
                return false;
            }

            if (d_ProductType.Visible&&string.IsNullOrEmpty(d_ProductType.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_ProductType, "产品型号不能为空", 1000);
                return false;
            }

            Dictionary<Control,string> emptyCtrs= this.GetValidEmptyCtrs();
            foreach(var v in emptyCtrs.Keys)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.cmbProductInfo1, emptyCtrs[v], 1000);

                return false;
            }

            if (dropDownProductSpec1.ItemSpec == null || dropDownProductSpec1.ItemSpec.Items.Count < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.dropDownProductSpec1, "属性列表不能为空", 1000);
                return false;
            }

            Model.Info_product_info info = this.cmbProductInfo1.SelectedItem as Model.Info_product_info;
            info.Procuct_Count = mDecimalInput1.Value;
            info.Item_Type = d_ProductType.Text;
            info.Items = dropDownProductSpec1.ItemSpec.Items;
            
            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
