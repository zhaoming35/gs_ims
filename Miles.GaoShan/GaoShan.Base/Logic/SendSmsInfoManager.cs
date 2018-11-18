using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class SendSmsInfoManager : LogicManager<Model.Tb_send_sms_info>
    {
        public override bool Add(Tb_send_sms_info t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Tb_send_sms_info t)
        {
            throw new NotImplementedException();
        }

        public List<Tb_send_sms_info> GetSmsInfo()
        {
            return this.Repository.Find().From<Tb_send_sms_info>()
                .Select().End()
                .ToQuery()
                .ToList<Tb_send_sms_info>();
        }

        public bool Save(List<Tb_send_sms_info> list)
        {
           ExeBatchTrans exeBatchTrans= this.BatchTrans();

            exeBatchTrans.Append<long>((r,id)=> 
            {
                if (r.Remove<Tb_send_sms_info>()
                .Save() < 0) { return false; }

                return true;
            },0); 

            foreach (var v in list)
            {
                exeBatchTrans.Append<Tb_send_sms_info>((r, item) =>
                {
                    return Add(r, item);

                }, v);
            }

            return exeBatchTrans.Save();
        }
    }
}
