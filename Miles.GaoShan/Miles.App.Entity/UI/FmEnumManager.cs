using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miles.App.Entity.UI
{
    public partial class FmEnumManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.EnumManager manager = new Logic.EnumManager();

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmEnumManager()
        {
            InitializeComponent();
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDeleteDetail.Click += BtnDeleteDetail_Click;
            this.btnEditDetail.Click += BtnEditDetail_Click;
            this.btnAddDetail.Click += BtnAddDetail_Click;
            this.mDataGrid1.CurrentRowChanged += MDataGrid1_CurrentRowChanged;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(txtSearch.Text))
            {
                mDataGrid1.SetFilter<Model.Tb_enum>(null);
            }
            else
            {
                mDataGrid1.SetFilter<Model.Tb_enum>(delegate (Model.Tb_enum p)
                {

                    if (p.Enum_Kind.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        return true;
                    }

                    if (Miles.Coro.Common.StringUtils.GetFirstPinyin(p.Enum_Text).Contains(txtSearch.Text)
                        ||p.Enum_Text.Contains(txtSearch.Text))
                    {
                        return true;
                    }

                    return false;
            

                });

            }
        }

        private void MDataGrid1_CurrentRowChanged(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }
            Model.Tb_enum infoKind = mDataGrid1.GetCurrentEntity() as Model.Tb_enum;

            if (infoKind != null)
            {
                List<Model.Tb_enum> list = manager.FindKindAllInfo(infoKind.Enum_Kind);
                mDataGrid2.SetDataSource<Model.Tb_enum>(list);
            }
        }

        private void BtnAddDetail_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }
            Model.Tb_enum infoKind = mDataGrid1.GetCurrentEntity() as Model.Tb_enum;

            FmEnumInfo fm = new FmEnumInfo();
            fm.Tag = infoKind.Enum_Kind;
            fm.lblType.Text = infoKind.Enum_Text;
            fm.SelectValue += FmAdd_SelectValue;
            fm.ShowDialog();
        }

        private void FmAdd_SelectValue(object obj)
        {
            mDataGrid2.AddItem<Model.Tb_enum>((Model.Tb_enum)obj);
        }

        private void BtnEditDetail_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }
            Model.Tb_enum infoKind = mDataGrid1.GetCurrentEntity() as Model.Tb_enum;

            if (mDataGrid2.DataSource == null) { return; }
            Model.Tb_enum info = mDataGrid2.GetCurrentEntity() as Model.Tb_enum;

            FmEnumInfo fm = new FmEnumInfo(info);
            fm.Tag = infoKind.Enum_Kind;
            fm.lblType.Text = infoKind.Enum_Text;
            fm.SelectValue += FmEdit_SelectValue;
            fm.ShowDialog();
        }

        private void FmEdit_SelectValue(object obj)
        {
            mDataGrid2.EditCurrentItem<Model.Tb_enum>((Model.Tb_enum)obj);
        }

        private void BtnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (mDataGrid2.DataSource == null) { return; }
            Model.Tb_enum info = mDataGrid2.GetCurrentEntity() as Model.Tb_enum;
            string msg = string.Format("确定删除:{0}信息?", info.Enum_Text);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.Remove(info))
                {
                    mDataGrid2.DeleteCurrentItem<Model.Tb_enum>();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FmEnumKindInfo fmDicKind = new FmEnumKindInfo();
            fmDicKind.SelectValue += FmDicKind_SelectValue;
            fmDicKind.ShowDialog();
        }

        private void FmDicKind_SelectValue(object obj)
        {
            LoadAllKindData();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }
            Model.Tb_enum info = mDataGrid1.GetCurrentEntity() as Model.Tb_enum;

            FmEnumKindInfo fmDicKind = new FmEnumKindInfo(info);
            fmDicKind.SelectValue += FmDicKind_SelectValue;
            fmDicKind.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mDataGrid1.DataSource == null) { return; }
            Model.Tb_enum info = mDataGrid1.GetCurrentEntity() as Model.Tb_enum;
            string msg = string.Format("确定删除:{0}信息?", info.Enum_Text);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {
                if (manager.RemoveKind(info))
                {
                    LoadAllKindData();
                }
            }
        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAllKindData();
        }

        private void LoadAllKindData()
        {
            List<Model.Tb_enum> list = manager.FindAllKind();
            mDataGrid1.SetDataSource<Model.Tb_enum>(list);
        }



    }
}
