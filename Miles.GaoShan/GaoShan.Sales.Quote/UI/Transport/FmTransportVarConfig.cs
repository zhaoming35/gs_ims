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

namespace GaoShan.Sales.Quote.UI
{
    public partial class FmTransportVarConfig : Miles.Framework.UI.Forms.FmMdi
    {
        protected override void InitToolBtn()
        {
           this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        Logic.FinTransportTmpManager manager = new Logic.FinTransportTmpManager();
        Model.Info_fin_transport_tmp infoTmp;

        public FmTransportVarConfig()
        {
            InitializeComponent();
            this.btnAddItem.Click += BtnAddItem_Click;
            this.btnDeleteItem.Click += BtnDeleteItem_Click;
            this.btnSaveItem.Click += BtnSave_Click;
            this.btnAddSpec.Click += BtnAddSpec_Click;
            this.btnDeleteSpec.Click += BtnDeleteSpec_Click;
            this.btnSaveSpec.Click += BtnSave_Click;
            this.btnAddFixed.Click += BtnAddFixed_Click;
            this.btnDeleteFixed.Click += BtnDeleteFixed_Click;
            this.btnSaveFixed.Click += BtnSave_Click;
            this.btnAddDml.Click += BtnAddDml_Click;
            this.btnDeleteDml.Click += BtnDeleteDml_Click;
            this.btnSaveDml.Click += BtnSave_Click;
            this.btnAddInput.Click += BtnAddInput_Click;
            this.btnDeleteInput.Click += BtnDeleteInput_Click;
            this.btnSaveInput.Click += BtnSave_Click;
            this.btnAddCal.Click += BtnAddCal_Click;
            this.btnDeleteCal.Click += BtnDeleteCal_Click;
            this.btnSaveCal.Click += BtnSave_Click;
        }


        private void BtnDeleteCal_Click(object sender, EventArgs e)
        {
            if (mDataGridCal.CurrentRow == null) { return; }
            mDataGridCal.DeleteCurrentItem<VarCal>();
        }

        private void BtnAddCal_Click(object sender, EventArgs e)
        {
            mDataGridCal.AddItem<VarCal>(new VarCal());
        }

        private void BtnDeleteInput_Click(object sender, EventArgs e)
        {
            if (mDataGridInput.CurrentRow == null) { return; }
            mDataGridInput.DeleteCurrentItem<VarInput>();
        }

        private void BtnAddInput_Click(object sender, EventArgs e)
        {
            mDataGridInput.AddItem<VarInput>(new VarInput());
        }

        private void BtnDeleteDml_Click(object sender, EventArgs e)
        {
            if (mDataGridDmz.CurrentRow == null) { return; }
            mDataGridDmz.DeleteCurrentItem<RanageFormula>();
        }

        private void BtnAddDml_Click(object sender, EventArgs e)
        {
            mDataGridDmz.AddItem<RanageFormula>(new RanageFormula());
        }

        private void BtnDeleteFixed_Click(object sender, EventArgs e)
        {
            if (mDataGridFixed.CurrentRow == null) { return; }
            mDataGridFixed.DeleteCurrentItem<TransFixedItem>();
        }

        private void BtnAddFixed_Click(object sender, EventArgs e)
        {
            mDataGridFixed.AddItem<TransFixedItem>(new TransFixedItem());
        }

        private void BtnDeleteSpec_Click(object sender, EventArgs e)
        {
            if (mDataGridSpec.CurrentRow == null) { return; }
            mDataGridSpec.DeleteCurrentItem<StringValue>();
        }

        private void BtnAddSpec_Click(object sender, EventArgs e)
        {

            mDataGridSpec.AddItem<StringValue>(new StringValue());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (infoTmp == null) { return; }

            mDataGridEdgeHeight.EndEdit();
            mDataGridSpec.EndEdit();
            mDataGridFixed.EndEdit();
            mDataGridDmz.EndEdit();
            mDataGridInput.EndEdit();
            mDataGridCal.EndEdit();

            infoTmp.EdgeHeight = mDataGridEdgeHeight.GetDataSource<DecValue>();
            infoTmp.MainSpec = mDataGridSpec.GetDataSource<StringValue>();
            infoTmp.TransFixed = mDataGridFixed.GetDataSource<TransFixedItem>();
            infoTmp.DmlFormula = mDataGridDmz.GetDataSource<RanageFormula>();
            infoTmp.VarInputs = mDataGridInput.GetDataSource<VarInput>();
            infoTmp.VarCals = mDataGridCal.GetDataSource<VarCal>();

            if (manager.Save(infoTmp))
            {
                ToolStripButton btnSave= sender as ToolStripButton;
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(btnSave, "保存成功");
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (mDataGridEdgeHeight.CurrentRow == null) { return; }
            mDataGridEdgeHeight.DeleteCurrentItem<StringValue>();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            mDataGridEdgeHeight.AddItem<StringValue>(new StringValue());
        }
        

        protected override void LazyInit()
        {
            infoTmp = manager.FindThe();
            mDataGridEdgeHeight.SetDataSource<DecValue>(infoTmp.EdgeHeight);
            mDataGridSpec.SetDataSource<StringValue>(infoTmp.MainSpec);
            mDataGridFixed.SetDataSource<TransFixedItem>(infoTmp.TransFixed);
            mDataGridDmz.SetDataSource<RanageFormula>(infoTmp.DmlFormula);
            mDataGridInput.SetDataSource<VarInput>(infoTmp.VarInputs);
            mDataGridCal.SetDataSource<VarCal>(infoTmp.VarCals);
        }

    }
}
