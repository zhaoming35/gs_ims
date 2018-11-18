using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.UI.Order
{
    public partial class FmOrderInfo : Miles.Framework.UI.Forms.FmMdi
    {
        private Model.Info_order_code orderCode = null;
        private Info_OrderMain info;
        private UC.UCBase ucBody = null;

        public event Action<Model.Info_OrderMain> SelectOrderChange;

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmOrderInfo()
        {
            InitializeComponent();
            cmbOrderType1.SelectItemEvent += CmbOrderType1_SelectItemEvent;
        }

        public FmOrderInfo(Info_OrderMain info)
            :this()
        {
            this.info = info;
        }

        protected override void LazyInit()
        {
            cmbOrderType1.LoadData();
            if (info != null)
            {
                cmbOrderType1.Enabled = false;
                cmbOrderType1.Text = info.OrderTypeText; 
                SwitchBody(info.Odr_Type);
                ucBody.SetDataSource(this.info);
            }

        }


        private void CmbOrderType1_SelectItemEvent(object obj)
        {
            if (obj == null) { return; }
            if (!cmbOrderType1.Enabled) { return; }

            int orderType = int.Parse(cmbOrderType1.SelectKey.ToString());
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            orderCode = Logic.Utils.BuildOrderCode(user.Employ_Code, orderType);
            string orderNo = orderCode.ToString();
            SwitchBody(orderType);
        }

        private void SwitchBody(int orderType)
        {
            ucBody = null;

            this.panelOrder.Controls.Clear();
            if (orderType == 4)
            {
                ucBody = new UCOrderBodyAdd();
            }
            else if (orderType == 3)
            {
                ucBody = new UCOrderBodyService();
            }
            else if (orderType == 2)
            {
                ucBody = new UCOrderBodyLease();
            }
            else if (orderType == 1)
            {
                ucBody = new UCOrderBodySales();
            }

            ucBody.Clear();
            ucBody.SetOrderCode(orderCode);

            ucBody.Dock = DockStyle.Fill;
            this.panelOrder.Controls.Add(ucBody);

            this.ucBody.SetTabControls(this.tabControlSeq);
            this.tabControlSeq.FirstControlFocus();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.cmbOrderType1.Focus();
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void Save(ToolStripButton sender)
        {
            if (this.ucBody.Save(sender))
            {
                Model.Info_OrderMain info_OrderMain = this.ucBody.CurrentSelectValue as Model.Info_OrderMain;
                this.SetButtonClickResultTip(sender, "保存成功");
                if (SelectOrderChange != null)
                {
                    SelectOrderChange(info_OrderMain);
                }

            }
        }
    }
}
