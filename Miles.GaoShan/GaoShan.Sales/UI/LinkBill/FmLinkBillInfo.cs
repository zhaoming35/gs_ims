using GaoShan.Sales.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.LinkBill
{
    public partial class FmLinkBillInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.ProductPropertyManager propertyManager = new Logic.ProductPropertyManager();

        public FmLinkBillInfo()
        {
            InitializeComponent();
        }

        public FmLinkBillInfo(Model.Info_link_bill_tent info)
         : base(info)
        {
            InitializeComponent();
        }
     
        protected override void LazyInit()
        {
            List<Model.Info_product_property> list = propertyManager.FindAllInfo(5693845056367661209);
            d_ProductSpec.SetDataSource(list);
            d_cmb_FixedMode.LoadData();
            d_tent_Require.LoadData("lld_tent_Require");
            d_en_roof_purlin.LoadData("lld_en_roof_purlin");
            d_engine_truck_way.LoadData("lld_engine_truck_way");
            d_ground_State.LoadData("lld_ground_State");
            d_has_Logo.LoadData("lld_has_Logo");
            d_is_truck_enter.LoadData("lld_is_truck_enter");
            d_lamp_Info.LoadData("lld_lamp_Info");
            d_net_frame.LoadData("lld_net_frame");
            d_peri_cloth_bear.LoadData("lld_peri_cloth_bear");
            d_power_Box.LoadData("lld_power_Box");

            d_steel_part_pack.LoadData("lld_steel_part_pack");
            d_tent_Pack.LoadData("lld_tent_Pack");
            d_tool_Bar.LoadData("lld_tool_Bar");
            d_wall_Require.LoadData("lld_wall_Require");

            //d_steel_drill.LoadData("lld_steel_drill");
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.d_ProductSpec.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.blNewFlag)
            {

                Model.Info_link_bill_tent info = modelObj as Model.Info_link_bill_tent;
                SetAccountInfo(info);
            }
        }

        private void SetAccountInfo(Model.Info_link_bill_tent info)
        {
            this.SetDataBind(info);
            //this.d_ProductSpec.SetDataSource(info.ItemSpec.Items);

        }


        protected override bool BtnOkClick()
        {
            if (d_ProductSpec.ItemSpec==null)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_ProductSpec, "篷房规格不能为空", 1000);
                return false;
            }

            Dictionary<Control, string> dicEmptyCtrs = this.GetValidEmptyCtrs();
            if (dicEmptyCtrs.Count > 0)
            {
                foreach (var ctr in dicEmptyCtrs.Keys)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(ctr, dicEmptyCtrs[ctr], 1000);
                    return false;
                }
            }

            Model.Info_link_bill_tent old = modelObj as Model.Info_link_bill_tent;
            Model.Info_link_bill_tent info = old!=null? this.GetDataBind<Model.Info_link_bill_tent>(old): this.GetDataBind<Model.Info_link_bill_tent>();
            //规格特殊处理获取下数据

            //info.ItemSpec = d_ProductSpec.ItemSpec;

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
