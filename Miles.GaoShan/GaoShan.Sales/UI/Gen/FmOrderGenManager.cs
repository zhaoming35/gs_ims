using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miles.Framework.UI.Forms;

namespace GaoShan.Sales.UI.Gen
{
    public partial class FmOrderGenManager :   Miles.Framework.UI.Forms.FmMdi
    {
        Logic.GenManager manager = new Logic.GenManager();
        //Logic.EmployManager employManager = new Logic.EmployManager();

        public FmOrderGenManager()
        {
            InitializeComponent();
            this.ucGenList1.SelectValueChange += UcGenList1_SelectValueChange;
        }

        private void UcGenList1_SelectValueChange(object sender, object obj)
        {
            if (this.ucGenList1.CurrentSelectValue == null) { return; }

            Model.Info_fin_order_gen info = this.ucGenList1.CurrentSelectValue as Model.Info_fin_order_gen;

            if (info.Items.Count == 0)
            {
                info.Items = manager.GetGenItems(info.Odr_No);
            }

            ucGenInfo1.SetDataSource(info);
        }

        protected override void InitToolBtn()
        {
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Reload, "刷新");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建");

            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentRemove, "删除");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Save, "保存");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "合同摘要预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Print, "打印");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Document)
            {
                Document(sender);
            }
            else if (buttonType == ButtonType.Commit)
            {
                Commit(sender);
            }
            else if (buttonType == ButtonType.Reload)
            {
                Reload(sender);
            }
        }

        private void Reload(ToolStripButton sender)
        {
            LoadSelfOrder();
        }

        private void Commit(ToolStripButton sender)
        {
            if (this.ucGenInfo1.CurrentSelectValue == null) { return; }

            Model.Info_fin_order_gen infoGen = this.ucGenInfo1.CurrentSelectValue as Model.Info_fin_order_gen;

            string msg = string.Format("确定提交:{0},{1}?", infoGen.Odr_No, infoGen.Jia_Name);
            if (!Miles.Framework.UI.Function.Dialog.ShowQuestionYesNo(msg))
            { return; }

            if (manager.Commit(infoGen))
            {
                LoadSelfOrder();
                this.SetButtonClickResultTip(sender, "提交成功");
            }
            else
            {
                this.SetButtonClickResultTip(sender, "提交失败");
            }
        }

        private void Document(ToolStripButton sender)
        {

            if (this.ucGenList1.CurrentSelectValue == null) { return; }

            Model.Info_fin_order_gen info = ucGenList1.CurrentSelectValue as Model.Info_fin_order_gen;


            Win.FmReoGridShow fmReoGridShow = new Win.FmReoGridShow();

            fmReoGridShow.SetReportBind(new Report.FmOrderGenManagerReport(),info);
            fmReoGridShow.ShowDialog();
        }

        protected override void Save(ToolStripButton sender)
        {
            if (this.ucGenInfo1.Save(sender))
            {
                Model.Info_fin_order_gen info_OrderMain = this.ucGenInfo1.CurrentSelectValue as Model.Info_fin_order_gen;
                //ucOrderList1.UpdateCurrentValue(info_OrderMain);
                ucGenList1.UpdateCurrentValue(info_OrderMain);
                LoadSelfOrder();
                this.SetButtonClickResultTip(sender, "保存成功");
            }
        }


        protected override void SetTabControls()
        {
            this.ucGenInfo1.SetTabControls(this.tabControlSeq);

        }

        private void Clear()
        {
            this.ucGenInfo1.Clear();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode) { return; }

            LoadSelfOrder();
        }

        /// <summary>
        /// 加载自己的合同，没提交的合同
        /// </summary>
        private void LoadSelfOrder()
        {
            Clear();
            Miles.IMSFramework.Model.Sm_employee user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;

            List<Model.Info_fin_order_gen> list = manager.FindSelfNotCommitGenList(user.Employ_Code);

            ucGenList1.SetDataSource(list);
        }

    }
}
