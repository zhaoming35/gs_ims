using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Sales.Quote.UI
{
    public partial class FmTransUseTruckManager : Miles.Framework.UI.Forms.FmMdi
    {
        Logic.FinTransportMaxManager maxManager = new Logic.FinTransportMaxManager();
        Logic.FinTransportTmpManager manager = new Logic.FinTransportTmpManager();
        Logic.PlaceFeeManager feeManager = new Logic.PlaceFeeManager();
        Model.Info_fin_transport_tmp infoTmp;

        protected override void InitToolBtn()
        {
            this.AddToolBtn(Miles.Framework.UI.Forms.ButtonType.Exit, "退出");
        }

        public FmTransUseTruckManager()
        {
            InitializeComponent();
            this.btnCalMax.Click += BtnCalMax_Click;
        }

        protected override void LazyInit()
        {
            infoTmp = manager.FindThe();
            cmbTransEdgeHeight1.LoadData();
            cmbTransFixed1.LoadData();
            cmbTransMainSpec1.LoadData();
            cmbTransSpace1.LoadData();
            cmbTransPlace1.LoadData(0);
            cmbTruckSpec1.LoadData();
            cmbTransBothDirection1.LoadData();
            this.cmbTransPlace1.SelectItemEvent += CmbTransPlace1_SelectItemEvent;
            this.cmbTransPlace2.SelectItemEvent += CmbTransPlace2_SelectItemEvent;
            LoadTransFee();
            this.cmbTransPlace3.SelectItemEvent += Fee_SelectItemEvent;
            this.cmbTruckSpec1.SelectItemEvent += Fee_SelectItemEvent;
            this.cmbTransBothDirection1.SelectItemEvent += Fee_SelectItemEvent;
        }

        private void Fee_SelectItemEvent(object obj)
        {
            if (mDataGridFee.DataSource == null) { return; }

            if (Miles.Coro.Common.Methods.IsEmptyTextInput(cmbTruckSpec1.Text)
                && Miles.Coro.Common.Methods.IsEmptyTextInput(cmbTransPlace3.Text)
                  && Miles.Coro.Common.Methods.IsEmptyTextInput(cmbTransBothDirection1.Text))
            {
                mDataGridFee.SetFilter<Model.Bu_place_fee>(null);
            }
            else
            {
                mDataGridFee.SetFilter<Model.Bu_place_fee>(delegate (Model.Bu_place_fee p)
                {
                    if (!Miles.Coro.Common.Methods.IsEmptyTextInput(cmbTransPlace3.Text)
                        && !p.Place_Id.Equals(cmbTransPlace3.SelectKey))
                    {
                        return false;
                    }

                    if (!Miles.Coro.Common.Methods.IsEmptyTextInput(cmbTruckSpec1.Text)
                   && !p.Truck_Name.Equals(cmbTruckSpec1.Text))
                    {
                        return false;
                    }


                    if (!Miles.Coro.Common.Methods.IsEmptyTextInput(cmbTransBothDirection1.Text)
                   && !p.Trans_Direction.Equals(cmbTransBothDirection1.Text))
                    {
                        return false;
                    }

                    return true;
                });

            }
        }

        private void LoadTransFee()
        {
           List<Model.Bu_place_fee> list= feeManager.GetAllTransFee();
            mDataGridFee.SetDataSource<Model.Bu_place_fee>(list);
        }

        private void CmbTransPlace2_SelectItemEvent(object obj)
        {
            if (cmbTransPlace2.SelectKey == null) { return; }

            long id = (long)cmbTransPlace2.SelectKey;

            cmbTransPlace3.LoadData(id);
        }

        private void CmbTransPlace1_SelectItemEvent(object obj)
        {
            if (cmbTransPlace1.SelectKey == null) { return; }

            long id = (long)cmbTransPlace1.SelectKey;

            cmbTransPlace2.LoadData(id);
        }

  


        protected override void SetTabControls()
        {
            tabControlSeq.AddContainer(this.groupBox1);
            base.SetTabControls();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.mDecimalInput1.Focus();
        }

        private void BtnCalMax_Click(object sender, EventArgs e)
        {
            Miles.Framework.UI.Function.ControlDataBind.ClearBindValue(this.groupBox2);
            Dictionary<Control, string> dicEmptyCtrs = Miles.Framework.UI.Function.ControlDataBind.ValidBindCtrIsEmpty(this.groupBox1);
            if (dicEmptyCtrs.Count > 0)
            {
                foreach (var ctr in dicEmptyCtrs.Keys)
                {
                    Miles.Framework.UI.Function.MForm.SetToolTip(ctr, dicEmptyCtrs[ctr], 1000);
                    return;
                }
            }

            Dictionary<string, object> dicVars = new Dictionary<string, object>();
            //获得所有输入参数
            Dictionary<string, object> dicInput = new Dictionary<string, object>();
            Miles.Framework.UI.Function.ControlDataBind.GetDataBind(this.groupBox1, ref dicInput);
            foreach(var v in dicInput)
            {
                string varName = GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString(v.Key);
                dicVars.Add(varName, v.Value);
            }

            //计算级别是0的计算参数
            var query0 = from item in infoTmp.VarCals
                         where item.Level == 0
                         select item;

            foreach(var v in query0)
            {
                string varName = GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString(v.Name);
                object value = GaoShan.Sales.UI.Report.ReportTemplateBase.ParseFormula( v.Formula, dicVars);
                dicVars.Add(varName, value);
            }

            //计算端面立柱数
            var queryDmlz = from item in infoTmp.DmlFormula
                            orderby item.DL ascending
                            select item;

            decimal dmlzValue = 0;
            object valueWidth = dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("tent_Width")];
            decimal decWidth = -1;
            decimal.TryParse(valueWidth.ToString(), out decWidth);
            foreach (var v in queryDmlz)
            {
                if(v.DL<= decWidth&& decWidth <= v.UL)
                {
                    dmlzValue = v.RT;
                    break;
                }
            }
            dicVars.Add(GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("tent_Dmlz_Count"), decWidth);

            //配重单位重量,通过固定方式获得  
            decimal addUnitWidth = -1;
            foreach(var v in infoTmp.TransFixed)
            {
                if (v.Name.Equals(dicInput["trans_Fixed"]))
                {
                    addUnitWidth = v.UnitWeight;
                    break;
                }
            }
            dicVars.Add(GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("add_Weight_Unit"), addUnitWidth);

            //计算级别是的计算参数
            var query2 = from item in infoTmp.VarCals
                         where item.Level >1&&!item.Formula.Equals("dynamic")
                         orderby item.Level ascending
                         select item;

            foreach(var v in query2)
            {
                string varName = GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString(v.Name);
                object value = GaoShan.Sales.UI.Report.ReportTemplateBase.ParseFormula(v.Formula, dicVars);
                dicVars.Add(varName, value);
            }

            //定位最长件和重量
            Model.Tb_fin_transport_max info = new Model.Tb_fin_transport_max();
            info.Tent_edgeHeight = (decimal)dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("tent_edgeHeight")];
            info.Tent_MainSpec = dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("tent_MainSpec")].ToString();
            info.Tent_Space =(decimal)dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("tent_Space")];
            info.Tent_Width = (decimal)dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("tent_Width")];
            Model.Tb_fin_transport_max maxResult = maxManager.FindThe(info);


            if (maxResult == null)
            {
                MessageBox.Show("没有满足条件的,最长件基础数据");
                return;
            }
            CalResult calResult = new CalResult();
            calResult.max_Length = maxResult.Max_Length;
            calResult.add_Weight_Sum =(decimal)dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("add_Weight_Sum")];
            calResult.tent_Weight= (decimal)dicVars[GaoShan.Sales.UI.Report.ReportTemplateBase.Format2VarString("sum_Row")]* maxResult.Row_Weight;

            Miles.Framework.UI.Function.ControlDataBind.SetDataBind(this.groupBox2, calResult);

        }
    }
}
