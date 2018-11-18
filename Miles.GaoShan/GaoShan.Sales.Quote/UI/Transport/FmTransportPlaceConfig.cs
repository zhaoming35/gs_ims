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

namespace GaoShan.Sales.Quote.UI
{
    public partial class FmTransportPlaceConfig : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.PlaceInfoManager manager = new Logic.PlaceInfoManager();
        Logic.TruckInfoManager truckInfoManager = new Logic.TruckInfoManager();
        Logic.PlaceFeeManager placeFeeManager = new Logic.PlaceFeeManager();

        public FmTransportPlaceConfig()
        {
            InitializeComponent();
            this.btnAddPlace.Click += BtnAdd_Click;
            this.btnEditPlace.Click += BtnEdit_Click;
            this.btnDeletePlace.Click += BtnDelete_Click;


            this.btnAddTruck.Click += BtnAddTruck_Click;
            this.btnDeleteTruck.Click += BtnDeleteTruck_Click;
            this.btnSaveTruck.Click += BtnSaveTruck_Click;

            this.btnAddFee.Click += BtnAddFee_Click;
            this.btnEditFee.Click += BtnEditFee_Click;
            this.btnDeleteFee.Click += BtnDeleteFee_Click;
        }

        private void BtnDeleteFee_Click(object sender, EventArgs e)
        {
            if (mDataGridFee.CurrentRow == null) { return; }
            Model.Info_place_fee info = mDataGridFee.GetCurrentEntity() as Model.Info_place_fee;

            string msg = string.Format("确定删除:{0},{1},{2}?", info.MerName, info.Truck_Name, info.Trans_Direction);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (placeFeeManager.Remove(info))
                {
                    mDataGridFee.DeleteCurrentItem<Model.Info_place_fee>();
                }
            }
        }

        private void BtnEditFee_Click(object sender, EventArgs e)
        {
            if (mDataGridFee.CurrentRow == null) { return; }
            Model.Info_place_fee old = mDataGridFee.GetCurrentEntity() as Model.Info_place_fee;

            FmTransFeeInfo fm = new FmTransFeeInfo(old);
            fm.SelectValue += (obj) => {
                Model.Info_place_fee info = obj as Model.Info_place_fee;
                mDataGridFee.EditCurrentItem<Model.Info_place_fee>(info);
            };
            fm.ShowDialog();
        }

        private void BtnAddFee_Click(object sender, EventArgs e)
        {
            FmTransFeeInfo fm = new FmTransFeeInfo();
            fm.SelectValue += (obj) => {
                Model.Info_place_fee info = obj as Model.Info_place_fee;
                mDataGridFee.AddItem<Model.Info_place_fee>(info);
            };
            fm.ShowDialog();
        }

        private void BtnSaveTruck_Click(object sender, EventArgs e)
        {
            mDataGridTruck.EndEdit();
            List<Model.Tb_truck_info> list = mDataGridTruck.GetDataSource<Model.Tb_truck_info>();
            if (truckInfoManager.Save(list))
            {
                ToolStripButton btnSave = sender as ToolStripButton;
                Miles.Framework.UI.Function.MForm.SetToolStripButtonTip(btnSave, "保存成功");
            }
        }

        private void BtnDeleteTruck_Click(object sender, EventArgs e)
        {
            if (mDataGridTruck.CurrentRow == null) { return; }

            mDataGridTruck.DeleteCurrentItem<Model.Tb_truck_info>();
        }

        private void BtnAddTruck_Click(object sender, EventArgs e)
        {
            mDataGridTruck.AddItem<Model.Tb_truck_info>(new Model.Tb_truck_info());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null) { return; }
            if (this.treeView1.SelectedNode.Level == 0) { return; }
            Model.Info_place_info info = this.treeView1.SelectedNode.Tag as Model.Info_place_info;
            if (Miles.Framework.UI.Function.Dialog.ShowWarningYesNo("确定要删除：" + info .Place_Name+ "?将删除所有下级数据"))
            {
                if (manager.Remove(info))
                {
                    LoadAllPlace();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null) { return; }
            if (this.treeView1.SelectedNode.Level == 0) { return; }

            Model.Info_place_info update = this.treeView1.SelectedNode.Tag as Model.Info_place_info;

            FmPlaceInfo fm = new FmPlaceInfo(update);
            fm.Tag = this.treeView1.SelectedNode.Parent.Tag;
            fm.SelectValue += (obj) => {
                Model.Info_place_info info = obj as Model.Info_place_info;
                this.treeView1.SelectedNode.Text = info.Place_Name;
            };
            fm.ShowDialog();


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode== null) { return; }

            Model.Info_place_info parent = this.treeView1.SelectedNode.Tag as Model.Info_place_info;
            FmPlaceInfo fm = new FmPlaceInfo();
            fm.Tag = parent;
            fm.SelectValue += (obj) => {
                Model.Info_place_info info = obj as Model.Info_place_info;
                TreeNode node = new TreeNode(info.Place_Name);
                node.Tag = info;
                node.ImageIndex = info.Level;

                this.treeView1.SelectedNode.Nodes.Add(node);
                parent.Children.Add(info);
                this.treeView1.SelectedNode.Tag = parent;
            };
            fm.ShowDialog();

        }

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void LazyInit()
        {
            LoadAllPlace();
            LoadTruck();
            LoadFee();
        }

        private void LoadFee()
        {
          List<Model.Info_place_fee> list=  placeFeeManager.FindAll();
           mDataGridFee.SetDataSource<Model.Info_place_fee>(list);
        }

        private void LoadTruck()
        {
           List<Model.Tb_truck_info> list= truckInfoManager.FindAll();
            mDataGridTruck.SetDataSource<Model.Tb_truck_info>(list);
        }

        private void LoadAllPlace()
        {
            treeView1.Nodes.Clear();
            Model.Info_place_info root = manager.GetAll2Root();
            TreeNode node = new TreeNode(root.Place_Name);
            node.ImageIndex = root.Level;
            node.Tag = root;
            treeView1.Nodes.Add(node);
            LoadTreeNode(node, root);
            node.Expand();
        }

        private void LoadTreeNode(TreeNode parentNode, Info_place_info root)
        {
            if (root.Children.Count > 0)
            {
                foreach (var v in root.Children)
                {
                    TreeNode node = new TreeNode(v.Place_Name);
                    node.ImageIndex = v.Level;
                    node.Tag = v;
                    parentNode.Nodes.Add(node);

                    if (v.Children.Count > 0)
                    {
                        LoadTreeNode(node, v);
                    }
                }
            }
        }
    }
}
