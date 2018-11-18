using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class ProjectIncomeManager : LogicManager<Model.Info_fin_order_income>
    {
        Logic.ProcessManager processManager = new ProcessManager();
        public override bool Add(Info_fin_order_income t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_fin_order_income t)
        {
            if (this.Repository.Remove<Tb_fin_order_income>().Where()
   .And(Tb_fin_order_income.Table.Fin_Id, t.Fin_Id)
   .EndWhere().Save() < 1)
            {
                return false;
            }
            return true;
        }

        public List<Info_fin_order_income> FindAllNoCommitInfo()
        {
            return this.Repository.Query().From<Tb_fin_order_income>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Tb_fin_order_income.Table.Fin_State,(int)Enum.FinState.New)
                .EndWhere()
                .ToQuery()
                .ToList<Info_fin_order_income>();
        }

        public bool Save(Info_fin_order_income info)
        {
            return this.BatchTrans()
                .Append<long>(
                (r, id) =>
                {
                    if (r.Remove<Tb_fin_order_income>().Where()
                    .And(Tb_fin_order_income.Table.Fin_Id, id)
                    .EndWhere().Save() < 0)
                    {
                        return false;
                    }
                    return true;
                }
                , info.Fin_Id
                )
                .Append<Tb_fin_order_income>
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

        public bool Commit(Info_fin_order_income info)
        {
            if (this.Repository.Update<Tb_fin_order_income>()
                .Set()
                .Field(Model.Tb_fin_order_income.Table.Fin_State, (int)Enum.FinState.Commit)
                .EndSet()
                .Where()
                .And(Tb_fin_order_income.Table.Fin_Id, info.Fin_Id)
                .EndWhere().Save() < 1)
            {
                return false;
            }
            return true;
        }

        public List<Info_fin_order_income> FindAllCommitInfo()
        {
            return this.Repository.Query().From<Tb_fin_order_income>()
     .ToSelect().EndSelect()
     .ToWhere()
     .And(Tb_fin_order_income.Table.Fin_State, (int)Enum.FinState.Commit)
     .EndWhere()
     .ToQuery()
     .ToList<Info_fin_order_income>();
        }

        public bool CheckIncomeNoPass(Info_fin_order_income info, string msg = "回款费用审核不通过")
        {
            return processManager.RejectFinIncome(info,msg);
        }

        public bool CheckIncomePass(Info_fin_order_income info)
        {
            return processManager.AdoptFinIncome(info);
        }
    }
}
