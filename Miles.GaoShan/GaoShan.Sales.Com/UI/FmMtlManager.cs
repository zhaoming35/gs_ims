using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.Com.UI
{
    public partial class FmMtlManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.MtlManager manager = new Logic.MtlManager();

        public FmMtlManager()
        {
            InitializeComponent();
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnEdit.Click += new EventHandler(btnEdit_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
            this.btnAddItem.Click += new EventHandler(btnAddItem_Click);
            this.btnEditItem.Click += new EventHandler(btnEditItem_Click);
            this.btnDeleteItem.Click += new EventHandler(btnDeleteItem_Click);

            this.txtSearchItem.TextChanged += new EventHandler(txtSearchItem_TextChanged);
            this.treeView1.AfterSelect += TreeView1_AfterSelect;
            //this.mDataGridItem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            if (this.mDataGridItem.DataSource == null) { return; }

            if (!Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearchItem.Text))
            {
                mDataGridItem.SetFilter<Model.Info_mtl_item>(delegate (Model.Info_mtl_item p)
                { return p.Mtl_Code.Contains(txtSearchItem.Text) || p.Mtl_Name.Contains(txtSearchItem.Text); });
            }
            else
            {
                mDataGridItem.SetFilter<Model.Info_mtl_item>(null);
            }
        }


        void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Info_mtl_kind parent = null;

            if (this.treeView1.SelectedNode != null)
            {
                parent = this.treeView1.SelectedNode.Tag as Model.Info_mtl_kind;
            }

            FmMtlKind fm = new FmMtlKind();
            fm.Tag = parent;
            fm.SelectValue += new Miles.Framework.UI.Forms.FmCustomInfo.SelectValueHandler(fm_SelectValue);
            fm.ShowDialog();
        }

        void fm_SelectValue(object obj)
        {
            LoadKind();
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null) { return; }

            Model.Info_mtl_kind kind = this.treeView1.SelectedNode.Tag as Model.Info_mtl_kind;

            FmMtlKind fm = new FmMtlKind(kind);
            if (this.treeView1.SelectedNode.Level > 0)
            {
                fm.Tag = this.treeView1.SelectedNode.Parent.Tag;
            }

            fm.SelectValue += new Miles.Framework.UI.Forms.FmCustomInfo.SelectValueHandler(fm_SelectValue);
            fm.ShowDialog();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null) { return; }

            Model.Info_mtl_kind kind = this.treeView1.SelectedNode.Tag as Model.Info_mtl_kind;

            if (this.treeView1.SelectedNode.Nodes.Count > 0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.toolStripKind, "分类下包含子分类不能删除", 1000);
                return;
            }

            if (Miles.Framework.UI.Function.Dialog.ShowWarningYesNo("确定要删除：" + kind.Kind_Name + "?"))
            {
                if (kind.Items.Count > 0)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(this.toolStripKind, "分类下包含物料数据不能删除", 1000);
                    return;
                }

                if (manager.DeleteKind(kind))
                {
                    LoadKind();
                }
            }
        }

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }


        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadItem();
        }


        private void LoadItem()
        {
            mDataGridItem.Clear();
            if (this.treeView1.SelectedNode == null) { return; }
            Model.Info_mtl_kind kind = this.treeView1.SelectedNode.Tag as Model.Info_mtl_kind;
            if (kind == null) { return; }
            List<Model.Info_mtl_item> list =manager.GetKindItems(kind.Kind_Code);
            mDataGridItem.SetDataSource<Model.Info_mtl_item>(list);
        }

        void btnAddItem_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null) { return; }
            Model.Info_mtl_kind kind = this.treeView1.SelectedNode.Tag as Model.Info_mtl_kind;

            FmMtlInfo fmItem = new FmMtlInfo();
            fmItem.Tag = kind;
            fmItem.SelectValue += FmItem_SelectValue;
            fmItem.ShowDialog();
        }

        private void FmItem_SelectValue(object obj)
        {
            LoadItem();
        }

        void btnEditItem_Click(object sender, EventArgs e)
        {
            if (mDataGridItem.CurrentRow == null) { return; }
            Model.Info_mtl_kind kind = this.treeView1.SelectedNode.Tag as Model.Info_mtl_kind;

            Model.Info_mtl_item item = this.mDataGridItem.GetCurrentEntity() as Model.Info_mtl_item;

            FmMtlInfo fmItem = new FmMtlInfo(item);
            fmItem.Tag = kind;
            fmItem.SelectValue += FmItem_SelectValue;
            fmItem.ShowDialog();
        }

        void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (mDataGridItem.CurrentRow == null) { return; }

            Model.Info_mtl_item item = this.mDataGridItem.GetCurrentEntity() as Model.Info_mtl_item;

            if (Miles.Framework.UI.Function.Dialog.ShowWarningYesNo("确定要删除物料：" + item.Mtl_Name + "?"))
            {

                //if (manager.HasItemRecord(item.Gs_Id))
                //{
                //    Miles.Framework.UI.Function.MForm.SetToolTip(this.toolStripItem, "商品存在业务数据不能删除", 1000);
                //    return;
                //}

                if (manager.Remove(item))
                {
                    this.mDataGridItem.DeleteCurrentItem<Model.Info_mtl_item>();
                }
            }
        }


        protected override void LazyInit()
        {
            LoadKind();
        }

        private void LoadKind()
        {
            List<Model.Info_mtl_kind> list = manager.GetAllRelationKind();
            this.treeView1.Nodes[0].Nodes.Clear();

            foreach(var v in list)
            {
                TreeNode treeNode = NewTreeNode(v);
                this.treeView1.Nodes[0].Nodes.Add(treeNode);
                LoadChildNodes(treeNode,v.Children);
                //treeNode.Expand();
            }

            treeView1.ExpandAll();
        }

        TreeNode NewTreeNode(Info_mtl_kind kind)
        {
            string text = string.Format("[{0}]{1}",kind.Kind_Code,kind.Kind_Name);
            TreeNode treeNode = new TreeNode(text);
            treeNode.Tag = kind;

            return treeNode;
        }
        private void LoadChildNodes(TreeNode parentNode, List<Info_mtl_kind> children)
        {
           foreach(var v in children)
            {
                TreeNode treeNode = NewTreeNode(v); 
                parentNode.Nodes.Add(treeNode);
                if (v.Children.Count > 0)
                {
                    LoadChildNodes(treeNode, v.Children);
                }
            }
        }
    }
}
