using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using unvell.ReoGrid;

namespace GaoShan.Sales.UI.Report
{
    public abstract class ReportTemplateBase : Miles.ReoGrid.ReportTemplateBind
    {
        protected int ItemRowGroupCount = 1;
        protected int ItemColumnGroupCount = 1;
        protected Model.Info_tmp_xls tmpXls = null;
        private Dictionary<string, Model.Tb_tmp_xls_map> dicVarMap = new Dictionary<string, Model.Tb_tmp_xls_map>();

        public ReportTemplateBase(string reportName)
            :base(reportName)
        {
            BeforeInit();
            foreach (var v in tmpXls.VarMaps)
            {
                dicVarMap.Add(v.Var_Text, v);
            }
        }

        public abstract void BeforeInit();

        public override void Init()
        {
            this.ItemRowGroupCount = (int)tmpXls.Item_Row_Count;
            this.ItemColumnGroupCount = (int)tmpXls.Item_Column_Count;

            this.InitColumnCount = (int)tmpXls.Column_Count;
            this.InitRowCount= (int)tmpXls.Row_Count;
            this.TemplateStream = new MemoryStream(tmpXls.Tmp_Body);
        }

        protected void ReplaceVar(Dictionary<string,object> dicVars, bool isClearEmptyVar = true)
        {
            List<unvell.ReoGrid.Cell> cells = this.GetAllMergedCells();
            foreach (unvell.ReoGrid.Cell cellFrom in cells)
            {
                string varText = FindVarString(cellFrom.DisplayText);
                if (varText != null&& dicVars.ContainsKey(varText))
                {
                    object value = dicVars[varText];
                    unvell.ReoGrid.Cell cell = this.Sheet.Cells[cellFrom.Row, cellFrom.Column];
                    if (value != null)
                    {
                        SetCellFormatData(cell, value,null);
                    }
                    else
                    {
                        if(isClearEmptyVar)
                        SetCellFormatData(cell, "", null);
                    }
                }
            }
        }

        protected void ReplaceVar(object dataSource, bool isClearEmptyVar = true)
        {
            List<unvell.ReoGrid.Cell> cells = this.GetAllMergedCells();
            foreach (unvell.ReoGrid.Cell cellFrom in cells)
            {
                string varText = FindVarString(cellFrom.DisplayText);
                if (varText != null)
                {
                    Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;

                    Model.Tb_tmp_xls_map map = dicVarMap.ContainsKey(varText) ? dicVarMap[varText] : null;
                    if (map != null)
                    {
                        string dataField = map.Field_Name;
                        object value = memberAccessor.GetValue(dataSource, dataField);
                        unvell.ReoGrid.Cell cell = this.Sheet.Cells[cellFrom.Row, cellFrom.Column];
                        if (value != null)
                        {
                            SetCellFormatData(cell, value, map.Field_Format);
                        }
                        else
                        {
                            if(isClearEmptyVar)
                            SetCellFormatData(cell, "",null);
                        }
                    }
                }
            }
        }

        public static void SetCellFormatData(Cell cell, object value, string format, object dataSource = null)
        {
            if (value == null) { return; }

            cell.Body = new Miles.ReoGrid.CanClickCell();

            string strValue = Com.VarParse.GetFormatData(value, format);
            SetCellValue(cell, strValue, dataSource);
        }

        protected void InsertItems(IList items, Model.Info_tmp_xls tmpXlsItem)
        {
            Miles.ReoGrid.ReportTemplate reportTemplate = new Miles.ReoGrid.ReportTemplate();
            reportTemplate.TemplateStream = new MemoryStream(tmpXlsItem.Tmp_Body);
            reportTemplate.InitColumnCount = (int)tmpXlsItem.Column_Count;
            reportTemplate.InitRowCount = (int)tmpXlsItem.Row_Count;
            reportTemplate.Bind(null, null);

            int itemStartRow = (int)tmpXls.Item_Start_Row;
            int itemStartColumn = (int)tmpXls.Item_Start_Column ;
            int itemGroupCount = (int)tmpXls.Item_Row_Count;

            Dictionary<string, Model.Tb_tmp_xls_map> dicMap = new Dictionary<string, Model.Tb_tmp_xls_map>();
            foreach (var v in tmpXlsItem.VarMaps)
            {
                dicMap.Add(v.Var_Text, v);
            }
            InsertItems(items, new XlsItemGroup(reportTemplate.GetAllMergedCells(), itemGroupCount, dicMap), itemStartRow, itemStartColumn);
        }

