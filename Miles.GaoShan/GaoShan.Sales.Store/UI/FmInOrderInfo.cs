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
    public partial class FmInOrderInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        public FmInOrderInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1是订单入库，2是直接入库
        /// </summary>
        //public int StoreInType { get; set; }

        public FmInOrderInfo(Model.Info_store_in info) : base(info)
        {
            InitializeComponent();
            //Column4.DefaultCellStyle.BackColor = Color.Yellow;
        }

        protected override void LazyInit()
        {
            Model.Info_store_in info = this.modelObj as Model.Info_store_in;
            this.SetDataBind(info);
            info.Items = manager.GetInItems(info.LinkBill_Id);

            ucInOrderItem1.SetDataSource(info);
        }

        protected override bool BtnOkClick()
        {
            if (!ucInOrderItem1.Save(null))
            {
                return false;
            }

            DoSelectValueEvent(ucInOrderItem1.CurrentSelectValue);
            return true;
        }
    }
}
