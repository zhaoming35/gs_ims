using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public  class Info_salary_tmp: Tb_salary_tmp
    {
        public List<VarCal> VarCals
        {
            get
            {
                if (string.IsNullOrEmpty(this.Var_Cal))
                {
                    return new List<VarCal>();
                }

                List<VarCal> items = (List<VarCal>)JsonConvert.DeserializeObject(this.Var_Cal, typeof(List<VarCal>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Var_Cal = strSerializeJSON;
            }
        }

        public List<VarInput> VarInputs
        {
            get
            {
                if (string.IsNullOrEmpty(this.Var_Input))
                {
                    return new List<VarInput>();
                }

                List<VarInput> items = (List<VarInput>)JsonConvert.DeserializeObject(this.Var_Input, typeof(List<VarInput>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Var_Input = strSerializeJSON;
            }
        }

        public List<RanageFormula> SalesMan
        {
            get
            {
                if (string.IsNullOrEmpty(this.Sales_Man))
                {
                    return new List<RanageFormula>();
                }

                List<RanageFormula> items = (List<RanageFormula>)JsonConvert.DeserializeObject(this.Sales_Man, typeof(List<RanageFormula>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Sales_Man = strSerializeJSON;
            }
        }

        public List<SalaryRanageFormula> DeptAward
        {
            get
            {
                if (string.IsNullOrEmpty(this.Dept_Award))
                {
                    return new List<SalaryRanageFormula>();
                }

                List<SalaryRanageFormula> items = (List<SalaryRanageFormula>)JsonConvert.DeserializeObject(this.Dept_Award, typeof(List<SalaryRanageFormula>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Dept_Award = strSerializeJSON;
            }
        }

        public List<SalaryRanageFormula> OrganAward
        {
            get
            {
                if (string.IsNullOrEmpty(this.Organ_Award))
                {
                    return new List<SalaryRanageFormula>();
                }

                List<SalaryRanageFormula> items = (List<SalaryRanageFormula>)JsonConvert.DeserializeObject(this.Organ_Award, typeof(List<SalaryRanageFormula>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Organ_Award = strSerializeJSON;
            }
        }

  

    }
}
