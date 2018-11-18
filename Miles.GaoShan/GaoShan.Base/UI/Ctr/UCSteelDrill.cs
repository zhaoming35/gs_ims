using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class UCSteelDrill : UC.UCBase
    {
        public UCSteelDrill()
        {
            InitializeComponent();
        }

        public Bu_SteelDrill GetDataSource()
        {
            Bu_SteelDrill info = GetDataBind<Bu_SteelDrill>();
            return info;
        }

      
    }
}
