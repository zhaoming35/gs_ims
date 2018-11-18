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
    public partial class FmMatchTbCreate : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.MatchTbManager manager = new Logic.MatchTbManager();

        public FmMatchTbCreate()
        {
            InitializeComponent();
        }

        public FmMatchTbCreate(Model.Info_link_bill obj) 
            : base(obj)
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
            this.mTextInput1.Focus();

            Model.Info_link_bill bill = this.modelObj as Model.Info_link_bill;
            this.mTextInput1.Text = bill.LinkBill_Name;
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

            Model.Info_matchTb info =  this.GetDataBind<Model.Info_matchTb>();
            Model.Info_link_bill bill = this.modelObj as Model.Info_link_bill;
            info = Miles.Coro.Common.Utils.CopyToOther<Model.Info_link_bill, Model.Info_matchTb>(bill,info);

            if (!manager.Add(info))
            {
                return false;
            }

            this.DoSelectValueEvent(info);

            return true;
        }





    }



}
