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
    public partial class FmStoreManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.StoreManager manager = new Logic.StoreManager();

        protected override void InitToolBtn()
        {
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.InStore, "直接入库");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.OutStore, "直接出库");
            //base.AddToolBtn(ButtonType.Edit, "修改");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmStoreManager()
        {
            InitializeComponent();
            this.cmbMtlInfo1.SelectItemEvent += Cmb_SelectedValueChanged;
            this.cmbMtlKind1.SelectItemEvent += Cmb_SelectedValueChanged;
        }


        private void Cmb_SelectedValueChanged(object obj)
        {
            
            if (mDataGridItem.DataSource == null) { return; }

            if (cmbMtlKind1.SelectKey==null&&cmbMtlInfo1.SelectKey==null)
            {
                mDataGridItem.SetFilter<Model.Info_store_main>(null);
            }
            else
            {
                mDataGridItem.SetFilter<Model.Info_store_main>(delegate (Model.Info_store_main p)
                {
                    if (cmbMtlKind1.SelectKey !=null )
                    {
                        GaoShan.Sales.Model.Tb_mtl_kind kind = cmbMtlKind1.SelectedItem as GaoShan.Sales.Model.Tb_mtl_kind;
                        if (kind.Kind_Level == 0)
                        {
                            List<string> childs = GaoShan.Sales.Cache.LogicCache.DicChildKind[kind.Kind_Code];
                            var query = from item in childs
                                        where item.Contains(p.Kind_Code)
                                        select item;

                            if (query.Count() <1)
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

                    if (cmbMtlInfo1.SelectKey!=null&&!p.Mtl_Code.Equals(cmbMtlInfo1.SelectKey))
                    {
                        return false;
                    }

                    return true;

                });

            }
        }

        protected override void LazyInit()
        {
            cmbMtlKind1.LoadData();
            cmbMtlInfo1.LoadData();
            LoadStore();
        }

        private void LoadStore()
        {
            List<Model.Info_store_main> list = manager.FindAll();
            mDataGridItem.SetDataSource<Model.Info_store_main>(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Reload)
            {
                Reload(sender);
            }
 
           
        }

        private void Reload(ToolStripButton sender)
        {
            LoadStore();
        }
    }
}
