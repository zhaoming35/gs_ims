using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_tmp_xls: Tb_tmp_xls
    {
        public List<Tb_tmp_xls_map> VarMaps = new List<Tb_tmp_xls_map>();

        public List<Tb_tmp_xls_var> Vars = new List<Tb_tmp_xls_var>();
    }
}
