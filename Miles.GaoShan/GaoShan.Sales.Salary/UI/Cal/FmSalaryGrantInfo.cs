using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Salary.UI.Cal
{
    public partial class FmSalaryGrantInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.SalaryCalManager manager = new Logic.SalaryCalManager();

        public FmSalaryGrantInfo()
        {
            InitializeComponent();
        }

        public FmSalaryGrantInfo(Model.Q_salary_main_item item) 
            : base(item)
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
            this.mDateTimeInput1.Focus();
        }

        protected override void LazyInit()
        {
            //cmbSalaryMan1.LoadData();
            Model.Q_salary_main_item item = this.modelObj as Model.Q_salary_main_item;

            mTextInput2.Text = item.Odr_No_Main;
            mTextInput1.Text = item.Employ_Name;
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

            Model.Q_salary_main_item buItem = this.modelObj as Model.Q_salary_main_item;

            Model.Info_salary_grant_item item = this.GetDataBind<Model.Info_salary_grant_item>();
            item.Employ_Code = buItem.Employ_Code;
            item.Odr_No_Main = buItem.Odr_No_Main;
            item.Salary_Grant = mDecimalInput1.Value;

            if (!manager.AddGrantItem(item))
            {
                MessageBox.Show("添加失败");
                return false;
            }

            DoSelectValueEvent(item);

            return true;
        }


    }
}
