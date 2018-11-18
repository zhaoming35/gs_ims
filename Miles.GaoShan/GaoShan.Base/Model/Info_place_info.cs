using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_place_info: Tb_place_info
    {
        public Info_place_info Parent { get; set; }

        public string MerName {
            get
            {
                if (this.Parent != null&&this.Parent.Level>0)
                {
                    return this.Parent.MerName+","+ this.Place_Name;
                }
                else
                {
                    return this.Place_Name;
                }
            }
        }

        public List<Info_place_info> Children = new List<Info_place_info>();

        public string DetailAdress { get; set; }

        public string ToText()
        {
            if (string.IsNullOrEmpty(DetailAdress)){ return this.MerName; }

            return this.MerName +","+ DetailAdress;
        }

        public override string ToString()
        {
            return this.Place_Name;
        }
    }
}
