using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Logic
{
    public class CarriageManager : LogicManager<Model.Info_carriage_bill>
    {
        public override bool Add(Info_carriage_bill t)
        {
            t.Carriage_Id = NewId();
            t.Carriage_State = 0;
            return this.Add(Repository, t);
        }
 
        public override bool Remove(Info_carriage_bill t)
        {
            return this.Repository.Remove<Tb_carriage_bill>()
                .Where().And(Model.Tb_carriage_bill.Table.Carriage_Id, t.Carriage_Id)
                .EndWhere()
                .Save() > 0 ? true : false;

        }
        public List<Info_carriage_bill> GetNoDoneCarriage()
        {
            return this.Repository.Query().From<Tb_carriage_bill>()
                   .ToSelect().EndSelect()
                   .ToWhere()
                   .And(Tb_carriage_bill.Table.Carriage_State, (int)Enum.CarriageState.New)
                   .EndWhere()
                   .ToQuery()
                   .ToList<Info_carriage_bill>();
        }

        public bool Save(Info_carriage_bill info)
        {
            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Remove<Model.Tb_carriage_bill>()
                .Where().And(Model.Tb_carriage_bill.Table.Carriage_Id, id)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, info.Carriage_Id)
            .Append<Model.Tb_carriage_bill>((r, m) =>
            {
                return this.Add(r, m);
            }, info);


            return exeBatchTrans.Save();
        }

        public List<Info_carriage_bill> QueryCarriageBillRecord(object beginTime, object endTime, string odrNo)
        {
            Miles.Coro.ORM.Find.IWherePart wherePart = this.Repository.Find().From<Model.Tb_carriage_bill>()
            .Select().End().Where()
            .And(Model.Tb_carriage_bill.Table.Carriage_State, (int)Enum.CarriageState.Valid);

            if (beginTime != null)
            {
                wherePart.And(Model.Tb_carriage_bill.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.More, (DateTime)beginTime);
            }

            if (endTime != null)
            {
                wherePart.And(Model.Tb_carriage_bill.Table.Oper_Date, Miles.Coro.ORM.DbCompareChar.Less, (DateTime)endTime);
            }

            if (!string.IsNullOrEmpty(odrNo))
            {
                wherePart.AndLike(Model.Tb_carriage_bill.Table.Odr_No, odrNo);
            }

            return wherePart.End().ToQuery().ToList<Info_carriage_bill>();

        }

        Logic.DefaultAdressManager defaultAdressManager = new Logic.DefaultAdressManager();

        public bool Commit(Info_carriage_bill info)
        {
            Model.Tb_default_adress defaultAdress = defaultAdressManager.FindThe();
            Info_place_fee feeOrigen;
            Info_place_fee updateFee = new Info_place_fee();
            string transDirection;
            //装车地址是默认地址,发车
            if (info.Load_Place_Id == defaultAdress.Place_Id)
            {
                updateFee.Place_Id = info.Unload_Place_Id;
                transDirection = "发车";
                feeOrigen = this.Repository.Query().From<Model.Tb_place_fee>()
               .ToSelect().EndSelect()
               .ToWhere()
               .And(Model.Tb_place_fee.Table.Place_Id, info.Unload_Place_Id)
               .And(Model.Tb_place_fee.Table.Truck_Name, info.Trunk_Spec)
               .And(Model.Tb_place_fee.Table.Trans_Direction, transDirection)
               .EndWhere()
               .ToQuery()
               .First<Info_place_fee>();
            }
            else
            {
                updateFee.Place_Id = info.Load_Place_Id;
                //回车
                transDirection = "回车";
                feeOrigen = this.Repository.Query().From<Model.Tb_place_fee>()
                .ToSelect().EndSelect()
                .ToWhere()
                 .And(Model.Tb_place_fee.Table.Place_Id, info.Load_Place_Id)
                .And(Model.Tb_place_fee.Table.Truck_Name, info.Trunk_Spec)
                 .And(Model.Tb_place_fee.Table.Trans_Direction, transDirection)
                .EndWhere()
                .ToQuery()
                .First<Info_place_fee>();
            }

   
            updateFee.Truck_Name = info.Trunk_Spec;
            updateFee.Trans_Direction = transDirection;
            updateFee.Trans_Cost = info.Carriage_Cost;
            if (feeOrigen != null)
            {
                updateFee.Place_Distance = feeOrigen.Place_Distance;
            }

            ExeBatchTrans exeBatchTrans = this.BatchTrans();
            //更新运费表
            exeBatchTrans.Append<long>((r, id) =>
            {
                if (r.Update<Model.Tb_carriage_bill>()
                .Set()
                .Field(Model.Tb_carriage_bill.Table.Carriage_State,(int)Enum.CarriageState.Valid)
                .EndSet()
                .Where().And(Model.Tb_carriage_bill.Table.Carriage_Id, id)
                .EndWhere()
                .Save() < 1)
                {
                    return false;
                }
                return true;
            }, info.Carriage_Id);

            //更新运输单状态
            exeBatchTrans.Append<Info_place_fee>((r, f) =>
            {
                if (r.Remove<Model.Tb_place_fee>()
                .Where()
                .And(Model.Tb_place_fee.Table.Place_Id, f.Place_Id)
                .And(Model.Tb_place_fee.Table.Truck_Name, f.Truck_Name)
                .And(Model.Tb_place_fee.Table.Trans_Direction, f.Trans_Direction)
                .EndWhere()
                .Save() < 0)
                {
                    return false;
                }
                return true;
            }, updateFee);

            exeBatchTrans.Append<Model.Info_place_fee>((r, m) =>
            {
                m.Fee_Id = NewId();
                return this.Add(r, m);

            }, updateFee);

            return exeBatchTrans.Save();
        }
    }
}
