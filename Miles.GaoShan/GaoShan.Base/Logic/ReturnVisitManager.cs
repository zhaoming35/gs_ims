using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class ReturnVisitManager : LogicManager<Model.ReturnVisitInfo>
    {
        public override bool Add(ReturnVisitInfo t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(ReturnVisitInfo t)
        {
            throw new NotImplementedException();
        }

        public List<ReturnVisitInfo> GetNeedReturnVisitList()
        {
            string sql = SQL.SqlManager.Intance.GetSql("ReturnVisitManager.GetNeedReturnVisitList");

            List<ReturnVisitInfo> result = this.Repository.Find().QuerySingle<ReturnVisitInfo>(sql);

            return result;
        }

        public bool UpdateIsReturnVisit(ReturnVisitInfo v)
        {
            //运费
            if (v.item_type ==(int)Enum.ReturnVisitItemType.Carriage)
            {
                return this.Repository.Update<Tb_carriage_bill>().Set()
                     .Field(Tb_carriage_bill.Table.Is_return_visit,(int)Enum.IsFlag.Yes)
                     .EndSet()
                     .Where()
                     .And(Tb_carriage_bill.Table.Carriage_Id, v.Item_Id)
                     .EndWhere()
                     .Save() > 0 ? true : false;
            }
            else
            {
                return this.Repository.Update<Tb_project_Cost_Item>().Set()
                     .Field(Tb_project_Cost_Item.Table.Is_return_visit, (int)Enum.IsFlag.Yes)
                     .EndSet()
                     .Where()
                     .And(Tb_project_Cost_Item.Table.Item_Id, v.Item_Id)
                     .EndWhere()
                     .Save() > 0 ? true : false;
            }
        }
    }
}
