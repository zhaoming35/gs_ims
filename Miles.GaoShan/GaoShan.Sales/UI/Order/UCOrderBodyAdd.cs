using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.UI.UC;
using System.IO;
using GaoShan.Sales.Model;
using Xceed.Words.NET;

namespace GaoShan.Sales.UI.Order
{
    public partial class UCOrderBodyAdd : UCBase
    {
        bool blUpdate = false;

        public bool IsUpdate { get { return blUpdate; } }
        Miles.IMSFramework.Model.Sm_employee user = null;
        Logic.TmpManager tmpManager = new Logic.TmpManager();
        Logic.OrderManager orderManager = new Logic.OrderManager();

        public UCOrderBodyAdd()
        {
            InitializeComponent();
            if (DesignMode) { return; }
        }

        protected override void LazyInit()
        {
            LoadCtrDs();

            this.btnOdrNoOk.Click += BtnOdrNoOk_Click;
            this.d_TotCost.TextChanged += D_TotCost_TextChanged;

            this.ucOrderProtocol1.GetTmpStreamBody = () =>
            {
                Model.Tb_tmp_info info = d_cmb_Tmp.SelectedItem as Model.Tb_tmp_info;
                if (info == null)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(this.d_cmb_Tmp, "请选择合同模板", 1000);
                    return null;
                }
                byte[] btsClause = tmpManager.GetTmpClause(info.Tmp_Id);

                return new MemoryStream(btsClause);
            };

        }

        private void D_TotCost_TextChanged(object sender, EventArgs e)
        {
            lblRmb.Text = Miles.Coro.Common.MoneyConvert.ToWord((decimal)d_TotCost.Value);
        }

        private void BtnOdrNoOk_Click(object sender, EventArgs e)
        {
            Model.Tb_order_main info = orderManager.FindTheOrderMain(this.d_OrdNoMain.Text);

            if (info == null) { return; }

            d_JiaAdress.Text = info.Jia_Adress;
            d_JiaDaiLi.Text = info.Jia_DaiLi;
            d_JiaFaRen.Text = info.Jia_FaRen;
            d_JiaFax.Text = info.Jia_Fax;
            d_JiaName.Text = info.Jia_Name;
            d_JiaPhone.Text = info.Jia_Phone;


            d_YiActName.Text = info.Yi_Act_Name;
            d_YiActNo.Text = info.Yi_Act_No;
            d_YiAdress.Text = info.Yi_Adress;
            d_YiBankName.Text = info.Yi_Bank_Name;
            d_YiDaiLi.Text = info.Yi_DaiLi;
            d_YiName.Text = info.Yi_Name;
            d_YiFaRen.Text = info.Yi_FaRen;
            d_YiPhone.Text = info.Yi_Phone;
            d_YiTaxCode.Text = info.Yi_Tax_Code;

            d_odr_No.Text = Logic.Utils.BuildOrderNoAdd(info.Odr_No);
        }

        private void D_cmb_CompanyInfo_SelectItemEvent(object obj)
        {
            //加载公司预设的的账户信息
            Model.Tb_company_act info = obj as Model.Tb_company_act;
            if (info != null)
            {
                //d_YiActName.Text = info.Pay_Act_Name;
                //d_YiActNo.Text = info.Pay_Act_No;
                d_YiAdress.Text = info.Act_Adress;
                //d_YiBankName.Text = info.Pay_Bank_Name;
                //d_YiDaiLi.Text = info.Act_DaiLi;
                d_YiFaRen.Text = info.Act_FaRen;
                d_YiPhone.Text = info.Act_Phone;
                d_YiTaxCode.Text = info.Pay_Tax_Code;
            }
        }

        public override void SetOrderCode(Info_order_code orderCode)
        {
            base.SetOrderCode(orderCode);
            //追加合同号根据主合同号来生成
            //if (orderCode != null)
            //    d_odrNo.Text = orderCode.ToString();
        }

        public override void Clear()
        {
            lblState.Text = "新建";
            base.Clear();
            d_OrdNoMain.Text= null;
            //this.Tag = Miles.Coro.Common.Utils.GuidToInt64();
            this.d_OrderDate.Value = DateTime.Now;
            this.ucOrderItem1.Clear();
            this.ucOrderProtocol1.ResetText();
            blUpdate = false;
            mDataGrid2.Clear();

        }

