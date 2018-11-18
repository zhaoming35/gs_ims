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
    public partial class FmMtlKind : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.MtlManager manager = new Logic.MtlManager();

        public FmMtlKind()
        {
            InitializeComponent();
        }

        public FmMtlKind(Model.Info_mtl_kind info)
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
            this.d_kind_Code.Focus();
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
                Model.Info_mtl_kind info = modelObj as Model.Info_mtl_kind;
                this.SetDataBind(info);
            }
   
            if (this.Tag==null)
            {
                lblParent.Text = "顶级分类";
            }
            else
            {
                Model.Info_mtl_kind info = this.Tag as Model.Info_mtl_kind;
                lblParent.Text = info.Kind_Name;
            }
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


            Model.Info_mtl_kind info = this.GetDataBind<Model.Info_mtl_kind>();

            if (this.blNewFlag)
            {
                Model.Info_mtl_kind parent = this.Tag as Model.Info_mtl_kind;
                if (parent != null)
                {
                    info.Kind_Parent = parent.Kind_Code;
                    info.Kind_Level = parent.Kind_Level + 1;
                }
                else
                {
                    info.Kind_Parent = null;
                    info.Kind_Level =0;
                }

                if (!manager.AddKind(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Info_mtl_kind update = modelObj as Model.Info_mtl_kind;
                update.Kind_Name = info.Kind_Name;
                if (!manager.UpdateKind(update, update))
                {
                    return false;
                }
            }

            this.DoSelectValueEvent(info);

            return true;
        }
    }
}
