using GaoShan.Sales.Model;
using Miles.Framework.UI.Forms;
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
    public partial class FmSalaryCalQuery : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.SalaryCalManager manager = new Logic.SalaryCalManager();

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Money, "重新计算提成");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "合同摘要预览");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmSalaryCalQuery()
        {
            InitializeComponent();
            this.mDataGridResult.CurrentRowChanged += MDataGridResult_CurrentRowChanged;
            this.mDataGridRelatedMan.CurrentRowChanged += MDataGridRelatedMan_CurrentRowChanged;
        }

        private void MDataGridRelatedMan_CurrentRowChanged(object sender, EventArgs e)
        {
            if (this.mDataGridRelatedMan.CurrentRow == null) { return; }

            Model.Q_salary_main_item info = mDataGridRelatedMan.GetCurrentEntity() as Model.Q_salary_main_item;

            List<Model.Info_salary_grant_item> list = manager.GetSalaryGrantList(info.Odr_No_Main, info.Employ_Code);
            mDataGridGrant.SetDataSource<Model.Info_salary_grant_item>(list);
        }

        private void MDataGridResult_CurrentRowChanged(object sender, EventArgs e)
        {
            if (this.mDataGridResult.CurrentRow == null) { return; }

            Model.Info_salary_main info = this.mDataGridResult.GetCurrentEntity() as Model.Info_salary_main;

            //过程结果
            mDataGridProcess.SetDataSource<CalParmResult>(info.CalProcess);
            
            //相关人提成金额
            List<Model.Q_salary_main_item> list = manager.QuerySalaryItemsQRecord(info.Odr_No_Main);
            mDataGridRelatedMan.SetDataSource<Model.Q_salary_main_item>(list);

            //相关合同摘要数据
            List<Model.Info_fin_order_gen> listGen = manager.QuerySalaryGens(info.Odr_No_Main);
            mDataGridGen.SetDataSource<Model.Info_fin_order_gen>(listGen);


        }

        protected override void Query(ToolStripButton sender)
        {
            if (beginDate.Value == null && endDate.Value == null && string.IsNullOrEmpty(txtOrderNo.Text))
            {
                MessageBox.Show("请输入查询条件");
                return;
            }

            //Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_salary_main> list = manager.QuerySalaryMainRecord(beginDate.Value, endDate.Value, txtOrderNo.Text);
            mDataGridResult.SetDataSource<Model.Info_salary_main>(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Money)
            {
                Money(sender);
            }
        }

        private void Money(ToolStripButton sender)
        {
            if (mDataGridResult.CurrentRow == null)
            {
                return;
            }

            Model.Info_salary_main oldSalary = mDataGridResult.GetCurrentEntity() as Model.Info_salary_main;
            string msg = string.Format("确定重新计算:{0}合同编号提成?", oldSalary.Odr_No_Main);
            if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                return;
            }

            Bu_CalSalaryGen salaryGen = manager.FindTheCalSalaryGenList(oldSalary.Odr_No_Main);
            if (salaryGen.Items.Count == 0)
            {
                salaryGen.Items = manager.GetOrderAllProductItems(salaryGen.Odr_No_Main);
            }

            if (salaryGen.BuildItems.Count == 0)
            {
                salaryGen.BuildItems = manager.GetBuildItems(salaryGen.Odr_No_Main);
            }

            if (salaryGen.FreightItems.Count == 0)
            {
                salaryGen.FreightItems = manager.GetFreightItems(salaryGen.Odr_No_Main);
            }

            if (salaryGen.Odr_Type == 1)
            {
                FmGuidePriceInfo fm = new FmGuidePriceInfo();
                fm.mDecimalInput1.Value = oldSalary.Guide_Price;
                fm.SelectValue += (obj) =>
                {
                    decimal value = (decimal)obj;
                    salaryGen.GuidePrice = value;
                };
                if (fm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            if (NewCalSalary(salaryGen))
            {
                Query(null);
            }
        }

        private bool NewCalSalary(Bu_CalSalaryGen v)
        {

            SalaryCal salaryCal = SalaryFactory.GetSalaryCal(v.Odr_Type, v.Odr_No_Main, v);

            bool hasSalary = salaryCal.HasSalary();
            if (hasSalary)
            {
               return salaryCal.DoCal();
            }

            return false;
        }
    }
}
