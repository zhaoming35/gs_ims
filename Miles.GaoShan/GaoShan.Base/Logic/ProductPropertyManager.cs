using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class ProductPropertyManager : LogicManager<Model.Tb_product_property>
    {
        public override bool Add(Tb_product_property t)
        {
            t.Property_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Tb_product_property t)
        {
            if (Repository.Remove<Model.Tb_product_property>()
.Where().And(Model.Tb_product_property.Table.Property_Id, t.Property_Id)
.EndWhere()
.Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override bool Update(Model.Tb_product_property tNew, Model.Tb_product_property tOld)
        {
            tNew.Product_Id = tOld.Product_Id;
            if (Repository.Update<Model.Tb_product_property>()
                .Set()
                .AllFields(tNew)
                .EndSet()
                .Where().And(Model.Tb_product_property.Table.Property_Id, tOld.Property_Id)
                .EndWhere()
                .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public List<Info_product_property> FindAllInfo(long product_Id)
        {
            return Repository.Query().From<Model.Tb_product_property>().ToSelect().EndSelect()
            .ToWhere()
            .And(Model.Tb_product_property.Table.Product_Id, product_Id)
            .EndWhere()
            .ToOrderBy()
            .ASC(Model.Tb_product_property.Table.Property_Seq)
            .EndOrderBy()
            .ToQuery().ToList<Info_product_property>();
        }

        public override List<Tb_product_property> FindAll(params object[] parms)
        {
            return Repository.Query().From<Model.Tb_product_property>().ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_product_property.Table.Product_Id, parms[0])
                .EndWhere()
                .ToOrderBy()
                .ASC(Model.Tb_product_property.Table.Property_Seq)
                .EndOrderBy()
                .ToQuery().ToList<Tb_product_property>();

        }

    }
}
