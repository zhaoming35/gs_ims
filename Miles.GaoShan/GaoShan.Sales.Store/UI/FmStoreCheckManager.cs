using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.Store.UI
{
    public partial class FmStoreCheckManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        int storeState = -1;

        Report.FmStoreCheckManagerReport orderPrint = null;
        protected override void InitToolBtn()
        {
            orderPrint = new Report.FmStoreCheckManagerReport();
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Locked, "开始盘库");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印盘库单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "提交盘库单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.UnLocked, "取消盘库");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmStoreCheckManager()
        {
            InitializeComponent();
            mDataGridItem.RowPrePaint += MDataGridItem_RowPrePaint;
            this.cmbMtlInfo1.SelectItemEvent += Cmb_SelectedValueChanged;
            this.cmbMtlKind1.SelectItemEvent += Cmb_SelectedValueChanged;
        }


        private void Cmb_SelectedValueChanged(object obj)
        {

            if (mDataGridItem.DataSource == null) { return; }

            if (cmbMtlKind1.SelectKey == null && cmbMtlInfo1.SelectKey == null)
            {
                mDataGridItem.SetFilter<Model.Info_store_check>(null);
            }
            else
            {
                mDataGridItem.SetFilter<Model.Info_store_check>(delegate (Model.Info_store_check p)
                {
                    if (cmbMtlKind1.SelectKey != null)
                    {
                        GaoShan.Sales.Model.Tb_mtl_kind kind = cmbMtlKind1.SelectedItem as GaoShan.Sales.Model.Tb_mtl_kind;
                        if (kind.Kind_Level == 0)
                        {
                            List<string> childs = GaoShan.Sales.Cache.LogicCache.DicChildKind[kind.Kind_Code];
                            var query = from item in childs
                                        where item.Contains(p.Kind_Code)
                                        select item;

                            if (query.Count() < 1)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (!p.Kind_Code.Equals(cmbMtlKind1.SelectKey))
                            {
                                return false;
                            }
                        }
                    }

                    if (cmbMtlInfo1.SelectKey != null && !p.Mtl_Code.Equals(cmbMtlInfo1.SelectKey))
                    {
                        return false;
                    }

                    return true;

                });

            }
        }

        private void MDataGridItem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            ShowLimitColor();
        }

        protected override void PrintPreview(ToolStripButton sender)
        {
            List<Model.Info_store_check> list = mDataGridItem.GetDataSource<Model.Info_store_check>();
            if (list != null)
            {
                Model.Bu_store_check buStoreCheck = GetCheckReportInfo(list);
                //orderPrint.PrintPreview(buStoreCheck);
                GaoShan.Sales.UI.Win.FmReoGridShow fmReoGridShow = new GaoShan.Sales.UI.Win.FmReoGridShow();

                fmReoGridShow.SetReportBind(new Report.FmStoreCheckManagerReport(), buStoreCheck);
                fmReoGridShow.ShowDialog();
            }


        }

        private Bu_store_check GetCheckReportInfo(List<Info_store_check> list)
        {
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;
            Bu_store_check info = new Bu_store_check();
            info.Items = list;
            info.Oper_Code= user.Employ_Code;
            info.Oper_Date= DateTime.Now;
            return info;
        }

        protected override void PrintDialog(ToolStripButton sender)
        {
            using (PageSetupDialog psd = new PageSetupDialog())
            {
                System.Drawing.Printing.PageSettings ps = orderPrint.GetPrintSetting();

                if (ps != null)
                    psd.PageSettings = ps;

                psd.AllowMargins = true;
                psd.AllowPrinter = true;
                psd.AllowPaper = true;
                psd.EnableMetric = true;

                if (psd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    orderPrint.SetPageSetting(psd.PageSettings);
                }
            }
        }

        protected override void Print(ToolStripButton sender)
        {
            List<Model.Info_store_check> list = mDataGridItem.GetDataSource<Model.Info_store_check>();
            if (list != null)
            {
                Model.Bu_store_check buStoreCheck = GetCheckReportInfo(list);
                orderPrint.Print(buStoreCheck);
            }
               
        }

        protected override void DefineButtonClick(ToolStripButton sender, Miles.Framework.UI.Forms.ButtonType buttonType)
        {
            if (buttonType == Miles.Framework.UI.Forms.ButtonType.Locked)
            {
                DoLocked();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Check)
            {
                DoCheck(sender);
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.UnLocked)
            {
                DoUnLocked();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Reload)
            {
                DoReload(sender);
            }
        }

        private void DoReload(ToolStripButton sender)
        {
            LoadAll();
        }

        private void DoUnLocked()
        {
            GetLastStoreState();

            if (storeState == (int)Enum.StoreState.Normal)
            {
                MessageBox.Show("还没有开始盘库操作");
                return;
            }

            if (storeState == (int)Enum.StoreState.Commit)
            {
                MessageBox.Show("盘库已经提交操作,不能取消盘库");
                return;
            }

            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo("确定要取消盘库,放弃当前交盘点单?"))
            {
                if (manager.CancelCheckStore())
                {
                    LoadStoreCheck();
                    GetLastStoreState();
                }
            }


        }

        private void DoCheck(ToolStripButton sender)
        {

            mDataGridItem.EndEdit();
            List<Model.Info_store_check> listSave = mDataGridItem.GetDataSource<Model.Info_store_check>();
            if (!manager.SaveCheckStore(listSave))
            {
                MessageBox.Show("保存失败");
                return;
            }

            GetLastStoreState();

            if (storeState == (int)Enum.StoreState.Normal)
            {
                MessageBox.Show("还没有开始盘库操作");
                return;
            }

            if (storeState == (int)Enum.StoreState.Commit)
            {
                MessageBox.Show("盘库已经提交操作");
                return;
            }


            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo("确定要提交盘点单?"))
            {
                List<Model.Info_store_check> list = mDataGridItem.GetDataSource<Model.Info_store_check>();
                if (manager.CommitCheckStore(list))
                {
                    this.SetButtonClickResultTip(sender, "提交成功");
                    GetLastStoreState();
                }

            }
        }

        private void DoLocked()
        {
            GetLastStoreState();
            if (storeState != (int)Enum.StoreState.Normal)
            {
                MessageBox.Show("当前已经是盘库状态");
                return;
            }

            if (manager.StartCheckStore())
            {
                LoadStoreCheck();
                GetLastStoreState();
            }
        }

        protected override void Save(ToolStripButton sender)
        {
            GetLastStoreState();

            if (storeState == (int)Enum.StoreState.Normal)
            {
                MessageBox.Show("还没有开始盘库操作");
                return;

            }

            if (storeState == (int)Enum.StoreState.Commit)
            {
                MessageBox.Show("盘库已经提交操作,不能修改数据");
                return;

            }


            mDataGridItem.EndEdit();
            List<Model.Info_store_check> list = mDataGridItem.GetDataSource<Model.Info_store_check>();
            if (manager.SaveCheckStore(list))
            {
                this.SetButtonClickResultTip(sender, "保存成功");
                LoadStoreCheck();
                GetLastStoreState();
            }
        }

        protected override void LazyInit()
        {
            cmbMtlKind1.LoadData();
            cmbMtlInfo1.LoadData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadAll();
        }

        private void LoadAll()
        {
            GetLastStoreState();
            LoadStoreCheck();
        }

        private void GetLastStoreState()
        {
            storeState = manager.GetStoreState();
            if (storeState == (int)Enum.StoreState.LockStore)
            {
                lblState.Text = "开始盘库状态";
            }
            else if (storeState == (int)Enum.StoreState.Commit)
            {
                lblState.Text = "盘库提交状态";
            }
            else if (storeState == (int)Enum.StoreState.Normal)
            {
                lblState.Text = "未盘库状态";
            }
        }

        private void LoadStoreCheck()
        {
            List<Model.Info_store_check> list = manager.GetCheckStore();
            this.mDataGridItem.SetDataSource<Model.Info_store_check>(list);

        }

        private void ShowLimitColor()
        {
            if (this.mDataGridItem.DataSource != null)
            {
                foreach (DataGridViewRow drDGV in this.mDataGridItem.Rows)
                {
                    Model.Info_store_check info = drDGV.DataBoundItem as Model.Info_store_check;

                    if (info.Mtl_Qty < info.Check_Qty)
                    {
                        drDGV.Cells["ColumnUpdate"].Style.BackColor = System.Drawing.Color.Red;
                    }

                    if (info.Mtl_Qty > info.Check_Qty)
                    {
                        drDGV.Cells["ColumnUpdate"].Style.BackColor = System.Drawing.Color.Green;
                    }

                }

            }
        }



    }
}
