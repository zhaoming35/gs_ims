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
    public partial class UCGutterInfo : UC.UCBase
    {
        public UCGutterInfo()
        {
            InitializeComponent();
        }

        public Bu_GutterInfo GetDataSource()
        {
            Bu_GutterInfo info=  this.GetDataBind<Bu_GutterInfo>();
            return info;
        }

        public void SetDataSource(Bu_GutterInfo info)
        {
            this.SetDataBind(info);
        }

        public bool ValidIsEmpty()
        {
            if (mDecimalInput1.Value == 0 || mDecimalInput2.Value == 0)
            {
                return true;
            }

            return false;
        }

    }
}
