using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;
using Miles.Framework.UI.Forms;

namespace GaoShan.ReturnVisit.UI
{
    public partial class FmReturnVisitManager : Miles.Framework.UI.Forms.FmMdi
    {
        GaoShan.Sales.Logic.ReturnVisitManager manager = new Sales.Logic.ReturnVisitManager();
        GaoShan.Sales.Logic.SendSmsInfoManager smsManager = new Sales.Logic.SendSmsInfoManager();

        protected override void InitToolBtn()
        {

            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Query, "查询");
            base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Check, "发送回访短信");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.PrintDialog, "打印设置");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Document, "联络单预览");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Commit, "提交");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Backward, "召回联络单");
            //base.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.DocumentAdd, "新建取消单");

            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmReturnVisitManager()
        {
            InitializeComponent();
        }


        protected override void Query(ToolStripButton sender)
        {
            DoQuery();
        }

        private void DoQuery()
        {
            List<GaoShan.Sales.Model.ReturnVisitInfo> list = manager.GetNeedReturnVisitList();
            mDataGrid1.SetDataSource<GaoShan.Sales.Model.ReturnVisitInfo>(list);
        }

        protected override void DefineButtonClick(ToolStripButton sender, ButtonType buttonType)
        {
            if (buttonType == ButtonType.Check)
            {
                Check(sender);
            }
        }

        private void Check(ToolStripButton sender)
        {
            mDataGrid1.EndEdit(); //这句很关键

            var task = Task.Factory.StartNew<bool>(DoSendAll);

            if (!task.Result) { return; }

            this.SetButtonClickResultTip(sender, "发送完成");
            DoQuery();
        }

        bool DoSendAll()
        {
            List<GaoShan.Sales.Model.ReturnVisitInfo> list = mDataGrid1.GetDataSource<GaoShan.Sales.Model.ReturnVisitInfo>();
            var querySelect = from item in list
                              where item.SelectFlag == 1
                              select item;

            foreach (var v in querySelect)
            {
                bool blFlag = SendSms(v);
                Thread.Sleep(500);
                if (blFlag)
                {
                    if (!manager.UpdateIsReturnVisit(v))
                    {
                        MessageBox.Show(string.Format("更新数据库失败,合同编号{0},费用名称{1}", v.Odr_No, v.Cost_Type));
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }


        bool isInit = false;
        string msgTemplate = "";
        string companyPhone = "";

        private bool SendSms(ReturnVisitInfo v)
        {
            if (!isInit)
            {
                Init();
            }

            //string msg = @"您本次{0}为：{1}元整，如遇我司人员由故意难为、索要回扣、利诱等情况发生，请及时联系：{2}(公司名称)";
            string msg = string.Format(msgTemplate, v.Cost_Type, (int)v.Tot_Cost, companyPhone);
            return GaoShan.Tools.SendMessage.Instance.Send(msg, v.Phone);
        }

        private void Init()
        {
            List<Tb_send_sms_info> smsList= smsManager.GetSmsInfo();
            Tb_send_sms_info smsInfo = smsList.First<Tb_send_sms_info>();

            msgTemplate = smsInfo.Sms_content;
            companyPhone = smsInfo.Company_Phone;
            GaoShan.Tools.SendMessage.Instance.Init(smsInfo.Sms_Url, smsInfo.Sms_user, smsInfo.Sms_password);
            isInit = true;
        }


        //List<GaoShan.Sales.Model.ReturnVisitInfo> list = mDataGrid1.GetDataSource<GaoShan.Sales.Model.ReturnVisitInfo>();
        //var querySelect = from item in list
        //                  where item.SelectFlag == 1
        //                  select item;

        //foreach (var v in querySelect)
        //{
        //    bool blFlag = SendSms(v);
        //    Thread.Sleep(500);
        //    if (blFlag)
        //    {
        //        if (!manager.UpdateIsReturnVisit(v))
        //        {
        //            MessageBox.Show(string.Format("更新数据库失败,合同编号{0},费用名称{1}", v.Odr_No, v.Cost_Type));
        //            return;
        //        }
        //    }
        //}

        //return;

        //foreach (DataGridViewRow row in mDataGrid1.Rows)
        //{

        //    bool isSelect = (bool)row.Cells["ColSelect"].FormattedValue;
        //    if (isSelect)
        //    {
        //        GaoShan.Sales.Model.ReturnVisitInfo item = row.DataBoundItem as GaoShan.Sales.Model.ReturnVisitInfo;
        //        bool blFlag = SendSms(item);
        //        if (blFlag)
        //        {
        //            if (!manager.UpdateIsReturnVisit(item))
        //            {
        //                MessageBox.Show(string.Format("更新数据库失败,合同编号{0},费用名称{1}", item.Odr_No, item.Cost_Type));
        //                return;
        //            }
        //        }

        //    }

        //}
    }
}
