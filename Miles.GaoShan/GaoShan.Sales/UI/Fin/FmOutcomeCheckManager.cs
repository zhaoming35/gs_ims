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

namespace GaoShan.Sales.UI.Fin
{
    public partial class FmOutcomeCheckManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.ProjectOutcomeManager manager = new Logic.ProjectOutcomeManager();
        Logic.GenManager genManager = new Logic.GenManager();
        Logic.OrderManager orderManager = new Logic.OrderManager();
        //Logic.EmployManager employManager = new Logic.EmployManager();

        public FmOutcomeCheckManager()
        {
            InitializeComponent();
            this.ucIncomeList1.SelectValueChange += UcIncomeList1_SelectValueChange;
        }

        Report.FmOrderGenManagerReport orderGenManagerReport=new Report.FmOrderGenManagerReport ();
        private void UcIncomeList1_SelectValueChange(object sender, object obj)
        {
           Model.Info_fin_order_outcome info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_outcome;
            if (info == null) { return; }

            this.SetDataBind(info);

            //显示合同摘要信息
            Model.Info_fin_order_gen infoGen = genManager.FindTheVaildGen(info.Odr_No);

            //orderGenManagerReport.GridControl = this.reoGridControl1;
            orderGenManagerReport.Show(infoGen, this.reoGridControl1);
        }

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "审核通过");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Backward, "驳回不通过");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == Miles.Framework.UI.Forms.ButtonType.Check)
            {
                Check(sender);
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Backward)
            {
                Backward(sender);
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Reload)
            {
                Reload(sender);
            }
        }

        private void Reload(ToolStripButton sender)
        {
            LoadSelfOrder();
        }

        private void Check(ToolStripButton sender)
        {
            if (this.ucIncomeList1.CurrentSelectValue == null) { return; }

           Model.Info_fin_order_outcome info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_outcome;
            string msg = string.Format("确定通过:{0},{1}?", info.Odr_No, info.Jia_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.CheckOutcomePass(info))
                {
                    Clear();
                    LoadSelfOrder();
                }
            }
        }

        private void Backward(ToolStripButton sender)
        {
            if (this.ucIncomeList1.CurrentSelectValue == null) { return; }

           Model.Info_fin_order_outcome info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_outcome;

            Win.FmCheckCommentInfo fm = new Win.FmCheckCommentInfo();
            fm.SelectValue += (obj) =>
            {
                if (manager.CheckOutcomeNoPass(info, obj.ToString()))
                {
                    Clear();
                    LoadSelfOrder();
                }
            };

            fm.ShowDialog();

        }


        private void LoadSelfOrder()
        {
            List<Model.Info_fin_order_outcome> list = manager.FindAllCommitInfo();

            ucIncomeList1.SetDataSource(list);
        }

        protected override void LazyInit()
        {
            cmbReceivePayWay1.LoadData();


            this.SetBindCtrNoEnabled();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //cmbCompanyAccount1.LoadData();
            LoadSelfOrder();
        }

        private void Clear()
        {
            this.ClearBindValue();
            this.reoGridControl1.Reset();
        }
    }
}
