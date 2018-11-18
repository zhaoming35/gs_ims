using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class SalaryRanageFormula : RanageFormula
    {
        public long Role { get; set; }

        [JsonIgnore]
        public string RoleText
        {
            get { return Cache.LogicCache.DicSalaryDeptRole.ContainsKey(this.Role) ? 
                    Cache.LogicCache.DicSalaryDeptRole[Role].Role_Name : ""; }
        }
    }
}
