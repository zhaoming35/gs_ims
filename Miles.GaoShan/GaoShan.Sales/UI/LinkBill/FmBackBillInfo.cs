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
    public partial class FmBackBillInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.LinkBillManager manager = new Logic.LinkBillManager();

        public FmBackBillInfo()
        {
            InitializeComponent();
            this.btnQuery.Click += BtnQuery_Click;
        }
        Model.Info_link_bill info = null;
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderNo.Text))
            {
                return;
            }


            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            string employ_Code = user.Employ_Code;
            info = manager.FindSelfMayBackBill(employ_Code, txtOrderNo.Text);
            if (info == null)
            {
                MessageBox.Show("没有要召回的数据");
            }
            else
            {
                this.SetDataBind(info);
            }
        }

        protected override bool BtnOkClick()
        {
            if (info == null) { return false; }
            string msg = string.Format("确定召回:{0},{1}联络单?", info.Odr_No, info.LinkBill_Name);
            if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                return false;
            }

            //召回操作
            if (!manager.BackBill(info))
            {
                return false;
            }
            this.DoSelectValueEvent(info);
            return true;
        }
    }
}
