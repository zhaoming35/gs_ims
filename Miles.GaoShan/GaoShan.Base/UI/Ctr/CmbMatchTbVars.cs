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
    public partial class CmbMatchTbVars : Miles.Framework.UI.Controls.MComboBox
    {
        Logic.MatchTbTmpManager manager = new Logic.MatchTbTmpManager();

        public CmbMatchTbVars():base()
        {
    
        }

        public void LoadData()
        {

          Dictionary<string,string> dic=  manager.GetAllVars();

            List<KeyValuePair<string,string>> list = new List<KeyValuePair<string, string>>();
            foreach(var v in dic)
            {
                list.Add(v);
            }
            List<Miles.Framework.UI.Controls.ColumnMap> columnsMap = new List<Miles.Framework.UI.Controls.ColumnMap>();
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("key", "变量名称", true));
            columnsMap.Add(new Miles.Framework.UI.Controls.ColumnMap("value", "变量说明", true));

            this.SetDataSource(list, columnsMap, "value", "key");


        }

    }
}
