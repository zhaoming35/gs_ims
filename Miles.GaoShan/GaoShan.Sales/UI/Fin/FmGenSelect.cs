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

namespace GaoShan.Sales.UI.Fin
{
    public partial class FmGenSelect : Miles.Framework.UI.Forms.FmCustomInfo
    {
        Logic.GenManager genManager = new Logic.GenManager();
        public FmGenSelect()
        {
            InitializeComponent();
            this.btnQuery.Click += BtnQuery_Click;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderNo.Text)) { return; }

            List<Model.Info_fin_order_gen> list = FindGenList(txtOrderNo.Text);
            mDataGrid1.SetDataSource<Model.Info_fin_order_gen>(list);
            if (list.Count == 0)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(btnQuery, "没有满足条件的合同信息",1000);
            }
        }

        private List<Info_fin_order_gen> FindGenList(string odr_No)
        {
            Model.Info_fin_order_gen infoGen = genManager.FindTheVaildGen(odr_No);
            List<Info_fin_order_gen> list = new List<Info_fin_order_gen>();
             if(infoGen!=null) list.Add(infoGen);
            return list;
   
        }

        protected override bool BtnOkClick()
        {
            if (mDataGrid1.CurrentRow == null) { return false; }

            Model.Info_fin_order_gen info = mDataGrid1.GetCurrentEntity() as Model.Info_fin_order_gen;

            this.DoSelectValueEvent(info);

            return true;
        }


    }
}
