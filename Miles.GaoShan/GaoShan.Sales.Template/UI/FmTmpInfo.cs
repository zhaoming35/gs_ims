using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaoShan.Sales.Template.UI
{
    public partial class FmTmpInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.TmpManager manager = new Logic.TmpManager();

        public FmTmpInfo()
        {
            InitializeComponent();
        }

        public FmTmpInfo(Model.Info_tmp info)
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
            this.cmbOrderType1.Focus();
        }

        protected override void LazyInit()
        {
            cmbOrderType1.LoadData();
            if (!this.blNewFlag)
            {
                Model.Info_tmp info = modelObj as Model.Info_tmp;
                SetInfo(info);
            }
        }

        private void SetInfo(Model.Info_tmp info)
        {
            cmbOrderType1.SetKeyValue((decimal)info.Order_Type);
            this.d_Name.Text = info.Tmp_Name;
            this.d_Explain.Text = info.Tmp_Explain;
        }

        protected override bool BtnOkClick()
        {
            if (string.IsNullOrEmpty(this.d_Name.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_Name, "名称不能为空", 1000);
                return false;
            }


            Model.Info_tmp info = new Model.Info_tmp();
            info.Tmp_Name = d_Name.Text;
            info.Tmp_Explain = d_Explain.Text;
            info.Order_Type = int.Parse(cmbOrderType1.SelectKey.ToString());

            if (this.blNewFlag)
            {
                //info.Part_Id = Miles.Coro.Common.Utils.GuidToInt64();
                if (!manager.Add(info))
                {
                    return false;
                }
            }
            else
            {
                Model.Info_tmp old = modelObj as Model.Info_tmp;
                info.Tmp_Id = old.Tmp_Id;
                if (!manager.UpdateInfo(info))
                {
                    return false;
                }
            }

            this.DoSelectValueEvent(info);

            return true;
        }



    }
}
