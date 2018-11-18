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
    public partial class FmPartInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.TmpManager manager = new Logic.TmpManager();

        public FmPartInfo()
        {
            InitializeComponent();
        }

        public FmPartInfo(Model.Tb_tmp_part info)
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
            this.d_partName.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {

                Model.Tb_tmp_part info = modelObj as Model.Tb_tmp_part;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Tb_tmp_part info)
        {
            this.SetDataBind(info);
        }

        protected override bool BtnOkClick()
        {
            if (string.IsNullOrEmpty(this.d_partName.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_partName, "名称不能为空", 1000);
                return false;
            }

            if (string.IsNullOrEmpty(this.d_partExplain.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_partExplain, "说明不能为空", 1000);
                return false;
            }

            if (d_partSeq.Value==0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_partSeq, "顺序不能为空", 1000);
                return false;
            }

            Model.Tb_tmp_part info = this.GetDataBind<Model.Tb_tmp_part>();

            if (this.blNewFlag)
            {
                info.Tmp_Id = (long)this.Tag;
                if (!manager.AddPartInfo(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Tb_tmp_part old = modelObj as Model.Tb_tmp_part;
                info.Part_Id = old.Part_Id;

                info.Tmp_Id = (long)this.Tag;
                if (!manager.UpdatePartInfo(info))
                {
                    return false;
                }
            }

            this.DoSelectValueEvent(info);

            return true;
        }




    }
}
