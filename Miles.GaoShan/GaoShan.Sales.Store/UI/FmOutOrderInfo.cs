using GaoShan.Sales.Model;
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
    public partial class FmOutOrderInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        public FmOutOrderInfo()
        {
            InitializeComponent();
        }

        public FmOutOrderInfo(Model.Info_store_out info) : base(info)
        {
            InitializeComponent();
            //Column4.DefaultCellStyle.BackColor = Color.Yellow;
        }

        protected override void LazyInit()
        {
            Model.Info_store_out info = this.modelObj as Model.Info_store_out;
            this.SetDataBind(info);
            info.Items = manager.GetOutItems(info.LinkBill_Id);
            ucOutOrderItem1.SetDataSource(info);
        }


        protected override bool BtnOkClick()
        {
            

            Model.Info_store_out info = this.modelObj as Model.Info_store_out;
            //info.Items = ltOutItem;
            //info.StoreOut_Type = StoreOutType;

            //if (!manager.AddStoreOut(info))
            //{
            //    return false;
            //}

            if (!ucOutOrderItem1.Save(null))
            {
                return false;
            }

            DoSelectValueEvent(ucOutOrderItem1.CurrentSelectValue);
            return true;
        }


    }
}
