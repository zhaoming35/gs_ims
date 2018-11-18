using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class TxtBindOrderMain :  Miles.Framework.UI.Controls.MDropDownTextBox
    {
        public TxtBindOrderMain()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("FieldName");
            dt.Columns.Add("FieldNote");

            foreach (PropertyInfo info in typeof(Model.Info_OrderMain).GetProperties(BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance))
            {
                if (info.IsDefined(typeof(DataFieldAttribute), false))
                {
                    DataFieldAttribute attribute = (DataFieldAttribute)Attribute.GetCustomAttribute(info, typeof(DataFieldAttribute));
                    if (!string.IsNullOrEmpty(attribute.FieldNote))
                    {
                        DataRow dr = dt.NewRow();
                        dr["FieldName"] = attribute.FieldName;
                        dr["FieldNote"] = attribute.FieldNote;
                        dt.Rows.Add(dr);
                    }
                }
            }

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();

            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("FieldNote", "绑定数据", true));

            this.SetDataSource(dt, columnsMap);
            this.DisplayMember = "FieldNote";
            this.ValueMember = "FieldName";

        }
    }
}
