using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;
using System.IO;
using GaoShan.Sales.Model;
using unvell.ReoGrid.Actions;

namespace GaoShan.Sales.UI.Report
{
    public class FmOrderGenManagerReport : ReportTemplateBase
    {
        Logic.TmpXlsManager tmpXlsManager = new Logic.TmpXlsManager();

        public FmOrderGenManagerReport()
        : base("FmOrderGenManagerReport")
        {
        }

        Model.Info_tmp_xls tmpXlsItem = null;
        public override  void BeforeInit()
        {
            //得到模板数据
            tmpXls = tmpXlsManager.FindThe(4737506234498655130);
            tmpXlsItem = tmpXlsManager.FindThe(5557049638610432885);
            this.GridColSpaceLastCount = 1;
            this.GridRowSpaceLastCount = 1;
        }

        public override void LoadDataSource(Worksheet sheet, object dataSource)
        {
            Model.Info_fin_order_gen info = dataSource as Model.Info_fin_order_gen;
            //替换静态变量
            ReplaceVar(info);

            InsertItems(info.Items, tmpXlsItem);

            //插入动态数据
            //InsertTable(info.Items, GetItemMapArray);
        }

        //private XlsItemBindInfo[] GetItemMapArray(object obj)
        //{
        //    Info_fin_order_item item = obj as Info_fin_order_item;
        //    List<XlsItemBindInfo> list = new List<XlsItemBindInfo>();
        //    list.Add(new XlsItemBindInfo(item.Item_Name));
        //    list.Add(new XlsItemBindInfo(item.Item_Type));
        //    list.Add(new XlsItemBindInfo(item.Item_Spec));
        //    list.Add(new XlsItemBindInfo(item.Item_Count, "num"));
        //    list.Add(new XlsItemBindInfo(item.Item_Price, "dec"));
        //    list.Add(new XlsItemBindInfo(item.Item_Total, "dec"));
        //    list.Add(new XlsItemBindInfo(item.Item_Material));
        //    list.Add(new XlsItemBindInfo(item.Remark));
        //    return list.ToArray();
        //}

    }
}
