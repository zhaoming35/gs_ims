using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_MatchTb_Tmp: Model.Tb_matchTb_tmp
    {
        public List<RanageFormula> SzcLt30
        {
            get
            {
                if (string.IsNullOrEmpty(this.Szc_lt30))
                {
                    return new List<RanageFormula>();
                }

                List<RanageFormula> items = (List<RanageFormula>)JsonConvert.DeserializeObject(this.Szc_lt30, typeof(List<RanageFormula>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Szc_lt30 = strSerializeJSON;
            }
        }
        public List<RanageFormula> SzcGt30
        {
            get
            {
                if (string.IsNullOrEmpty(this.Szc_gt30))
                {
                    return new List<RanageFormula>();
                }

                List<RanageFormula> items = (List<RanageFormula>)JsonConvert.DeserializeObject(this.Szc_gt30, typeof(List<RanageFormula>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Szc_gt30 = strSerializeJSON;
            }
        }
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
    }
}
