using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class CmbModelType : Miles.Framework.UI.Controls.MDropDownComboBox
    {
        public CmbModelType()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            System.Reflection.Assembly assembly= System.Reflection.Assembly.GetExecutingAssembly();

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("fullName");
            dt.Columns.Add("className");


            foreach (System.Reflection.TypeInfo mytype in assembly.DefinedTypes)
            {
                object[] objs = mytype.GetCustomAttributes(typeof(Miles.Coro.ORM.TableAttribute), true);
                if (objs != null && objs.Length > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = mytype.FullName;
                    dr[1] = mytype.Name;
                    dt.Rows.Add(dr);
                }
            }

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap(dt.Columns[1].ColumnName, "名称", true));

            this.SetDataSource(dt, columnsMap);
            this.DisplayMember = dt.Columns[1].ColumnName;
            this.ValueMember = dt.Columns[0].ColumnName;

        }
    }
}
