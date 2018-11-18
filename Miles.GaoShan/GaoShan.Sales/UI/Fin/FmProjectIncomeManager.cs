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
    public partial class FmProjectIncomeManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.ProjectIncomeManager manager = new Logic.ProjectIncomeManager();
        Logic.GenManager genManager = new Logic.GenManager();
        Logic.OrderManager orderManager = new Logic.OrderManager();
        //Logic.EmployManager employManager = new Logic.EmployManager();

        public FmProjectIncomeManager()
        {
            InitializeComponent();
            this.ucIncomeList1.SelectValueChange += UcIncomeList1_SelectValueChange;
        }

        Report.FmOrderGenManagerReport orderGenManagerReport=new Report.FmOrderGenManagerReport ();
        private void UcIncomeList1_SelectValueChange(object sender, object obj)
        {
            Model.Info_fin_order_income info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;
            if (obj == null) { return; }
            this.SetDataBind(info);

            //显示合同摘要信息
            Model.Info_fin_order_gen infoGen = genManager.FindTheVaildGen(info.Odr_No);

            if (infoGen.BuildItems.Count == 0)
            {
                infoGen.BuildItems = genManager.GetBuildItems(info.Odr_No);
            }

            if (infoGen.FreightItems.Count == 0)
            {
                infoGen.FreightItems = genManager.GetFreightItems(info.Odr_No);
            }

            //orderGenManagerReport.GridControl = this.reoGridControl1;
            orderGenManagerReport.Show(infoGen, this.reoGridControl1);
        }

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "合同摘要预览");

            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.DocumentAdd)
            {
                DocumentAdd(sender);
            }
            else if (buttonType == ButtonType.DocumentRemove)
            {
                DocumentRemove(sender);
            }
            else if (buttonType == ButtonType.Commit)
            {
                Commit(sender);
            }
            else if (buttonType == ButtonType.Reload)
            {
                Reload(sender);
            }
        }

        private void Reload(ToolStripButton sender)
        {
            LoadSelfOrder();
        }

        private void Commit(ToolStripButton sender)
        {
            Model.Info_fin_order_income info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;
            if (info == null) { return; }
            string msg = string.Format("确定提交:{0},{1}?", info.Odr_No, info.Odr_Prt_Name);
            if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            { return; }

            if (this.manager.Commit(info))
            {
                LoadSelfOrder();
                this.SetButtonClickResultTip(sender, "提交成功");
            }
            else
            {
                this.SetButtonClickResultTip(sender, "提交失败");
            }
        }

        private void DocumentRemove(ToolStripButton sender)
        {
            Model.Info_fin_order_income info = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;
            if (info == null) { return; }
            string msg = string.Format("确定删除:{0},{1}?", info.Odr_No, info.Odr_Prt_Name);
            if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            { return; }

            if (this.manager.Remove(info))
            {
                LoadSelfOrder();
                this.SetButtonClickResultTip(sender, "删除成功");
            }
            else
            {
                this.SetButtonClickResultTip(sender, "删除失败");
            }
        }

        private void DocumentAdd(ToolStripButton sender)
        {
            FmGenSelect fmOrderNo = new FmGenSelect();

            fmOrderNo.SelectValue += (obj)=> 
            {
                Model.Info_fin_order_gen infoGen = obj as Model.Info_fin_order_gen;
                Model.Info_fin_order_income infoIncome =  Miles.Coro.Common.Utils.CopyToOther<Model.Info_fin_order_gen, Model.Info_fin_order_income>(infoGen);

                if (this.manager.Save(infoIncome))
                {
                    LoadSelfOrder();
                }
            };

            fmOrderNo.ShowDialog();
        }

  

        protected override void Save(ToolStripButton sender)
        {
            if (this.ucIncomeList1.CurrentSelectValue==null)
            {
                return;
            }

            Model.Info_fin_order_income old = this.ucIncomeList1.CurrentSelectValue as Model.Info_fin_order_income;
            Model.Info_fin_order_income info = old != null ? this.GetDataBind<Model.Info_fin_order_income>(old) : this.GetDataBind<Model.Info_fin_order_income>();

            if (this.manager.Save(info))
            {
                LoadSelfOrder();
                this.SetButtonClickResultTip(sender, "保存成功");
            }
            else
            {
                this.SetButtonClickResultTip(sender, "保存失败");
            }
        }

        protected override void SetTabControls()
        {
            this.tabControlSeq.AddContainer(groupBox16);

        }

        private void LoadSelfOrder()
        {
            Clear();
            List<Model.Info_fin_order_income> list = manager.FindAllNoCommitInfo();

            ucIncomeList1.SetDataSource(list);
        }

        protected override void LazyInit()
        {
            cmbReceivePayWay1.LoadData();
            cmbCompanyAccount1.LoadData();
       
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
