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

namespace GaoShan.Sales.UI.LinkBill
{
    public partial class FmOrderLinkRecordQuery : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.LinkBillManager manager = new Logic.LinkBillManager();
        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "项目联络单预览");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmOrderLinkRecordQuery()
        {
            InitializeComponent();
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Document)
            {
                Document(sender);
            }
        }

        protected override void Query(ToolStripButton sender)
        {
            if (beginDate.Value == null && endDate.Value == null && string.IsNullOrEmpty(txtOrderNo.Text))
            {
                MessageBox.Show("请输入查询条件");
                return;
            }

            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_link_bill> list = manager.QuerySelfLinkRecord(user.Employ_Code, beginDate.Value, endDate.Value, txtOrderNo.Text);
            mDataGrid1.SetDataSource<Model.Info_link_bill>(list);
        }

        private void Document(ToolStripButton sender)
        {

            if (this.mDataGrid1.CurrentRow== null) { return; }

            Model.Info_link_bill info = mDataGrid1.GetCurrentEntity() as Model.Info_link_bill;
            if (info.Items.Count == 0)
            {
                info.Items = manager.GetLinkItems(info.LinkBill_Id);
            }
            Win.FmReoGridShow fmReoGridShow = new Win.FmReoGridShow();
            fmReoGridShow.SetReportBind(new Report.FmLinkBillManagerReport(), info);
            fmReoGridShow.ShowDialog();
        }



    }
}
