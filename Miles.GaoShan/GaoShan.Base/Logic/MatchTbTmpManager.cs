using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class MatchTbTmpManager : LogicManager<Info_MatchTb_Tmp>
    {
        public override bool Add(Info_MatchTb_Tmp t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Info_MatchTb_Tmp t)
        {
            throw new NotImplementedException();
        }

        public override Info_MatchTb_Tmp FindThe(params object[] parms)
        {
            Info_MatchTb_Tmp matchTbTmp= this.Repository.Query().From<Model.Tb_matchTb_tmp>()
                  .ToSelect().EndSelect()
                  .ToQuery()
                  .First<Info_MatchTb_Tmp>();

            if (matchTbTmp == null)
            {
                this.Repository.Add(new Info_MatchTb_Tmp());
            }

            return matchTbTmp == null ? new Info_MatchTb_Tmp() : matchTbTmp;
        }

        public Info_matchTb_tmp_set GetTheSet(decimal tent_Weight, string tent_MainSpec)
        {
            return this.Repository.Query().From<Tb_matchTb_tmp_set>()
                .ToSelect().EndSelect()
                .ToWhere()
                .And(Tb_matchTb_tmp_set.Table.Tent_Weight,tent_Weight)
                .And(Tb_matchTb_tmp_set.Table.Tent_MainSpec,tent_MainSpec)
                .EndWhere()
                .ToQuery().First<Info_matchTb_tmp_set>();
        }

        public Dictionary<string, string> GetAllVars()
        {
            Info_MatchTb_Tmp matchTbTmp = this.FindThe();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach(var v in matchTbTmp.VarInputs)
            {
                dic.Add(v.Name, v.Text);
            }

            foreach(var v in matchTbTmp.VarCals)
            {
                dic.Add(v.Name, v.Text);
            }

            return dic;
        }

        public bool SaveVarsInput(Info_MatchTb_Tmp tmp)
        {
          return  this.Repository.Update<Model.Tb_matchTb_tmp>()
                .Set()
                .Field(Model.Tb_matchTb_tmp.Table.Var_Input,tmp.Var_Input)
                .EndSet().Save() > 0 ? true : false;
        }


        public bool SaveVarsCal(Info_MatchTb_Tmp tmp)
        {
            return this.Repository.Update<Model.Tb_matchTb_tmp>()
          .Set()
          .Field(Model.Tb_matchTb_tmp.Table.Var_Cal, tmp.Var_Cal)
          .EndSet().Save() > 0 ? true : false;
        }

        public bool SaveSzcLt30(Info_MatchTb_Tmp tmp)
        {
            return this.Repository.Update<Model.Tb_matchTb_tmp>()
 .Set()
 .Field(Model.Tb_matchTb_tmp.Table.Szc_lt30, tmp.Szc_lt30)
 .EndSet().Save() > 0 ? true : false;
        }

        public bool SaveSzcGt30(Info_MatchTb_Tmp tmp)
        {
            return this.Repository.Update<Model.Tb_matchTb_tmp>()
.Set()
.Field(Model.Tb_matchTb_tmp.Table.Szc_gt30, tmp.Szc_gt30)
.EndSet().Save() > 0 ? true : false;
        }

        public bool AddTmpSet(Info_matchTb_tmp_set info)
        {
            info.Set_Id = NewId();
            return this.Add(this.Repository, info);
        }

        public List<Info_matchTb_tmp_set> FindAllSets()
        {
            return this.Repository.Query().From<Tb_matchTb_tmp_set>()
                .ToSelect().EndSelect()
                .ToQuery().ToList<Info_matchTb_tmp_set>();
        }

        public bool UpdateTmpSet(Info_matchTb_tmp_set info)
        {
            return this.Repository.Update<Tb_matchTb_tmp_set>()
                 .Set()
                 .AllFields(info)
                 .EndSet()
                 .Where()
                 .And(Model.Tb_matchTb_tmp_set.Table.Set_Id,info.Set_Id)
                 .EndWhere()
                 .Save() > 0 ? true : false;
        }

        public bool RemoveTmpSet(long set_Id)
        {
            return this.Repository.Remove<Model.Tb_matchTb_tmp_set>()
                .Where().And(Model.Tb_matchTb_tmp_set.Table.Set_Id,set_Id).EndWhere().Save() > 0 ? true : false;
        }

        public bool SaveItems(Info_matchTb_tmp_set info)
        {
            return this.Repository.Update<Tb_matchTb_tmp_set>()
 .Set()
 .Field(Model.Tb_matchTb_tmp_set.Table.Set_Items, info.Set_Items)
 .EndSet()
 .Where()
 .And(Model.Tb_matchTb_tmp_set.Table.Set_Id, info.Set_Id)
 .EndWhere()
 .Save() > 0 ? true : false;
        }

    }
}
