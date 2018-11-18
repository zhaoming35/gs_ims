using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaoShan.Sales.Xls.UI
{
    public partial class FmTmpXlsInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.TmpXlsManager manager = new Logic.TmpXlsManager();

        public FmTmpXlsInfo()
        {
            InitializeComponent();
        }

        public FmTmpXlsInfo(Model.Info_tmp_xls info)
            : base(info)
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            cmbModelType1.LoadData();
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.d_Name.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            if (!this.blNewFlag)
            {
                Model.Info_tmp_xls info = modelObj as Model.Info_tmp_xls;
                SetInfo(info);
            }
        }

 
        private void SetInfo(Model.Info_tmp_xls info)
        {
            this.SetDataBind(info);
        }

        protected override bool BtnOkClick()
        {
            if (string.IsNullOrEmpty(this.d_Name.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_Name, "名称不能为空", 1000);
                return false;
            }

            Model.Info_tmp_xls old = modelObj as Model.Info_tmp_xls;
            Model.Info_tmp_xls info  =old!=null? this.GetDataBind<Model.Info_tmp_xls>(old): this.GetDataBind<Model.Info_tmp_xls>();


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
                //Model.Info_tmp_xls updateInfo = modelObj as Model.Info_tmp_xls;
                //updateInfo.Tmp_Name = info.Tmp_Name;
                //updateInfo.Tmp_Explain = info.Tmp_Explain;

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
