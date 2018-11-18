using GaoShan.Sales.Logic;
using GaoShan.Sales.Model;
using Miles.Framework.UI.Forms;
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
    public partial class FmStoreInDir : Miles.Framework.UI.Forms.FmMdi
    {
        StoreManager manager = new StoreManager();

        protected override void InitToolBtn()
        {
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToXLS, "导出联络单");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToCSV, "导出配套表");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "完成");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");

            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "运输单预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmStoreInDir()
        {
            InitializeComponent();
            this.mDataGrid1.CurrentRowChanged += MDataGrid1_CurrentRowChanged;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        private void MDataGrid1_CurrentRowChanged(object sender, EventArgs e)
        {
            mDataGridItem.Clear();
            if (this.mDataGrid1.CurrentRow == null) { return; }
            Model.Info_store_in info = this.mDataGrid1.GetCurrentEntity() as Model.Info_store_in;
            mDataGridItem.SetDataSource<Model.Info_store_in_item>(info.Items);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadNotDoneIn();
        }

        private void LoadNotDoneIn()
        {
            mDataGridItem.Clear();
            mDataGrid1.Clear();
            List<Model.Info_store_in> ltIn = manager.FindNotDoneInDir();
            mDataGrid1.SetDataSource<Model.Info_store_in>(ltIn);
    
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.DocumentAdd)
            {
                DocumentAdd(sender);
            }
            //else if (buttonType == ButtonType.ExportToXLS)
            //{
            //    ExportToXLS(sender);
            //}
            //else if (buttonType == ButtonType.ExportToCSV)
            //{
            //    ExportToCSV(sender);
            //}
            else if (buttonType == ButtonType.DocumentRemove)
            {
                DocumentRemove(sender);
            }
            else if (buttonType == ButtonType.Commit)
            {
                Commit(sender);
            }
            //else if (buttonType == ButtonType.Check)
            //{
            //    Check(sender);
            //}
        }

        private void DocumentAdd(ToolStripButton sender)
        {
            Model.Info_store_in info = new Model.Info_store_in();
            //info.LinkBill_Id=
            info.Oper_Date = DateTime.Now;
            info.StoreIn_Type = (int)Enum.InStoreType.DirIn;
            mDataGrid1.AddItem<Model.Info_store_in>(info);

            mDataGrid1.CurrentCell = mDataGrid1[0, mDataGrid1.Rows.Count - 1];
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

                mDataGridItem.AddItem<Model.Info_store_in_item>(item);
            };
            fm.ShowDialog();
        }


        private void DocumentRemove(ToolStripButton sender)
        {
            if (this.mDataGrid1.CurrentRow == null) { return; }
            Model.Info_store_in info = this.mDataGrid1.GetCurrentEntity() as Model.Info_store_in;
            string msg = string.Format("确定删除:【{0}】入库单?", info.Oper_Date.ToString("g"));
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.RemoveIn(info))
                {
                    LoadNotDoneIn();
                    this.SetButtonClickResultTip(sender, "删除成功");
                }
            }
        }

        int storeState = (int)Enum.StoreState.Normal;
        private void GetLastStoreState()
        {
            storeState = manager.GetStoreState();
        }

        private void Commit(ToolStripButton sender)
        {
            GetLastStoreState();
            if (storeState != (int)Enum.StoreState.Normal)
            {
                MessageBox.Show("当前正在盘库状态，不能进行出入库等操作");
                return;
            }

            if (this.mDataGrid1.CurrentRow == null) { return; }
            Model.Info_store_in info = this.mDataGrid1.GetCurrentEntity() as Model.Info_store_in;
            string msg = string.Format("确定提交:【{0}】入库单?", info.Oper_Date.ToString("g"));
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.CommitIn(info))
                {
                    LoadNotDoneIn();
                    this.SetButtonClickResultTip(sender, "提交成功");
                }
            }
        }

        protected override void Save(ToolStripButton sender)
        {
            if (this.mDataGrid1.CurrentRow == null) { return; }
            Model.Info_store_in info = this.mDataGrid1.GetCurrentEntity() as Model.Info_store_in;
            info.Items = this.mDataGridItem.GetDataSource<Model.Info_store_in_item>();

            decimal sumQty = info.Items.Sum(x => x.Mtl_Qty);

            if (sumQty == 0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mDataGridItem, "入库数量不能都为空", 1000);
                return;
            }

            if (manager.SaveIn(info))
            {
                LoadNotDoneIn();
                this.SetButtonClickResultTip(sender, "保存成功");
            }
        }



    }
}
