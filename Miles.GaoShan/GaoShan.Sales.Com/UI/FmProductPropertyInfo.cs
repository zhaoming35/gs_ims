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
    public partial class FmProductPropertyInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.ProductPropertyManager manager = new Logic.ProductPropertyManager();

        public FmProductPropertyInfo()
        {
            InitializeComponent();
        }

        public FmProductPropertyInfo(Model.Tb_product_property info)
         : base(info)
        {
            InitializeComponent();
        }


        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.d_propertyName.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {
                Model.Tb_product_property info = modelObj as Model.Tb_product_property;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Tb_product_property info)
        {
            this.SetDataBind(info);
        }

        protected override bool BtnOkClick()
        {
            if (string.IsNullOrEmpty(this.d_propertyName.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_propertyName, "名称不能为空", 1000);
                return false;
            }

            //if (string.IsNullOrEmpty(this.d_propertyUnit.Text))
            //{
            //    Miles.Framework.UI.Function.MForm.SetToolTip(this.d_propertyUnit, "单位不能为空", 1000);
            //    return false;
            //}

            if (this.d_propertySeq.Value==0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_propertySeq, "序号不能为空", 1000);
                return false;
            }

            Model.Tb_product_property info = this.GetDataBind<Model.Tb_product_property>();

            if (this.blNewFlag)
            {
                info.Product_Id = (long)this.Tag;
                if (!manager.Add(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Tb_product_property old = modelObj as Model.Tb_product_property;
                info.Product_Id = old.Product_Id;
                info.Property_Id = old.Property_Id;

                if (!manager.Update(info, old))
                {
                    return false;
                }
            }

            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
