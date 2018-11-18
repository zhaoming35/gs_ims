using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Quote.UI
{
    public partial class FmTransportMaxInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.FinTransportMaxManager manager = new Logic.FinTransportMaxManager();

        public FmTransportMaxInfo()
        {
            InitializeComponent();
        }

        public FmTransportMaxInfo(Model.Tb_fin_transport_max info)
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
            this.cmbTransMainSpec1.Focus();
        }

        protected override void LazyInit()
        {
            cmbTransEdgeHeight1.LoadData();
            cmbTransMainSpec1.LoadData();
            SetAccountInfo();
        }

        private void SetAccountInfo()
        {
            if (!this.blNewFlag)
            {
                Model.Tb_fin_transport_max info = modelObj as Model.Tb_fin_transport_max;
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

            Model.Tb_fin_transport_max info = this.GetDataBind<Model.Tb_fin_transport_max>();

            if (blNewFlag)
            {
                if (!manager.Add(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Tb_fin_transport_max old = this.modelObj as Model.Tb_fin_transport_max;
                info.Max_Id = old.Max_Id;
                if (!manager.Update(info, old))
                {
                    return false;
                }

            }


            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
