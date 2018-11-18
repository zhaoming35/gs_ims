using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Win
{
    /// <summary>
    /// 废弃了
    /// </summary>
    public partial class FmOrderNoSelect : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public Func<string, List<Model.Bu_OrderNoSelect>> FindOrderNoList;
        public FmOrderNoSelect()
        {
            InitializeComponent();
            this.btnQuery.Click += BtnQuery_Click;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderNo.Text)) { return; }
            if (FindOrderNoList == null) { return; }

            List<Model.Bu_OrderNoSelect> list = FindOrderNoList(txtOrderNo.Text);
            mDataGrid1.SetDataSource<Model.Bu_OrderNoSelect>(list);

        }

        protected override bool BtnOkClick()
        {
            if (mDataGrid1.CurrentRow == null) { return false; }

            Model.Bu_OrderNoSelect info = mDataGrid1.GetCurrentEntity() as Model.Bu_OrderNoSelect;

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
