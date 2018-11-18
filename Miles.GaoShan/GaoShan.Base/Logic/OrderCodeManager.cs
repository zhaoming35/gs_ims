using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;

namespace GaoShan.Sales.Logic
{
    public class OrderCodeManager : LogicManager<Model.Tb_order_code>
    {
        public override bool Add(Tb_order_code t)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Tb_order_code t)
        {
            throw new NotImplementedException();
        }

        public Model.Info_order_code GetCurrentOrderCode(string employCode, out string current)
        {
            DateTime dtNow = this.Repository.DbManager.GetSystemDate();
            current = dtNow.ToString("yyyyMMdd");

            return this.Repository.Query().From<Model.Tb_order_code>()
                  .ToSelect().EndSelect()
                  .ToWhere()
                  .And(Model.Tb_order_code.Table.Employ_Code, employCode)
                  .And(Model.Tb_order_code.Table.Order_Date, current)
                  .EndWhere()
                  .ToQuery()
                  .First<Model.Info_order_code>();

        }

        public bool UpdateOrderCode(Model.Tb_order_code info)
        {

            DateTime dtNow = this.Repository.DbManager.GetSystemDate();
            string current = dtNow.ToString("yyyyMMdd");
            info.Order_Date = current;

            return this.BatchTrans().Append<string>
                ((r, employCode) =>
                {
                    if (r.Remove<Model.Tb_order_code>()
                    .Where()
                    .And(Model.Tb_order_code.Table.Employ_Code, employCode)
                    .EndWhere().Save() < 0)
                    {
                        return false;
                    }

                    return true;
                }, info.Employ_Code
                )
                .Append<Model.Tb_order_code>
                ((r, o) =>
                {
                    return r.Add(o);

                }, info
                )
                .Save();
        }


    }
}
