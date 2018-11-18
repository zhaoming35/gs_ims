using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Miles.Framework.UI.Forms;

namespace GaoShan.Sales.UI.UC
{
    public partial class UCBase : Miles.Framework.UI.Controls.UCBase
    {
        protected Model.Info_order_code OrderCode { get; set; }

        public virtual void SetOrderCode(Model.Info_order_code orderCode)
        {
            OrderCode = orderCode;
        }

        public UCBase()
            : base()
        {
            InitializeComponent();
        }



        public virtual bool Save(ToolStripButton sender)
        {
            return false;
        }


    }
}