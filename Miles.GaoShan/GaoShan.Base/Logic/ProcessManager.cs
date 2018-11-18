using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GaoShan.Sales.Model;
using Miles.App.Entity.Logic;
using Miles.Coro.ORM;
using Newtonsoft.Json;

namespace GaoShan.Sales.Logic
{
    /// <summary>
    /// 业务流程操作类
    /// </summary>
    public class ProcessManager : DbManager
    {

        private bool WriteLog(Miles.Coro.ORM.Repository r, Model.Tb_order_log log,object obj)
        {
            string strSerializeJSON = JsonConvert.SerializeObject(obj);
            log.Oper_Info = strSerializeJSON;
            return this.Add(r, log);
        }

        private bool ExistParentEmploy(string employ_Code)
        {
            Miles.IMSFramework.Model.Sm_employee sm_Employee = this.Repository.Query()
                  .From<Miles.IMSFramework.Model.Sm_employee>()
                  .ToSelect()
                  .EndSelect()
                  .ToQuery()
                  .InnerJoin<Miles.IMSFramework.Model.Sm_employee>().On(Miles.IMSFramework.Model.Sm_employee.Table.Employ_Code, Miles.IMSFramework.Model.Sm_employee.Table.Parent_Code)
                  .JoinTable()
                  .ToWhere()
                  .And(Miles.IMSFramework.Model.Sm_employee.Table.Employ_Code, employ_Code)
                  .EndWhere()
                  .ToQuery()
                  .First<Miles.IMSFramework.Model.Sm_employee>();

            return sm_Employee == null ? false : true;
        }

