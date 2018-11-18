using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class FinActManager : LogicManager<Model.Tb_fin_act>
    {
        public override bool Add(Tb_fin_act t)
        {
            t.Pay_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Tb_fin_act t)
        {
            if (Repository.Remove<Model.Tb_fin_act>()
.Where().And(Model.Tb_fin_act.Table.Pay_Id, t.Pay_Id)
.EndWhere()
.Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override bool Update(Model.Tb_fin_act tNew, Model.Tb_fin_act tOld)
        {
            tNew.Pay_Id = tOld.Pay_Id;
            if (Repository.Update<Model.Tb_fin_act>()
                .Set()
                .AllFields(tNew)
                .EndSet()
                .Where().And(Model.Tb_fin_act.Table.Pay_Id, tOld.Pay_Id)
                .EndWhere()
                .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override List<Model.Tb_fin_act> FindAll(params object[] parms)
        {
            List<Model.Tb_fin_act> list = Repository
     .Query()
     .From<Model.Tb_fin_act>()
     .ToSelect()
     .EndSelect()
     .ToOrderBy()
     .ASC(Model.Tb_fin_act.Table.Define_Code)
     .EndOrderBy()
     .ToQuery()
     .ToList<Model.Tb_fin_act>();

            return list;
        }



    }
}
