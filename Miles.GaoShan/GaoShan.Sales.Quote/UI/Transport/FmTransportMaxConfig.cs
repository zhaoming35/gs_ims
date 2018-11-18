using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Quote.UI
{
    public partial class FmTransportMaxConfig : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.FinTransportMaxManager manager = new Logic.FinTransportMaxManager();

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmTransportMaxConfig()
        {
            InitializeComponent();
            this.btnAddItem.Click += BtnAddItem_Click;
            this.btnEditItem.Click += BtnEditItem_Click;
            this.btnDeleteItem.Click += BtnDeleteItem_Click;

        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }
            Model.Tb_fin_transport_max info = mDataGrid1.GetCurrentEntity() as Model.Tb_fin_transport_max;
            string msg = string.Format("确定删除:{0},{1}?", info.Tent_MainSpec,info.Tent_Width);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    mDataGrid1.DeleteCurrentItem<Model.Tb_fin_transport_max>();
                }
            }
         
        }
        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }

            Model.Tb_fin_transport_max old = mDataGrid1.GetCurrentEntity() as Model.Tb_fin_transport_max;

            FmTransportMaxInfo fm = new FmTransportMaxInfo(old);
            fm.SelectValue += (obj) =>
            {
                Model.Tb_fin_transport_max info = obj as Model.Tb_fin_transport_max;
                mDataGrid1.EditCurrentItem<Model.Tb_fin_transport_max>(info);

            };
            fm.ShowDialog();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            FmTransportMaxInfo fm = new FmTransportMaxInfo();
            fm.SelectValue += (obj) => 
            {
                Model.Tb_fin_transport_max info = obj as Model.Tb_fin_transport_max;
                mDataGrid1.AddItem<Model.Tb_fin_transport_max>(info);

            };
            fm.ShowDialog();
        }

        protected override void LazyInit()
        {
            LoadAll();
        }

        private void LoadAll()
        {
            List<Model.Tb_fin_transport_max> list = manager.FindAll();
            mDataGrid1.SetDataSource<Model.Tb_fin_transport_max>(list);
        }
    }
}
