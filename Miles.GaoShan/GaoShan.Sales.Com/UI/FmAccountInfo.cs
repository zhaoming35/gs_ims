using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaoShan.Sales.Com.UI
{
    public partial class FmAccountInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.AccountManager manager = new Logic.AccountManager();

        public FmAccountInfo()
        {
            InitializeComponent();
        }

        public FmAccountInfo(Model.Tb_company_act info)
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
            this.d_payActName.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {

                Model.Tb_company_act info = modelObj as Model.Tb_company_act;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Tb_company_act info)
        {
            this.SetDataBind(info);
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

            Model.Tb_company_act info = this.GetDataBind<Model.Tb_company_act>();

            if (this.blNewFlag)
            {
                //info.Act_Id = Miles.Coro.Common.Utils.GuidToInt64();
                if (!manager.Add(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Tb_company_act old = modelObj as Model.Tb_company_act;
                info.Act_Id = old.Act_Id;

                if (!manager.Update(info,old))
                {
                    return false;
                }
            }

            this.DoSelectValueEvent(info);

            return true;
        }
    }
}
