using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaoShan.Sales.Template.UI
{
    public partial class FmVarMapManager : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmVarMapManager()
        {
            InitializeComponent();
            this.btnSyn.Click += new EventHandler(btnSyn_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
            this.mDataGrid1.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(mDataGrid1_CellMouseDoubleClick);
        }

        void mDataGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.mDataGrid1.CurrentRow == null) { return; }

            Model.Tb_tmp_map info = mDataGrid1.GetCurrentEntity() as Model.Tb_tmp_map;
            FmVarMapInfo fm = new FmVarMapInfo(info);
            fm.SelectValue += new SelectValueHandler(fm_SelectValue);
            fm.ShowDialog();
        }

        void fm_SelectValue(object obj)
        {
            Model.Tb_tmp_map info = obj as Model.Tb_tmp_map;
            mDataGrid1.EditCurrentItem<Model.Tb_tmp_map>(info);
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.mDataGrid1.CurrentRow == null) { return; }

            Model.Tb_tmp_map info = mDataGrid1.GetCurrentEntity() as Model.Tb_tmp_map;
            string msg = string.Format("确定删除:{0}信息?", info.Var_Text);
            if (Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            {

                if (Miles.Coro.ORM.Repository.SingleRepository.Remove<Model.Tb_tmp_map>()
                    .Where()
                    .And(Model.Tb_tmp_map.Table.Tmp_Id, info.Tmp_Id)
                    .And(Model.Tb_tmp_map.Table.Var_Name, info.Var_Name)
                    .EndWhere()
                    .Save() > 0)
                {
                    LoadAllParmMap();
                }

            }

        }

        void btnSyn_Click(object sender, EventArgs e)
        {
            long tmpId = (long)this.Tag;
            Miles.Coro.ORM.Repository repository = Miles.Coro.ORM.Repository.SingleRepository;
            List<Model.Tb_tmp_var> vars = repository
                .Query()
                .From<Model.Tb_tmp_var>()
                .ToSelect().EndSelect()
                .ToWhere()
               .And(Model.Tb_tmp_var.Table.Tmp_Id, tmpId)
               .EndWhere()
                .ToQuery()
                .ToList<Model.Tb_tmp_var>();


            List<Model.Tb_tmp_map> mapList = mDataGrid1.GetDataSource<Model.Tb_tmp_map>();

            var mapVars = from v in mapList select v.Var_Name;

            var quary = from item in vars
                        where !mapVars.Contains(item.Var_Name)
                        select item;

            repository.DbManager.BeginTransaction();

            foreach (var v in quary)
            {
                Model.Tb_tmp_map map = new Model.Tb_tmp_map();
                map.Tmp_Id = tmpId;
                map.Var_Name = v.Var_Name;
                map.Var_Text = v.Var_Text;
                if (!repository.Add(map))
                {
                    repository.DbManager.RollBack();
                    return;
                }

            }

            repository.DbManager.Commit();
            LoadAllParmMap();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAllParmMap();
            LoadVarSetNote();
        }

        private void LoadVarSetNote()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("格式说明：");
            sb.AppendLine();
            sb.Append("1.金额数据，显示为大写人民币，设置rmb");
            sb.AppendLine();
            sb.Append("2.从系统中值，显示为枚举文字，设置enum-xxxx，如甲乙双方枚举enum-TwoParties");
            sb.AppendLine();
            sb.Append("3.日期类型，显示格式，显示年月日 yyyy-MM-dd,显示时间时分秒 HH:mm:ss");
            sb.AppendLine();
            label1.Text = sb.ToString();
        }

        private void LoadAllParmMap()
        {
            long tmpId = (long)this.Tag;
            List<Model.Tb_tmp_map> list = Miles.Coro.ORM.Repository.SingleRepository
               .Query()
               .From<Model.Tb_tmp_map>()
               .ToSelect().EndSelect()
               .ToWhere()
               .And(Model.Tb_tmp_map.Table.Tmp_Id, tmpId)
               .EndWhere()
               .ToQuery()
               .ToList<Model.Tb_tmp_map>();

            mDataGrid1.SetDataSource<Model.Tb_tmp_map>(list);
        }

        protected override bool BtnOkClick()
        {
            return true;
        }


    }
}
