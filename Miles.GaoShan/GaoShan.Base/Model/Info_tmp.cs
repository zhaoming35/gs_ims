using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_tmp: Tb_tmp_info
    {
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Order_Type);
            }
        }

        public List<Tb_tmp_part> Parts = new List<Tb_tmp_part>();

        public List<Tb_tmp_map> VarMaps = new List<Tb_tmp_map>();
    }
}
