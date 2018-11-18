using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaoShan.Sales.Xls.UI
{
    public partial class FmMapXlsInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmMapXlsInfo()
        {
            InitializeComponent();
        }

        public FmMapXlsInfo(Model.Tb_tmp_xls_map info,string typeFullName)
            : base(info)
        {
            InitializeComponent();

            if(typeFullName != null)
            d_field_Name.LoadData(typeFullName);
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

            //this.txtBindOrderHead1.LoadData();

            this.SetDataBind(this.modelObj);

            if (string.IsNullOrEmpty(this.d_Explain.Text)) { this.d_Explain.Text = this.d_var_Text.Text; }
         
        }


        protected override bool BtnOkClick()
        {
            Model.Tb_tmp_xls_map old = this.modelObj as Model.Tb_tmp_xls_map;

            Model.Tb_tmp_xls_map info = this.GetDataBind<Model.Tb_tmp_xls_map>(old);
            //old.Var_Explain = info.Var_Explain;
            //old.Field_Name = info.Field_Name;
            //old.Field_Format = info.Field_Format;


            if (Miles.Coro.ORM.Repository.SingleRepository.Update<Model.Tb_tmp_xls_map>()
.Set()
.AllFields(info)
.EndSet()
.Where()
.And(Model.Tb_tmp_xls_map.Table.Tmp_Id,old.Tmp_Id)
.And(Model.Tb_tmp_xls_map.Table.Var_Text, old.Var_Text)
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
