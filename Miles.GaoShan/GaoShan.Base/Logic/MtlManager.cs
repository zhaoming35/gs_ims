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
    public class MtlManager : LogicManager<Model.Info_mtl_item>
    {
        public override bool Add(Info_mtl_item t)
        {
            //同时增加库存0数据
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<Info_mtl_item>((r,i)=>
            {
                return Add(r,i);
            },t);

            exeBatchTrans.Append<Info_mtl_item>((r, i) =>
            {
                Model.Tb_store_main store = new Tb_store_main();
                store.Mtl_Code = i.Mtl_Code;
                store.Mtl_Qty = 0;
                return Add(r, store);
            }, t);

            return exeBatchTrans.Save();
        }

        public override bool Remove(Info_mtl_item t)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            //删除库存数据
            exeBatchTrans.Append<string>((r, c) =>
            {
                return r.Remove<Tb_mtl_item>().Where()
          .And(Model.Tb_mtl_item.Table.Mtl_Code, c)
          .EndWhere()
          .Save() > 0 ? true : false;

            }, t.Mtl_Code);

            exeBatchTrans.Append<string>((r, c) =>
            {
                return r.Remove<Tb_store_main>().Where()
          .And(Model.Tb_store_main.Table.Mtl_Code, c)
          .EndWhere()
          .Save() > 0 ? true : false;

            }, t.Mtl_Code);

            return exeBatchTrans.Save();
        }

        public override bool Update(Info_mtl_item tNew, Info_mtl_item tOld)
        {
            return this.Repository.Update<Tb_mtl_item>().Set().AllFields(tNew).EndSet()
                .Where().And(Tb_mtl_item.Table.Mtl_Code, tOld.Mtl_Code).EndWhere()
                .Save() > 0 ? true : false;
        }

        public List<Bu_MatchTb_Item> GetRangeItems(Dictionary<string,string> setItems)
        {
            List<Info_mtl_item> list= Repository.Query()
               .From<Tb_mtl_item>()
               .ToSelect().EndSelect()
               .ToWhere()
               .In(Model.Tb_mtl_item.Table.Mtl_Code,setItems.Keys.ToArray())
               .EndWhere()
               .ToQuery()
               .LeftJoin<Tb_mtl_kind>()
               .On(Model.Tb_mtl_item.Table.Kind_Code, Model.Tb_mtl_kind.Table.Kind_Code)
               .JoinTable()
               .ToSelect()
               .Select(Model.Tb_mtl_kind.Table.Kind_Name)
               .EndSelect()
               .ToQuery()
               .ToList<Info_mtl_item>();

            List<Bu_MatchTb_Item> result = new List<Bu_MatchTb_Item>();

            if (list != null)
            {
                foreach(var v in list)
                {
                    Bu_MatchTb_Item item= Miles.Coro.Common.Utils.CopyToChild<Model.Info_mtl_item, Model.Bu_MatchTb_Item>(v);
                    item.ItemFormula = setItems[v.Mtl_Code];

                    result.Add(item);
                }
            }

            return result;
        }

        public Dictionary<string,Model.Tb_mtl_kind> GetAllKind()
        {
            Dictionary<string, Model.Tb_mtl_kind> dic = this.Repository.Query()
            .From<Tb_mtl_kind>()
            .ToSelect().EndSelect()
            .ToWhere()
            .EndWhere()
            .ToOrderBy()
            .ASC(Model.Tb_mtl_kind.Table.Kind_Code)
            .EndOrderBy()
            .ToQuery()
            .ToMapKeyItem<string, Model.Tb_mtl_kind>(Model.Tb_mtl_kind.Table.Kind_Code);

            return dic;
        }

        public Dictionary<string, Info_mtl_kind> GetAllGroupKind()
        {
            List<Info_mtl_kind> list = GetAllRelationKind();
            Dictionary<string, Info_mtl_kind> dic = new Dictionary<string, Info_mtl_kind>();
            foreach(var v in list)
            {
                AddChildKind(v,v,ref dic);
            }

            return dic;
        }

        private void AddChildKind(Info_mtl_kind group, Info_mtl_kind kind, ref Dictionary<string, Info_mtl_kind> childs)
        {
            foreach(var c in kind.Children)
            {
                childs.Add(c.Kind_Code, group);
                if (c.Children.Count > 0)
                {
                    AddChildKind(group,c, ref childs);
                }
            }
        }

        public List<Info_mtl_kind> GetAllRelationKind()
        {
           List<Info_mtl_kind> list = this.Repository.Query().From<Tb_mtl_kind>()
          .ToSelect().EndSelect()
          .ToOrderBy()
          .ASC(Model.Tb_mtl_kind.Table.Kind_Code)
          .EndOrderBy()
          .ToQuery()
          .ToList<Info_mtl_kind>();

            var queryRoot = from item in list
                            where item.Kind_Level == 0
                            select item;

            List<Info_mtl_kind> rootList = queryRoot.ToList<Info_mtl_kind>();

            foreach(var kind in rootList)
            {
          
                GetChildren(list, kind);
            }
            //List <Info_mtl_kind> rootList = this.Repository.Query().From<Tb_mtl_kind>()
            //        .ToSelect().EndSelect()
            //        .ToWhere()
            //        .And(Model.Tb_mtl_kind.Table.Kind_Level, 0)
            //        .EndWhere()
            //        .ToOrderBy()
            //        .ASC(Model.Tb_mtl_kind.Table.Kind_Code)
            //        .EndOrderBy()
            //        .ToQuery()
            //        .ToList<Info_mtl_kind>();

            //   if (rootList != null)
            //       for (int i = 0; i < rootList.Count; i++)
            //       {
            //           Info_mtl_kind kind = rootList[i];
            //           GetChildren(this.Repository, ref kind);
            //       }

            return rootList;
        }

        private void GetChildren(List<Info_mtl_kind> list, Info_mtl_kind parentKind)
        {
            var queryChild = from item in list
                             where item.Kind_Parent == parentKind.Kind_Code
                             select item;

            foreach(var v in queryChild)
            {
                parentKind.Children.Add(v);
                GetChildren(list, v);
            }
        }

        //private void GetChildren(Repository repository, ref Info_mtl_kind parentKind)
        //{
        //    List<Info_mtl_kind> childrenList = repository.Query().From<Tb_mtl_kind>()
        //    .ToSelect().EndSelect()
        //    .ToWhere()
        //    .And(Model.Tb_mtl_kind.Table.Kind_Parent, parentKind.Kind_Code)
        //    .EndWhere()
        //    .ToOrderBy()
        //    .ASC(Model.Tb_mtl_kind.Table.Kind_Code)
        //    .EndOrderBy()
        //    .ToQuery()
        //    .ToList<Info_mtl_kind>();

        //    if (childrenList != null && childrenList.Count > 0)
        //    {
        //        parentKind.Children = childrenList;

        //        for (int i = 0; i < childrenList.Count; i++)
        //        {
        //            Info_mtl_kind kind = childrenList[i];
        //            kind.ParentName = parentKind.Kind_Name;
        //            GetChildren(repository, ref kind);
        //        }
        //    }

        //}

        public bool AddKind(Info_mtl_kind info)
        {
            return this.Add(Repository, info);
        }

        public bool UpdateKind(Info_mtl_kind info, Info_mtl_kind old)
        {
            return this.Repository.Update<Model.Tb_mtl_kind>().Set().AllFields(info).EndSet()
                 .Where().And(Model.Tb_mtl_kind.Table.Kind_Code, old.Kind_Code).EndWhere().Save() > 0 ? true : false;
        }

        public bool DeleteKind(Info_mtl_kind kind)
        {
            return this.Repository.Remove<Tb_mtl_kind>()
                .Where()
                .And(Tb_mtl_kind.Table.Kind_Code, kind.Kind_Code)
                .EndWhere()
                .Save() > 0 ? true : false;
        }

        public List<Info_mtl_item> GetKindItems(string Kind_Code)
        {
            return Repository.Query()
                .From<Tb_mtl_item>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_mtl_item.Table.Kind_Code, Kind_Code)
                .EndWhere()
                .ToQuery()
                .LeftJoin<Tb_mtl_kind>()
                .On(Model.Tb_mtl_item.Table.Kind_Code, Model.Tb_mtl_kind.Table.Kind_Code)
                .JoinTable()
                .ToSelect()
                .Select(Model.Tb_mtl_kind.Table.Kind_Name)
                .EndSelect()
                .ToQuery()
                .ToList<Info_mtl_item>();
        }

        public List<Info_mtl_item> GetAllItems()
        {
            return Repository.Query()
                .From<Tb_mtl_item>()
                .ToSelect().EndSelect()
                .ToWhere()
                .EndWhere()
                .ToQuery()
                .LeftJoin<Tb_mtl_kind>()
                .On(Model.Tb_mtl_item.Table.Kind_Code, Model.Tb_mtl_kind.Table.Kind_Code)
                .JoinTable()
                .ToSelect()
                .Select(Model.Tb_mtl_kind.Table.Kind_Name)
                .EndSelect()
                .ToOrderBy()
                .ASC(Model.Tb_mtl_item.Table.Kind_Code)
                .EndOrderBy()
                .ToQuery()
                .ToList<Info_mtl_item>();
        }

        public Dictionary<string,Info_mtl_item> GetMapItems()
        {
            return Repository.Query()
                .From<Tb_mtl_item>()
                .ToSelect().EndSelect()
                .ToWhere()
                .EndWhere()
                .ToQuery()
                .LeftJoin<Tb_mtl_kind>()
                .On(Model.Tb_mtl_item.Table.Kind_Code, Model.Tb_mtl_kind.Table.Kind_Code)
                .JoinTable()
                .ToSelect()
                .Select(Model.Tb_mtl_kind.Table.Kind_Name)
                .EndSelect()
                .ToOrderBy()
                .ASC(Model.Tb_mtl_item.Table.Kind_Code)
                .EndOrderBy()
                .ToQuery()
                .ToMapKeyItem<string,Info_mtl_item>(Model.Tb_mtl_item.Table.Mtl_Code);
        }
    }
}
