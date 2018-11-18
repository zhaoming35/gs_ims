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
using Miles.Framework.UI.Forms;

namespace GaoShan.Sales.Salary.UI.Cal
{
    public partial class FmSalaryCalManager  : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.SalaryCalManager manager = new Logic.SalaryCalManager();
 
        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Money, "计算提成");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmSalaryCalManager()
        {
            InitializeComponent();
            this.mDataGrid1.CurrentRowChanged += MDataGrid1_CurrentRowChanged;
        }

        private void MDataGrid1_CurrentRowChanged(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }

            Model.Bu_CalSalaryGen salaryGen = mDataGrid1.GetCurrentEntity() as Model.Bu_CalSalaryGen;
            if(salaryGen.Items.Count == 0)
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

            ucSumOrderCost1.SetDataSource(salaryGen);
        }

        protected override void Query(ToolStripButton sender)
        {
            ucSumOrderCost1.Clear();

            List<Model.Bu_CalSalaryGen> list1 = manager.QueryNeedCalSalaryGenList();
            mDataGrid1.SetDataSource<Model.Bu_CalSalaryGen>(list1);

            List<Model.Bu_CalSalaryGen> list2 = manager.QueryChangeCalSalaryMainList();
            mDataGrid2.SetDataSource<Model.Bu_CalSalaryGen>(list2);
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
            if (tabControl1.TabIndex == 0)
            {
                if (mDataGrid1.CurrentRow == null)
                {
                    return;
                }

                Model.Bu_CalSalaryGen salaryGen = mDataGrid1.GetCurrentEntity() as Model.Bu_CalSalaryGen;
                string msg = string.Format("确定要计算:{0}合同编号提成?", salaryGen.Odr_No_Main);
                if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
                {
                    return;
                }

                //如果是销售合同,得到输入的指导价
                if (salaryGen.Odr_Type == 1)
                {
                    FmGuidePriceInfo fm = new FmGuidePriceInfo();
                    fm.SelectValue += (obj) => 
                    {
                        decimal value = (decimal)obj ;
                        salaryGen.GuidePrice = value;
                    };
                    if (fm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

                NewCalSalary(salaryGen);
            }
            else
            {
                if (mDataGrid2.CurrentRow == null)
                {
                    return;
                }

                Model.Bu_CalSalaryGen salaryGen = mDataGrid2.GetCurrentEntity() as Model.Bu_CalSalaryGen;
                string msg = string.Format("确定重新计算:{0}合同编号提成?", salaryGen.Odr_No_Main);
                if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
                {
                    return;
                }

                Model.Info_salary_main oldSalary = manager.FindThe(salaryGen.Odr_No_Main);

                if (salaryGen.Odr_Type == 1)
                {
                    salaryGen.GuidePrice = oldSalary.Guide_Price;
                }

                NewCalSalary(salaryGen);
            }

            Query(null);
        }

        private void NewCalSalary(Bu_CalSalaryGen v)
        {
           
            SalaryCal salaryCal= SalaryFactory.GetSalaryCal(v.Odr_Type, v.Odr_No_Main, v);
            
            bool hasSalary=salaryCal.HasSalary();
            if (hasSalary)
            {
                salaryCal.DoCal();
            }
        }
    }
}
