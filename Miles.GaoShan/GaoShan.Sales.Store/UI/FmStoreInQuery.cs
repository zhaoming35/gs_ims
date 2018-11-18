using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Store.UI
{
    public partial class FmStoreInQuery : Miles.Framework.UI.Forms.FmMdi
    {
        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmStoreInQuery()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            //beginDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd 00:00:00");
            //endDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd 23:59:59");
        }

        Logic.StoreManager manager = new Logic.StoreManager();

        protected override void Query(ToolStripButton sender)
        {
            if (beginDate.Value == null && endDate.Value == null && string.IsNullOrEmpty(txtOrderNo.Text))
            {
                MessageBox.Show("请输入查询条件");
                return;
            }
            //Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Q_store_in_item> list = manager.QueryStoreInRecord(beginDate.Value, endDate.Value, txtOrderNo.Text);
            mDataGrid1.SetDataSource<Model.Q_store_in_item>(list);
        }

    }
}
