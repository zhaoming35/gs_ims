﻿using GaoShan.Sales.Logic;
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
    public partial class FmStoreOutOrder : Miles.Framework.UI.Forms.FmMdi
    {
        StoreManager manager = new StoreManager();
        Sales.Logic.LinkBillManager linkManager = new Sales.Logic.LinkBillManager();

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToXLS, "导出联络单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.ExportToCSV, "导出配套表");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "完成");
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

        public FmStoreOutOrder()
        {
            InitializeComponent();
            this.ucOutOrderList1.SelectValueChange += UcOutOrderList1_SelectValueChange;
        }

        private void UcOutOrderList1_SelectValueChange(object sender, object obj)
        {
            Model.Info_store_out update = ucOutOrderList1.CurrentSelectValue as Model.Info_store_out;
            ucOutOrderItem1.SetDataSource(update);
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadNeedCreateOut();
            LoadNotDoneOut();
        }

        private void LoadNeedCreateOut()
        {
            ucOutOrder1.Clear();
            List<Info_link_bill> list = linkManager.GetNeedCreateOutStore();
            ucOutOrder1.SetDataSource(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.DocumentAdd)
            {
                DocumentAdd(sender);
            }
            else if (buttonType == ButtonType.ExportToXLS)
            {
                ExportToXLS(sender);
            }
            else if (buttonType == ButtonType.ExportToCSV)
            {
                ExportToCSV(sender);
            }
            else if (buttonType == ButtonType.DocumentRemove)
            {
                DocumentRemove(sender);
            }
            else if (buttonType == ButtonType.Commit)
            {
                Commit(sender);
            }
            else if (buttonType == ButtonType.Check)
            {
                Check(sender);
            }
            else if (buttonType == ButtonType.Reload)
            {
                Reload(sender);
            }
        }

        private void Reload(ToolStripButton sender)
        {
            LoadNeedCreateOut();
            LoadNotDoneOut();
        }

        private void Check(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 0) { return; }
            if (ucOutOrder1.CurrentSelectValue == null) { return; }
            Info_link_bill link = ucOutOrder1.CurrentSelectValue as Info_link_bill;
            string msg = string.Format("确定完成:{0},{1}项目联络单?", link.Odr_No, link.LinkBill_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.DoneOut(link))
                {
                    LoadNeedCreateOut();
                    this.SetButtonClickResultTip(sender, "保存成功");
                }
            }
        }

        protected override void Save(ToolStripButton sender)
        {

            if (this.ucOutOrderItem1.CurrentSelectValue == null) { return; }
            if (ucOutOrderItem1.Save(sender))
            {
                LoadNotDoneOut();
                this.SetButtonClickResultTip(sender, "保存成功");
            }

            //if (this.ucOutOrderList1.CurrentSelectValue == null) { return; }
            //Model.Info_store_out info = ucOutOrderList1.CurrentSelectValue as Model.Info_store_out;
            //if (manager.SaveOut(info))
            //{
            //    LoadNotDoneOut();
            //    this.SetButtonClickResultTip(sender, "保存成功");
            //}
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

            if (this.ucOutOrderList1.CurrentSelectValue == null) { return; }
            Model.Info_store_out info = ucOutOrderList1.CurrentSelectValue as Model.Info_store_out;
            string msg = string.Format("确定提交:{0},{1}出库单?", info.Odr_No, info.LinkBill_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.CommitOut(info))
                {
                    LoadNotDoneOut();
                    this.SetButtonClickResultTip(sender, "提交成功");
                }
            }
        }

        private void DocumentRemove(ToolStripButton sender)
        {
            if (this.ucOutOrderList1.CurrentSelectValue == null) { return; }
            Model.Info_store_out info = ucOutOrderList1.CurrentSelectValue as Model.Info_store_out;
            string msg = string.Format("确定删除:{0},{1}出库单?", info.Odr_No, info.LinkBill_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.RemoveOut(info))
                {
                    LoadNotDoneOut();
                    this.SetButtonClickResultTip(sender, "删除成功");
                }
            }

        }

        private void ExportToXLS(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 0) { return; }
            if (ucOutOrder1.CurrentSelectValue == null) { return; }

            ucOutOrder1.ExportLink();
        }

        private void ExportToCSV(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 0) { return; }
            if (ucOutOrder1.CurrentSelectValue == null) { return; }

            ucOutOrder1.ExportMatchTb();
        }

        private void DocumentAdd(ToolStripButton sender)
        {
            if (tabControl1.SelectedIndex != 0) { return; }
            if (ucOutOrder1.CurrentSelectValue == null) { return; }
            Info_link_bill link = ucOutOrder1.CurrentSelectValue as Info_link_bill;
            Model.Info_store_out info = Miles.Coro.Common.Utils.CopyToOther<Info_link_bill, Model.Info_store_out>(link);

            info.StoreOut_Type= (int)Enum.OutStoreType.OrderOut;
            FmOutOrderInfo fm = new FmOutOrderInfo(info);

            fm.SelectValue += (obj) =>
            {
                LoadNotDoneOut();
                tabControl1.SelectedIndex = 1;
            };
            fm.ShowDialog();
        }

        private void LoadNotDoneOut()
        {
 
            ucOutOrderItem1.Clear();
            List<Model.Info_store_out> ltOut = manager.FindNotDoneOutOrder();
            ucOutOrderList1.SetDataSource(ltOut);
        }
    }
}
