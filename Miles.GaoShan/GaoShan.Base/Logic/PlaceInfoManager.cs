using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Logic
{
    public class PlaceInfoManager : LogicManager<Model.Info_place_info>
    {
        public override bool Add(Info_place_info t)
        {
            t.Place_Id = NewId();
            return this.Add(Repository, t);
        }

        public override bool Remove(Info_place_info t)
        {
           ExeBatchTrans batchTrans= this.BatchTrans();
            batchTrans.Append<long>((r, id) => {

                if (r.Remove<Tb_place_info>().Where()
                .And(Model.Tb_place_info.Table.Place_Id, id)
                .EndWhere().Save() < 1)
                {
                    return false;
                }

                return true;
            }, t.Place_Id);

            AddDeleteBatch(batchTrans, t);

            return batchTrans.Save();
        }


        private void AddDeleteBatch(ExeBatchTrans batchTrans, Info_place_info t)
        {
         
            if (t.Children.Count > 0)
            {
                batchTrans.Append<long>((r,id)=> {

                    if(r.Remove<Tb_place_info>().Where()
                    .And(Model.Tb_place_info.Table.Parent_Id, id)
                    .EndWhere().Save() < 1)
                    {
                        return false;
                    }

                    return true;
                },t.Place_Id);

                foreach (var v in t.Children)
                {
                    AddDeleteBatch(batchTrans, v);
                }
            }

   
        }

        public override bool Update(Info_place_info tNew, Info_place_info tOld)
        {
            return this.Repository.Update<Tb_place_info>()
                .Set()
                .Field(Model.Tb_place_info.Table.Place_Name,tNew.Place_Name)
                .EndSet()
                .Where().And(Tb_place_info.Table.Place_Id, tNew.Place_Id)
                .EndWhere()
                .Save() > 0 ? true : false;
        }

        public Dictionary<long,Info_place_info> GetAllPlaces()
        {
            Dictionary<long, Info_place_info> list = this.Repository.Query().From<Tb_place_info>()
            .ToSelect().EndSelect()
            .ToOrderBy()
            .ASC(Tb_place_info.Table.Place_Id)
            .EndOrderBy()
            .ToQuery()
            .ToMapKeyItem<long, Info_place_info>(Tb_place_info.Table.Place_Id);

            return list;
        }

        public Info_place_info GetAll2Root()
        {
            List<Info_place_info> list= this.Repository.Query().From<Tb_place_info>()
             .ToSelect().EndSelect()
             .ToOrderBy()
             .ASC(Tb_place_info.Table.Place_Id)
             .EndOrderBy()
             .ToQuery()
             .ToList<Info_place_info>();

            var rootQuery = from item in list
                       where item.Level == 0
                       select item;

            Info_place_info root=null;
            foreach(var v in rootQuery)
            {
                root = v;
                break;
            }

            GetChildren(list, root);

            return root;
        }

        private void GetChildren(List<Info_place_info> list, Info_place_info parent)
        {
            var queryChild = from item in list
                             where item.Parent_Id == parent.Place_Id
                             select item;

            foreach (var v in queryChild)
            {
                parent.Children.Add(v);
                v.Parent = parent;
                GetChildren(list, v);
            }

        }

       

    }
}
