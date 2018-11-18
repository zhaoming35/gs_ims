using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class ProjectOutcomeManager : LogicManager<Model.Info_fin_order_outcome>
    {
        Logic.ProcessManager processManager = new ProcessManager();

        public override bool Add(Info_fin_order_outcome t)
        {
            throw new NotImplementedException();
        }


        public override bool Remove(Info_fin_order_outcome t)
        {
            if (this.Repository.Remove<Tb_fin_order_outcome>().Where()
   .And(Tb_fin_order_outcome.Table.Fin_Id, t.Fin_Id)
   .EndWhere().Save() < 1)
            {
                return false;
            }
            return true;
        }

        public List<Info_fin_order_outcome> FindAllNoCommitInfo()
        {
            return this.Repository.Query().From<Tb_fin_order_outcome>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Tb_fin_order_outcome.Table.Fin_State, (int)Enum.FinState.New)
                .EndWhere()
                .ToQuery()
                .ToList<Info_fin_order_outcome>();
        }

        public bool Save(Info_fin_order_outcome info)
        {
            return this.BatchTrans()
                .Append<long>(
                (r, id) =>
                {
                    if (r.Remove<Tb_fin_order_outcome>().Where()
                    .And(Tb_fin_order_outcome.Table.Fin_Id, id)
                    .EndWhere().Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }
                , info.Fin_Id
                )
                .Append<Tb_fin_order_outcome>
                ((r, l) =>
                {
                    l.Fin_Id = NewId();
                    if (!Add(r, l))
                    {
                        return false;
                    }

                    return true;
                }, info)
                .Save();
        }

        public bool Commit(Info_fin_order_outcome info)
        {
            if (this.Repository.Update<Tb_fin_order_outcome>()
                .Set()
                .Field(Model.Tb_fin_order_outcome.Table.Fin_State, (int)Enum.FinState.Commit)
                .EndSet()
                .Where()
                .And(Tb_fin_order_outcome.Table.Fin_Id, info.Fin_Id)
                .EndWhere().Save() < 1)
            {
                return false;
            }
            return true;
        }

        public List<Info_fin_order_outcome> FindAllCommitInfo()
        {
            return this.Repository.Query().From<Tb_fin_order_outcome>()
     .ToSelect().EndSelect()
     .ToWhere()
     .And(Tb_fin_order_outcome.Table.Fin_State, (int)Enum.FinState.Commit)
     .EndWhere()
     .ToQuery()
     .ToList<Info_fin_order_outcome>();
        }

        public bool CheckOutcomeNoPass(Info_fin_order_outcome info, string msg = "退款费用审核不通过")
        {
            return processManager.RejectFinOutcome(info, msg);
        }

        public bool CheckOutcomePass(Info_fin_order_outcome info)
        {
            return processManager.AdoptFinOutcome(info);
        }
    }
}
