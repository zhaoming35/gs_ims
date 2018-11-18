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
    public partial class FmMatchTbItem : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.MatchTbTmpManager manager = new Logic.MatchTbTmpManager();
        public FmMatchTbItem()
        {
            InitializeComponent();
        }

        public FmMatchTbItem(Model.Bu_MatchTb_Item info)
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
            this.cmbMtlInfo1.Focus();
        }


        protected override void LazyInit()
        {
            cmbMatchTbVars1.LoadData();
            cmbMtlInfo1.LoadData();
            SetAccountInfo();
        }

        private void SetAccountInfo()
        {
            if (!this.blNewFlag)
            {
                Model.Bu_MatchTb_Item info = modelObj as Model.Bu_MatchTb_Item;
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

            Model.Bu_MatchTb_Item info = this.GetDataBind<Model.Bu_MatchTb_Item>();
            Model.Info_mtl_item item=cmbMtlInfo1.SelectedItem as Model.Info_mtl_item;

            Model.Bu_MatchTb_Item update = Miles.Coro.Common.Utils.CopyToChild<Model.Info_mtl_item, Model.Bu_MatchTb_Item>(item);
            update.ItemFormula = info.ItemFormula;

            this.DoSelectValueEvent(update);

            return true;
        }

    }
}
