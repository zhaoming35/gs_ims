using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.ProjectCost
{
    public partial class UCProjectCostInfo : UC.UCBase
    {
        Logic.ProjectCostManager manager = new Logic.ProjectCostManager();

        public UCProjectCostInfo()
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

            Model.Info_project_Cost_Item info = mDataGrid1.GetCurrentEntity() as Model.Info_project_Cost_Item;

            FmProjectCostInfo fmGenUpdate = new FmProjectCostInfo(info);
            fmGenUpdate.SelectValue += (object obj) =>
            {
                mDataGrid1.EditCurrentItem<Model.Info_project_Cost_Item>((Model.Info_project_Cost_Item)obj);

            };
            fmGenUpdate.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmProjectCostInfo fmGenAdd = new FmProjectCostInfo();
            fmGenAdd.SelectValue += (object obj) =>
            {
                mDataGrid1.AddItem<Model.Info_project_Cost_Item>((Model.Info_project_Cost_Item)obj);
            };
            fmGenAdd.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.CurrentRow == null) { return; }
            mDataGrid1.DeleteCurrentItem<Model.Info_project_Cost_Item>();
        }

        public override void SetTabControls(Miles.Framework.UI.Forms.TabControlSeq tabControlSeq)
        {
            this.tabControlSeq.AddContainer(this.groupBox16);
        }

        /// <summary>
        /// 管理员修改提交后的费用
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool AdminEdit(ToolStripButton sender)
        {
            if (mDataGrid1.DataSource == null || mDataGrid1.GetDataSource<Model.Info_project_Cost_Item>().Count < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mDataGrid1, "费用列表不能为空", 1000);
                return false;
            }

            //Model.Info_project_Cost info = this.GetDataBind<Model.Info_project_Cost>();

            Model.Info_project_Cost updateNew = this.selectValue as Model.Info_project_Cost;

            updateNew.Items = mDataGrid1.GetDataSource<Model.Info_project_Cost_Item>();

            if (manager.CorrectCost(updateNew))
            {
                DoSelectValueEvent(updateNew);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 工程人员使用
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
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

            if (mDataGrid1.DataSource == null || mDataGrid1.GetDataSource<Model.Info_project_Cost_Item>().Count < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mDataGrid1, "费用列表不能为空", 1000);
                return false;
            }

            //Model.Info_project_Cost info = this.GetDataBind<Model.Info_project_Cost>();

            Model.Info_project_Cost updateNew = this.selectValue as Model.Info_project_Cost;


            updateNew.Items = mDataGrid1.GetDataSource<Model.Info_project_Cost_Item>();

            if(manager.Save(updateNew))
            {
                DoSelectValueEvent(updateNew);
                return true;
            }
            else
            {
                return false;
            }
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


            Model.Info_project_Cost info = dataSource as Model.Info_project_Cost;

            this.SetDataBind(dataSource);

            //商品列表添加
            mDataGrid1.SetDataSource<Model.Info_project_Cost_Item>(info.Items);

        }

    }
}
