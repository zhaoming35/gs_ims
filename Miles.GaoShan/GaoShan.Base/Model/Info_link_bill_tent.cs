using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.Model
{
    public class Info_link_bill_tent: Tb_link_bill_tent
    {
        public Bu_ItemSpec ItemSpec
        {
            get
            {
                if (string.IsNullOrEmpty(this.Item_Spec))
                {
                    return new Bu_ItemSpec();
                }

                Bu_ItemSpec itemSpec = (Bu_ItemSpec)JsonConvert.DeserializeObject(this.Item_Spec, typeof(Bu_ItemSpec));
                return itemSpec;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Item_Spec = strSerializeJSON;
            }
        }

        public Bu_GutterInfo GutterInfo
        {
            get
            {
                if (string.IsNullOrEmpty(this.Gutter_Info))
                {
                    return new Bu_GutterInfo();
                }

                Bu_GutterInfo itemSpec = (Bu_GutterInfo)JsonConvert.DeserializeObject(this.Gutter_Info, typeof(Bu_GutterInfo));
                return itemSpec;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Gutter_Info = strSerializeJSON;
            }
        }

        public Bu_SteelDrill SteelDrill
        {
            get
            {
                if (string.IsNullOrEmpty(this.Steel_drill))
                {
                    return new Bu_SteelDrill();
                }

                Bu_SteelDrill itemSpec = (Bu_SteelDrill)JsonConvert.DeserializeObject(this.Steel_drill, typeof(Bu_SteelDrill));
                return itemSpec;

            }
            set
            {
                if (value == null) { return; }
                string strSerializeJSON = JsonConvert.SerializeObject(value);
                this.Steel_drill = strSerializeJSON;
            }
        }

        public string TentRequire
        {
            get
            {
                return ToDisplayText(this.Tent_Require);
            }
        }

        public string WallRequire
        {
            get
            {
                return ToDisplayText(this.Wall_Require);
            }
        }

        public string ToolBar
        {
            get
            {
                return ToDisplayText(this.Tool_Bar);
            }
        }

        public string TentPack
        {
            get
            {
                return ToDisplayText(this.Tent_Pack);
            }
        }

        public string SteelPartPack
        {
            get
            {
                return ToDisplayText(this.Steel_part_pack);
            }
        }

        public string GroundState
        {
            get
            {
                return ToDisplayText(this.Ground_State);
            }
        }

        public string LampInfo
        {
            get
            {
                return ToDisplayText(this.Lamp_Info);
            }
        }

        public string NetFrame
        {
            get
            {
                return ToDisplayText(this.Net_frame);
            }
        }

        public string IsTruckEnter
        {
            get
            {
                return ToDisplayText(this.Is_truck_enter);
            }
        }

        public string EngineTruckWay
        {
            get
            {
                return ToDisplayText(this.Engine_truck_way);
            }
        }

        public string EnRoofPurlin
        {
            get
            {
                return ToDisplayText(this.En_roof_purlin);
            }
        }

        public string PowerBox
        {
            get
            {
                return ToDisplayText(this.Power_Box);
            }
        }

        public string PeriClothBear
        {
            get
            {
                return ToDisplayText(this.Peri_cloth_bear);
            }
        }

        public string HasLogo
        {
            get
            {
                return ToDisplayText(this.Has_Logo);
            }
        }


        //其它所有的都要这么改，对应的excel位置变量修改
        private string ToDisplayText(string strValue)
        {
            if (string.IsNullOrEmpty(strValue)) { return null; }

            Dictionary<string, bool> dicProvideInfo = (Dictionary<string, bool>)JsonConvert.DeserializeObject(strValue, typeof(Dictionary<string, bool>));

            StringBuilder sb = new StringBuilder();
            foreach (var v in dicProvideInfo)
            {
                sb.Append(v.Key);
                if (v.Value)
                {
                    sb.Append("（√）");
                }
                else {
                    sb.Append("（ ）");
                }
            }

            return sb.ToString();
        }
    }
}
