using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;

namespace GaoShan.Sales.Salary.UI.Cal
{
    public partial class UCSumOrderCost :  UCBase
    {
        public UCSumOrderCost()
        {
            InitializeComponent();
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


            Model.Bu_CalSalaryGen info = dataSource as Model.Bu_CalSalaryGen;
            //this.Tag = info.Odr_Id;
            this.SetDataBind(dataSource);

            //商品列表添加
            mDataGrid1.SetDataSource<Model.Info_fin_order_item>(info.Items);

        }

    }
}
