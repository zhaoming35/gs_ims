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
    public partial class FmStoreInOrderDone : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        public FmStoreInOrderDone()
        {
            InitializeComponent();
        }

        public FmStoreInOrderDone(Model.Info_link_bill info) : base(info)
        {
            InitializeComponent();
            //Column4.DefaultCellStyle.BackColor = Color.Yellow;
        }

        protected override void LazyInit()
        {
            Model.Info_link_bill info = this.modelObj as Model.Info_link_bill;

            List<Model.Info_store_in_item> ltOutItem = manager.GetInItems(info.LinkBill_Id);

            mDataGridItem.SetDataSource<Model.Info_store_in_item>(ltOutItem);

        }
        protected override bool BtnOkClick()
        {
            List<Model.Info_store_in_item> ltOutItem = mDataGridItem.GetDataSource<Model.Info_store_in_item>();
            decimal sumQty = ltOutItem.Sum(x => x.Already_InQty);

            if (sumQty == 0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mDataGridItem, "入库数量不能都为空", 1000);
                return false;
            }


            Model.Info_link_bill info = this.modelObj as Model.Info_link_bill;

            if (!manager.DoneBackOrder(info))
            {
                return false;
            }

            DoSelectValueEvent(info);
            return true;
        }

    }
}
