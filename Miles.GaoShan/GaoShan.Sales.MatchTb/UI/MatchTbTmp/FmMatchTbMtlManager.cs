using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.MatchTb.UI
{
    public partial class FmMatchTbMtlManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.MatchTbTmpManager manager = new Logic.MatchTbTmpManager();
        Logic.MtlManager mtlManager = new Logic.MtlManager();
        public FmMatchTbMtlManager()
        {
            InitializeComponent();
            this.mDataGridMain.CurrentRowChanged += MDataGridMain_CurrentRowChanged;
            this.btnAddMain.Click += BtnAddMain_Click;
            this.btnEditMain.Click += BtnEditMain_Click;
            this.btnDeleteMain.Click += BtnDeleteMain_Click;
            this.btnAddItem.Click += BtnAddItem_Click;
            this.btnEditItem.Click += BtnEditItem_Click;
            this.btnDeleteItem.Click += BtnDeleteItem_Click;
            this.btnSaveItem.Click += BtnSaveItem_Click;
            this.txtSearchMain.TextChanged += TxtSearchMain_TextChanged;
            this.txtSearchItem.TextChanged += TxtSearchItem_TextChanged;
        }

        private void TxtSearchItem_TextChanged(object sender, EventArgs e)
        {
            if (this.mDataGridItem.DataSource == null) { return; }

            if (!Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchItem.Text))
            {
                mDataGridItem.SetFilter<Model.Bu_MatchTb_Item>(delegate (Model.Bu_MatchTb_Item p)
                { return p.Mtl_Code.Contains(txtSearchItem.Text) || p.Mtl_Name.Contains(txtSearchItem.Text); });
            }
            else
            {
                mDataGridItem.SetFilter<Model.Bu_MatchTb_Item>(null);
            }
        }

        private void TxtSearchMain_TextChanged(object sender, EventArgs e)
        {
            if (this.mDataGridMain.DataSource == null) { return; }

            if (!Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchItem.Text))
            {
                mDataGridMain.SetFilter<Model.Info_matchTb_tmp_set>(delegate (Model.Info_matchTb_tmp_set p)
                { return p.Tent_Weight.ToString().Contains(txtSearchMain.Text) || p.Tent_MainSpec.Contains(txtSearchMain.Text); });
            }
            else
            {
                mDataGridMain.SetFilter<Model.Info_matchTb_tmp_set>(null);
            }
        }

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            if (mDataGridMain.CurrentRow == null) { return; }

            Model.Info_matchTb_tmp_set info = this.mDataGridMain.GetCurrentEntity() as Model.Info_matchTb_tmp_set;
            List<Model.Bu_MatchTb_Item> list = this.mDataGridItem.GetDataSource<Model.Bu_MatchTb_Item>();
            Dictionary<string, string> dicSetItem = new Dictionary<string, string>();
            foreach(var v in list)
            {
                dicSetItem.Add(v.Mtl_Code, v.ItemFormula);
            }
            info.SetItems = dicSetItem;
            if (manager.SaveItems(info))
            {
                MDataGridMain_CurrentRowChanged(null, null);
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(this.btnSaveItem, "保存成功");
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (mDataGridItem.CurrentRow == null)
            {
                return;
            }

            Model.Bu_MatchTb_Item info = mDataGridItem.GetCurrentEntity() as Model.Bu_MatchTb_Item;
            string msg = string.Format("确定删除:{0},{1}?", info.Kind_Name, info.ItemFormula);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                mDataGridItem.DeleteCurrentItem<Model.Bu_MatchTb_Item>();
            }
        }

        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            if (mDataGridItem.CurrentRow == null) { return; }
            Model.Bu_MatchTb_Item old = mDataGridItem.GetCurrentEntity() as Model.Bu_MatchTb_Item;
            FmMatchTbItem fm = new FmMatchTbItem(old);
            fm.SelectValue += (obj) => {

                Model.Bu_MatchTb_Item item = obj as Model.Bu_MatchTb_Item;
                mDataGridItem.EditCurrentItem<Model.Bu_MatchTb_Item>(item);
            };
            fm.ShowDialog();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            FmMatchTbItem fm = new FmMatchTbItem();
            fm.SelectValue += (obj) => {

                Model.Bu_MatchTb_Item item = obj as Model.Bu_MatchTb_Item;
                mDataGridItem.AddItem<Model.Bu_MatchTb_Item>(item);
            };
            fm.ShowDialog();
        }

        private void BtnDeleteMain_Click(object sender, EventArgs e)
        {
            if (mDataGridMain.CurrentRow == null)
            {
                return;
            }

            Model.Info_matchTb_tmp_set info = mDataGridMain.GetCurrentEntity() as Model.Info_matchTb_tmp_set;
            string msg = string.Format("确定删除:{0},{1}?", info.Tent_Weight, info.Tent_MainSpec);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.RemoveTmpSet(info.Set_Id))
                {
                    LoadSetMain();
                }
            }
        }


        private void BtnEditMain_Click(object sender, EventArgs e)
        {
            if (mDataGridMain.CurrentRow == null)
            {
                return;
            }

            Model.Info_matchTb_tmp_set info = mDataGridMain.GetCurrentEntity() as Model.Info_matchTb_tmp_set;

            FmMatchTbMtl fm = new FmMatchTbMtl(info);
            fm.SelectValue += (obj) => {
           
                LoadSetMain();
            };
            fm.ShowDialog();
        }

        private void BtnAddMain_Click(object sender, EventArgs e)
        {
            FmMatchTbMtl fm = new FmMatchTbMtl();
            fm.SelectValue += (obj) => {
                LoadSetMain();
            };
            fm.ShowDialog();
        }

        private void MDataGridMain_CurrentRowChanged(object sender, EventArgs e)
        {
            if (mDataGridMain.CurrentRow == null) { return; }

            Model.Info_matchTb_tmp_set info = this.mDataGridMain.GetCurrentEntity() as Model.Info_matchTb_tmp_set;

            List<Model.Bu_MatchTb_Item> items= mtlManager.GetRangeItems(info.SetItems);

            mDataGridItem.SetDataSource<Model.Bu_MatchTb_Item>(items);
        }

        protected override void InitToolBtn()
        {

            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentEdit, "修改订单");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintPreview, "打印预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void LazyInit()
        {
            LoadSetMain();
        }




        private void LoadSetMain()
        {
            List<Model.Info_matchTb_tmp_set> lt = manager.FindAllSets();
            mDataGridMain.SetDataSource<Model.Info_matchTb_tmp_set>(lt);
        }
    }
}
