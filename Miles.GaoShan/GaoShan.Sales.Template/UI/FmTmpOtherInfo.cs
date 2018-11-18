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
    public partial class FmTmpOtherInfo :  Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.TmpManager manager = new Logic.TmpManager();

        public FmTmpOtherInfo()
        {
            InitializeComponent();
        }

        public FmTmpOtherInfo(Model.Tb_tmp_info info)
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
            this.d_TableSeq.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {

                Model.Tb_tmp_info info = modelObj as Model.Tb_tmp_info;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Tb_tmp_info info)
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


            Model.Tb_tmp_info infoBind = this.GetDataBind<Model.Tb_tmp_info>();

            Model.Tb_tmp_info info = modelObj as Model.Tb_tmp_info;
            info.Item_Table_Seq = infoBind.Item_Table_Seq;
            info.Item_Clause_Seq = infoBind.Item_Clause_Seq;
            info.Item_Pay_Seq = infoBind.Item_Pay_Seq;

            if (!manager.UpdateTmpOtherInfo(info))
            {
                return false;
            }

            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
