using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class TruckInfoManager : LogicManager<Model.Tb_truck_info>
    {
        public override bool Add(Tb_truck_info t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Tb_truck_info t)
        {
            throw new NotImplementedException();
        }

        public override List<Tb_truck_info> FindAll(params object[] parms)
        {
            return this.Repository.Query().From<Tb_truck_info>()
                .ToSelect().EndSelect().ToQuery().ToList<Tb_truck_info>();
        }

        public bool Save(List<Tb_truck_info> list)
        {
          ExeBatchTrans exeBatchTrans=  this.BatchTrans()
                 .Append<long>((r, id) =>
                 {
                     if (r.Remove<Tb_truck_info>().Save() < 0)
                     {
                         return false;
                     }
                     return true;
                 }, 1);

            foreach(var v in list)
            {
                exeBatchTrans.Append<Tb_truck_info>((r,info)=> {
                    return this.Add(r, info);
                },v);
            }

            return exeBatchTrans.Save();
        }
    }
}
