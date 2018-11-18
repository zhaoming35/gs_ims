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

namespace GaoShan.Sales.Salary.UI.Tmp
{
    public partial class FmSalaryTmpManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.SalaryTmpManager manager = new Logic.SalaryTmpManager();
        Info_salary_tmp infoTmp = null;

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmSalaryTmpManager()
        {
            InitializeComponent();
            this.cmbSalaryType1.SelectItemEvent += CmbSalaryType1_SelectItemEvent;
            this.btnAddInput.Click += BtnAddInput_Click;
            this.btnDeleteInput.Click += BtnDeleteInput_Click;
            this.btnSaveInput.Click += BtnSave_Click;
            this.btnAddCal.Click += BtnAddCal_Click;
            this.btnDeleteCal.Click += BtnDeleteCal_Click;
            this.btnSaveCal.Click += BtnSave_Click;
            this.btnAddSalary.Click += BtnAddSalary_Click;
            this.btnEditSalary.Click += BtnEditSalary_Click;
            this.btnDeleteSalary.Click += BtnDeleteSalary_Click;
            this.btnSaveSalary.Click+= BtnSave_Click;

            this.btnAddDept.Click += BtnAddDept_Click;
            this.btnEditDept.Click += BtnEditDept_Click;
            this.btnDeleteDept.Click += BtnDeleteDept_Click;
            this.btnSaveDept.Click += BtnSave_Click;

            this.btnAddOrgan.Click += BtnAddOrgan_Click;
            this.btnEditOrgan.Click += BtnEditOrgan_Click;
            this.btnDeleteOrgan.Click += BtnDeleteOrgan_Click;
            this.btnSaveOrgan.Click+= BtnSave_Click;
        }

   
        protected override void LazyInit()
        {
            cmbSalaryType1.LoadData();
            //object obj= cmbSalaryType1.Items[0];
            //cmbSalaryType1.SelectedIndex = 0;
            cmbSalaryType1.SetSelectItemFirst();
        }

