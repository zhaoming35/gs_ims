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
    public partial class FmMtlInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.MtlManager manager = new Logic.MtlManager();

        public FmMtlInfo()
        {
            InitializeComponent();
        }

        public FmMtlInfo(Model.Info_mtl_item info)
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
            this.d_mtl_Code.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetAccountInfo();
        }

        private void SetAccountInfo()
        {
            if (!this.blNewFlag)
            {
                Model.Info_mtl_item info = modelObj as Model.Info_mtl_item;
                this.SetDataBind(info);
            }

            Model.Info_mtl_kind kind = this.Tag as Model.Info_mtl_kind;
            lblParent.Text = kind.Kind_Name;
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

            Model.Info_mtl_item info = this.GetDataBind<Model.Info_mtl_item>();
            Model.Info_mtl_kind parent = this.Tag as Model.Info_mtl_kind;
            info.Kind_Code = parent.Kind_Code;
            if (this.blNewFlag)
            {
                if (!manager.Add(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Info_mtl_item old = modelObj as Model.Info_mtl_item;
                
                if (!manager.Update(info, old))
                {
                    return false;
                }
            }

            this.DoSelectValueEvent(info);

            return !chbInput.Checked;
        }
    }
}
