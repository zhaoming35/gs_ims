using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace GaoShan.Sales.Doc
{
    public class DocBuilder
    {
        public static string ReportName = "TmpPageSetup";

        Logic.TmpManager tmpManager = new Logic.TmpManager();

        protected Model.Info_OrderMain orderMain = null;
        protected Dictionary<string, string> dicVarMap = new Dictionary<string, string>();

        Model.Info_tmp infoTmp = null;
        /// <summary>
        /// 模板构造
        /// </summary>
        /// <param name="infoTmp"></param>
        public DocBuilder(Model.Info_tmp infoTmp)
        {
            this.infoTmp = infoTmp;
        }

        /// <summary>
        /// 有实际数值构造
        /// </summary>
        /// <param name="orderMain"></param>
        public DocBuilder(Model.Info_OrderMain orderMain)
        {
            this.orderMain = orderMain;
            this.infoTmp =  tmpManager.GetTheTmpAllInfo(orderMain.Tmp_Id);
        }

        private void InitVar()
        {
            dicVarMap.Clear();
            if (infoTmp == null || orderMain == null) { return; }

            Dictionary<string, string> dicParm = orderMain.FieldExtend;
            foreach (var var in infoTmp.VarMaps)
            {
                if (string.IsNullOrEmpty(var.Field_Name))
                {
                    if (dicParm.ContainsKey(var.Var_Text))
                    {
                        dicVarMap.Add(var.Var_Text, dicParm[var.Var_Text]);
                    }
                }
                else
                {
                    object value = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance.GetValue(orderMain, var.Field_Name);

                    if (value == null) { continue; }
                    string strValue = Com.VarParse.GetFormatData(value, var.Field_Format);
                    dicVarMap.Add(var.Var_Text, strValue);
                }
            }
        }

        private void ReplaceVar(DocX document, Dictionary<string, string> dicVarMap)
        {
            if (dicVarMap.Count == 0) { return; }

            string regEx = "\\$\\{[^\\$\\{\\}]*\\}";
            List<string> parms = document.FindUniqueByPattern(regEx, RegexOptions.IgnoreCase);

            foreach (var v in parms)
            {
                if (dicVarMap.ContainsKey(v))
                {
                    document.ReplaceText(v, dicVarMap[v]);
                }
                else
                {
                    document.ReplaceText(v, "   ");
                }
            }
        }

        public string GetOrderPay()
        {
            string text = "";
            foreach (var v in infoTmp.Parts)
            {
                if (v.Part_Seq == infoTmp.Item_Pay_Seq)
                {
                    using (DocX document = DocX.Load(new MemoryStream(v.Part_File)))
                    {
                        SetPageMargin(document);
                        InitVar();
                        ReplaceVar(document, dicVarMap);
                        text = document.Text;
                    }

                    break;
                }
            }

            return text;
        }

        public MemoryStream ToStream(byte[] orderClause=null)
        {

            MemoryStream stream = new MemoryStream();
            using (DocX docPage = DocX.Create(System.IO.Path.Combine("Report", "tmp.docx")))
            {
                SetPageMargin(docPage);

                for(int i=0;i< infoTmp.Parts.Count; i++)
                {
                    if (infoTmp.Parts[i].Part_Seq== infoTmp.Item_Clause_Seq && orderClause!=null)
                    {
                        using (DocX document = DocX.Load(new MemoryStream(orderClause)))
                        {
                            SetPageMargin(document);
                            docPage.InsertDocument(document, true);
                        }
                    }
                    else
                    {
                        using (DocX document = DocX.Load(new MemoryStream(infoTmp.Parts[i].Part_File)))
                        {
                            SetPageMargin(document);
                            docPage.InsertDocument(document, true);
                        }
                    }
                }

                //替换变量
                //SetOrderHead();
                InitVar();
                ReplaceVar(docPage, dicVarMap);

                //录入产品信息
                InsertTable(docPage);

                SetHeaderFooter(docPage);
                docPage.SaveAs(stream);
                stream.Seek(0, SeekOrigin.Begin);

            }

            return stream;
        }

        private void InsertTable(DocX document)
        {
            if (infoTmp == null || orderMain == null) { return; }

            if ((int)infoTmp.Item_Table_Seq < 0) { return; }

            var t = document.Tables[(int)infoTmp.Item_Table_Seq];

            if (orderMain.Items.Count > 1)
            {
                int rowsCount = orderMain.Items.Count - 1;
                while (rowsCount > 0)
                {
                    var totalRow = t.InsertRow(1);
                    rowsCount--;
                }
            }

            for (int i = 0; i < orderMain.Items.Count; i++)
            {
                t.Rows[i + 1].Cells[0].Paragraphs[0].Append(orderMain.Items[i].Product_Name).Alignment = Alignment.center;
                t.Rows[i + 1].Cells[1].Paragraphs[0].Append(orderMain.Items[i].Item_Type).Alignment = Alignment.center;
                t.Rows[i + 1].Cells[2].Paragraphs[0].Append(orderMain.Items[i].ItemSpec.ToString()).Alignment = Alignment.center;
                t.Rows[i + 1].Cells[3].Paragraphs[0].Append(orderMain.Items[i].ProductCountUnit).Alignment = Alignment.center;
            }
        }

        public static void SetPageMargin(DocX doc)
        {
            Miles.Coro.Common.Print.PrintPageInfo pageInfo = Miles.Coro.Common.Print.PrintConfigManager.GetPrintPageInfo(DocBuilder.ReportName);

            //按照设定好的页面大小来配置，可以做一个模板，读取
            doc.PageWidth = Miles.Coro.Common.Print.PrintHelper.FromDisplayToPt(pageInfo.PageWidth);
            doc.PageHeight = Miles.Coro.Common.Print.PrintHelper.FromDisplayToPt(pageInfo.PageHeight);

            doc.PageLayout.Orientation = pageInfo.Landscape ? Xceed.Words.NET.Orientation.Landscape : Xceed.Words.NET.Orientation.Portrait;

            // Set the document margins.
            doc.MarginLeft = Miles.Coro.Common.Print.PrintHelper.FromDisplayToPt(pageInfo.MarginLeft);
            doc.MarginRight = Miles.Coro.Common.Print.PrintHelper.FromDisplayToPt(pageInfo.MarginRight);
            doc.MarginTop = Miles.Coro.Common.Print.PrintHelper.FromDisplayToPt(pageInfo.MarginTop);
            doc.MarginBottom = Miles.Coro.Common.Print.PrintHelper.FromDisplayToPt(pageInfo.MarginBottom);

            //doc.Save();
        }

        private void SetHeaderFooter(DocX docPage)
        {
            docPage.AddHeaders();
            docPage.AddFooters();

            //docPage.DifferentFirstPage = false;
            //docPage.DifferentOddAndEvenPages = false;
            StringBuilder sbLine = new StringBuilder();
            for (int i = 0; i < 82; i++)
            {

                sbLine.Append("_");
            }

            string line = sbLine.ToString();
            docPage.Headers.Even.InsertParagraph(line).Alignment = Alignment.center;
            docPage.Headers.Odd.InsertParagraph(line).Alignment = Alignment.center;

            docPage.Footers.Even.InsertParagraph(line).Alignment = Alignment.center;
            docPage.Footers.Odd.InsertParagraph(line).Alignment = Alignment.center;


            Model.Tb_tmp_main footInfo = Cache.LogicCache.TmpMain;
            string linkWay1 = string.Format("监督电话：{0}",footInfo.LinkWay1);
            string linkWay2 = string.Format("合同版本号：{0}", footInfo.LinkWay2);
            //string linkWay1 = "监督电话：15712307900";
            //string linkWay2 = "合同版本号：20180101";
            StringBuilder sbEmpty = new StringBuilder();
            for (int i = 0; i < 82 - linkWay1.Length - linkWay2.Length; i++)
            {
                sbEmpty.Append(" ");
            }

            docPage.Footers.Even.InsertParagraph().Append(linkWay1).Append(sbEmpty.ToString()).Append(linkWay2).Alignment = Alignment.center;
            docPage.Footers.Odd.InsertParagraph().Append(linkWay1).Append(sbEmpty.ToString()).Append(linkWay2).Alignment = Alignment.center;

            Paragraph footerEven = docPage.Footers.Even.InsertParagraph("第");
            footerEven.AppendPageNumber(PageNumberFormat.normal);
            footerEven.Append("页,共");
            footerEven.AppendPageCount(PageNumberFormat.normal);
            footerEven.Append("页").Alignment = Alignment.center;


            Paragraph footerOdd = docPage.Footers.Odd.InsertParagraph("第");
            footerOdd.AppendPageNumber(PageNumberFormat.normal);
            footerOdd.Append("页,共");
            footerOdd.AppendPageCount(PageNumberFormat.normal);
            footerOdd.Append("页").Alignment = Alignment.center;
        }


        public static void PrintDocPreview(Stream stream,string reportName)
        {
            Aspose.Words.Document doc = new Aspose.Words.Document(stream);
            //Aspose.Words.Rendering.AsposeWordsPrintDocument printDocument = new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc);
            using (System.Drawing.Printing.PrintDocument printDoc = Miles.Coro.Common.Print.PrintConfigManager.ApplyPrintSettings(new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc), Doc.DocBuilder.ReportName))
            {
                PrintPreviewDialog previewDlg = new PrintPreviewDialog();
                previewDlg.Document = printDoc;
                previewDlg.ShowInTaskbar = true;
                previewDlg.MinimizeBox = true;
                previewDlg.PrintPreviewControl.Zoom = 1.5d;
                previewDlg.WindowState = FormWindowState.Maximized;
                previewDlg.ShowDialog();
            }
        }

        //public static void PrintDoc(Stream stream, string reportName)
        //{
        //    Aspose.Words.Document doc = new Aspose.Words.Document(stream);
        //    //Aspose.Words.Rendering.AsposeWordsPrintDocument printDocument = new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc);
        //    using (System.Drawing.Printing.PrintDocument printDoc = Miles.Coro.Common.Print.PrintConfigManager.ApplyPrintSettings(new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc), Doc.DocBuilder.ReportName))
        //    {
        //        printDoc.Print();
        //    }
        //}

        public static void PrintDoc(Stream stream, string reportName,bool isPrintDialog=false)
        {

            Aspose.Words.Document doc = new Aspose.Words.Document(stream);
            //Aspose.Words.Rendering.AsposeWordsPrintDocument printDocument = new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc);

            using (System.Drawing.Printing.PrintDocument printDoc = Miles.Coro.Common.Print.PrintConfigManager.ApplyPrintSettings(new Aspose.Words.Rendering.AsposeWordsPrintDocument(doc), Doc.DocBuilder.ReportName))
            {
                if (isPrintDialog)
                {
                    PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
                    if (printDialog.ShowDialog() == DialogResult.OK)//弹出选择印表机的窗体
                    {
                        printDoc.PrinterSettings.PrinterName = printDialog.PrinterSettings.PrinterName;
                        printDoc.Print();
                    }
                }
                else
                {
                    printDoc.Print();
                }

            }
        }

        public static MemoryStream LoadCtrViewDoc(Miles.Dev.Controls.MRichEditOnly mRichEditOnly, string fileName)
        {
            using (DocX document = DocX.Load(fileName))
            {
                MemoryStream streamBody = new MemoryStream();
                document.SaveAs(streamBody);
                string filename = System.IO.Path.Combine("Report", "tmp.docx");
                document.SaveAs(filename);
                mRichEditOnly.LoadDocument(filename);
                return streamBody;
            }
        }

        public static MemoryStream LoadCtrViewDoc(Miles.Dev.Controls.MRichEditOnly mRichEditOnly, MemoryStream streamBody)
        {
            using (DocX document = DocX.Load(streamBody))
            {
                string filename = System.IO.Path.Combine("Report", "tmp.docx");
                document.SaveAs(filename);
                mRichEditOnly.LoadDocument(filename);
                return streamBody;
            }
        }

    }
}
