using Miles.App.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.App.Entity.Logic
{
    public class EnumManager : LogicManager<Model.Tb_enum>
    {
        public override bool Add(Tb_enum t)
        {
            t.Item_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Tb_enum t)
        {
            if (Repository.Remove<Model.Tb_enum>()
            .Where().And(Model.Tb_enum.Table.Item_Id, t.Item_Id)
            .EndWhere()
            .Save() < 1)
            {
                return false;
            }

            return true;
        }


        public bool RemoveKind(Tb_enum t)
        {
            if (Repository.Remove<Model.Tb_enum>()
            .Where().And(Model.Tb_enum.Table.Enum_Kind, t.Enum_Kind)
            .EndWhere()
            .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public override bool Update(Model.Tb_enum tNew, Model.Tb_enum tOld)
        {
            tNew.Item_Id = tOld.Item_Id;
            if (Repository.Update<Model.Tb_enum>()
                .Set()
                .AllFields(tNew)
                .EndSet()
                .Where().And(Model.Tb_enum.Table.Item_Id, tOld.Item_Id)
                .EndWhere()
                .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public Dictionary<int, string> FindKindMap(string enumKind)
        {
            List<Model.Tb_enum> list = FindKindAllInfo(enumKind);

            Dictionary<int, string> dicMap = new Dictionary<int, string>();
            if (list != null)
            {
                foreach (var v in list)
                {
                    dicMap.Add((int)v.Enum_Value, v.Enum_Text);
                }

            }

            return dicMap;
        }

        public Tb_enum FindKindThe(string kind, int enumValue)
        {
            Model.Tb_enum info = Repository
            .Query()
            .From<Model.Tb_enum>()
            .ToSelect()
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_enum.Table.Enum_Kind, kind)
            .And(Model.Tb_enum.Table.Item_Flag, 0)
            .And(Model.Tb_enum.Table.Enum_Value, enumValue)
            .EndWhere()
            .ToQuery()
            .First<Model.Tb_enum>();

            return info;
        }

        public List<Tb_enum> FindKindAllInfo(string enumKind)
        {
            List<Model.Tb_enum> list = Repository
            .Query()
            .From<Model.Tb_enum>()
            .ToSelect()
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_enum.Table.Enum_Kind, enumKind)
            .And(Model.Tb_enum.Table.Item_Flag, 0)
            .EndWhere()
            .ToOrderBy()
            .ASC(Model.Tb_enum.Table.Enum_Value)
            .EndOrderBy()
            .ToQuery()
            .ToList<Model.Tb_enum>();

            return list;

        }

        public List<Tb_enum> FindAllKind()
        {
            List<Model.Tb_enum> list = Repository
            .Query()
            .From<Model.Tb_enum>()
            .ToSelect()
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_enum.Table.Item_Flag, 1)
            .EndWhere()
            .ToQuery()
            .ToList<Model.Tb_enum>();

            return list;
        }

        public bool ExistsKind(string kind)
        {
            List<Model.Tb_enum> list = Repository
            .Query()
            .From<Model.Tb_enum>()
            .ToSelect()
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_enum.Table.Item_Flag, 1)
            .And(Model.Tb_enum.Table.Enum_Kind, kind)
            .EndWhere()
            .ToQuery()
            .ToList<Model.Tb_enum>();

            return (list != null && list.Count > 0) ? true : false;
        }
    }
}
