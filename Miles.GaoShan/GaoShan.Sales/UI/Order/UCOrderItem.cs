using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.UI.Order
{
    public partial class UCOrderItem : UCBase
    {
        public List<Info_order_item> Items
        {
            get { return mDataGrid1.GetDataSource<Model.Info_order_item>(); }
        }

        public string OdrNo { get => odrNo; set => odrNo = value; }

        public UCOrderItem()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        string odrNo = "";
        private Info_order_item ConvertPro2Item(Info_product_info info)
        {
            Model.Info_order_item item = new Model.Info_order_item();
            item.Odr_No = OdrNo;
            item.Item_Seq = mDataGrid1.Rows.Count + 1;
            item.Product_Name = info.Product_Name;
            item.Product_Unit = info.Product_Unit;
            item.Product_Count = info.Procuct_Count;

            Bu_ItemSpec itemSpec = new Bu_ItemSpec();
            foreach (var v in info.Items)
            {
                itemSpec.AddItem(v);
            }

            item.ItemSpec = itemSpec;
            item.Item_Type = info.Item_Type;

            return item;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmOrderItemInfo fmOrderItemInfo = new FmOrderItemInfo();
            fmOrderItemInfo.SelectValue += (obj) => {
                Model.Info_product_info infoPro = obj as Model.Info_product_info;
                Model.Info_order_item item = ConvertPro2Item(infoPro);
                mDataGrid1.AddItem<Model.Info_order_item>(item);
            };
            fmOrderItemInfo.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }
            Model.Info_order_item info = mDataGrid1.GetCurrentEntity() as Model.Info_order_item;
            FmOrderItemInfo fmOrderItemInfo = new FmOrderItemInfo(info);
            fmOrderItemInfo.SelectValue += (obj) =>
            {
                Model.Info_product_info infoPro = obj as Model.Info_product_info;
                Model.Info_order_item item = ConvertPro2Item(infoPro);
                mDataGrid1.EditCurrentItem<Model.Info_order_item>(item);
            };
            fmOrderItemInfo.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }
            mDataGrid1.DeleteCurrentItem<Model.Info_order_item>();
        }

        public override void Clear()
        {
            base.Clear();
            this.mDataGrid1.SetDataSource<Model.Info_order_item>(new List<Model.Info_order_item>());
            mDataGrid1.Clear();

        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);
            base.selectValue = dataSource;
            if (dataSource == null) { return; }

            Model.Info_OrderMain info = dataSource as Model.Info_OrderMain;
            OdrNo = info.Odr_No;
            //商品列表添加
            mDataGrid1.SetDataSource<Model.Info_order_item>(info.Items);

        }

        public override void SetBindCtrNoEnabled()
        {
            base.SetBindCtrNoEnabled();
            this.toolStripItem.Visible = false;
            mDataGrid1.ReadOnly = true;
        }

    }
}
