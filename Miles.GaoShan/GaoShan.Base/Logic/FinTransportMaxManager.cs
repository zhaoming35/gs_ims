using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class FinTransportMaxManager : LogicManager<Model.Tb_fin_transport_max>
    {
        public override bool Add(Tb_fin_transport_max t)
        {
            t.Max_Id = NewId();
            return this.Add(this.Repository, t);
        }

        public override bool Remove(Tb_fin_transport_max t)
        {
            return this.Repository.Remove<Tb_fin_transport_max>()
                .Where().And(Tb_fin_transport_max.Table.Max_Id, t.Max_Id)
                .EndWhere()
                .Save() > 0 ? true : false;
        }


        public override bool Update(Tb_fin_transport_max tNew, Tb_fin_transport_max tOld)
        {
            return this.Repository.Update<Tb_fin_transport_max>()
                .Set().AllFields(tNew).EndSet()
                .Where().And(Tb_fin_transport_max.Table.Max_Id, tOld.Max_Id)
                .EndWhere()
                .Save() > 0 ? true : false;
        }

        public override List<Tb_fin_transport_max> FindAll(params object[] parms)
        {
            return this.Repository.Query().From<Tb_fin_transport_max>()
                .ToSelect().EndSelect()
                .ToQuery()
                .ToList<Tb_fin_transport_max>();
        }

        public override Tb_fin_transport_max FindThe(params object[] parms)
        {
            Tb_fin_transport_max info = parms[0] as Tb_fin_transport_max;

            return this.Repository.Query().From<Tb_fin_transport_max>()
         .ToSelect().EndSelect()
         .ToWhere()
         .And(Tb_fin_transport_max.Table.Tent_Width, info.Tent_Width)
          .And(Tb_fin_transport_max.Table.Tent_MainSpec, info.Tent_MainSpec)
           .And(Tb_fin_transport_max.Table.Tent_edgeHeight, info.Tent_edgeHeight)
            .And(Tb_fin_transport_max.Table.Tent_Space, info.Tent_Space)
         .EndWhere()
         .ToQuery()
         .First<Tb_fin_transport_max>();
        }
    }
}
