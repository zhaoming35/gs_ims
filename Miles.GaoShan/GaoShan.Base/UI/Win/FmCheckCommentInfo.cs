using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.UI.Win
{
    public partial class FmCheckCommentInfo : Miles.Framework.UI.Forms.FmCustomInfo
    {
        public FmCheckCommentInfo()
        {
            InitializeComponent();
        }

        protected override bool BtnOkClick()
        {
            if (string.IsNullOrEmpty(mTextInput1.Text))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.mTextInput1, "审核意见不能为空", 1000);
                return false;
            }

            DoSelectValueEvent(this.mTextInput1.Text);
            return true;
        }
    }
}
