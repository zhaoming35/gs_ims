using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.Store.UI.UC
{
    public partial class UCInOrderItem : GaoShan.Sales.UI.UC.UCBase
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        public UCInOrderItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1是订单出库，2是直接出库
        /// </summary>
        //public int StoreOutType { get; set; }

        protected override void LazyInit()
        {
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;

        }

        public override void Clear()
        {
            base.Clear();
            mDataGridItem.Clear();
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            base.SetDataSource(dataSource);
            this.selectValue = dataSource;

            Model.Info_store_in info = dataSource as Model.Info_store_in;
            if (info == null) { return; }

            //dicMatchTbItems = matchTbManager.FindDoneLinkMatchTbItems(info.LinkBill_Id);
            //for(int i=0;i<info.Items.Count;i++)
            //{
            //    string mtlCode = info.Items[i].Mtl_Code;
            //    info.Items[i].Plan_OutQty = dicMatchTbItems.ContainsKey(mtlCode) ? dicMatchTbItems[mtlCode].Value : 0;
            //}

            mDataGridItem.SetDataSource<Model.Info_store_in_item>(info.Items);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGridItem.CurrentRow == null) { return; }
            Model.Info_store_in_item item = mDataGridItem.GetCurrentEntity() as Model.Info_store_in_item;

            string msg = string.Format("确定删除:{0}?", item.Mtl_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                mDataGridItem.DeleteCurrentItem<Model.Info_store_in_item>();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmMtlSelect fm = new FmMtlSelect();
            fm.SelectValue += (obj) =>
            {
                Info_mtl_item mtl = obj as Info_mtl_item;
                Model.Info_store_in_item item = Miles.Coro.Common.Utils.CopyToOther<Info_mtl_item, Model.Info_store_in_item>(mtl);
                foreach (var v in mDataGridItem.GetDataSource<Model.Info_store_in_item>())
                {
                    if (v.Mtl_Code.Equals(mtl.Mtl_Code))
                    {
                        MessageBox.Show(string.Format("已存在物料：{0}", mtl.Mtl_Name));
                        return;
                    }
                }
                mDataGridItem.AddItem<Model.Info_store_in_item>(item);
            };
            fm.ShowDialog();
        }



        public override bool Save(ToolStripButton sender)
        {
            List<Model.Info_store_in_item> ltOutItem = mDataGridItem.GetDataSource<Model.Info_store_in_item>();
            decimal sumQty = ltOutItem.Sum(x => x.Mtl_Qty);

            if (sumQty == 0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mDataGridItem, "入库数量不能都为空", 1000);
                return false;
            }

            Model.Info_store_in info = this.dataSource as Model.Info_store_in;
            info.Items = ltOutItem;

            if (!manager.SaveIn(info))
            {
                return false;
            }

            DoSelectValueEvent(info);
            return true;
        }


    }
}
