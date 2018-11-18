using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.App.Entity.Enum
{
    public class EnumText
    {
        static Logic.EnumManager enumManager = null;
        public static Logic.EnumManager GetEnumManager()
        {
            if (enumManager == null) { enumManager = new Logic.EnumManager(); }
            return enumManager;
        }

        public static string GetEnumText(string enumKind, int enumValue)
        {
            Dictionary<int, string> mapEnum = GetEnumManager().FindKindMap(enumKind);

            return mapEnum.ContainsKey(enumValue) ? mapEnum[enumValue] : null;
        }

        public static string GetTwoPartiesText(int twoParties)
        {
            string enumKind = "TwoParties";

            return GetEnumText(enumKind, twoParties);
        }

        public static string GetOrderTypeText(int orderType)
        {
            string enumKind = "OrderType";

            return GetEnumText(enumKind, orderType);
        }






    }
}
