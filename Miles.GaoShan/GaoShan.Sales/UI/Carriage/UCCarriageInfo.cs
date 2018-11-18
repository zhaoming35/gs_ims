using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Carriage
{
    public partial class UCCarriageInfo : UC.UCBase
    {
        Logic.CarriageManager manager = new Logic.CarriageManager();
        public UCCarriageInfo()
        {
            InitializeComponent();
            this.mDecimalInput1.TextChanged += MDecimalInput1_TextChanged;
        }

        private void MDecimalInput1_TextChanged(object sender, EventArgs e)
        {
           lblRmb.Text= Miles.Coro.Common.MoneyConvert.ToWord(mDecimalInput1.Value);
        }

        protected override void LazyInit()
        {
            cmbCarriageType1.LoadData();
            cmbPayPart1.LoadData();
            cmbPayWay1.LoadData();
            cmbTransportNature1.LoadData();
            cmbTransportType1.LoadData();
            cmbTrunkSpec1.LoadData();
        }

        public override void SetTabControls(Miles.Framework.UI.Forms.TabControlSeq tabControlSeq)
        {
            this.tabControlSeq.AddContainer(this);
        }

        public override void Clear()
        {
            base.Clear();
            //this.mDateTimeInput1.Value = DateTime.Now;
            //this.mDateTimeInput2.Value = DateTime.Now;
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);
            base.selectValue = dataSource;
            if (dataSource == null) { return; }

            Model.Info_carriage_bill info = dataSource as Model.Info_carriage_bill;
            this.Tag = info.Carriage_Id;
            this.SetDataBind(dataSource);

        }

        public override bool Save(ToolStripButton sender)
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

            Model.Info_carriage_bill info = dataSource as Model.Info_carriage_bill;
            Model.Info_carriage_bill update = this.GetDataBind<Model.Info_carriage_bill>(info);

            if (manager.Save(update))
            {
                base.SetDataSource(update);
                base.selectValue = update;
            }

            return true;
        }


    }
}
