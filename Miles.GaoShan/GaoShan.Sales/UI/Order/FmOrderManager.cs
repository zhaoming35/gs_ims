using GaoShan.Sales.UI.UC;
using Miles.Framework.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace GaoShan.Sales.UI.Order
{
    public partial class FmOrderManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.OrderManager manager = new Logic.OrderManager();

        protected override void InitToolBtn()
        {

            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }


        public FmOrderManager()
        {
            InitializeComponent();

            this.ucOrderList1.SelectValueChange += UcOrderList1_SelectValueChange;
        }

        private void UcOrderList1_SelectValueChange(object sender, object obj)
        {

            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info_OrderMain = this.ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;

            if (info_OrderMain.Items.Count == 0)
            {
                info_OrderMain.Items = manager.GetOrderItems(info_OrderMain.Odr_No);
            }

            if (info_OrderMain.Odr_Clause == null)
            {
                info_OrderMain.Odr_Clause = manager.GetOrderClause(info_OrderMain.Odr_No);
            }

            Doc.DocBuilder docBuilder = new Doc.DocBuilder(info_OrderMain);

            Doc.DocBuilder.LoadCtrViewDoc(this.mRichEditOnly1, docBuilder.ToStream(info_OrderMain.Odr_Clause));
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == Miles.Framework.UI.Forms.ButtonType.DocumentAdd)
            {
                DocumentAdd();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.DocumentEdit)
            {
                DocumentEdit();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.DocumentRemove)
            {
                DocumentRemove();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Commit)
            {
                Commit(sender);
            }
        }

        private void DocumentEdit()
        {
            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;
            FmOrderInfo fm = new FmOrderInfo(info);
            fm.SelectOrderChange += (obj) =>
            {
                LoadSelfOrder();
            };
            fm.ShowDialog();
        }

        private void DocumentRemove()
        {
            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;
            string msg = string.Format("确定删除:{0},{1}?", info.Odr_No, info.Odr_Prt_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    LoadSelfOrder();
                }
            }
        }

        private void DocumentAdd()
        {
            FmOrderInfo fm = new FmOrderInfo();
            fm.SelectOrderChange += (info) => 
            {
                LoadSelfOrder();
            };
            fm.ShowDialog();
        }

        private void Commit(ToolStripButton sender)
        {
            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;
            string msg = string.Format("确定提交:{0},{1}?{2}总金额为：{3}", info.Odr_No, info.Jia_Name, Environment.NewLine, info.Tot_Cost);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.CommitOrder(info))
                {
                    LoadSelfOrder();
                    this.SetButtonClickResultTip(sender, "提交成功");
                }
            }
        }

        protected override void PrintDialog(ToolStripButton sender)
        {
            //Miles.Coro.Common.Print.PrintConfigManager.PrintDialog(Doc.DocBuilder.ReportName);//this.GetType().FullName);
            sender.Tag = Doc.DocBuilder.ReportName;
            base.PrintDialog(sender);
        }

        protected override void PrintPreview(ToolStripButton sender)
        {

            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;

            Doc.DocBuilder docBuilder = new Doc.DocBuilder(info);

            Doc.DocBuilder.PrintDocPreview(docBuilder.ToStream(info.Odr_Clause), Doc.DocBuilder.ReportName);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.tabControlSeq.FirstControlFocus();
        }

        protected override void LazyInit()
        {
            LoadSelfOrder();
        }

        /// <summary>
        /// 加载自己的合同，没提交的合同
        /// </summary>
        private void LoadSelfOrder()
        {
            mRichEditOnly1.ResetText();

            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_OrderMain> list = manager.FindSelfNotCommitOrders(user.Employ_Code);
            ucOrderList1.SetDataSource(list);
        }
    }
}
