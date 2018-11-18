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
    public partial class FmMatchTbMtl : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.MatchTbTmpManager manager = new Logic.MatchTbTmpManager();
        public FmMatchTbMtl()
        {
            InitializeComponent();
        }

        public FmMatchTbMtl(Model.Info_matchTb_tmp_set info)
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
            this.mDecimalInput1.Focus();
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
                Model.Info_matchTb_tmp_set info = modelObj as Model.Info_matchTb_tmp_set;
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

            Model.Info_matchTb_tmp_set info = this.GetDataBind<Model.Info_matchTb_tmp_set>();

            if (this.blNewFlag)
            {
                if (!manager.AddTmpSet(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Info_matchTb_tmp_set old = this.modelObj as Model.Info_matchTb_tmp_set;
                info.Set_Id = old.Set_Id;
                info.Set_Items = old.Set_Items;

                if (!manager.UpdateTmpSet(info))
                {
                    return false;
                }

            }

            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
