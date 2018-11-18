using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_link_bill_tent","gaoshan_db")]
	[Serializable]
	public class Tb_link_bill_tent
	{

		//自动生成属性
		private long _item_Id;
		/// <summary>
		///
		/// </summary>
		[Description("item_Id")]
		[DataFieldAttribute("item_Id", "bigint", "")]
		public long Item_Id
		{
			get { return _item_Id;}
			set 
			{ 
				_item_Id = value;
			}
		}

		private long _linkBill_Id;
		/// <summary>
		///联络单id
		/// </summary>
		[Description("联络单id")]
		[DataFieldAttribute("linkBill_Id", "bigint", "联络单id")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

		private int _item_Seq;
		/// <summary>
		///
		/// </summary>
		[Description("item_Seq")]
		[DataFieldAttribute("item_Seq", "int", "")]
		public int Item_Seq
		{
			get { return _item_Seq;}
			set 
			{ 
				_item_Seq = value;
			}
		}

		private string _item_Spec;
		/// <summary>
		///
		/// </summary>
		[Description("item_Spec")]
		[DataFieldAttribute("item_Spec", "varchar", "")]
		public string Item_Spec
		{
			get { return _item_Spec;}
			set 
			{ 
				_item_Spec = value;
			}
		}

		private string _special_Info;
		/// <summary>
		///特殊要求信息
		/// </summary>
		[Description("特殊要求信息")]
		[DataFieldAttribute("special_Info", "varchar", "特殊要求信息")]
		public string Special_Info
		{
			get { return _special_Info;}
			set 
			{ 
				_special_Info = value;
			}
		}

		private string _within_Bag;
		/// <summary>
		///内包描述
		/// </summary>
		[Description("内包描述")]
		[DataFieldAttribute("within_Bag", "varchar", "内包描述")]
		public string Within_Bag
		{
			get { return _within_Bag;}
			set 
			{ 
				_within_Bag = value;
			}
		}

		private decimal _item_Count;
		/// <summary>
		///
		/// </summary>
		[Description("item_Count")]
		[DataFieldAttribute("item_Count", "decimal", "")]
		public decimal Item_Count
		{
			get { return _item_Count;}
			set 
			{ 
				_item_Count = value;
			}
		}

		private string _fixed_Mode;
		/// <summary>
		///固定方式
		/// </summary>
		[Description("固定方式")]
		[DataFieldAttribute("fixed_Mode", "varchar", "固定方式")]
		public string Fixed_Mode
		{
			get { return _fixed_Mode;}
			set 
			{ 
				_fixed_Mode = value;
			}
		}

		private string _tent_Require;
		/// <summary>
		///篷布要求
		/// </summary>
		[Description("篷布要求")]
		[DataFieldAttribute("tent_Require", "varchar", "篷布要求")]
		public string Tent_Require
		{
			get { return _tent_Require;}
			set 
			{ 
				_tent_Require = value;
			}
		}

		private string _wall_Require;
		/// <summary>
		///墙体要求
		/// </summary>
		[Description("墙体要求")]
		[DataFieldAttribute("wall_Require", "varchar", "墙体要求")]
		public string Wall_Require
		{
			get { return _wall_Require;}
			set 
			{ 
				_wall_Require = value;
			}
		}

		private string _tool_Bar;
		/// <summary>
		///工具栏
		/// </summary>
		[Description("工具栏")]
		[DataFieldAttribute("tool_Bar", "varchar", "工具栏")]
		public string Tool_Bar
		{
			get { return _tool_Bar;}
			set 
			{ 
				_tool_Bar = value;
			}
		}

		private string _tent_Pack;
		/// <summary>
		///篷布包装
		/// </summary>
		[Description("篷布包装")]
		[DataFieldAttribute("tent_Pack", "varchar", "篷布包装")]
		public string Tent_Pack
		{
			get { return _tent_Pack;}
			set 
			{ 
				_tent_Pack = value;
			}
		}

		private string _steel_part_pack;
		/// <summary>
		///钢部件包装
		/// </summary>
		[Description("钢部件包装")]
		[DataFieldAttribute("steel_part_pack", "varchar", "钢部件包装")]
		public string Steel_part_pack
		{
			get { return _steel_part_pack;}
			set 
			{ 
				_steel_part_pack = value;
			}
		}

		private string _ground_State;
		/// <summary>
		///地面情况
		/// </summary>
		[Description("地面情况")]
		[DataFieldAttribute("ground_State", "varchar", "地面情况")]
		public string Ground_State
		{
			get { return _ground_State;}
			set 
			{ 
				_ground_State = value;
			}
		}

		private string _lamp_Info;
		/// <summary>
		///灯具
		/// </summary>
		[Description("灯具")]
		[DataFieldAttribute("lamp_Info", "varchar", "灯具")]
		public string Lamp_Info
		{
			get { return _lamp_Info;}
			set 
			{ 
				_lamp_Info = value;
			}
		}

		private string _net_frame;
		/// <summary>
		///网框
		/// </summary>
		[Description("网框")]
		[DataFieldAttribute("net_frame", "varchar", "网框")]
		public string Net_frame
		{
			get { return _net_frame;}
			set 
			{ 
				_net_frame = value;
			}
		}

		private string _steel_drill;
		/// <summary>
		///钢钎
		/// </summary>
		[Description("钢钎")]
		[DataFieldAttribute("steel_drill", "varchar", "钢钎")]
		public string Steel_drill
		{
			get { return _steel_drill;}
			set 
			{ 
				_steel_drill = value;
			}
		}

		private string _is_truck_enter;
		/// <summary>
		///货车是否可以进场
		/// </summary>
		[Description("货车是否可以进场")]
		[DataFieldAttribute("is_truck_enter", "varchar", "货车是否可以进场")]
		public string Is_truck_enter
		{
			get { return _is_truck_enter;}
			set 
			{ 
				_is_truck_enter = value;
			}
		}

		private string _engine_truck_way;
		/// <summary>
		///工程车辆作业
		/// </summary>
		[Description("工程车辆作业")]
		[DataFieldAttribute("engine_truck_way", "varchar", "工程车辆作业")]
		public string Engine_truck_way
		{
			get { return _engine_truck_way;}
			set 
			{ 
				_engine_truck_way = value;
			}
		}

		private string _en_roof_purlin;
		/// <summary>
		///加密屋面檩条
		/// </summary>
		[Description("加密屋面檩条")]
		[DataFieldAttribute("en_roof_purlin", "varchar", "加密屋面檩条")]
		public string En_roof_purlin
		{
			get { return _en_roof_purlin;}
			set 
			{ 
				_en_roof_purlin = value;
			}
		}

		private string _power_Box;
		/// <summary>
		///配电箱
		/// </summary>
		[Description("配电箱")]
		[DataFieldAttribute("power_Box", "varchar", "配电箱")]
		public string Power_Box
		{
			get { return _power_Box;}
			set 
			{ 
				_power_Box = value;
			}
		}

		private string _gutter_Info;
		/// <summary>
		///天沟
		/// </summary>
		[Description("天沟")]
		[DataFieldAttribute("gutter_Info", "varchar", "天沟")]
		public string Gutter_Info
		{
			get { return _gutter_Info;}
			set 
			{ 
				_gutter_Info = value;
			}
		}

		private string _peri_cloth_bear;
		/// <summary>
		///围布承重管
		/// </summary>
		[Description("围布承重管")]
		[DataFieldAttribute("peri_cloth_bear", "varchar", "围布承重管")]
		public string Peri_cloth_bear
		{
			get { return _peri_cloth_bear;}
			set 
			{ 
				_peri_cloth_bear = value;
			}
		}

		private string _has_Logo;
		/// <summary>
		///销售篷房山尖布是否带LOGO
		/// </summary>
		[Description("销售篷房山尖布是否带LOGO")]
		[DataFieldAttribute("has_Logo", "varchar", "销售篷房山尖布是否带LOGO")]
		public string Has_Logo
		{
			get { return _has_Logo;}
			set 
			{ 
				_has_Logo = value;
			}
		}

		private string _remark;
		/// <summary>
		///备注
		/// </summary>
		[Description("备注")]
		[DataFieldAttribute("remark", "varchar", "备注")]
		public string Remark
		{
			get { return _remark;}
			set 
			{ 
				_remark = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Item_Id="+this._item_Id+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Item_Seq="+this._item_Seq+ ","+"Item_Spec="+this._item_Spec+ ","+"Special_Info="+this._special_Info+ ","+"Within_Bag="+this._within_Bag+ ","+"Item_Count="+this._item_Count+ ","+"Fixed_Mode="+this._fixed_Mode+ ","+"Tent_Require="+this._tent_Require+ ","+"Wall_Require="+this._wall_Require+ ","+"Tool_Bar="+this._tool_Bar+ ","+"Tent_Pack="+this._tent_Pack+ ","+"Steel_part_pack="+this._steel_part_pack+ ","+"Ground_State="+this._ground_State+ ","+"Lamp_Info="+this._lamp_Info+ ","+"Net_frame="+this._net_frame+ ","+"Steel_drill="+this._steel_drill+ ","+"Is_truck_enter="+this._is_truck_enter+ ","+"Engine_truck_way="+this._engine_truck_way+ ","+"En_roof_purlin="+this._en_roof_purlin+ ","+"Power_Box="+this._power_Box+ ","+"Gutter_Info="+this._gutter_Info+ ","+"Peri_cloth_bear="+this._peri_cloth_bear+ ","+"Has_Logo="+this._has_Logo+ ","+"Remark="+this._remark+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Item_Id="Item_Id";
		/// <summary>
		///联络单id
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///
		/// </summary>
		public const string Item_Seq="Item_Seq";
		/// <summary>
		///
		/// </summary>
		public const string Item_Spec="Item_Spec";
		/// <summary>
		///特殊要求信息
		/// </summary>
		public const string Special_Info="Special_Info";
		/// <summary>
		///内包描述
		/// </summary>
		public const string Within_Bag="Within_Bag";
		/// <summary>
		///
		/// </summary>
		public const string Item_Count="Item_Count";
		/// <summary>
		///固定方式
		/// </summary>
		public const string Fixed_Mode="Fixed_Mode";
		/// <summary>
		///篷布要求
		/// </summary>
		public const string Tent_Require="Tent_Require";
		/// <summary>
		///墙体要求
		/// </summary>
		public const string Wall_Require="Wall_Require";
		/// <summary>
		///工具栏
		/// </summary>
		public const string Tool_Bar="Tool_Bar";
		/// <summary>
		///篷布包装
		/// </summary>
		public const string Tent_Pack="Tent_Pack";
		/// <summary>
		///钢部件包装
		/// </summary>
		public const string Steel_part_pack="Steel_part_pack";
		/// <summary>
		///地面情况
		/// </summary>
		public const string Ground_State="Ground_State";
		/// <summary>
		///灯具
		/// </summary>
		public const string Lamp_Info="Lamp_Info";
		/// <summary>
		///网框
		/// </summary>
		public const string Net_frame="Net_frame";
		/// <summary>
		///钢钎
		/// </summary>
		public const string Steel_drill="Steel_drill";
		/// <summary>
		///货车是否可以进场
		/// </summary>
		public const string Is_truck_enter="Is_truck_enter";
		/// <summary>
		///工程车辆作业
		/// </summary>
		public const string Engine_truck_way="Engine_truck_way";
		/// <summary>
		///加密屋面檩条
		/// </summary>
		public const string En_roof_purlin="En_roof_purlin";
		/// <summary>
		///配电箱
		/// </summary>
		public const string Power_Box="Power_Box";
		/// <summary>
		///天沟
		/// </summary>
		public const string Gutter_Info="Gutter_Info";
		/// <summary>
		///围布承重管
		/// </summary>
		public const string Peri_cloth_bear="Peri_cloth_bear";
		/// <summary>
		///销售篷房山尖布是否带LOGO
		/// </summary>
		public const string Has_Logo="Has_Logo";
		/// <summary>
		///备注
		/// </summary>
		public const string Remark="Remark";
	}

	}

}
