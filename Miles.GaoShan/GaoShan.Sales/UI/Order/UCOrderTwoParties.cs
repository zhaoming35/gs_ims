using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;

namespace GaoShan.Sales.UI.Order
{
    public partial class UCOrderTwoParties : UCBase
    {
        Miles.IMSFramework.Model.Sm_employee user = null;

        public UCOrderTwoParties()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.cmbFinActInfo1.LoadData();
            this.cmbCompanyInfo1.LoadData();
            user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;
            this.d_YiDaiLi.Text = user.Employ_Name;
            this.cmbCompanyInfo1.SelectItemEvent += CmbCompanyInfo1_SelectItemEvent;
            this.cmbFinActInfo1.SelectItemEvent += CmbFinActInfo1_SelectItemEvent;
        }

        private void CmbFinActInfo1_SelectItemEvent(object obj)
        {
            Model.Tb_fin_act info = obj as Model.Tb_fin_act;
            if (info != null)
            {
                d_YiActName.Text = info.Pay_Act_Name;
                d_YiActNo.Text = info.Pay_Act_No;
                d_YiBankName.Text = info.Pay_Bank_Name;
            }
        }

        private void CmbCompanyInfo1_SelectItemEvent(object obj)
        {

            //加载公司预设的的账户信息
            Model.Tb_company_act info = obj as Model.Tb_company_act;
            if (info != null)
            {
                d_YiName.Text = info.Act_Name;
                d_YiAdress.Text = info.Act_Adress;
                d_YiFaRen.Text = info.Act_FaRen;
                d_YiPhone.Text = info.Act_Phone;
                d_YiTaxCode.Text = info.Pay_Tax_Code;
            }
        }

        

    }
}
