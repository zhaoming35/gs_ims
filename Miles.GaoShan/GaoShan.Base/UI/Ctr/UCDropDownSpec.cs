using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class UCDropDownSpec : UserControl
    {
        public UCDropDownSpec()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Model.Info_product_property> list)
        {
            this.mDataGrid1.SetDataSource<Model.Info_product_property>(list);
            SetSize();
          
        }

        public List<Model.Info_product_property> GetDataSource()
        {
            return mDataGrid1.GetDataSource<Model.Info_product_property>();
        }

        private void SetSize()
        {

            int height = mDataGrid1.ColumnHeadersHeight;
            int width = mDataGrid1.RowHeadersWidth;

            if (mDataGrid1.Rows.Count < 1)
            {
                return;
            }

            int showRowsCount = 8;
            foreach (DataGridViewRow dgv in mDataGrid1.Rows)
            {
                if (dgv.Visible)
                {
                    height += mDataGrid1.Rows[0].Height;
                    if (showRowsCount < 0) { break; }

                    showRowsCount--;
                }
            }

            foreach (DataGridViewColumn col in mDataGrid1.Columns)
            {
                width += col.Width;
            }

            this.Width = width + 2;
            this.Height = height + 2;
        }

        public void EndEdit()
        {
            mDataGrid1.EndEdit();
        }

        public bool ValidIsEmpty()
        {
            return mDataGrid1.DataSource == null || mDataGrid1.Rows.Count < 1;
        }

      
    }
}
