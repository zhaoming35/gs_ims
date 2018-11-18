using Miles.Framework.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.MatchTb.UI.MatchTb
{
    public partial class FmMatchTbQuery : Miles.Framework.UI.Forms.FmMdi
    {
        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "配套表预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmMatchTbQuery()
        {
            InitializeComponent();
        }

        Logic.MatchTbManager manager = new Logic.MatchTbManager();
        protected override void Query(ToolStripButton sender)
        {
            if (beginDate.Value == null && endDate.Value == null && string.IsNullOrEmpty(txtOrderNo.Text))
            {
                MessageBox.Show("请输入查询条件");
                return;
            }
            //Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_matchTb> list = manager.QueryMatchTbRecord(beginDate.Value, endDate.Value, txtOrderNo.Text);
            mDataGrid1.SetDataSource<Model.Info_matchTb>(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Document)
            {
                Document(sender);
            }
        }

        private void Document(ToolStripButton sender)
        {

            if (this.mDataGrid1.CurrentRow == null) { return; }

            Model.Info_matchTb info = mDataGrid1.GetCurrentEntity() as Model.Info_matchTb;

            if (info.Items.Count == 0)
            {
                info.Items = manager.GetMatchTbItems(info.MatchTb_Id);
            }

            GaoShan.Sales.UI.Win.FmReoGridShow fmReoGridShow = new GaoShan.Sales.UI.Win.FmReoGridShow();
            fmReoGridShow.SetReportBind(new GaoShan.Sales.UI.Report.FmMatchTbManagerReport(), info);
            fmReoGridShow.ShowDialog();
        }


    }
}
