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

namespace GaoShan.Sales.Salary.UI.Tmp
{
    public partial class FmRanageFormula : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmRanageFormula()
        {
            InitializeComponent();
        }

        public FmRanageFormula(RanageFormula info)
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
            this.mDecimalInput2.Focus();
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
                RanageFormula info = modelObj as RanageFormula;
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

            RanageFormula info = this.GetDataBind<RanageFormula>();
           
            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
