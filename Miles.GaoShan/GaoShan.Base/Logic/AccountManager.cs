using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaoShan.Sales.Logic
{
    public class AccountManager : LogicManager<Model.Tb_company_act>
    {
        public override bool Add(Model.Tb_company_act t)
        {
            t.Act_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Model.Tb_company_act t)
        {
            if (Repository.Remove<Model.Tb_company_act>()
         .Where().And(Model.Tb_company_act.Table.Act_Id, t.Act_Id)
         .EndWhere()
         .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override bool Update(Model.Tb_company_act tNew, Model.Tb_company_act tOld)
        {
            tNew.Act_Id = tOld.Act_Id;
            if (Repository.Update<Model.Tb_company_act>()
                .Set()
                .AllFields(tNew)
                .EndSet()
                .Where().And(Model.Tb_company_act.Table.Act_Id, tOld.Act_Id)
                .EndWhere()
                .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override List<Model.Tb_company_act> FindAll(params object[] parms)
        {
            List<Model.Tb_company_act> list = Repository
     .Query()
     .From<Model.Tb_company_act>()
     .ToSelect()
     .EndSelect()
     .ToOrderBy()
     .ASC(Model.Tb_fin_act.Table.Define_Code)
     .EndOrderBy()
     .ToQuery()
     .ToList<Model.Tb_company_act>();

            return list;
        }

    }
}
