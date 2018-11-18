using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class TmpManager : LogicManager<Model.Info_tmp>
    {
        public override bool Add(Info_tmp t)
        {
            t.Tmp_Id = NewId();
            return Repository.Add(t);
        }

        public override bool Remove(Info_tmp t)
        {
            return this.BatchTrans().Append<long>(
    (r, id) =>
    {
        if (r.Remove<Model.Tb_tmp_info>()
    .Where().And(Model.Tb_tmp_info.Table.Tmp_Id, t.Tmp_Id)
    .EndWhere()
    .Save() < 1)
        {
            return false;
        }
        return true;
    }, t.Tmp_Id).Append<long>(

             (r, id) =>
             {
                 if (r.Remove<Model.Tb_tmp_part>()
                .Where().And(Model.Tb_tmp_part.Table.Tmp_Id, t.Tmp_Id)
                .EndWhere()
                .Save() < 1)
                 {
                     return false;
                 }
                 return true;
             }, t.Tmp_Id

    ).Save();
        }


        public bool SavePartBody(Tb_tmp_part info)
        {
            if (Repository.Update<Model.Tb_tmp_part>()
        .Set()
        .Field(Model.Tb_tmp_part.Table.Part_File, info.Part_File)
        .EndSet()
        .Where().And(Model.Tb_tmp_part.Table.Part_Id, info.Part_Id)
        .EndWhere()
        .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public bool UpdateInfo(Info_tmp info)
        {
            if (Repository.Update<Model.Tb_tmp_info>()
     .Set()
     .AllFields(info)
     .EndSet()
     .Where().And(Model.Tb_tmp_info.Table.Tmp_Id, info.Tmp_Id)
     .EndWhere()
     .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public Tb_tmp_main GetTmpMain()
        {
            return Repository.Query().From<Tb_tmp_main>()
                  .ToSelect().EndSelect()
                  .ToQuery()
                  .First<Tb_tmp_main>();
        }

        public bool UpdateTmpMain(Tb_tmp_main info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();

            exeBatchTrans.Append<int>((r, s) =>
            {
                if(r.Remove<Tb_tmp_main>().Save() < 0)
                {
                    return false;
                }

                return true;

            }, 0);

            exeBatchTrans.Append<Tb_tmp_main>((r, i) =>
            {
                return Add(r,i);

            }, info);

            return exeBatchTrans.Save();
        }

        public bool UpdateTmpOtherInfo(Tb_tmp_info info)
        {
            if (Repository.Update<Model.Tb_tmp_info>()
.Set()
.Field(Model.Tb_tmp_info.Table.Item_Table_Seq, info.Item_Table_Seq)
.Field(Model.Tb_tmp_info.Table.Item_Clause_Seq,info.Item_Clause_Seq)
.Field(Model.Tb_tmp_info.Table.Item_Pay_Seq, info.Item_Pay_Seq)
.EndSet()
.Where().And(Model.Tb_tmp_info.Table.Tmp_Id, info.Tmp_Id)
.EndWhere()
.Save() < 1)
            {
                return false;
            }

            return true;
        }

        public List<Tb_tmp_part> GetAllParts(long tmp_Id)
        {
            List<Model.Tb_tmp_part> list = Repository.Query()
            .From<Model.Tb_tmp_part>()
            .ToSelect()
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_tmp_part.Table.Tmp_Id,tmp_Id)
            .EndWhere()
            .ToOrderBy()
            .ASC(Model.Tb_tmp_part.Table.Part_Seq).EndOrderBy()
            .ToQuery()
            .ToList<Model.Tb_tmp_part>();

            return list;
        }

        public List<Tb_tmp_map> GetAllVars(long tmp_Id)
        {
            List<Model.Tb_tmp_map> list = Repository.Query()
  .From<Model.Tb_tmp_map>()
  .ToSelect()
  .EndSelect()
  .ToWhere()
  .And(Model.Tb_tmp_map.Table.Tmp_Id, tmp_Id)
  .EndWhere()
  .ToOrderBy()
  .ASC(Model.Tb_tmp_map.Table.Var_Name).EndOrderBy()
  .ToQuery()
  .ToList<Model.Tb_tmp_map>();

            return list;
        }

        public Info_tmp GetTheTmpAllInfo(long tmp_Id)
        {
            Model.Info_tmp tmpInfo = Repository.Query()
.From<Model.Tb_tmp_info>()
.ToSelect()
.EndSelect()
.ToWhere()
.And(Model.Tb_tmp_info.Table.Tmp_Id, tmp_Id)
.EndWhere()
.ToOrderBy()
.ASC(Model.Tb_tmp_info.Table.Order_Type).EndOrderBy()
.ToQuery()
.First<Model.Info_tmp>();
            if (tmpInfo == null) { return null; }
            tmpInfo.VarMaps = GetAllVars(tmp_Id);
            tmpInfo.Parts = GetAllParts(tmp_Id);

            return tmpInfo;
        }

        public bool SaveTmpVars(long tmpId, List<string> parms)
        {
            return this.BatchTrans()
        .Append<long>((r, id) =>
        {
            if (r.Remove<Model.Tb_tmp_var>()
                        .Where().And(Model.Tb_tmp_var.Table.Tmp_Id, id)
                        .EndWhere().Save() < 0)
            {
                return false;
            }

            return true;
        }, tmpId)
        .Append<long>((r, id) =>
        {
            foreach (string parm in parms)
            {
                Model.Tb_tmp_var tbParm = new Model.Tb_tmp_var();
                tbParm.Tmp_Id = id;
                tbParm.Var_Name = parm.Substring(2, parm.Length - 3);
                tbParm.Var_Text = parm;
                if (!r.Add(tbParm))
                {
                    return false;
                }
            }

            return true;
        }, tmpId)
        .Save();

        }

        public bool RemovePart(Tb_tmp_part info)
        {
            if (Repository.Remove<Model.Tb_tmp_part>()
            .Where().And(Model.Tb_tmp_part.Table.Part_Id, info.Part_Id)
            .EndWhere()
            .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public bool AddPartInfo(Tb_tmp_part info)
        {
            info.Part_Id = NewId();
            return Repository.Add(info);
        }

        public List<Info_tmp> GetAllTmp()
        {
            List<Model.Info_tmp> list = Repository.Query()
    .From<Model.Tb_tmp_info>()
    .ToSelect()
    .EndSelect()
    .ToOrderBy()
    .ASC(Model.Tb_tmp_info.Table.Order_Type).EndOrderBy()
    .ToQuery()
    .ToList<Model.Info_tmp>();

            return list;
        }

        public bool UpdatePartInfo(Tb_tmp_part info)
        {
            if (Repository.Update<Model.Tb_tmp_part>()
         .Set()
         .AllFields(info)
         .FieldExclude(Model.Tb_tmp_part.Table.Part_File)
         .EndSet()
         .Where().And(Model.Tb_tmp_part.Table.Part_Id, info.Part_Id)
         .EndWhere()
         .Save() < 1)
            {
                return false;
            }

            return true;
        }

        public List<Info_tmp_map> GetTmpDynamicVars(long tmp_Id)
        {
            List<Model.Info_tmp_map> list = Repository.Query()
.From<Model.Tb_tmp_map>()
.ToSelect()
.EndSelect()
.ToWhere()
.AndIsNull(Model.Tb_tmp_map.Table.Field_Name)
.And(Model.Tb_tmp_map.Table.Tmp_Id,tmp_Id)
.EndWhere()
.ToOrderBy()
.ASC(Model.Tb_tmp_map.Table.Var_Name)
.EndOrderBy()
.ToQuery()
.ToList<Model.Info_tmp_map>();

            return list;
        }

        public byte[] GetTmpClause(long tmp_Id)
        {
            Model.Tb_tmp_part part = Repository.Query()
            .From<Model.Tb_tmp_part>()
            .ToSelect()
            .EndSelect()
            .ToWhere()
            .And(Model.Tb_tmp_part.Table.Tmp_Id, tmp_Id)
            .And(Model.Tb_tmp_part.Table.Part_Seq, 3)
            .EndWhere()
            .ToQuery()
            .First<Model.Tb_tmp_part>();

            return part != null ? part.Part_File : null ;
        }
    }
}
