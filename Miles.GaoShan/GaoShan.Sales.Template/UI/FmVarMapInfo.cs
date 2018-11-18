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
    public partial class FmVarMapInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmVarMapInfo()
        {
            InitializeComponent();
        }

        public FmVarMapInfo(Model.Tb_tmp_map info)
            : base(info)
        {
            InitializeComponent();
            //this.Tag = info.Parm_Id;
        }

        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.panelClient);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.d_Explain.Focus();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) { return; }

            this.txtBindOrderHead1.LoadData();

            this.SetDataBind(this.modelObj);

            if (string.IsNullOrEmpty(this.d_Explain.Text)) { this.d_Explain.Text = this.d_ParmName.Text; }
         
        }


        protected override bool BtnOkClick()
        {
            Model.Tb_tmp_map old = this.modelObj as Model.Tb_tmp_map;

            Model.Tb_tmp_map info = this.GetDataBind<Model.Tb_tmp_map>();
            old.Var_Explain = info.Var_Explain;
            old.Field_Name = info.Field_Name;
            old.Field_Format = info.Field_Format;
            old.Field_Note = info.Field_Note;

            if (Miles.Coro.ORM.Repository.SingleRepository.Update<Model.Tb_tmp_map>()
.Set().Field(Model.Tb_tmp_map.Table.Var_Explain, info.Var_Explain)
.Field(Model.Tb_tmp_map.Table.Field_Name, info.Field_Name)
.Field(Model.Tb_tmp_map.Table.Field_Note, info.Field_Note)
.Field(Model.Tb_tmp_map.Table.Field_Format, info.Field_Format)
.EndSet()
.Where()
.And(Model.Tb_tmp_map.Table.Tmp_Id,old.Tmp_Id)
.And(Model.Tb_tmp_map.Table.Var_Name, old.Var_Name)
.EndWhere()
.Save() < 1)
            {
                return false;
            }

            this.DoSelectValueEvent(old);

            return true;
        }

    }
}
