using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GaoShan.Sales.Enum;

namespace GaoShan.Sales.Logic
{
    public class Utils
    {
        static Logic.OrderCodeManager orderCodeManager = new OrderCodeManager();

        public static Model.Info_order_code BuildOrderCode(string employCode, int orderType)
        {
            string current;
            Model.Info_order_code orderCode = orderCodeManager.GetCurrentOrderCode(employCode, out current);
    
      
            if (orderCode == null)
            {
                orderCode = new Model.Info_order_code();
                orderCode.Employ_Code = employCode;
                orderCode.Seq_No = 0;
                orderCode.Order_Date = current;
                orderCodeManager.UpdateOrderCode(orderCode);
            }

            orderCode.Seq_No = orderCode.Seq_No + 1;

            string strType = Miles.App.Entity.Enum.EnumText.GetEnumText("OrderTypeCode", orderType);
            orderCode.OrderTypeCode = strType;

            return orderCode;
        }

        static Logic.OrderManager orderManager = new OrderManager();
        public static string BuildOrderNoAdd(string odrNoMain)
        {
            int seqNo = orderManager.GetMaxSeq(odrNoMain);
            seqNo++;
            return string.Format("{0}-{1}", odrNoMain, seqNo.ToString().PadLeft(2, '0'));
        }

        //public static bool UpdateOrderSeqNo(string employCode, int seqNo)
        //{
        //    Model.Tb_order_code orderCode = new Model.Tb_order_code();
        //    orderCode.Employ_Code = employCode;
        //    orderCode.Seq_No = seqNo;
        //    return orderCodeManager.UpdateOrderCode(orderCode);
        //}



    }
}
