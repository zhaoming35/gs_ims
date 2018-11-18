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

namespace GaoShan.Sales.UI.Gen
{
    public partial class FmOrderGenRecordQuery : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.GenManager manager = new Logic.GenManager();
        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "合同摘要预览");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmOrderGenRecordQuery()
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

            List<Model.Info_fin_order_gen> list = manager.QuerySelfGenRecord(user.Employ_Code, beginDate.Value, endDate.Value, txtOrderNo.Text);
            mDataGrid1.SetDataSource<Model.Info_fin_order_gen>(list);
        }

        private void Document(ToolStripButton sender)
        {

            if (this.mDataGrid1.CurrentRow== null) { return; }

            Model.Info_fin_order_gen info = mDataGrid1.GetCurrentEntity() as Model.Info_fin_order_gen;
            if (info.Items.Count == 0)
            {
                info.Items = manager.GetGenItems(info.Odr_No);
            }
            Win.FmReoGridShow fmReoGridShow = new Win.FmReoGridShow();
            fmReoGridShow.SetReportBind(new Report.FmOrderGenManagerReport(), info);
            fmReoGridShow.ShowDialog();
        }



    }
}
