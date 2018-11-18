using GaoShan.Sales.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.MatchTb.UI
{
    public partial class FmVarCal : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmVarCal()
        {
            InitializeComponent();
        }

        public FmVarCal(VarCal info)
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
                VarCal info = modelObj as VarCal;
                this.SetDataBind(info);
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

            VarCal info = this.GetDataBind<VarCal>();
           
            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
