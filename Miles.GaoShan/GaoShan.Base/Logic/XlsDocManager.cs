using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class XlsDocManager : LogicManager<Model.Info_xls_doc>
    {
        public override bool Add(Info_xls_doc t)
        {
            t.Tmp_Id = NewId();
            return this.Add(this.Repository, t);
        }

        public override bool Remove(Info_xls_doc t)
        {
           return this.Repository.Remove<Tb_tmp_xls_doc>().Where()
                .And(Tb_tmp_xls_doc.Table.Tmp_Id, t.Tmp_Id)
                .EndWhere().Save() > 0 ? true : false;
        }

        public bool UpdateInfo(Info_xls_doc info)
        {
            return this.Repository.Update<Tb_tmp_xls_doc>()
                .Set().AllFields(info).FieldExclude(Tb_tmp_xls_doc.Table.Tmp_Body).EndSet()
                .Where().And(Tb_tmp_xls_doc.Table.Tmp_Id, info.Tmp_Id)
                .EndWhere().Save() > 0 ? true : false;
        }

        public List<Info_xls_doc> FindAllTmp()
        {
            return Repository.Query().From<Tb_tmp_xls_doc>().ToSelect().EndSelect()
                 .ToQuery().ToList<Info_xls_doc>();
        }

        public bool SaveBody(Info_xls_doc info)
        {
            return this.Repository.Update<Tb_tmp_xls_doc>()
      .Set().Field(Tb_tmp_xls_doc.Table.Tmp_Body,info.Tmp_Body)
      .EndSet()
      .Where().And(Tb_tmp_xls_doc.Table.Tmp_Id, info.Tmp_Id)
      .EndWhere().Save() > 0 ? true : false;
        }
    }
}
