using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaoShan.Sales.Enum
{
    public class EnumSet
    {
        private static void AddNewRow(System.Data.DataTable dt, int id, string text = null)
        {
            System.Data.DataRow drNew = dt.NewRow();
            drNew[0] = id;
            drNew[1] =  text;
            dt.Rows.Add(drNew);
        }

        public static System.Data.DataTable GetOrderTypeSet(bool hasAll=false)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Text", typeof(string));

            if (hasAll)
            {
                AddNewRow(dt, -1, "全部");
            }

            Dictionary<int, string> mapEnum = Miles.App.Entity.Enum.EnumText.GetEnumManager().FindKindMap("OrderType");
            foreach(var v in mapEnum)
            {
                AddNewRow(dt, v.Key, v.Value);
            }

            return dt;
        }

    }
}