        private void CmbSalaryType1_SelectItemEvent(object obj)
        {
            if (obj == null) { return; }

            Miles.App.Entity.Model.Tb_enum info = obj as Miles.App.Entity.Model.Tb_enum;

            infoTmp = manager.FindThe((int)info.Enum_Value);
            mDataGridInput.SetDataSource<VarInput>(infoTmp.VarInputs);
            mDataGridCal.SetDataSource<VarCal>(infoTmp.VarCals);
            mDataGridSalary.SetDataSource<RanageFormula>(infoTmp.SalesMan);
            mDataGridDept.SetDataSource<SalaryRanageFormula>(infoTmp.DeptAward);
            mDataGridOrgan.SetDataSource<SalaryRanageFormula>(infoTmp.OrganAward);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<VarInput> varsInput = mDataGridInput.GetDataSource<VarInput>();
            List<VarCal> varsCal = mDataGridCal.GetDataSource<VarCal>();
            List<RanageFormula> ltSalary = mDataGridSalary.GetDataSource<RanageFormula>();
            List<SalaryRanageFormula> ltDept =mDataGridDept.GetDataSource<SalaryRanageFormula>();
            List<SalaryRanageFormula> ltOrgan = mDataGridOrgan.GetDataSource<SalaryRanageFormula>();
            infoTmp.VarInputs = varsInput;
            infoTmp.VarCals = varsCal;
            infoTmp.SalesMan = ltSalary;
            infoTmp.DeptAward = ltDept;
            infoTmp.OrganAward = ltOrgan;

            if (manager.Save(infoTmp))
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip((ToolStripButton)sender, "保存成功");
            }
        }

        #region 输入参数
        private void BtnAddInput_Click(object sender, EventArgs e)
        {
            mDataGridInput.AddItem<VarInput>(new VarInput());
        }


        private void BtnDeleteInput_Click(object sender, EventArgs e)
        {
            if (mDataGridInput.CurrentRow == null) { return; }

            mDataGridInput.DeleteCurrentItem<VarInput>();
        }

        #endregion

        #region 计算变量

        private void BtnDeleteCal_Click(object sender, EventArgs e)
        {
            if (mDataGridCal.CurrentRow == null) { return; }
            mDataGridCal.DeleteCurrentItem<VarCal>();
        }


        private void BtnAddCal_Click(object sender, EventArgs e)
        {
            mDataGridCal.AddItem<VarCal>(new VarCal());
        }

        #endregion

        #region 成交提成
        private void BtnDeleteSalary_Click(object sender, EventArgs e)
        {

            if (mDataGridSalary.CurrentRow == null) { return; }

            mDataGridSalary.DeleteCurrentItem<RanageFormula>();
        }

        private void BtnEditSalary_Click(object sender, EventArgs e)
        {
            if (mDataGridSalary.CurrentRow == null) { return; }
            RanageFormula old = mDataGridSalary.GetCurrentEntity() as RanageFormula;

            FmRanageFormula fm = new FmRanageFormula(old);
            fm.SelectValue += (obj) =>
            {
                RanageFormula info = obj as RanageFormula;
                mDataGridSalary.EditCurrentItem<RanageFormula>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddSalary_Click(object sender, EventArgs e)
        {
            FmRanageFormula fm = new FmRanageFormula();
            fm.SelectValue += (obj) =>
            {
                RanageFormula info = obj as RanageFormula;
                mDataGridSalary.AddItem<RanageFormula>(info);
            };
            fm.ShowDialog();
        }
        #endregion

        #region 部门提成
        private void BtnDeleteDept_Click(object sender, EventArgs e)
        {
            if (mDataGridDept.CurrentRow == null) { return; }

            mDataGridDept.DeleteCurrentItem<SalaryRanageFormula>();
        }

        private void BtnEditDept_Click(object sender, EventArgs e)
        {
            if (mDataGridDept.CurrentRow == null) { return; }
            SalaryRanageFormula old = mDataGridDept.GetCurrentEntity() as SalaryRanageFormula;

            FmSalaryRanageFormula fm = new FmSalaryRanageFormula(old);
            fm.SelectValue += (obj) =>
            {
                SalaryRanageFormula info = obj as SalaryRanageFormula;
                mDataGridDept.EditCurrentItem<SalaryRanageFormula>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddDept_Click(object sender, EventArgs e)
        {
            FmSalaryRanageFormula fm = new FmSalaryRanageFormula();
            fm.SelectValue += (obj) =>
            {
                SalaryRanageFormula info = obj as SalaryRanageFormula;
                mDataGridDept.AddItem<SalaryRanageFormula>(info);
            };
            fm.ShowDialog();
        }

        #endregion

        #region 组织奖
        private void BtnDeleteOrgan_Click(object sender, EventArgs e)
        {
            if (mDataGridOrgan.CurrentRow == null) { return; }

            mDataGridOrgan.DeleteCurrentItem<SalaryRanageFormula>();
        }

        private void BtnEditOrgan_Click(object sender, EventArgs e)
        {
            if (mDataGridOrgan.CurrentRow == null) { return; }
            SalaryRanageFormula old = mDataGridOrgan.GetCurrentEntity() as SalaryRanageFormula;

            FmSalaryRanageFormula fm = new FmSalaryRanageFormula(old);
            fm.SelectValue += (obj) =>
            {
                SalaryRanageFormula info = obj as SalaryRanageFormula;
                mDataGridOrgan.EditCurrentItem<SalaryRanageFormula>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddOrgan_Click(object sender, EventArgs e)
        {
            FmSalaryRanageFormula fm = new FmSalaryRanageFormula();
            fm.SelectValue += (obj) =>
            {
                SalaryRanageFormula info = obj as SalaryRanageFormula;
                mDataGridOrgan.AddItem<SalaryRanageFormula>(info);
            };
            fm.ShowDialog();
        }

        #endregion

    }
}
