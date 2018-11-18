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
    public partial class FmMtlSelect : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmMtlSelect()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            cmbMtlInfo1.LoadData();
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.cmbMtlInfo1.Focus();
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

            Model.Info_mtl_item item= cmbMtlInfo1.SelectedItem as Model.Info_mtl_item;
            this.DoSelectValueEvent(item);

            return true;
        }


    }
}
