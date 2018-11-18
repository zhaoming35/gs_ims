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
    public partial class FmXlsDocInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.XlsDocManager manager = new Logic.XlsDocManager();

        public FmXlsDocInfo()
        {
            InitializeComponent();
        }

        public FmXlsDocInfo(Model.Info_xls_doc info)
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
            this.d_Name.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            if (!this.blNewFlag)
            {
                Model.Info_xls_doc info = modelObj as Model.Info_xls_doc;
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

            Model.Info_xls_doc old = modelObj as Model.Info_xls_doc;
            Model.Info_xls_doc info  =old!=null? this.GetDataBind<Model.Info_xls_doc>(old): this.GetDataBind<Model.Info_xls_doc>();


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
