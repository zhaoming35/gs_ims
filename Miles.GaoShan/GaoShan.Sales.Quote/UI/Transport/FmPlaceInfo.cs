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
    public partial class FmPlaceInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.PlaceInfoManager manager = new Logic.PlaceInfoManager();

        public FmPlaceInfo()
        {
            InitializeComponent();
        }

        public FmPlaceInfo(Model.Info_place_info info):base(info)
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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Model.Info_place_info parent = this.Tag as Model.Info_place_info;
            lblParentName.Text = parent.Place_Name;
            if (!this.blNewFlag)
            {
                Model.Info_place_info info = modelObj as Model.Info_place_info;
                mTextInput1.Text = info.Place_Name;
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

            Model.Info_place_info parent = this.Tag as Model.Info_place_info;
            Model.Info_place_info info = new Model.Info_place_info();
            info.Parent_Id = parent.Place_Id;
            info.Level = parent.Level + 1;
            info.Place_Name = mTextInput1.Text;

            if (this.blNewFlag)
            {
               if (!manager.Add(info)) { return false; }

            }
            else
            {
                Model.Info_place_info update = modelObj as Model.Info_place_info;
                update.Place_Name = info.Place_Name;

                if (!manager.Update(update, update)) { return false; }

                info = update;
            }

            this.DoSelectValueEvent(info);

            return true;
        }
    }
}
