using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.ProjectCost
{
    public partial class FmProjectCostInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmProjectCostInfo()
        {
            InitializeComponent();
        }

        public FmProjectCostInfo(Model.Info_project_Cost_Item info)
     : base(info)
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            cmbExpendItem1.LoadData();
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.mDateTimeInput1.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {

                Model.Info_project_Cost_Item info = modelObj as Model.Info_project_Cost_Item;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Info_project_Cost_Item info)
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

            Model.Info_project_Cost_Item old = modelObj as Model.Info_project_Cost_Item;
            Model.Info_project_Cost_Item info = old != null ? this.GetDataBind<Model.Info_project_Cost_Item>(old) : this.GetDataBind<Model.Info_project_Cost_Item>();

            this.DoSelectValueEvent(info);

            return true;
        }
    }
}
