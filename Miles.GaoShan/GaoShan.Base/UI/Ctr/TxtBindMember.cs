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
    public partial class TxtBindMember : Miles.Framework.UI.Controls.MDropDownTextBox
    {
        public TxtBindMember()
        {
            InitializeComponent();
        }

        public void LoadData(string typeFullName)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("FieldName");
            dt.Columns.Add("FieldNote");

            Type myType = Type.GetType(typeFullName);

            foreach (PropertyInfo info in myType.GetProperties(BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance))
            {
                var v = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var descriptionName = (v != null && v.Count<DescriptionAttribute>() > 0) ? v[0].Description : null ;

                DataRow dr = dt.NewRow();
                dr["FieldName"] = info.Name;
                dr["FieldNote"] = descriptionName!=null? descriptionName:info.Name;
                dt.Rows.Add(dr);
            }

            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();

            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("FieldNote", "绑定数据", true));

            this.SetDataSource(dt, columnsMap);
            this.DisplayMember = "FieldNote";
            this.ValueMember = "FieldName";

        }
    }
}
