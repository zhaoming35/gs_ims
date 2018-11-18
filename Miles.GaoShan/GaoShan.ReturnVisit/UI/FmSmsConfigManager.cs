using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.ReturnVisit.UI
{
    public partial class FmSmsConfigManager : Miles.Framework.UI.Forms.FmMdi
    {
        GaoShan.Sales.Logic.SendSmsInfoManager manager = new Sales.Logic.SendSmsInfoManager();

        protected override void InitToolBtn()
        {

            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "发送回访短信");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "联络单预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Backward, "召回联络单");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建取消单");

            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmSmsConfigManager()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            List<GaoShan.Sales.Model.Tb_send_sms_info> list = manager.GetSmsInfo();
            mDataGrid1.SetDataSource<GaoShan.Sales.Model.Tb_send_sms_info>(list);
        }

        protected override void Save(ToolStripButton sender)
        {
            mDataGrid1.EndEdit();
            List<GaoShan.Sales.Model.Tb_send_sms_info> list = mDataGrid1.GetDataSource<GaoShan.Sales.Model.Tb_send_sms_info>();
            if (manager.Save(list))
            {
                LazyInit();
                this.SetButtonClickResultTip(sender, "保存成功");
            }
        }

    }
}
