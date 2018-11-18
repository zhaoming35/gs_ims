using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_fin_transport_tmp: Tb_fin_transport_tmp
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

        public List<StringValue> MainSpec {
            get
            {
                if (string.IsNullOrEmpty(this.Main_Spec))
                {
                    return new List<StringValue>();
                }

                List<StringValue> items = (List<StringValue>)JsonConvert.DeserializeObject(this.Main_Spec, typeof(List<StringValue>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Main_Spec = strSerializeJSON;
            }
        }

        public List<DecValue> EdgeHeight
        {
            get
            {
                if (string.IsNullOrEmpty(this.Edge_Height))
                {
                    return new List<DecValue>();
                }

                List<DecValue> items = (List<DecValue>)JsonConvert.DeserializeObject(this.Edge_Height, typeof(List<DecValue>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Edge_Height = strSerializeJSON;
            }
        }

        public List<TransFixedItem> TransFixed
        {
            get
            {
                if (string.IsNullOrEmpty(this.Trans_Fixed))
                {
                    return new List<TransFixedItem>();
                }

                List<TransFixedItem> items = (List<TransFixedItem>)JsonConvert.DeserializeObject(this.Trans_Fixed, typeof(List<TransFixedItem>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Trans_Fixed = strSerializeJSON;
            }
        }

        public List<RanageFormula> DmlFormula
        {
            get
            {
                if (string.IsNullOrEmpty(this.Dml_Formula))
                {
                    return new List<RanageFormula>();
                }

                List<RanageFormula> items = (List<RanageFormula>)JsonConvert.DeserializeObject(this.Dml_Formula, typeof(List<RanageFormula>));
                return items;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Dml_Formula = strSerializeJSON;
            }
        }

    }
}
