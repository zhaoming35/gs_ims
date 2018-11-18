using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_place_fee : Tb_place_fee
    {
        public string MerName
        {
            get
            {
                return Cache.LogicCache.DicPlaces[this.Place_Id].MerName;
            }
        }
    }
}