        public override bool Save(ToolStripButton sender)
        {
            Model.Tb_tmp_info obj = d_cmb_Tmp.SelectedItem as Model.Tb_tmp_info;
            if (obj == null)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.d_cmb_Tmp, "请选择合同模板", 1000);
                return false;
            }

            Dictionary<Control, string> dicEmptyCtrs = this.GetValidEmptyCtrs();
            if (dicEmptyCtrs.Count > 0)
            {
                foreach (var ctr in dicEmptyCtrs.Keys)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(ctr, dicEmptyCtrs[ctr], 1000);
                    return false;
                }
            }

           
            if (ucOrderItem1.Items == null || ucOrderItem1.Items.Count < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.ucOrderItem1, "产品列表不能为空", 1000);
                return false;
            }

            Model.Info_OrderMain info = this.GetDataBind<Model.Info_OrderMain>();
            info.Odr_Seq = 1;
            info.Tmp_Id = obj.Tmp_Id;
            //info.Odr_No = this.Tag as string;
            info.Odr_Type = obj.Order_Type;
            info.Oper_Code = user.Employ_Code;
            info.Items = ucOrderItem1.Items;

            mDataGrid2.EndEdit();
            Dictionary<string, string> fieldExtend = new Dictionary<string, string>();
            foreach (Model.Info_tmp_map map in mDataGrid2.GetDataSource<Model.Info_tmp_map>())
            {
                if (string.IsNullOrEmpty(map.Var_Value))
                {
                    MessageBox.Show(string.Format("参数值：{0}不能为空", map.Var_Explain));
                    return false;
                }
                fieldExtend.Add(map.Var_Text, map.Var_Value);
            }
            info.FieldExtend = fieldExtend;

           
            if (ucOrderProtocol1.StreamBody == null || ucOrderProtocol1.StreamBody.Length < 1)
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.ucOrderProtocol1, "文本不能为空", 1000);
                return false;
            }

            info.Odr_Clause = ucOrderProtocol1.StreamBody.ToArray();

            bool blFlag = orderManager.SaveOrderAllInfo(info, blUpdate);
            if (blFlag)
            {
                this.DoSelectValueEvent(info);
            }

            return blFlag;
        }

        public override void SetDataSource(object dataSource)
        {
            Clear();
            lblState.Text = "修改订单";
            base.SetDataSource(dataSource);
            base.selectValue = dataSource;
            if (dataSource == null) { return; }
            blUpdate = true;

            Model.Info_OrderMain info = dataSource as Model.Info_OrderMain;
            //this.Tag = info.Odr_No;
            this.SetDataBind(dataSource);

            //商品列表添加
            this.ucOrderItem1.SetDataSource(info);

            //加载变量部分
            //模板部分先添加-选择模板后就自动加载了
            //遍历变量，赋值
            foreach (DataGridViewRow row in mDataGrid2.Rows)
            {
                Model.Info_tmp_map map = row.DataBoundItem as Model.Info_tmp_map;
                map.Var_Value = info.FieldExtend.ContainsKey(map.Var_Text) ? info.FieldExtend[map.Var_Text] : null;
            }

            //如果数据中条款数据为空，那么从选择的模板中调出来
            if (info.Odr_Clause != null)
            {
                ucOrderProtocol1.SetDataSource(new MemoryStream(info.Odr_Clause));
            }

        }



        public override void SetTabControls(Miles.Framework.UI.Forms.TabControlSeq tabControlSeq)
        {
            this.tabControlSeq.AddContainer(this.panel11);
            this.tabControlSeq.AddContainer(this.groupBox12);
            this.tabControlSeq.AddContainer(this.groupBox13);
            this.tabControlSeq.AddContainer(this.groupBox16);
            this.tabControlSeq.AddContainer(this.groupBox17);
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Clear();
        //}

        private void LoadCtrDs()
        {
            user = Miles.IMSFramework.AppCache.Employee as Miles.IMSFramework.Model.Sm_employee;
            this.d_YiDaiLi.Text = user.Employ_Name;
            this.d_cmb_Tmp.LoadData(4);
            this.d_cmb_Tmp.SelectItemEvent +=
                (object item) =>
                {
                    d_TmpExplain.Text = null;
                    mDataGrid2.Clear();

                    if (item == null) { return; }

                    Model.Tb_tmp_info obj = item as Model.Tb_tmp_info;
                    d_TmpExplain.Text = obj.Tmp_Explain;
                    //加载模板动态变量
                    List<Model.Info_tmp_map> vars = tmpManager.GetTmpDynamicVars(obj.Tmp_Id);
                    mDataGrid2.SetDataSource<Model.Info_tmp_map>(vars);

                    ucOrderProtocol1.SynStreamBody();
                };

        }

        public override void SetBindCtrNoEnabled()
        {
            base.SetBindCtrNoEnabled();
            mDataGrid2.ReadOnly = true;
            ucOrderItem1.SetBindCtrNoEnabled();
        }

    }
}
