using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using unvell.ReoGrid;
 

namespace GaoShan.Sales.UI.Report
{
    public class FmMatchTbManagerReport : ReportTemplateBase
    {
        Logic.TmpXlsManager tmpXlsManager = new Logic.TmpXlsManager();
        Logic.MatchTbTmpManager tmpManager = new Logic.MatchTbTmpManager();

        private Info_MatchTb_Tmp _matchTbTmp = null;
        public Info_MatchTb_Tmp MatchTbTmp
        {
            get
            {
                if (_matchTbTmp == null) { _matchTbTmp = tmpManager.FindThe(); }
                return _matchTbTmp;
            }
        }

        Model.Info_tmp_xls tmpXlsItem = null;

        public FmMatchTbManagerReport()
        : base("FmMatchTbManagerReport")
        {
        }

        public override void BeforeInit()
        {
            //得到模板数据
            tmpXls = tmpXlsManager.FindThe(4887101819480924880);
            tmpXlsItem = tmpXlsManager.FindThe(5126702061095765704);
            this.GridStartRow = 7;
        }
        public override void LoadDataSource(Worksheet sheet, object dataSource)
        {
            Model.Info_matchTb info = dataSource as Model.Info_matchTb;
            ReplaceVar(info,false);
            //替换静态变量
            Dictionary<string, object> vars = GetMatchTbVars(info);
            ReplaceVar(vars);

            //InsertTheItems(info.Items);



            InsertItems(info.Items, tmpXlsItem);

            MergeItems(info.Items);
            //插入动态数据
            //InsertTable(info.Items, GetItemMapArray);
        }

        private void MergeItems(List<Info_matchTb_item> items)
        {
            int startRow = (int)this.tmpXls.Item_Start_Row;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var v in items)
            {
                if (!dic.ContainsKey(v.Group_Name))
                {
                    dic.Add(v.Group_Name, 0);
                }

                dic[v.Group_Name]++;
            }

            int row = startRow;
            foreach (var v in dic)
            {
                this.Sheet.MergeRange(row, 0, v.Value, 1);
                row += v.Value;
            }
        }

        public Dictionary<string, object> GetMatchTbVars(Info_matchTb info)
        {
            Dictionary<string, object> dicVar = new Dictionary<string, object>();

            //获得维护的基础数据
     
            Dictionary<string, object> dicInput = new Dictionary<string, object>();

            foreach (var v in this.MatchTbTmp.VarInputs)
            {
                string varName = "${" + v.Name + "}";
                object value = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance.GetValue(info, v.Name);
                dicInput.Add(varName, value);
                dicVar.Add(varName, value);
            }

            Dictionary<string, object> dicCal = new Dictionary<string, object>();
        
            foreach (var v in this.MatchTbTmp.VarCals)
            {
                string varName = Report.ReportTemplateBase.Format2VarString(v.Name);
                object value =ReportTemplateBase.ParseFormula(v.Formula,dicInput);

                dicCal.Add(varName, value);
                dicVar.Add(varName, value);
            }

            //十字撑计算
            List<RanageFormula> szcFormulas = null;
            if (info.Tent_Length < 26)
            {
                //30米以下
                szcFormulas = this.MatchTbTmp.SzcLt30;
            }
            else
            {
                //30米以上
                szcFormulas = this.MatchTbTmp.SzcGt30;
            }

            var query = from i in szcFormulas
                        orderby i.DL ascending
                        select i;

            decimal unit_SpecNum = -1;
            decimal.TryParse(dicVar["${unit_SpecNum}"].ToString(), out unit_SpecNum);
            decimal szcValue = 0;
            foreach (var v in query)
            {
                if (unit_SpecNum <= v.UL && unit_SpecNum >= v.DL)
                {
                    szcValue = v.RT;
                    break;
                }
            }
            dicVar.Add("${szc_Value}", szcValue);

            decimal allWeight = info.Items.Sum(i => i.ItemWeight);
            dicVar.Add("${All_Weight}", allWeight);
            return dicVar;
        }

   
    }
}
