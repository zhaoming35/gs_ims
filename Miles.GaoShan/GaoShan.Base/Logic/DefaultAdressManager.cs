using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{

    public class DefaultAdressManager : LogicManager<Model.Tb_default_adress>
    {
        public override bool Add(Tb_default_adress t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Tb_default_adress t)
        {
            throw new NotImplementedException();
        }

        public override Tb_default_adress FindThe(params object[] parms)
        {
            return Repository.Query().From<Tb_default_adress>()
                .ToSelect().EndSelect().ToQuery()
                .First<Tb_default_adress>();
        }

        public bool Save(Tb_default_adress info)
        {
            return this.BatchTrans()
                .Append<Tb_default_adress>((r, i) =>
                {
                    if (r.Remove<Tb_default_adress>().Save() < 0)
                    {
                        return false;
                    }

                    return true;
                }, info)
                .Append<Tb_default_adress>((r, i) =>
                {
                    return this.Add(r, i);
                }, info)
                .Save();
        }
    }
}
