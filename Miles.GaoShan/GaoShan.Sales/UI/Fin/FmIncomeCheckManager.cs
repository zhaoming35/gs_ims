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
    public partial class FmIncomeCheckManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.ProjectIncomeManager manager = new Logic.ProjectIncomeManager();
        Logic.GenManager genManager = new Logic.GenManager();
        Logic.OrderManager orderManager = new Logic.OrderManager();
        //Logic.EmployManager employManager = new Logic.EmployManager();

        public FmIncomeCheckManager()
        {
            InitializeComponent();
            this.ucIncomeList1.SelectValueChange += UcIncomeList1_SelectValueChange;
        }

        Report.FmOrderGenManagerReport orderGenManagerReport=new Report.FmOrderGenManagerReport ();
        private void UcIncomeList1_SelectValueChange(object sender, object obj)
        {
            Model.Info_fin_order_income info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;
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

            Model.Info_fin_order_income info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;
            string msg = string.Format("确定通过:{0},{1}?", info.Odr_No, info.Jia_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.CheckIncomePass(info))
                {
                    Clear();
                    LoadSelfOrder();
                }
            }
        }

        private void Backward(ToolStripButton sender)
        {
            if (this.ucIncomeList1.CurrentSelectValue == null) { return; }

            Model.Info_fin_order_income info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;

            Win.FmCheckCommentInfo fm = new Win.FmCheckCommentInfo();
            fm.SelectValue += (obj) =>
            {
                if (manager.CheckIncomeNoPass(info, obj.ToString()))
                {
                    Clear();
                    LoadSelfOrder();
                }
            };

            fm.ShowDialog();

        }


        private void LoadSelfOrder()
        {
            List<Model.Info_fin_order_income> list = manager.FindAllCommitInfo();

            ucIncomeList1.SetDataSource(list);
        }

        protected override void LazyInit()
        {
            cmbReceivePayWay1.LoadData();
            cmbCompanyAccount1.LoadData();
      

            this.SetBindCtrNoEnabled();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadSelfOrder();
        }

        private void Clear()
        {
            this.ClearBindValue();
            this.reoGridControl1.Reset();
        }
    }
}
