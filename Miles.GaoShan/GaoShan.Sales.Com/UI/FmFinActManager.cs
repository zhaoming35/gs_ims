using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaoShan.Sales.Com.UI
{
    public partial class FmFinActManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.FinActManager manager = new Logic.FinActManager();

        public FmFinActManager()
        {
            InitializeComponent();
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnEdit.Click += new EventHandler(btnEdit_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
            this.txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
        }

        void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearch.Text))
            {
                mDataGrid1.SetFilter<Model.Tb_fin_act>(null);
            }
            else
            {
                mDataGrid1.SetFilter<Model.Tb_fin_act>(delegate(Model.Tb_fin_act p)
                {
                    if (!p.Pay_Name.Contains(txtSearch.Text))
                    {
                        return false;
                    }

                    if (!Miles.Coro.Common.StringUtils.GetFirstPinyin(p.Pay_Name).Contains(txtSearch.Text))
                    {
                        return false;
                    }

                    return true; ;

                });

            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }
            Model.Tb_fin_act info = mDataGrid1.GetCurrentEntity() as Model.Tb_fin_act;
            string msg = string.Format("确定删除:{0}信息?", info.Pay_Name);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    LoadAllData();
                }
            }
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            Model.Tb_fin_act info = mDataGrid1.GetCurrentEntity() as Model.Tb_fin_act;

            FmFinActInfo fm = new FmFinActInfo(info);

            fm.SelectValue += new Miles.Framework.UI.Forms.FmCustomInfo.SelectValueHandler(fm_SelectValue);
            fm.ShowDialog();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            FmFinActInfo fm = new FmFinActInfo();
            fm.SelectValue += new Miles.Framework.UI.Forms.FmCustomInfo.SelectValueHandler(fm_SelectValue);
            fm.ShowDialog();
        }

        void fm_SelectValue(object obj)
        {
            LoadAllData();
        }


        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAllData();
        }

        private void LoadAllData()
        {
            List<Model.Tb_fin_act> list = manager.FindAll();
            mDataGrid1.SetDataSource<Model.Tb_fin_act>(list);
        }

    }
}
