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
    public partial class FmSalaryRanageFormula : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmSalaryRanageFormula()
        {
            InitializeComponent();
        }

        public FmSalaryRanageFormula(SalaryRanageFormula info)
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
            this.cmbDeptRole1.Focus();
        }

        protected override void LazyInit()
        {
            cmbDeptRole1.LoadData("004");
            SetAccountInfo();
        }

        private void SetAccountInfo()
        {
            if (!this.blNewFlag)
            {
                SalaryRanageFormula info = modelObj as SalaryRanageFormula;
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

            SalaryRanageFormula info = this.GetDataBind<SalaryRanageFormula>();
           
            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
