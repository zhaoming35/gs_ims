using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace GaoShan.Sales.UI.Report
{
    public class FmLinkBillManagerReport : ReportTemplateBase
    {
        Logic.TmpXlsManager tmpXlsManager = new Logic.TmpXlsManager();

        public FmLinkBillManagerReport()
        : base("FmLinkBillManagerReport")
        {
        }

        Model.Info_tmp_xls tmpXlsItem = null;
        public override void BeforeInit()
        {
            //得到模板数据
            tmpXls = tmpXlsManager.FindThe(4712284195760822845);
            tmpXlsItem = tmpXlsManager.FindThe(5179524403633683467);
        }

        public override void LoadDataSource(Worksheet sheet, object dataSource)
        {
            Model.Info_link_bill info = dataSource as Model.Info_link_bill;
            //替换静态变量
            ReplaceVar(info);

            if (info.LinkBill_Type == 1) { sheet.Cells["B3"].Style.BackColor = unvell.ReoGrid.Graphics.SolidColor.Red; }

            InsertItems(info.Items, tmpXlsItem);
        }

        public override void OnAfterFormatGrid(ReoGridControl gridControl)
        {
            base.OnAfterFormatGrid(gridControl);

        }
    }
}
