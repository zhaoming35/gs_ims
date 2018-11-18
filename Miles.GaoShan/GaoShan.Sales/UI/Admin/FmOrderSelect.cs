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

namespace GaoShan.Sales.UI.Admin
{
    public partial class FmOrderSelect : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.OrderManager manager = new Logic.OrderManager();
        public FmOrderSelect()
        {
            InitializeComponent();
            this.btnQuery.Click += BtnQuery_Click;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderNo.Text)) { return; }

            Model.Info_OrderMain orderMain = manager.FindTheOrderInfo(txtOrderNo.Text);
            if (orderMain==null)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(btnQuery, "没有满足条件的合同信息", 1000);
            }

            mDataGrid1.SetDataSource<Model.Info_OrderMain>(new List<Info_OrderMain>() { orderMain });
       
        }

        protected override bool BtnOkClick()
        {
            if (mDataGrid1.CurrentRow == null) { return false; }

            Model.Info_OrderMain info = mDataGrid1.GetCurrentEntity() as Model.Info_OrderMain;

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
