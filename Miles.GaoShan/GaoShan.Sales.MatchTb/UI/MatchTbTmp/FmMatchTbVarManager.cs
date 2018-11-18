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

namespace GaoShan.Sales.MatchTb.UI
{
    public partial class FmMatchTbVarManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.MatchTbTmpManager manager = new Logic.MatchTbTmpManager();
        public FmMatchTbVarManager()
        {
            InitializeComponent();
            this.btnAddInput.Click += BtnAddInput_Click;
            this.btnEditInput.Click += BtnEditInput_Click;
            this.btnDeleteInput.Click += BtnDeleteInput_Click;
            this.btnSaveInput.Click += BtnSaveInput_Click;
            this.btnAddCal.Click += BtnAddCal_Click;
            this.btnEditCal.Click += BtnEditCal_Click;
            this.btnDeleteCal.Click += BtnDeleteCal_Click;
            this.btnSaveCal.Click += BtnSaveCal_Click;
            this.btnAddLt.Click += BtnAddLt_Click;
            this.btnEditLt.Click += BtnEditLt_Click;
            this.btnDeleteLt.Click += BtnDeleteLt_Click;
            this.btnSaveLt.Click += BtnSaveLt_Click;
            this.btnAddGt.Click += BtnAddGt_Click;
            this.btnEditGt.Click += BtnEditGt_Click;
            this.btnDeleteGt.Click += BtnDeleteGt_Click;
            this.btnSaveGt.Click += BtnSaveGt_Click;
        }

        #region 30米以上的
        private void BtnSaveGt_Click(object sender, EventArgs e)
        {
            List<RanageFormula> vars = mDataGridGt.GetDataSource<RanageFormula>();
            if (vars.Count < 1)
            {
                return;
            }
            matchTbTmp.SzcGt30 = vars;
            if (manager.SaveSzcGt30(matchTbTmp))
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSaveGt, "保存成功");
            }
        }

        private void BtnDeleteGt_Click(object sender, EventArgs e)
        {
            if (mDataGridGt.CurrentRow == null) { return; }

            mDataGridGt.DeleteCurrentItem<RanageFormula>();
        }

        private void BtnEditGt_Click(object sender, EventArgs e)
        {
            if (mDataGridGt.CurrentRow == null) { return; }
            RanageFormula old = mDataGridGt.GetCurrentEntity() as RanageFormula;

            FmSzcFormula fm = new FmSzcFormula(old);
            fm.SelectValue += (obj) =>
            {
                RanageFormula info = obj as RanageFormula;
                mDataGridGt.EditCurrentItem<RanageFormula>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddGt_Click(object sender, EventArgs e)
        {
            FmSzcFormula fm = new FmSzcFormula();
            fm.SelectValue += (obj) =>
            {
                RanageFormula info = obj as RanageFormula;
                mDataGridGt.AddItem<RanageFormula>(info);
            };
            fm.ShowDialog();
        }

        #endregion
        #region 30米下的十字撑
        private void BtnSaveLt_Click(object sender, EventArgs e)
        {
            List<RanageFormula> vars = mDataGridLt.GetDataSource<RanageFormula>();
            if (vars.Count < 1)
            {
                return;
            }
            matchTbTmp.SzcLt30 = vars;
            if (manager.SaveSzcLt30(matchTbTmp))
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSaveLt, "保存成功");
            }
        }

        private void BtnDeleteLt_Click(object sender, EventArgs e)
        {
            if (mDataGridLt.CurrentRow == null) { return; }

            mDataGridLt.DeleteCurrentItem<RanageFormula>();
        }

        private void BtnEditLt_Click(object sender, EventArgs e)
        {
            if (mDataGridLt.CurrentRow == null) { return; }
            RanageFormula old = mDataGridLt.GetCurrentEntity() as RanageFormula;

            FmSzcFormula fm = new FmSzcFormula(old);
            fm.SelectValue += (obj) =>
            {
                RanageFormula info = obj as RanageFormula;
                mDataGridLt.EditCurrentItem<RanageFormula>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddLt_Click(object sender, EventArgs e)
        {
            FmSzcFormula fm = new FmSzcFormula();
            fm.SelectValue += (obj) =>
            {
                RanageFormula info = obj as RanageFormula;
                mDataGridLt.AddItem<RanageFormula>(info);
            };
            fm.ShowDialog();
        }

        #endregion
        #region 计算变量
        private void BtnSaveCal_Click(object sender, EventArgs e)
        {
            List<VarCal> vars = mDataGridCal.GetDataSource<VarCal>();
            if (vars.Count < 1)
            {
                return;
            }
            matchTbTmp.VarCals = vars;
            if (manager.SaveVarsCal(matchTbTmp))
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSaveCal, "保存成功");

            }
        }

        private void BtnDeleteCal_Click(object sender, EventArgs e)
        {
            if (mDataGridCal.CurrentRow == null) { return; }
            mDataGridCal.DeleteCurrentItem<VarCal>();
        }

        private void BtnEditCal_Click(object sender, EventArgs e)
        {
            if (mDataGridCal.CurrentRow == null) { return; }
            VarCal old = mDataGridCal.GetCurrentEntity() as VarCal;
            FmVarCal fm = new FmVarCal(old);
            fm.SelectValue += (obj) =>
            {
                VarCal info = obj as VarCal;

                mDataGridCal.EditCurrentItem<VarCal>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddCal_Click(object sender, EventArgs e)
        {
            FmVarCal fm = new FmVarCal();
            fm.SelectValue += (obj) =>
            {
                VarCal info = obj as VarCal;

                mDataGridCal.AddItem<VarCal>(info);
            };
            fm.ShowDialog();
        }

        #endregion

        #region 输入变量
        private void BtnSaveInput_Click(object sender, EventArgs e)
        {
            List<VarInput> vars = mDataGridInput.GetDataSource<VarInput>();
            if (vars.Count < 1)
            {
                return;
            }
            matchTbTmp.VarInputs = vars;
            if (manager.SaveVarsInput(matchTbTmp))
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSaveInput, "保存成功");
            }
        }

        private void BtnDeleteInput_Click(object sender, EventArgs e)
        {
            if (mDataGridInput.CurrentRow == null) { return; }

            mDataGridInput.DeleteCurrentItem<VarInput>();
        }

        private void BtnEditInput_Click(object sender, EventArgs e)
        {
            if (mDataGridInput.CurrentRow == null) { return; }
            VarInput old = mDataGridInput.GetCurrentEntity() as VarInput;

            FmVarInput fm = new FmVarInput(old);
            fm.SelectValue += (obj) =>
            {
                VarInput info = obj as VarInput;
                mDataGridInput.EditCurrentItem<VarInput>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddInput_Click(object sender, EventArgs e)
        {
            FmVarInput fm = new FmVarInput();
            fm.SelectValue += (obj) =>
            {
                VarInput info = obj as VarInput;
                mDataGridInput.AddItem<VarInput>(info);
            };
            fm.ShowDialog();
        }

        #endregion

        protected override void InitToolBtn()
        {

            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改订单");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        Info_MatchTb_Tmp matchTbTmp = null;
        protected override void LazyInit()
        {
            matchTbTmp = manager.FindThe();
            mDataGridInput.SetDataSource<VarInput>(matchTbTmp.VarInputs);
            mDataGridCal.SetDataSource<VarCal>(matchTbTmp.VarCals);
            mDataGridLt.SetDataSource<RanageFormula>(matchTbTmp.SzcLt30);
            mDataGridGt.SetDataSource<RanageFormula>(matchTbTmp.SzcGt30);
        }
    }
}
