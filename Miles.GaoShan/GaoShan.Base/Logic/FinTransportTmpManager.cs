using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class FinTransportTmpManager : LogicManager<Model.Info_fin_transport_tmp>
    {
        public override bool Add(Info_fin_transport_tmp t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_fin_transport_tmp t)
        {
            throw new NotImplementedException();
        }

        public override Info_fin_transport_tmp FindThe(params object[] parms)
        {
            Info_fin_transport_tmp matchTbTmp =
                this.Repository.Query().From<Model.Tb_fin_transport_tmp>()
           .ToSelect().EndSelect()
           .ToQuery()
           .First<Info_fin_transport_tmp>();

            if (matchTbTmp == null)
            {
                this.Repository.Add(new Info_fin_transport_tmp());
            }

            return matchTbTmp == null ? new Info_fin_transport_tmp() : matchTbTmp;
        }

        public bool Save(Info_fin_transport_tmp infoTmp)
        {
            return this.Repository.Update<Model.Tb_fin_transport_tmp>()
            .Set()
            .AllFields(infoTmp)
            .EndSet().Save() > 0 ? true : false;
        }
    }
}
