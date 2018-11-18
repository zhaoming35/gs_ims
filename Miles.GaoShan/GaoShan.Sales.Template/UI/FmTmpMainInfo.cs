using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Template.UI
{
    public partial class FmTmpMainInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.TmpManager manager = new Logic.TmpManager();

        public FmTmpMainInfo()
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
            this.d_linkWay1.Focus();
        }

        protected override void LazyInit()
        {
            Model.Tb_tmp_main info = manager.GetTmpMain();
            if(info!=null)
            SetInfo(info);
        }

        private void SetInfo(Model.Tb_tmp_main info)
        {
            this.SetDataBind(info);
        }

        protected override bool BtnOkClick()
        {
            Dictionary<Control, string> emptyCtrs = this.GetValidEmptyCtrs();
            foreach (var v in emptyCtrs.Keys)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(v, emptyCtrs[v], 1000);

                return false;
            }

            Model.Tb_tmp_main info = this.GetDataBind<Model.Tb_tmp_main>();

            if (!manager.UpdateTmpMain(info))
            {
                return false;

            }

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
