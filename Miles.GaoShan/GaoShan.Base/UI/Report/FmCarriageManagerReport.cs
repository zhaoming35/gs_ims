using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace GaoShan.Sales.UI.Report
{
    public class FmCarriageManagerReport : ReportTemplateBase
    {
        Logic.TmpXlsManager tmpXlsManager = new Logic.TmpXlsManager();
        public FmCarriageManagerReport()
        : base("FmCarriageManagerReport")
        {
        }

        public override void BeforeInit()
        {
            tmpXls = tmpXlsManager.FindThe(5146362887886472866);
            this.IsDrawGrid = false;
        }

        public override void LoadDataSource(Worksheet sheet, object dataSource)
        {
            Model.Info_carriage_bill info = dataSource as Model.Info_carriage_bill;
            ReplaceVar(info, false);
        }
    }
}
