using Miles.Coro.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{

    [TableAttribute("tb_empty", "gaoshan_db")]
    [Serializable]
    public class Bu_store_check
    {
        [Description("制表人名字")]
        public string EmployName
        {
            get { return Cache.LogicCache.DicEmployee[this.Oper_Code].Employ_Name; }
        }

        public string Oper_Code { get; set; }

        public DateTime Oper_Date { get; set; }

        public List<Model.Info_store_check> Items = new List<Info_store_check>();
    }
}
