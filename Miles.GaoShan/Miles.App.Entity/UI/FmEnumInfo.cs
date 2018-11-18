using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miles.App.Entity.UI
{
    public partial class FmEnumInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.EnumManager manager = new Logic.EnumManager();

        public FmEnumInfo()
        {
            InitializeComponent();
        }

        public FmEnumInfo(Model.Tb_enum info)
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
            this.d_Value.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {

                Model.Tb_enum info = modelObj as Model.Tb_enum;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Tb_enum info)
        {
            this.SetDataBind(info);
        }

        protected override bool BtnOkClick()
        {


            if (this.d_Value.Value < 0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_Value, "数值不能为负数", 1000);
                return false;
            }


            if (string.IsNullOrEmpty(this.d_Text.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_Text, "说明不能为空", 1000);
                return false;
            }



            Model.Tb_enum info = this.GetDataBind<Model.Tb_enum>();

            if (this.blNewFlag)
            {
                info.Item_Id = 0;
                info.Enum_Kind = this.Tag.ToString();
                if (!manager.Add(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Tb_enum old = modelObj as Model.Tb_enum;
                info.Item_Id = 0;
                info.Enum_Kind = this.Tag.ToString();

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
