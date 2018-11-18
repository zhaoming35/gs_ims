using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Carriage
{
    public partial class FmCarriageCreate : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.CarriageManager manager = new Logic.CarriageManager();

        public FmCarriageCreate()
        {
            InitializeComponent();
        }

        public FmCarriageCreate(Model.Info_link_bill obj)
       : base(obj)
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            cmbCarriageType1.LoadData();
            cmbCarriageType1.SelectItemEvent += CmbCarriageType1_SelectItemEvent;

            if (this.modelObj != null)
                this.SetDataBind(this.modelObj);
        }

        private void CmbCarriageType1_SelectItemEvent(object obj)
        {
            if (obj == null) { return; }
            Miles.App.Entity.Model.Tb_enum info = obj as Miles.App.Entity.Model.Tb_enum;
            if (info.Enum_Value == 5)
            {
                this.label1.Visible = false;
                this.mTextInput1.Visible = false;

                this.label2.Visible = false;
                this.mTextInput2.Visible = false;

                this.label3.Visible = false;
                this.mTextInput3.Visible = false;
            }
            else
            {
                this.label1.Visible = true;
                this.mTextInput1.Visible = true;

                this.label2.Visible = true;
                this.mTextInput2.Visible = true;

                this.label3.Visible = true;
                this.mTextInput3.Visible = true;
            }
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.mTextInput3.Focus();

            Model.Info_link_bill bill = this.modelObj as Model.Info_link_bill;
            this.mTextInput3.Text = bill.LinkBill_Name;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

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

            Model.Info_carriage_bill info = this.GetDataBind<Model.Info_carriage_bill>();

            Model.Info_link_bill bill = this.modelObj as Model.Info_link_bill;
            //如果是销售或者租赁项目，项目必须选中
            int carType = int.Parse(cmbCarriageType1.SelectKey.ToString());
            if ( carType != 5)
            {
                if (bill == null)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(mTextInput1, "类型是项目的运输单必须根据项目建立", 1000);
                    return false;

                }

                info = Miles.Coro.Common.Utils.CopyToOther<Model.Info_link_bill, Model.Info_carriage_bill>(bill, info);
            }

            if (!manager.Add(info))
            {
                return false;
            }

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
