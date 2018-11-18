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
    public partial class FmStoreCheckPermitManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        int storeState = -1;

        //GaoShan.Sales.UI.Report.ReportTemplateBase orderPrint = null;
        protected override void InitToolBtn()
        {
            //orderPrint = new Invoices.FmStoreCheckManagerPrint();
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "通过盘库单");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Backward, "驳回盘库单");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmStoreCheckPermitManager()
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

        protected override void DefineButtonClick(ToolStripButton sender, Miles.Framework.UI.Forms.ButtonType buttonType)
        {
            if (buttonType == Miles.Framework.UI.Forms.ButtonType.Check)
            {
                DoCheck();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Backward)
            {
                DoBackward();
            }
            else if (buttonType == Miles.Framework.UI.Forms.ButtonType.Reload)
            {
                Reload();
            }
        }

        private void Reload()
        {
            LoadAll();
        }

        private void DoBackward()
        {
            GetLastStoreState();

            if (storeState != (int)Enum.StoreState.Commit)
            {
                MessageBox.Show("盘库单没有提交,不能审核操作");
                return;

            }

            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo("确定要驳回盘点单?"))
            {
                if (manager.RejectCheckStore())
                {
                    MessageBox.Show("驳回成功");
                    LoadStoreCheck();
                }

            }
        }


        private void DoCheck()
        {
            GetLastStoreState();

            if (storeState != (int)Enum.StoreState.Commit)
            {
                MessageBox.Show("盘库单没有提交,不能审核操作");
                return;

            }

            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo("确定要通过盘点单?"))
            {
                List<Model.Info_store_check> list = mDataGridItem.GetDataSource<Model.Info_store_check>();
                if (manager.PermitCheckStore(list))
                {
                    MessageBox.Show("通过成功");
                    LoadStoreCheck();
                }

            }
        }


        protected override void LazyInit()
        {
            cmbMtlKind1.LoadData();
            cmbMtlInfo1.LoadData();

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
