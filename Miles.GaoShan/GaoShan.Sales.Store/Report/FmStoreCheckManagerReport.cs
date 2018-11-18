using GaoShan.Sales.UI.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace GaoShan.Sales.Store.Report
{
    public class FmStoreCheckManagerReport : Sales.UI.Report.ReportTemplateBase
    {
        Logic.TmpXlsManager tmpXlsManager = new Logic.TmpXlsManager();
        public FmStoreCheckManagerReport()
        : base("FmStoreCheckManagerReport")
        {
        }

        public override void BeforeInit()
        {
            tmpXls = tmpXlsManager.FindThe(4725920822726143157);
            this.GridStartColumn = 1;
            this.GridStartRow = 3;
            this.GridRowSpaceLastCount = 1;
            this.GridColSpaceLastCount = 1;
        }


        public override void LoadDataSource(Worksheet sheet, object dataSource)
        {
            Model.Bu_store_check info = dataSource as Model.Bu_store_check;
            ReplaceVar(info, false);
            //插入动态数据
            InsertTable(info.Items, GetItemMapArray);
        }

        private XlsItemBindInfo[] GetItemMapArray(object obj)
        {
            Model.Info_store_check item = obj as Model.Info_store_check;
            List<XlsItemBindInfo> list = new List<XlsItemBindInfo>();
            list.Add(new XlsItemBindInfo(item.Kind_Name));
            list.Add(new XlsItemBindInfo(item.Mtl_Code));
            list.Add(new XlsItemBindInfo(item.Mtl_Name));
            list.Add(new XlsItemBindInfo(item.Mtl_Spec));
            list.Add(new XlsItemBindInfo(item.Mtl_Unit));
            list.Add(new XlsItemBindInfo(item.Mtl_Qty, "num"));
            list.Add(new XlsItemBindInfo(item.Check_Qty, "num"));
            return list.ToArray();
        }
    }
}
