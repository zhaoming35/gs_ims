using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Com
{
    public class VarParse
    {
        public static string GetFormatData(object value, string format)
        {
            if (value == null) { return string.Empty; }
            string strValue = string.Empty;
            if (string.IsNullOrEmpty(format) || string.IsNullOrEmpty(format.Trim()))
            {
                return value.ToString();
            }
            else
            {
                if (format.ToLower().Equals("rmb"))
                {
                   strValue = Miles.Coro.Common.MoneyConvert.ToWord((decimal)value);
                   
                }
                else if (format.ToLower().Equals("num"))
                {
                    string tmp = value.ToString();
                    if (tmp.Contains("."))
                    {
                        tmp = tmp.Substring(0, tmp.IndexOf("."));
                    }
                    int result = 0;
                    if (int.TryParse(tmp, out result))
                    {
                        strValue = result.ToString();
                    }
                }
                else if (format.ToLower().Equals("dec"))
                {
                    decimal result = 0;
                    if(decimal.TryParse(value.ToString(),out result))
                    {
                        strValue = result.ToString();
                    }
                }
                else if (format.ToLower().StartsWith("enum-"))
                {
                    string enumName = format.Substring(format.IndexOf("-") + 1);
                    strValue = Miles.App.Entity.Enum.EnumText.GetEnumText(enumName, (int)value);
                }
                else
                {
                    if (!System.Data.SqlTypes.SqlDateTime.MinValue.Value.Equals(value))
                    {
                        DateTime dtValue = DateTime.Parse(value.ToString());
                        strValue = dtValue.ToString(format);
                    }
                }
            }

            return strValue;
        }
    }
}
