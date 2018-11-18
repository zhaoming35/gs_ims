using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class ExpendItemManager : LogicManager<Model.Tb_expend_item>
    {
        public override bool Add(Tb_expend_item t)
        {
            return Repository.Add(t);
        }

        public override bool Remove(Tb_expend_item t)
        {
            if (Repository.Remove<Model.Tb_expend_item>()
 .Where().And(Model.Tb_expend_item.Table.Item_Value, t.Item_Value)
 .EndWhere()
 .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override List<Tb_expend_item> FindAll(params object[] parms)
        {
            return Repository.Find().From<Tb_expend_item>()
                 .Select().End()
                 .OrderBy()
                 .ASC(Tb_expend_item.Table.Item_Value)
                 .End()
                 .ToQuery()
                 .ToList<Tb_expend_item>();
        }

        public bool Save(List<Tb_expend_item> items)
        {
          ExeBatchTrans exeBatchTrans=  this.BatchTrans();

            exeBatchTrans.Append<int>((r,id)=> 
            {
                if(r.Remove<Tb_expend_item>().Save() < 0)
                {
                    return false;
                }

                return true;
            },0);

            foreach(var v in items)
            {
                exeBatchTrans.Append<Tb_expend_item>((r, it) =>
                {
                    return this.Add(r, it);

                }, v);
            }

            return exeBatchTrans.Save();
        }
    }
}
