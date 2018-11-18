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
    public partial class UCOrderBodySales : UCBase
    {
        bool blUpdate = false;

        public bool IsUpdate { get { return blUpdate; } }
        Miles.IMSFramework.Model.Sm_employee user = null;
        Logic.TmpManager tmpManager = new Logic.TmpManager();
        Logic.OrderManager orderManager = new Logic.OrderManager();

        public UCOrderBodySales()
        {
            InitializeComponent();
        }

        protected override void LazyInit()
        {
            LoadCtrDs();
            this.d_totCost.TextChanged += D_totCost_TextChanged;

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


        private void D_totCost_TextChanged(object sender, EventArgs e)
        {
            lblRmb.Text = Miles.Coro.Common.MoneyConvert.ToWord((decimal)d_totCost.Value);
        }

        public override void SetOrderCode(Info_order_code orderCode)
        {
            base.SetOrderCode(orderCode);
            if (orderCode != null)
                d_odrNo.Text = orderCode.ToString();
        }

        public override void Clear()
        {
            lblState.Text = "新建";
            base.Clear();
            d_odrNo.Text = null;
            this.d_OrderDate.Value = DateTime.Now;
            this.ucOrderTwoParties1.Clear();
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

            info.Odr_No_Main = info.Odr_No;
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
            ucOrderItem1.SetDataSource(info);

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
            this.tabControlSeq.AddContainer(this.ucOrderTwoParties1);
            this.tabControlSeq.AddContainer(this.groupBox14);
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
            this.d_cmb_odrFixedMode.LoadData();
            this.d_cmb_odrTaxType.LoadData();
            this.d_cmb_odrTransParty.LoadData();
            this.d_cmb_BuildParties.LoadData();
            this.d_cmb_Tmp.LoadData(1);
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
            ucOrderItem1.SetBindCtrNoEnabled();
            mDataGrid2.ReadOnly = true;
        }

    }
}
