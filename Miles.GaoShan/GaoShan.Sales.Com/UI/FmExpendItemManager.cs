using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Com.UI
{
    public partial class FmExpendItemManager : Miles.Framework.UI.Forms.FmMdi
    {
        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmExpendItemManager()
        {
            InitializeComponent();
        }

        Logic.ExpendItemManager manager = new Logic.ExpendItemManager();

        protected override void LazyInit()
        {
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSave.Click += BtnSave_Click;

            List<Model.Tb_expend_item> list = manager.FindAll();
            mDataGrid1.SetDataSource<Model.Tb_expend_item>(list);
 
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<Model.Tb_expend_item> items = mDataGrid1.GetDataSource<Model.Tb_expend_item>();

            if (manager.Save(items))
            {
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip((ToolStripButton)sender, "保存成功");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }

            mDataGrid1.DeleteCurrentItem<Model.Tb_expend_item>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            mDataGrid1.AddItem<Model.Tb_expend_item>(new Model.Tb_expend_item());
        }
    }
}