        protected void InsertItems(IList items, XlsItemGroup xlsItemGroup, int itemStartRow, int itemStartCol)
        {
            int itemCount = items.Count;
            int rowCount = xlsItemGroup.RowCount;
            if (itemCount > 1)
            {
                this.Sheet.InsertRows(itemStartRow + rowCount, rowCount * (itemCount - 1));
            }

            //按照插入行行的合并情况，循环列合并，新增加的行的列
            for (int row = 1; row < itemCount; row++)
            {
                SetItemGroupMergedCell(this.Sheet, itemStartRow + row * rowCount, itemStartCol, xlsItemGroup.CellsTmp);
            }

            for (int row = 0; row < itemCount; row++)
            {
                object dataSource = items[row];
                foreach(unvell.ReoGrid.Cell cellFrom in xlsItemGroup.CellsTmp)
                {
                    int realRow = itemStartRow + row * rowCount;
                    unvell.ReoGrid.Cell cell = this.Sheet.Cells[cellFrom.Row + realRow, cellFrom.Column + itemStartCol];
                    string varText = FindVarString(cellFrom.DisplayText);
                    if (varText != null)
                    {
                        Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;

                        Model.Tb_tmp_xls_map map = xlsItemGroup.DicVarMap.ContainsKey(varText) ? xlsItemGroup.DicVarMap[varText] : null;
                        if (map != null)
                        {
                            string dataField = map.Field_Name;
                            object value = memberAccessor.GetValue(dataSource, dataField);
                            if (value != null)
                            {
                                //根据格式来设置单元格值
                                SetCellFormatData(cell, value, map.Field_Format);
                                this.Sheet.AutoFitRowHeight(realRow);
                            }
                        }
                    }
                    else
                    {
                        cell.Data = cellFrom.Data; 
                    }
                }
            }
        }

        protected void InsertTable(IList items,Func<object, XlsItemBindInfo[]> funcItemToArray, object dataSource = null)
        {
            int itemCount = items.Count;
            //动态数据模板起始位置行
            int itemStartRow = (int)tmpXls.Item_Start_Row;
            int itemStartColumn = (int)tmpXls.Item_Start_Column;

            if (itemCount > 1)
            {
                this.Sheet.InsertRows(itemStartRow+ ItemRowGroupCount, ItemRowGroupCount*(itemCount - 1));
            }

            List<unvell.ReoGrid.Cell> cellsTmp = GetRangeMergedCells(this.Sheet,itemStartRow, itemStartColumn, ItemRowGroupCount, ItemColumnGroupCount);

            //按照插入行行的合并情况，循环列合并，新增加的行的列
            for (int row = 1; row < itemCount; row++)
            {
                SetItemGroupMergedCell(this.Sheet,row* ItemRowGroupCount, itemStartColumn, cellsTmp);
            }

            for (int row = 0; row < itemCount; row++)
            {
                XlsItemBindInfo[] xlsItems = funcItemToArray(items[row]);
                int i = 0;
                foreach (unvell.ReoGrid.Cell fromCell in cellsTmp)
                {
                    int realRow = fromCell.Row + row* ItemRowGroupCount;
                    XlsItemBindInfo xlsItem = xlsItems[i];
                    unvell.ReoGrid.Cell cell = this.Sheet.Cells[realRow, fromCell.Column]; //+itemStartColumn
                    if (xlsItem.UseTmpText&&fromCell.Data != null) { cell.Data = fromCell.Data; }
                    SetCellFormatData(cell, xlsItem.Value, xlsItem.Format, dataSource);
                    this.Sheet.AutoFitRowHeight(realRow);
                    i++;
                }

            }
        }

        public static string Format2VarString(string varValue)
        {
            return "${"+varValue+"}";
        }

        public static string FindVarString(string displayText)
        {
            if (string.IsNullOrEmpty(displayText)) { return null; }

            string regEx = "\\$\\{[^\\$\\{\\}]*\\}";
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(regEx);
            //返回一个结果集
            System.Text.RegularExpressions.MatchCollection result = reg.Matches(displayText);
            //遍历每个结果
            foreach (System.Text.RegularExpressions.Match m in result)
            {
                //输出结果
                return m.ToString();
            }

            return null;
        }

        public static object ParseFormula(string formula, Dictionary<string, object> dicInput)
        {

            DataTable eval = new DataTable();
            object value = null;
            if (formula.StartsWith("string."))
            {
                string expression = formula.Substring(7);
                expression = ReplaceExe(expression, dicInput);
                value = expression;
            }
            else
            {
                string expression = ReplaceExe(formula, dicInput);
                value = eval.Compute(expression, "");
            }

            return value;
        }

        static string ReplaceExe(string formula, Dictionary<string, object> dicInput)
        {
            while (FindVarString(formula) != null)
            {
                string var = FindVarString(formula);
                formula = formula.Replace(var, dicInput[var].ToString());
            }

            return formula;
        }

    }

    public class XlsItemGroup
    {
        List<unvell.ReoGrid.Cell> cellsTmp;
        int rowCount;
        Dictionary<string, Model.Tb_tmp_xls_map> dicVarMap;

        public List<Cell> CellsTmp { get => cellsTmp; set => cellsTmp = value; }
        public int RowCount { get => rowCount; set => rowCount = value; }
        public Dictionary<string, Tb_tmp_xls_map> DicVarMap { get => dicVarMap; set => dicVarMap = value; }

        public XlsItemGroup(List<Cell> cellsTmp, int rowCount, Dictionary<string, Tb_tmp_xls_map> dicVarMap)
        {
            this.cellsTmp = cellsTmp;
            this.rowCount = rowCount;
            this.dicVarMap = dicVarMap;
        }
    }

    public class XlsItemBindInfo
    {
        public static XlsItemBindInfo Empty = new XlsItemBindInfo();

        bool useTmpText = false;
        object value;
        string format;

        public bool UseTmpText { get => useTmpText;}
        public object Value { get => value; set => this.value = value; }
        public string Format { get => format; set => format = value; }

        public XlsItemBindInfo(object value, string format=null)
        {
            this.Value = value;
            this.Format = format;
        }

        public XlsItemBindInfo()
        {
            useTmpText = true;
        }


    }
}
