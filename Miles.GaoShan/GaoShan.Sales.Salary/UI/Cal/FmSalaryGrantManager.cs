using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miles.Framework.UI.Forms;

namespace GaoShan.Sales.Salary.UI.Cal
{
    public partial class FmSalaryGrantManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.SalaryCalManager manager = new Logic.SalaryCalManager();

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Note, "发放记录");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmSalaryGrantManager()
        {
            InitializeComponent();
            this.mDataGrid1.CurrentRowChanged += MDataGrid1_CurrentRowChanged;
            this.txtSearchCode.TextChanged += TxtSearchCode_TextChanged;
        }

        private void TxtSearchCode_TextChanged(object sender, EventArgs e)
        {
            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchCode.Text))
            {
                mDataGrid1.SetFilter<Model.Q_salary_main_item>(null);
            }
            else
            {
                mDataGrid1.SetFilter<Model.Q_salary_main_item>(delegate (Model.Q_salary_main_item p)
                {
                    if (!p.Odr_No_Main.Contains(txtSearchCode.Text))
                    {
                        return false;
                    }

                    return true;

                });

            }
        }

        private void MDataGrid1_CurrentRowChanged(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null)
            {
                return;
            }

            Model.Q_salary_main_item item= mDataGrid1.GetCurrentEntity() as Model.Q_salary_main_item;

            LoadGrantList(item.Odr_No_Main, item.Employ_Code);


        }

        private void LoadGrantList(string odrNoMain, string employCode)
        {
            List<Model.Info_salary_grant_item> list = manager.GetSalaryGrantList(odrNoMain, employCode);
            mDataGrid2.SetDataSource<Model.Info_salary_grant_item>(list);
        }

        protected override void Query(ToolStripButton sender)
        {
            mDataGrid1.Clear();
            mDataGrid2.Clear();
            List<Model.Q_salary_main_item> list = manager.GetNoGrantDoneSalary();
            mDataGrid1.SetDataSource<Model.Q_salary_main_item>(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Note)
            {
                Note(sender);
            }
        }

        private void Note(ToolStripButton sender)
        {
            if (mDataGrid1.CurrentRow == null)
            {
                return;
            }

            Model.Q_salary_main_item item = mDataGrid1.GetCurrentEntity() as Model.Q_salary_main_item;

            FmSalaryGrantInfo fm = new FmSalaryGrantInfo(item);
            fm.SelectValue += (obj) => 
            {
                Query(null);
                //LoadGrantList(item.Odr_No_Main, item.Employ_Code);
            };
            fm.ShowDialog();

        }
    }
}
