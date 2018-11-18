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

namespace GaoShan.Sales.UI.Gen
{
    public partial class UCGenInfo : UCBase
    {
        Logic.GenManager manager = new Logic.GenManager();

        public UCGenInfo()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }

            Model.Info_fin_order_item info = mDataGrid1.GetCurrentEntity() as Model.Info_fin_order_item;

            FmGenItem fmGenUpdate = new FmGenItem(info);
            fmGenUpdate.SelectValue += (object obj) =>
            {
                mDataGrid1.EditCurrentItem<Model.Info_fin_order_item>((Model.Info_fin_order_item)obj);

            };
            fmGenUpdate.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmGenItem fmGenAdd = new FmGenItem();
            fmGenAdd.SelectValue += (object obj) =>
            {
                mDataGrid1.AddItem<Model.Info_fin_order_item>((Model.Info_fin_order_item)obj);
            };
            fmGenAdd.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }
            mDataGrid1.DeleteCurrentItem<Model.Info_fin_order_item>();
        }

        public override void SetTabControls(Miles.Framework.UI.Forms.TabControlSeq tabControlSeq)
        {
            this.tabControlSeq.AddContainer(this.groupBox1);
        }

        public override bool Save(ToolStripButton sender)
        {
            Dictionary<Control, string> dicEmptyCtrs = this.GetValidEmptyCtrs();
            if (dicEmptyCtrs.Count > 0)
            {
                foreach (var ctr in dicEmptyCtrs.Keys)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(ctr, dicEmptyCtrs[ctr], 1000);
                    return false;
                }
            }

            if (mDataGrid1.DataSource == null || mDataGrid1.GetDataSource<Model.Info_fin_order_item>().Count < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mDataGrid1, "产品列表不能为空", 1000);
                return false;
            }

            Model.Info_fin_order_gen info = this.GetDataBind<Model.Info_fin_order_gen>();

            Model.Info_fin_order_gen updateNew = this.selectValue as Model.Info_fin_order_gen;

            updateNew.Deliver_Date = info.Deliver_Date;
            //updateNew.Freight_Cost = info.Freight_Cost;
            updateNew.Gen_Date = DateTime.Now;
            updateNew.Odr_Cost = info.Odr_Cost;
            updateNew.Part_Cost = info.Part_Cost;
            updateNew.Remark = info.Remark;
            updateNew.Sales_Cost = info.Sales_Cost;
            updateNew.Supplier_Info = info.Supplier_Info;
            updateNew.Tax_Cost = info.Tax_Cost;
            updateNew.Discount_Cost = info.Discount_Cost;
            updateNew.Rent_Cost = info.Rent_Cost;

            updateNew.Items = mDataGrid1.GetDataSource<Model.Info_fin_order_item>();

            return manager.SaveGenAll(updateNew);
        }

        public override void Clear()
        {
            base.Clear();
            mDataGrid1.Clear();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);
            base.selectValue = dataSource;
            if (dataSource == null) { return; }


            Model.Info_fin_order_gen info = dataSource as Model.Info_fin_order_gen;
            //this.Tag = info.Odr_Id;
            this.SetDataBind(dataSource);

            //商品列表添加
            mDataGrid1.SetDataSource<Model.Info_fin_order_item>(info.Items);

        }

    }
}
