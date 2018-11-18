using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_carriage_bill : Tb_carriage_bill
    {
        [Description("制表人名字")]
        public string EmployName
        {
            get { return Cache.LogicCache.DicEmployee[this.Oper_Code].Employ_Name; }
        }

        [Description("装车地址")]
        public string LoadPlace
        {
            get
            {
                Model.Info_place_info info = Cache.LogicCache.DicPlaces[this.Load_Place_Id];
                info.DetailAdress = this.Load_Place_Text;
                return info.ToText();

            }
        }

        [Description("卸货地址")]
        public string UnloadPlace
        {
            get
            {
                Model.Info_place_info info = Cache.LogicCache.DicPlaces[this.Unload_Place_Id];
                info.DetailAdress = this.Unload_Place_Text;
                return info.ToText();

            }
        }

    }
}
