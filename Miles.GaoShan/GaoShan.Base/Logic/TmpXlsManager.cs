using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class TmpXlsManager : LogicManager<Model.Info_tmp_xls>
    {
        public override bool Add(Info_tmp_xls t)
        {
            t.Tmp_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Info_tmp_xls t)
        {
            return this.BatchTrans().Append<long>(
     (r, id) =>
     {
         if (r.Remove<Model.Tb_tmp_xls>()
     .Where().And(Model.Tb_tmp_xls.Table.Tmp_Id, t.Tmp_Id)
     .EndWhere()
     .Save() < 1)
         {
             return false;
         }
         return true;
     }, t.Tmp_Id).Append<long>(

              (r, id) =>
              {
                  if (r.Remove<Model.Tb_tmp_xls_var>()
                 .Where().And(Model.Tb_tmp_xls_var.Table.Tmp_Id, t.Tmp_Id)
                 .EndWhere()
                 .Save() < 1)
                  {
                      return false;
                  }
                  return true;
              }, t.Tmp_Id

     ).Append<long>(

              (r, id) =>
              {
                  if (r.Remove<Model.Tb_tmp_xls_map>()
                 .Where().And(Model.Tb_tmp_xls_map.Table.Tmp_Id, t.Tmp_Id)
                 .EndWhere()
                 .Save() < 1)
                  {
                      return false;
                  }
                  return true;
              }, t.Tmp_Id

     ).Save();
        }

        public List<Info_tmp_xls> FindAllTmp()
        {
            List<Model.Info_tmp_xls> list = Repository.Query()
            .From<Model.Tb_tmp_xls>()
            .ToSelect()
            .EndSelect()
            .ToOrderBy()
            .ASC(Model.Tb_tmp_xls.Table.Tmp_Name)
            .EndOrderBy()
            .ToQuery()
            .ToList<Model.Info_tmp_xls>();

            return list;
        }

        public bool UpdateInfo(Info_tmp_xls info)
        {
            if (Repository.Update<Model.Tb_tmp_xls>()
.Set()
.AllFields(info)
.EndSet()
.Where().And(Model.Tb_tmp_xls.Table.Tmp_Id, info.Tmp_Id)
.EndWhere()
.Save() < 1)
            {
                return false;
            }

            return true;
        }

        public byte[] GetTheTmpBody(long tmp_Id)
        {
            Model.Info_tmp_xls part = Repository.Query()
 .From<Model.Info_tmp_xls>()
 .ToSelect()
 .EndSelect()
 .ToWhere()
 .And(Model.Info_tmp_xls.Table.Tmp_Id, tmp_Id)
 .EndWhere()
 .ToQuery()
 .First<Model.Info_tmp_xls>();

            return part != null ? part.Tmp_Body : null;
        }

        public bool SaveBodyAndVars(Info_tmp_xls info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<Info_tmp_xls>
    ((r, i) =>
    {

        if (r.Update<Model.Tb_tmp_xls>()
.Set()
.Field(Model.Tb_tmp_xls.Table.Tmp_Body, info.Tmp_Body)
.EndSet()
.Where().And(Model.Tb_tmp_xls.Table.Tmp_Id, info.Tmp_Id)
.EndWhere()
.Save() < 1)
        {
            return false;
        }

        return true;


    }, info

    );


            exeBatchTrans.Append<long>
                ( (r, id) =>
              {
                  if (r.Remove<Model.Tb_tmp_xls_var>()
                 .Where().And(Model.Tb_tmp_xls_var.Table.Tmp_Id, id)
                 .EndWhere()
                 .Save() < 0)
                  {
                      return false;
                  }
                  return true;
              }, info.Tmp_Id);

            foreach(var item in info.Vars)
            {
                exeBatchTrans.Append<Tb_tmp_xls_var>
                        ((r, i) =>
                        {
                            return Add(r, item);
                        }, item

                        );
            }


            return exeBatchTrans.Save();

        }

        public override Info_tmp_xls FindThe(params object[] parms)
        {
            List<Info_tmp_xls> list=
                 Repository.Query().From<Tb_tmp_xls>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Model.Tb_tmp_xls.Table.Tmp_Id, parms[0])
                .EndWhere()
                .ToQuery()
                .LeftJoin<Model.Tb_tmp_xls_map>()
                .On(Model.Tb_tmp_xls.Table.Tmp_Id, Model.Tb_tmp_xls_map.Table.Tmp_Id)
                .JoinTable()
                .ToSelect()
                .Select(Model.Tb_tmp_xls_map.Table.Tmp_Id, true)
                .EndSelect()
                .ToQuery()
                .QueryOneMany<Info_tmp_xls, Tb_tmp_xls_map, Info_tmp_xls>((i,m) => { if(!string.IsNullOrEmpty(m.Var_Text))i.VarMaps.Add(m); return i; }, Info_tmp_xls.Table.Tmp_Id);

            return list != null && list.Count > 0 ? list[0] : null;



        }

    }
}
