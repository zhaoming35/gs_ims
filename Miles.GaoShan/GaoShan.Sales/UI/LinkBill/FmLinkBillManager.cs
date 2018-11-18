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

namespace GaoShan.Sales.UI.LinkBill
{
    public partial class FmLinkBillManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.LinkBillManager manager = new Logic.LinkBillManager();
        Logic.EmployManager employManager = new Logic.EmployManager();
        Logic.ProcessManager processManager = new Logic.ProcessManager();
        Logic.OrderManager orderManager = new Logic.OrderManager();


        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "联络单预览");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Backward, "召回联络单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建取消单");

            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }


        public FmLinkBillManager()
        {
            InitializeComponent();
            this.ucLinkBillList1.SelectValueChange += UcLinkBillList1_SelectValueChange;
        }

        private void UcLinkBillList1_SelectValueChange(object sender, object obj)
        {
            if (this.ucLinkBillList1.CurrentSelectValue == null) { return; }

            Model.Info_link_bill info = this.ucLinkBillList1.CurrentSelectValue as Model.Info_link_bill;

            if (info.Items.Count == 0)
            {
                info.Items = manager.GetLinkItems(info.LinkBill_Id);
            }

            if (info.Employ_Name == null)
            {
                Miles.IMSFramework.Model.Sm_employee employee = employManager.GetEmployee(info.Employ_Code);
                info.Employ_Name = employee != null ? employee.Employ_Name : "";
                info.Employ_Phone= employee != null ? employee.Phone : "";
            }

            ucLinkBillInfo1.SetDataSource(info);
        }


        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Document)
            {
                Document(sender);
            }
            else if (buttonType == ButtonType.DocumentAdd)
            {
                DocumentAdd(sender);
            }
            else if (buttonType == ButtonType.Backward)
            {
                Backward(sender);
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

        private void Backward(ToolStripButton sender)
        {
            //查询出合同编码
            FmBackBillInfo fm = new FmBackBillInfo();
            fm.SelectValue += (obj) => 
            {
                LoadSelfOrder();
            };
            fm.ShowDialog();

        }

        //private void DocumentRemove(ToolStripButton sender)
        //{
        //    if (this.ucLinkBillList1.CurrentSelectValue == null) { return; }

        //    Model.Info_link_bill info = ucLinkBillList1.CurrentSelectValue as Model.Info_link_bill;
        //    string msg = string.Format("确定删除:{0},{1}联络单?", info.Odr_No, info.Jia_Name);
        //    if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
        //    {
        //        if (manager.Remove(info))
        //        {
        //            LoadSelfOrder();
        //            this.SetButtonClickResultTip(sender, "删除成功");
        //        }
        //    }
        //}

        private void DocumentAdd(ToolStripButton sender)
        {

            FmCancelBillInfo fm = new FmCancelBillInfo();
            fm.SelectValue += (obj) =>
            {
                LoadSelfOrder();
            };
            fm.ShowDialog();

        }

        private void Document(ToolStripButton sender)
        {

            if (this.ucLinkBillList1.CurrentSelectValue == null) { return; }

            Model.Info_link_bill info = ucLinkBillList1.CurrentSelectValue as Model.Info_link_bill;

            Win.FmReoGridShow fmReoGridShow = new Win.FmReoGridShow();

            fmReoGridShow.SetReportBind(new Report.FmLinkBillManagerReport(), info);
            fmReoGridShow.ShowDialog();
        }

        private void Commit(ToolStripButton sender)
        {
            if (this.ucLinkBillList1.CurrentSelectValue == null) { return; }

            Model.Info_link_bill info = ucLinkBillList1.CurrentSelectValue as Model.Info_link_bill;
            string msg = string.Format("确定提交:{0},{1}?", info.Odr_No, info.Jia_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Commit(info))
                {
                    LoadSelfOrder();
                    this.SetButtonClickResultTip(sender, "提交成功");
                }
            }
        }

        protected override void Save(ToolStripButton sender)
        {
            if (this.ucLinkBillInfo1.Save(sender))
            {
                Model.Info_link_bill info_OrderMain = this.ucLinkBillInfo1.CurrentSelectValue as Model.Info_link_bill;
                //ucOrderList1.UpdateCurrentValue(info_OrderMain);
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
            this.ucLinkBillInfo1.SetTabControls(this.tabControlSeq);

        }

        private void Clear()
        {
            this.ucLinkBillInfo1.Clear();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode) { return; }

            LoadSelfOrder();
        }

        /// <summary>
        /// 加载自己的合同，没提交的合同
        /// </summary>
        private void LoadSelfOrder()
        {
            Clear();
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_link_bill> list = manager.FindSelfLinkBillList(user.Employ_Code);

            ucLinkBillList1.SetDataSource(list);
        }
    }
}