        public bool UpdateOrderState(Miles.Coro.ORM.Repository r, Model.Info_OrderMain info)
        {
            if (r.Update<Model.Info_OrderMain>()
            .Set()
            .Field(Model.Tb_order_main.Table.Odr_State, info.Odr_State)
            .EndSet()
            .Where().And(Model.Info_OrderMain.Table.Odr_No, info.Odr_No)
            .EndWhere()
            .Save() < 1)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// 拟定合同提交操作
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool CommitOrder(Model.Info_OrderMain info)
        {
            if (ExistParentEmploy(info.Oper_Code))
            {
                int odrState = (int)Enum.OrderState.Commit;// 1;
                info.Odr_State = odrState;
                return UpdateOrderState(this.Repository, info);
            }
            else
            {
                return this.BatchTrans().Append<Model.Info_OrderMain>(DoAdoptOrder, info).Save();
            }
        }

        internal bool TerminationOrder(Info_OrderMain info)
        {
            return this.BatchTrans().Append<Model.Info_OrderMain>(DoTerminationOrder, info).Save();
        }

        private bool DoTerminationOrder(Repository r, Info_OrderMain info)
        {
            int odrState = (int)Enum.OrderState.Termination;//3;
            info.Odr_State = odrState;
            Model.Tb_order_log log = new Model.Tb_order_log();
            log.Odr_No = info.Odr_No;
            log.Oper_log = "合同手工终止";
            log.Msg = "合同手工终止";
            if (!WriteLog(r, log, info))
            {
                return false;
            }

            if (!UpdateOrderState(r, info))
            {
                return false;
            }

            //更新合同摘要
            if (r.Update<Tb_fin_order_gen>()
                .Set()
                .Field(Tb_fin_order_gen.Table.Gen_State,(int)Enum.GenState.Termination)
                .EndSet()
                .Where()
                .And(Tb_fin_order_gen.Table.Odr_No,info.Odr_No)
                .EndWhere().Save() < 0)
            {
                return false;
            }
            //更新项目联络单
            if (r.Update<Tb_link_bill>()
        .Set()
        .Field(Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Termination)
        .EndSet()
        .Where()
        .And(Tb_link_bill.Table.Odr_No, info.Odr_No)
        .EndWhere().Save() < 0)
            {
                return false;
            }
            //物流单
            //工程部费用表


            return true;
        }

        private bool DoAdoptOrder(Miles.Coro.ORM.Repository r, Model.Info_OrderMain info)
        {
            int odrState = (int)Enum.OrderState.Pass;//2;
            info.Odr_State = odrState;
            Model.Tb_order_log log = new Model.Tb_order_log();
            log.Odr_No = info.Odr_No;
            log.Oper_log = "合同审核通过";
            log.Msg = "合同审核通过";
            if (!WriteLog(r, log,info))
            {
                return false;
            }

            if (!UpdateOrderState(r, info))
            {
                return false;
            }

            //新建合同摘要表部分数据
            if (!DoNewFinOrderGen(r, info))
            {
                return false;
            }

            //新建项目联络单要表部分数据
            if (!DoNewLinkBill(r, info))
            {
                return false;
            }

            return true;
        }

        internal bool RejectFinOutcome(Info_fin_order_outcome info, string msg)
        {
            return this.BatchTrans().Append<Model.Info_fin_order_outcome>
               ((r, f) =>
               {
                   int odrState = (int)Enum.FinState.New;// 0;
                   info.Fin_State = odrState;

                   Model.Tb_order_log log = new Model.Tb_order_log();
                    //log.Ass_Id = info.Fin_Id;
                    log.Oper_log = "退款审核不通过";
                   log.Msg = msg == null ? "退款审核不通过" : msg;
                   if (!WriteLog(r, log, info))
                   {
                       return false;
                   }

                   SetOperateInfo(info, new List<string> { Model.Tb_fin_order_outcome.Table.Audit_Code }
                   , new List<string> { Model.Tb_fin_order_outcome.Table.Audit_Date });

                   if (r.Update<Tb_fin_order_outcome>()
                   .Set()
                   .Field(Model.Tb_fin_order_outcome.Table.Fin_State, odrState)
                   .Field(Model.Tb_fin_order_outcome.Table.Audit_Code, info.Audit_Code)
                   .Field(Model.Tb_fin_order_outcome.Table.Audit_Date, info.Audit_Date)
                   .EndSet()
                   .Where()
                   .And(Model.Tb_fin_order_outcome.Table.Fin_Id, f.Fin_Id)
                   .EndWhere()
                   .Save() < 1)
                   {
                       return false;
                   }

                   return true;
               }, info
               ).Save();
        }

        internal bool AdoptFinOutcome(Info_fin_order_outcome info)
        {
            return this.BatchTrans().Append<Model.Info_fin_order_outcome>
                 ((r, f) =>
                 {
                     int odrState = (int)Enum.FinState.Pass;// 2;
                     info.Fin_State = odrState;

                     Model.Tb_order_log log = new Model.Tb_order_log();
                    //log.Ass_Id = info.Fin_Id;
                    log.Oper_log = "回款审核通过";
                     log.Msg = "回款审核通过";

                     if (!WriteLog(r, log, info))
                     {
                         return false;
                     }

                     SetOperateInfo(info, new List<string> { Model.Tb_fin_order_outcome.Table.Audit_Code }
                     , new List<string> { Model.Tb_fin_order_outcome.Table.Audit_Date });

                     if (r.Update<Tb_fin_order_outcome>()
                     .Set()
                     .Field(Model.Tb_fin_order_outcome.Table.Fin_State, odrState)
                     .Field(Model.Tb_fin_order_outcome.Table.Audit_Code, info.Audit_Code)
                     .Field(Model.Tb_fin_order_outcome.Table.Audit_Date, info.Audit_Date)
                     .EndSet()
                     .Where()
                     .And(Model.Tb_fin_order_outcome.Table.Fin_Id, f.Fin_Id)
                     .EndWhere()
                     .Save() < 1)
                     {
                         return false;
                     }

                    //更新合同摘要的支付金额
                    if (r.Update<Tb_fin_order_gen>()
              .Set()
              .Decrease(Tb_fin_order_gen.Table.Pay_Cost, f.Pay_Cost)
              .EndSet()
              .Where()
              .And(Model.Tb_fin_order_gen.Table.Odr_No, f.Odr_No)
              .EndWhere()
              .Save() < 1)
                     {
                         return false;
                     }


                     return true;
                 }, info
                 ).Save();
        }

        public bool AdoptFinIncome(Info_fin_order_income info)
        {
            return this.BatchTrans().Append<Model.Info_fin_order_income>
                ((r, f) =>
                {
                    int odrState = (int)Enum.FinState.Pass;// 2;
                    info.Fin_State = odrState;

                    Model.Tb_order_log log = new Model.Tb_order_log();
                    //log.Ass_Id = info.Fin_Id;
                    log.Oper_log = "回款审核通过";
                    log.Msg = "回款审核通过";

                    if (!WriteLog(r, log, info))
                    {
                        return false;
                    }

                    SetOperateInfo(info, new List<string> { Model.Tb_fin_order_income.Table.Audit_Code }
                    , new List<string> { Model.Tb_fin_order_income.Table.Audit_Date });

                    if (r.Update<Tb_fin_order_income>()
                    .Set()
                    .Field(Model.Tb_fin_order_income.Table.Fin_State, odrState)
                    .Field(Model.Tb_fin_order_income.Table.Audit_Code, info.Audit_Code)
                    .Field(Model.Tb_fin_order_income.Table.Audit_Date, info.Audit_Date)
                    .EndSet()
                    .Where()
                    .And(Model.Tb_fin_order_income.Table.Fin_Id, f.Fin_Id)
                    .EndWhere()
                    .Save() < 1)
                    {
                        return false;
                    }

                    //更新合同摘要的支付金额
                    if (r.Update<Tb_fin_order_gen>()
             .Set()
             .Increase(Tb_fin_order_gen.Table.Pay_Cost,f.Pay_Cost)
             .EndSet()
             .Where()
             .And(Model.Tb_fin_order_gen.Table.Odr_No, f.Odr_No)
             .EndWhere()
             .Save() < 1)
                    {
                        return false;
                    }


                    return true;
                }, info
                ).Save();
        }

        public bool RejectFinIncome(Info_fin_order_income info, string msg)
        {
            return this.BatchTrans().Append<Model.Info_fin_order_income>
                ((r, f) =>
                {
                    int odrState = (int)Enum.FinState.New;// 0;
                    info.Fin_State = odrState;

                    Model.Tb_order_log log = new Model.Tb_order_log();
                    //log.Ass_Id = info.Fin_Id;
                    log.Oper_log = "回款审核不通过";
                    log.Msg = msg == null ? "回款审核不通过" : msg;
                    if (!WriteLog(r, log,info))
                    {
                        return false;
                    }

                    SetOperateInfo(info, new List<string> { Model.Tb_fin_order_income.Table.Audit_Code }
                    , new List<string> { Model.Tb_fin_order_income.Table.Audit_Date });

                    if(r.Update<Tb_fin_order_income>()
                    .Set()
                    .Field(Model.Tb_fin_order_income.Table.Fin_State, odrState)
                    .Field(Model.Tb_fin_order_income.Table.Audit_Code,info.Audit_Code)
                    .Field(Model.Tb_fin_order_income.Table.Audit_Date,info.Audit_Date)
                    .EndSet()
                    .Where()
                    .And(Model.Tb_fin_order_income.Table.Fin_Id, f.Fin_Id)
                    .EndWhere()
                    .Save() < 1)
                    {
                        return false;
                    }

                    return true;
                },info
                ).Save();

        }

        public bool NewLinkBill(Info_OrderMain info)
        {
            return this.BatchTrans().Append<Model.Info_OrderMain>(DoNewLinkBill, info).Save();
        }

        private bool DoNewLinkBill(Repository r, Info_OrderMain info)
        {
            Model.Info_link_bill linkBil = new Info_link_bill();
            linkBil.LinkBill_Id = NewId();
            linkBil.Bill_State = (int)Enum.LinkState.New;// 0;
            linkBil.Employ_Code = info.Oper_Code;
            linkBil.Jia_Name = info.Jia_Name;
            linkBil.Let_Bud_EDate = info.Let_Bud_EDate;
            linkBil.Let_Bud_SDate = info.Let_Bud_SDate;
            linkBil.Let_Entry_Date = info.Let_Entry_Date;
            linkBil.Let_Rm_EDate = info.Let_Rm_EDate;
            linkBil.Let_Rm_SDate = info.Let_Rm_SDate;
            linkBil.Let_Use_EDate = info.Let_Use_EDate;
            linkBil.Let_Use_SDate = info.Let_Use_SDate;
            linkBil.Odr_Bud_Palce = info.Odr_Bud_Palce;
            linkBil.Odr_Bud_Party = info.Odr_Bud_Party;
            linkBil.Odr_Date = info.Odr_Date;
            linkBil.Odr_Fixed_Mode = info.Odr_Fixed_Mode;
            linkBil.Odr_Ground_State = info.Odr_Ground_State;
            linkBil.Odr_No = info.Odr_No;
            linkBil.Odr_Place_Linkman = info.Odr_Place_Linkman;
            linkBil.Odr_Place_Phone = info.Odr_Place_Phone;
            linkBil.Odr_Prt_Name = info.Odr_Prt_Name;
            linkBil.Odr_Trans_Party = info.Odr_Trans_Party;
            linkBil.Odr_Type = info.Odr_Type;
            linkBil.Odr_Water_proof = info.Odr_Water_proof;

            if (!this.Add(r, linkBil))
            {
                return false;
            }

            foreach (var v in info.Items)
            {
                if (v.Product_Name.Equals("篷房"))
                {
                    Model.Tb_link_bill_tent item = new Tb_link_bill_tent();
                    item.LinkBill_Id = linkBil.LinkBill_Id;
                    item.Item_Id = NewId();
                    item.Item_Seq = v.Item_Seq;
                    item.Item_Spec = v.Item_Spec;
                    if (!this.Add(r, item))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool DoNewFinOrderGen(Repository r, Info_OrderMain info)
        {
            Model.Tb_fin_order_gen gen = new Tb_fin_order_gen();
            gen.Employ_Code = info.Oper_Code;
            gen.Jia_Adress = info.Jia_Adress;
            gen.Jia_Fax = info.Jia_Fax;
            gen.Jia_Name = info.Jia_Name;
            gen.Jia_Phone = info.Jia_Phone;
            gen.Odr_Bud_Palce = info.Odr_Bud_Palce;
            gen.Odr_Fixed_Mode = info.Odr_Fixed_Mode;
            gen.Odr_Ground_State = info.Odr_Ground_State;
            gen.Odr_No = info.Odr_No;
            gen.Odr_Place_Linkman = info.Odr_Place_Linkman;
            gen.Odr_Place_Phone = info.Odr_Place_Phone;
            gen.Odr_Prt_Name = info.Odr_Prt_Name;
            gen.Odr_Prt_Purpose = info.Odr_Prt_Purpose;
            gen.Odr_Sum_Area = info.Odr_Sum_Area;
            gen.Odr_Tax_Type = info.Odr_Tax_Type;
            gen.Odr_Trans_Party = info.Odr_Trans_Party;
            gen.Odr_Type = info.Odr_Type;
            gen.Odr_Water_proof = info.Odr_Water_proof;
            gen.Tot_Cost = info.Tot_Cost;
            gen.Odr_No_Main = info.Odr_No_Main;

            if(! this.Add(r, gen))
            {
                return false;
            }

            foreach(var v in info.Items)
            {
                Model.Tb_fin_order_item item = new Tb_fin_order_item();
                item.Item_Id = v.Item_Id;
                item.Item_Name = v.Product_Name;
                item.Item_Seq = v.Item_Seq;
                item.Item_Spec = v.Item_Spec;
                item.Item_Type = v.Item_Type;
                item.Odr_No = v.Odr_No;
                if (!this.Add(r, item))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 审核合同通过
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool AdoptOrder(Model.Info_OrderMain info)
        {
            return this.BatchTrans().Append<Model.Info_OrderMain>(DoAdoptOrder, info).Save();
        }

        private bool DoRejectOrder(Repository r, Info_OrderMain info)
        {
            int odrState = (int)Enum.OrderState.New;// 0;
            info.Odr_State = odrState;

            Model.Tb_order_log log = new Model.Tb_order_log();
            log.Odr_No = info.Odr_No;
            log.Oper_log = "合同审核不通过";
            log.Msg = info.Tag==null?"合同审核不通过":info.Tag.ToString();
            if (!WriteLog(r, log,info))
            {
                return false;
            }

            if (!UpdateOrderState(r, info))
            {
                return false;
            }

            return true;
        }
       
        /// <summary>
        /// 审核不通过
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool RejectOrder(Model.Info_OrderMain info)
        {
            return this.BatchTrans().Append<Model.Info_OrderMain>(DoRejectOrder, info).Save(); 
        }

        internal bool CancelLinkBill(Info_link_bill info)
        {


            //作废原来的单据标志位=-1
            //新建一个取消的联络单,编码相同
            return this.BatchTrans()
               .Append<long>((r, id) =>
               {
                   Model.Tb_order_log log = new Model.Tb_order_log();
                   log.Odr_No = info.Odr_No;
                   log.Oper_log = "项目联络单取消";
                   log.Msg = "项目联络单取消";
                   if (!WriteLog(r, log, info))
                   {
                       return false;
                   }

                   if (r.Update<Model.Tb_link_bill>()
                   .Set()
                   .Field(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Invalid)
                   .EndSet()
                   .Where()
                   .And(Model.Tb_link_bill.Table.LinkBill_Id, id)
                   .EndWhere()
                   .Save() < 1) { return false; }

                   info.LinkBill_Id = NewId();
                   info.Bill_State = (int)Enum.LinkState.Valid;// 1;  //直接提交状态
                   info.LinkBill_Type = (int)Enum.LinkBillType.Cancel;// 1;
                   info.LinkBill_Name += "-取消单";

                   if (!this.Add(r, info))
                   {
                       return false;
                   }

                   foreach(var v in info.Items)
                   {
                       v.Item_Id= NewId();
                       v.LinkBill_Id = info.LinkBill_Id;
                       if (!this.Add(r, v))
                       {
                           return false;
                       }
                   }

                   return true;
               }, info.LinkBill_Id)
               .Save();
        }

        internal bool BackLinkBill(Info_link_bill info)
        {
            //记录日志
            //更新标志位
            return this.BatchTrans()
                .Append<long>((r, id) =>
                {
                    Model.Tb_order_log log = new Model.Tb_order_log();
                    log.Odr_No = info.Odr_No;
                    log.Oper_log = "项目联络单召回";
                    log.Msg = "项目联络单召回";
                    if (!WriteLog(r, log, info))
                    {
                        return false;
                    }

                    if (r.Update<Model.Tb_link_bill>()
                    .Set()
                    .Field(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.New)
                    .EndSet()
                    .Where()
                    .And(Model.Tb_link_bill.Table.LinkBill_Id, id)
                    .EndWhere()
                    .Save() < 1) { return false; }

                    return true;
                }, info.LinkBill_Id)
                .Save();
        }


        public bool CommitLinkBill(Info_link_bill info)
        {
            //修改联络单状态
            //新建工程部费用数据
            //Model.Tb_project_Cost tbProjectCost = new Tb_project_Cost();
            //tbProjectCost.Cost_State = 0;
            //tbProjectCost.Employ_Code = info.Employ_Code;
            //tbProjectCost.Employ_Name = info.Employ_Name;
            //tbProjectCost.Jia_Name = info.Jia_Name;
            //tbProjectCost.LinkBill_Id = info.LinkBill_Id;
            //tbProjectCost.LinkBill_Name = info.LinkBill_Name;
            //tbProjectCost.Odr_Bud_Palce = info.Odr_Bud_Palce;
            //tbProjectCost.Odr_No = info.Odr_No;
            //tbProjectCost.Odr_No = info.Odr_No;
            //tbProjectCost.Odr_Prt_Name = info.Odr_Prt_Name;
            //tbProjectCost.Odr_Type = info.Odr_Type;
       

            return this.BatchTrans()
                .Append<long>((r,id)=> 
                {
                    if (r.Update<Model.Tb_link_bill>()
                    .Set()
                    .Field(Model.Tb_link_bill.Table.Bill_State, (int)Enum.LinkState.Valid)
                    .EndSet()
                    .Where()
                    .And(Model.Tb_link_bill.Table.LinkBill_Id,id)
                    .EndWhere()
                    .Save() < 1) { return false; }

                    return true;
                }, info.LinkBill_Id)
                .Save();

        }

    }
}
