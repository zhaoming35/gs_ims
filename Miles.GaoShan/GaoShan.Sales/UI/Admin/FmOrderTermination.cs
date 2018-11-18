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
using Miles.Framework.UI.Forms;
using Xceed.Words.NET;

namespace GaoShan.Sales.UI.Admin
{
    public partial class FmOrderTermination : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.OrderManager manager = new Logic.OrderManager();
        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Stop, "终止合同");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }
        public FmOrderTermination()
        {
            InitializeComponent();
            this.ucOrderList1.SelectValueChange += UcOrderList1_SelectValueChange;
        }

        protected override void LazyInit()
        {
            beginDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd 00:00:00");
            endDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd 23:59:59");
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

        protected override void Print(ToolStripButton sender)
        {
            if (this.ucOrderList1.CurrentSelectValue == null) { return; }

            Model.Info_OrderMain info = ucOrderList1.CurrentSelectValue as Model.Info_OrderMain;

            Doc.DocBuilder docBuilder = new Doc.DocBuilder(info);

            Doc.DocBuilder.PrintDoc(docBuilder.ToStream(info.Odr_Clause), Doc.DocBuilder.ReportName,true);
        }

        protected override void Query(ToolStripButton sender)
        {
            List<Model.Info_OrderMain> list = manager.QueryTerminationOrderRecord(beginDate.Value,endDate.Value);
            ucOrderList1.SetDataSource(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if(buttonType== ButtonType.Stop)
            {
                Stop(sender);
            }
        }

        private void Stop(ToolStripButton sender)
        {

            FmOrderSelect fmOrderNo = new FmOrderSelect();

            fmOrderNo.SelectValue += (obj) =>
            {
                Model.Info_OrderMain info = obj as Model.Info_OrderMain;
                string msg = string.Format("确定终止:{0},{1}?", info.Odr_No, info.Odr_Prt_Name);
                if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
                {
                    if (manager.OrderTermination(info))
                    {
                        Query(null);
                    }
                }

            };

            fmOrderNo.ShowDialog();
        }
    }
}
