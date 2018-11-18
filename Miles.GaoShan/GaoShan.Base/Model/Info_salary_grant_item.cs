﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_salary_grant_item: Tb_salary_grant_item
    {
        [Description("提成人名字")]
        public string Employ_Name
        {
            get
            {
                return Cache.LogicCache.DicEmployee.ContainsKey(this.Employ_Code) ? Cache.LogicCache.DicEmployee[this.Employ_Code].Employ_Name : null;
            }
        }



    }
}