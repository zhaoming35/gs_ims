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
    public partial class FmTransFeeInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.PlaceFeeManager manager = new Logic.PlaceFeeManager();

        public FmTransFeeInfo()
        {
            InitializeComponent();
        }

        public FmTransFeeInfo(Model.Info_place_fee info) : base(info)
        {
            InitializeComponent();
        }

        private void CmbTransPlace2_SelectItemEvent(object obj)
        {
            if (cmbTransPlace2.SelectKey == null) { return; }

            long id = (long)cmbTransPlace2.SelectKey;

            cmbTransPlace3.LoadData(id);
        }

        private void CmbTransPlace1_SelectItemEvent(object obj)
        {
            if (cmbTransPlace1.SelectKey == null) { return; }

            long id = (long)cmbTransPlace1.SelectKey;

            cmbTransPlace2.LoadData(id);
        }

        protected override void LazyInit()
        {
            cmbTransPlace1.LoadData(0);
            cmbTruckSpec1.LoadData();
            cmbTransBothDirection1.LoadData();

            this.cmbTransPlace1.SelectItemEvent += CmbTransPlace1_SelectItemEvent;
            this.cmbTransPlace2.SelectItemEvent += CmbTransPlace2_SelectItemEvent;

        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.cmbTransPlace1.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!blNewFlag)
            {
                Model.Info_place_fee info = this.modelObj as Model.Info_place_fee;

                Model.Info_place_info placeArea = Cache.LogicCache.DicPlaces[info.Place_Id];
                Model.Info_place_info placeCity= Cache.LogicCache.DicPlaces[placeArea.Parent_Id];
                Model.Info_place_info placeProvince = Cache.LogicCache.DicPlaces[placeCity.Parent_Id];

                cmbTransPlace1.SetKeyValue(placeProvince.Place_Id);
                cmbTransPlace2.SetKeyValue(placeCity.Place_Id);

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


            Model.Info_place_fee info = this.GetDataBind<Model.Info_place_fee>();

            if (this.blNewFlag)
            {
                if (!manager.Add(info)) { return false; }

            }
            else
            {
                Model.Info_place_fee old = modelObj as Model.Info_place_fee;
                info.Fee_Id=old.Fee_Id;

                if (!manager.Update(info, old)) { return false; }

            }

            this.DoSelectValueEvent(info);

            return true;
        }

    }
}
