using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.UI.Gen
{
    public partial class FmGenItem : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.ProductPropertyManager propertyManager = new Logic.ProductPropertyManager();

        public FmGenItem()
        {
            InitializeComponent();
        }

        public FmGenItem(Model.Info_fin_order_item info)
         : base(info)
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            if (DesignMode) { return; }
            cmbProductInfo1.LoadData();
            cmbProductInfo1.SelectItemEvent += CmbProductInfo1_SelectItemEvent;
            if (!this.blNewFlag)
            {
                this.cmbProductInfo1.Enabled = false;
                Model.Info_fin_order_item info = modelObj as Model.Info_fin_order_item;
                SetInfo(info);
            }
        }

        private void CmbProductInfo1_SelectItemEvent(object obj)
        {
            if (obj == null) { return; }
            Model.Info_product_info info = obj as Model.Info_product_info;
            List<Model.Info_product_property> list = propertyManager.FindAllInfo(info.Product_Id);

            dropDownProductSpec1.SetDataSource(list);
        }

        private void SetInfo(Model.Info_fin_order_item info)
        {
            this.SetDataBind(info);
            this.dropDownProductSpec1.SetDataSource(info.ItemSpec.Items);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.cmbProductInfo1.Focus();
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override bool BtnOkClick()
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

            Model.Info_fin_order_item info = this.GetDataBind<Model.Info_fin_order_item>();

            info.ItemSpec = this.dropDownProductSpec1.ItemSpec;

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
