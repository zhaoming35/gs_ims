using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class PlaceFeeManager : LogicManager<Model.Info_place_fee>
    {
        public override bool Add(Info_place_fee t)
        {
            t.Fee_Id = NewId();
            return this.Add(Repository, t);
        }

        public override bool Remove(Info_place_fee t)
        {
            return this.Repository.Remove<Tb_place_fee>()
                .Where().And(Tb_place_fee.Table.Fee_Id, t.Fee_Id)
                .EndWhere()
                .Save() > 0 ? true : false;
        }

        public override bool Update(Info_place_fee tNew, Info_place_fee tOld)
        {
            return this.Repository.Update<Tb_place_fee>()
                 .Set().AllFields(tNew)
                 .EndSet()
                 .Where()
                 .And(Tb_place_fee.Table.Fee_Id, tOld.Fee_Id)
                 .EndWhere()
                 .Save() > 0 ? true : false;
        }

        public override List<Info_place_fee> FindAll(params object[] parms)
        {
            return this.Repository.Query().From<Tb_place_fee>()
                .ToSelect().EndSelect()
                .ToQuery()
                .ToList<Info_place_fee>();
        }

        public List<Bu_place_fee> GetAllTransFee()
        {
            return this.Repository.Query().From<Tb_place_fee>()
               .ToSelect().EndSelect()
               .ToQuery()
              .InnerJoin<Tb_truck_info>()
              .On(Tb_place_fee.Table.Truck_Name,Tb_truck_info.Table.Truck_Name)
              .JoinTable()
              .ToSelect()
              .Select(Tb_truck_info.Table.Truck_Name,true)
              .EndSelect()
              .ToQuery()
               .ToList<Bu_place_fee>();
        }
    }
}
