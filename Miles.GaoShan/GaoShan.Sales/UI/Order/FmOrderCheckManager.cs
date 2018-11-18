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
    public partial class FmOrderCheckManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.OrderManager manager = new Logic.OrderManager();

        [Category("配置"), Description("合同状态"), DefaultValue(0)]
        public int OrderState { get; set; }


        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "审核通过");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Backward, "驳回不通过");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
     
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmOrderCheckManager()
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

            if (info_OrderMain.Odr_BodyText == null)
            {
                info_OrderMain.Odr_BodyText = manager.GetOrderBodyText(info_OrderMain.Odr_No);
            }

            Doc.DocBuilder.LoadCtrViewDoc(this.mRichEditOnly1, new MemoryStream(info_OrderMain.Odr_BodyText));
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
            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;
            string msg = string.Format("确定通过:{0},{1}?{2}总金额为：{3}", info.Odr_No, info.Jia_Name, Environment.NewLine, info.Tot_Cost);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.CheckOrderPass(info))
                {
                    LoadSelfOrder();
                }
            }
        }

        private void Backward(ToolStripButton sender)
        {
            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;

            Win.FmCheckCommentInfo fm = new Win.FmCheckCommentInfo();
            fm.SelectValue += (obj)=> 
            {
                if (manager.CheckOrderNoPass(info, obj.ToString()))
                {
                    LoadSelfOrder();
                }
            };

            fm.ShowDialog();

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

            Doc.DocBuilder.PrintDocPreview(new MemoryStream(info.Odr_BodyText), Doc.DocBuilder.ReportName);
        }

        protected override void SetTabControls()
        {
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.tabControlSeq.FirstControlFocus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode) { return; }

            LoadSelfOrder();
        }


        /// <summary>
        /// 加载自己下一级的员工
        /// </summary>
        private void LoadSelfOrder()
        {
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;
            mRichEditOnly1.ResetText();
            List<Model.Info_OrderMain> list = manager.FindChildNeedCheckOrder(user.Employ_Code);
            ucOrderList1.SetDataSource(list);
        }
    }
}
