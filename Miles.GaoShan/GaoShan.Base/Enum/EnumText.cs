using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaoShan.Sales.Enum
{
    public class EnumText
    {

        public static Miles.App.Entity.Logic.EnumManager GetEnumManager()
        {
            return Miles.App.Entity.Enum.EnumText.GetEnumManager();
        }

        //public static string GetEnumText(string enumKind, int enumValue)
        //{
        //    Dictionary<int, string> mapEnum = GetEnumManager().FindKindMap(enumKind);

        //    return mapEnum.ContainsKey(enumValue)? mapEnum[enumValue]:null;
        //}

        public static string GetOrderStateText(int orderState)
        {
            string text = "";
            if (orderState == (int)Enum.OrderState.New)
            {
                text = "未提交";
            }
            else if (orderState == (int)Enum.OrderState.Commit)
            {
                text = "提交";
            }
            else if (orderState == (int)Enum.OrderState.Pass)
            {
                text = "正常";
            }
            else if (orderState == (int)Enum.OrderState.Termination)
            {
                text = "手工终止";
            }
            else if (orderState == (int)Enum.OrderState.Invalid)
            {
                text = "作废";
            }

            return text;
        }

        public static string GetTwoPartiesText(int twoParties)
        {
            string enumKind = "TwoParties";

            return Miles.App.Entity.Enum.EnumText.GetEnumText(enumKind, twoParties);
        }

        public static string GetOrderTypeText(int orderType)
        {
            string enumKind = "OrderType";

            return Miles.App.Entity.Enum.EnumText.GetEnumText(enumKind, orderType);
        }

        public static string GetSalaryKindText(int salaryKind)
        {
            string enumKind = "Salary_Kind";

            return Miles.App.Entity.Enum.EnumText.GetEnumText(enumKind, salaryKind);
        }

        public static string GetStoreInTypeText(int storeInType)
        {
            string text = "";
            if (storeInType == 1)
            {
                text = "租赁回库";
            }
            else if (storeInType ==2)
            {
                text = "直接入库";
            }

            return text;
        }

        public static string GetStoreOutTypeText(int storeOutType)
        {
            string text = "";
            if (storeOutType == 1)
            {
                text = "订单出库";
            }
            //else if (storeOutType == 2)
            //{
            //    text = "直接入库";
            //}

            return text;
        }
    }
}
