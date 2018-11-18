using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class ProductManager : LogicManager<Model.Tb_product_info>
    {
        public override bool Add(Tb_product_info t)
        {
            t.Product_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Tb_product_info t)
        {
            return this.BatchTrans().Append<long>(
                (r, id) =>
                {
                    if (r.Remove<Model.Tb_product_info>()
                .Where().And(Model.Tb_product_info.Table.Product_Id, t.Product_Id)
                .EndWhere()
                .Save() < 1)
                    {
                        return false;
                    }
                    return true;
                }, t.Product_Id).Append<long>(

                         (r, id) =>
                         {
                             if (r.Remove<Model.Tb_product_property>()
                            .Where().And(Model.Tb_product_property.Table.Product_Id, t.Product_Id)
                            .EndWhere()
                            .Save() < 1)
                             {
                                 return false;
                             }
                             return true;
                         }, t.Product_Id

                ).Save();

        }

        public override bool Update(Model.Tb_product_info tNew, Model.Tb_product_info tOld)
        {
            tNew.Product_Id = tOld.Product_Id;
            if (Repository.Update<Model.Tb_product_info>()
                .Set()
                .AllFields(tNew)
                .EndSet()
                .Where().And(Model.Tb_product_info.Table.Product_Id, tOld.Product_Id)
                .EndWhere()
                .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override List<Tb_product_info> FindAll(params object[] parms)
        {
            return Repository.Query().From<Model.Tb_product_info>()
                .ToSelect().EndSelect()
                       .ToOrderBy()
                .ASC(Model.Tb_product_info.Table.Seq_No)
                .EndOrderBy()
                .ToQuery().ToList<Tb_product_info>();
        }

    }
}
