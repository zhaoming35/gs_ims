using Miles.Coro.ORM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_salary_main: Tb_salary_main
    {
        public List<CalParmResult> CalProcess
        {
            get
            {
                if (string.IsNullOrEmpty(this.Cal_Process))
                {
                    return new List<CalParmResult>();
                }

                List<CalParmResult> items = (List<CalParmResult>)JsonConvert.DeserializeObject(this.Cal_Process, typeof(List<CalParmResult>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Cal_Process = strSerializeJSON;
            }
        }

        public List<PostSalary> RelatedMan
        {
            get
            {
                if (string.IsNullOrEmpty(this.Related_Man))
                {
                    return new List<PostSalary>();
                }

                List<PostSalary> items = (List<PostSalary>)JsonConvert.DeserializeObject(this.Related_Man, typeof(List<PostSalary>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Related_Man = strSerializeJSON;
            }
        }

        [Description("合同类型文本")]
        public string OrderTypeText
        {
            get
            {
                return Enum.EnumText.GetOrderTypeText(this.Odr_Type);
            }
        }

        [Description("业务员名字")]
        public string Employ_Name
        {
            get
            {
                return Cache.LogicCache.DicEmployee.ContainsKey(this.Employ_Code) ? Cache.LogicCache.DicEmployee[this.Employ_Code].Employ_Name : null;
            }
        }

        [Description("合同类型")]
        [DataFieldAttribute("odr_Type", "int", "合同类型",true)]
        public int Odr_Type
        {
            get;set;
        }

        [Description("甲方(需方)")]
        [DataFieldAttribute("jia_Name", "varchar", "甲方(需方)",true)]
        public string Jia_Name
        {
            get;set;
        }

        [Description("业务员")]
        [DataFieldAttribute("employ_Code", "varchar", "业务员",true)]
        public string Employ_Code
        {
            get;set;
        }


        public List<Info_salary_main_item> Items = new List<Info_salary_main_item>();
    }
}
