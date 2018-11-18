using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_carriage_bill","gaoshan_db")]
	[Serializable]
	public class Tb_carriage_bill
	{

		//自动生成属性
		private long _carriage_Id;
		/// <summary>
		///运输单Id
		/// </summary>
		[Description("运输单Id")]
		[DataFieldAttribute("carriage_Id", "bigint", "运输单Id")]
		public long Carriage_Id
		{
			get { return _carriage_Id;}
			set 
			{ 
				_carriage_Id = value;
			}
		}

		private string _carriage_Type;
		/// <summary>
		///运输类型
		/// </summary>
		[Description("运输类型")]
		[DataFieldAttribute("carriage_Type", "varchar", "运输类型")]
		public string Carriage_Type
		{
			get { return _carriage_Type;}
			set 
			{ 
				_carriage_Type = value;
			}
		}

		private string _product_Name;
		/// <summary>
		///运输名称
		/// </summary>
		[Description("运输名称")]
		[DataFieldAttribute("product_Name", "varchar", "运输名称")]
		public string Product_Name
		{
			get { return _product_Name;}
			set 
			{ 
				_product_Name = value;
			}
		}

		private decimal _max_Length;
		/// <summary>
		///最长件
		/// </summary>
		[Description("最长件")]
		[DataFieldAttribute("max_Length", "decimal", "最长件")]
		public decimal Max_Length
		{
			get { return _max_Length;}
			set 
			{ 
				_max_Length = value;
			}
		}

		private decimal _product_Weight;
		/// <summary>
		///车载
		/// </summary>
		[Description("车载")]
		[DataFieldAttribute("product_Weight", "decimal", "车载")]
		public decimal Product_Weight
		{
			get { return _product_Weight;}
			set 
			{ 
				_product_Weight = value;
			}
		}

		private decimal _product_Volume;
		/// <summary>
		///体积
		/// </summary>
		[Description("体积")]
		[DataFieldAttribute("product_Volume", "decimal", "体积")]
		public decimal Product_Volume
		{
			get { return _product_Volume;}
			set 
			{ 
				_product_Volume = value;
			}
		}

		private decimal _product_Count;
		/// <summary>
		///件数
		/// </summary>
		[Description("件数")]
		[DataFieldAttribute("product_Count", "decimal", "件数")]
		public decimal Product_Count
		{
			get { return _product_Count;}
			set 
			{ 
				_product_Count = value;
			}
		}

		private DateTime _load_Date;
		/// <summary>
		///装车时间
		/// </summary>
		[Description("装车时间")]
		[DataFieldAttribute("load_Date", "datetime", "装车时间")]
		public DateTime Load_Date
		{
			get { return _load_Date;}
			set 
			{ 
				_load_Date = value;
			}
		}

		private DateTime _arrive_Date;
		/// <summary>
		///到达时间
		/// </summary>
		[Description("到达时间")]
		[DataFieldAttribute("arrive_Date", "datetime", "到达时间")]
		public DateTime Arrive_Date
		{
			get { return _arrive_Date;}
			set 
			{ 
				_arrive_Date = value;
			}
		}

		private string _load_Place_Text;
		/// <summary>
		///装车地址
		/// </summary>
		[Description("装车地址")]
		[DataFieldAttribute("load_Place_Text", "varchar", "装车地址")]
		public string Load_Place_Text
		{
			get { return _load_Place_Text;}
			set 
			{ 
				_load_Place_Text = value;
			}
		}

		private string _unload_Place_Text;
		/// <summary>
		///卸车地址
		/// </summary>
		[Description("卸车地址")]
		[DataFieldAttribute("unload_Place_Text", "varchar", "卸车地址")]
		public string Unload_Place_Text
		{
			get { return _unload_Place_Text;}
			set 
			{ 
				_unload_Place_Text = value;
			}
		}

		private string _transport_Type;
		/// <summary>
		///运输方式
		/// </summary>
		[Description("运输方式")]
		[DataFieldAttribute("transport_Type", "varchar", "运输方式")]
		public string Transport_Type
		{
			get { return _transport_Type;}
			set 
			{ 
				_transport_Type = value;
			}
		}

		private string _receive_Man;
		/// <summary>
		///收货人
		/// </summary>
		[Description("收货人")]
		[DataFieldAttribute("receive_Man", "varchar", "收货人")]
		public string Receive_Man
		{
			get { return _receive_Man;}
			set 
			{ 
				_receive_Man = value;
			}
		}

		private string _transport_Nature;
		/// <summary>
		///运输性质
		/// </summary>
		[Description("运输性质")]
		[DataFieldAttribute("transport_Nature", "varchar", "运输性质")]
		public string Transport_Nature
		{
			get { return _transport_Nature;}
			set 
			{ 
				_transport_Nature = value;
			}
		}

		private DateTime _oper_Date;
		/// <summary>
		///操作日期
		/// </summary>
		[Description("操作日期")]
		[DataFieldAttribute("oper_Date", "datetime", "操作日期")]
		public DateTime Oper_Date
		{
			get { return _oper_Date;}
			set 
			{ 
				_oper_Date = value;
			}
		}

		private string _oper_Code;
		/// <summary>
		///操作人
		/// </summary>
		[Description("操作人")]
		[DataFieldAttribute("oper_Code", "varchar", "操作人")]
		public string Oper_Code
		{
			get { return _oper_Code;}
			set 
			{ 
				_oper_Code = value;
			}
		}

		private string _odr_No;
		/// <summary>
		///合同编码
		/// </summary>
		[Description("合同编码")]
		[DataFieldAttribute("odr_No", "varchar", "合同编码")]
		public string Odr_No
		{
			get { return _odr_No;}
			set 
			{ 
				_odr_No = value;
			}
		}

		private int _carriage_State;
		/// <summary>
		///运输单状态
		/// </summary>
		[Description("运输单状态")]
		[DataFieldAttribute("carriage_State", "int", "运输单状态")]
		public int Carriage_State
		{
			get { return _carriage_State;}
			set 
			{ 
				_carriage_State = value;
			}
		}

		private string _receive_Phone;
		/// <summary>
		///收货电话
		/// </summary>
		[Description("收货电话")]
		[DataFieldAttribute("receive_Phone", "varchar", "收货电话")]
		public string Receive_Phone
		{
			get { return _receive_Phone;}
			set 
			{ 
				_receive_Phone = value;
			}
		}

		private string _pay_Part;
		/// <summary>
		///支付方
		/// </summary>
		[Description("支付方")]
		[DataFieldAttribute("pay_Part", "varchar", "支付方")]
		public string Pay_Part
		{
			get { return _pay_Part;}
			set 
			{ 
				_pay_Part = value;
			}
		}

		private string _pay_Way;
		/// <summary>
		///支付方式
		/// </summary>
		[Description("支付方式")]
		[DataFieldAttribute("pay_Way", "varchar", "支付方式")]
		public string Pay_Way
		{
			get { return _pay_Way;}
			set 
			{ 
				_pay_Way = value;
			}
		}

		private decimal _carriage_Cost;
		/// <summary>
		///运费
		/// </summary>
		[Description("运费")]
		[DataFieldAttribute("carriage_Cost", "decimal", "运费")]
		public decimal Carriage_Cost
		{
			get { return _carriage_Cost;}
			set 
			{ 
				_carriage_Cost = value;
			}
		}

		private string _carrier_Name;
		/// <summary>
		///承运人
		/// </summary>
		[Description("承运人")]
		[DataFieldAttribute("carrier_Name", "varchar", "承运人")]
		public string Carrier_Name
		{
			get { return _carrier_Name;}
			set 
			{ 
				_carrier_Name = value;
			}
		}

		private string _carrier_Phone;
		/// <summary>
		///承运人电话
		/// </summary>
		[Description("承运人电话")]
		[DataFieldAttribute("carrier_Phone", "varchar", "承运人电话")]
		public string Carrier_Phone
		{
			get { return _carrier_Phone;}
			set 
			{ 
				_carrier_Phone = value;
			}
		}

		private string _trunk_Spec;
		/// <summary>
		///车辆规格
		/// </summary>
		[Description("车辆规格")]
		[DataFieldAttribute("trunk_Spec", "varchar", "车辆规格")]
		public string Trunk_Spec
		{
			get { return _trunk_Spec;}
			set 
			{ 
				_trunk_Spec = value;
			}
		}

		private string _plate_Number;
		/// <summary>
		///车牌号
		/// </summary>
		[Description("车牌号")]
		[DataFieldAttribute("plate_Number", "varchar", "车牌号")]
		public string Plate_Number
		{
			get { return _plate_Number;}
			set 
			{ 
				_plate_Number = value;
			}
		}

		private string _driving_Num;
		/// <summary>
		///驾驶证号码
		/// </summary>
		[Description("驾驶证号码")]
		[DataFieldAttribute("driving_Num", "varchar", "驾驶证号码")]
		public string Driving_Num
		{
			get { return _driving_Num;}
			set 
			{ 
				_driving_Num = value;
			}
		}

		private string _linkBill_Name;
		/// <summary>
		///项目名称
		/// </summary>
		[Description("项目名称")]
		[DataFieldAttribute("linkBill_Name", "varchar", "项目名称")]
		public string LinkBill_Name
		{
			get { return _linkBill_Name;}
			set 
			{ 
				_linkBill_Name = value;
			}
		}

		private string _carriage_Name;
		/// <summary>
		///
		/// </summary>
		[Description("carriage_Name")]
		[DataFieldAttribute("carriage_Name", "varchar", "")]
		public string Carriage_Name
		{
			get { return _carriage_Name;}
			set 
			{ 
				_carriage_Name = value;
			}
		}

		private long _linkBill_Id;
		/// <summary>
		///
		/// </summary>
		[Description("linkBill_Id")]
		[DataFieldAttribute("linkBill_Id", "bigint", "")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

		private long _load_Place_Id;
		/// <summary>
		///
		/// </summary>
		[Description("load_Place_Id")]
		[DataFieldAttribute("load_Place_Id", "bigint", "")]
		public long Load_Place_Id
		{
			get { return _load_Place_Id;}
			set 
			{ 
				_load_Place_Id = value;
			}
		}

		private long _unload_Place_Id;
		/// <summary>
		///
		/// </summary>
		[Description("unload_Place_Id")]
		[DataFieldAttribute("unload_Place_Id", "bigint", "")]
		public long Unload_Place_Id
		{
			get { return _unload_Place_Id;}
			set 
			{ 
				_unload_Place_Id = value;
			}
		}

		private int _is_return_visit;
		/// <summary>
		///是否回访
		/// </summary>
		[Description("是否回访")]
		[DataFieldAttribute("is_return_visit", "int", "是否回访")]
		public int Is_return_visit
		{
			get { return _is_return_visit;}
			set 
			{ 
				_is_return_visit = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Carriage_Id="+this._carriage_Id+ ","+"Carriage_Type="+this._carriage_Type+ ","+"Product_Name="+this._product_Name+ ","+"Max_Length="+this._max_Length+ ","+"Product_Weight="+this._product_Weight+ ","+"Product_Volume="+this._product_Volume+ ","+"Product_Count="+this._product_Count+ ","+"Load_Date="+this._load_Date+ ","+"Arrive_Date="+this._arrive_Date+ ","+"Load_Place_Text="+this._load_Place_Text+ ","+"Unload_Place_Text="+this._unload_Place_Text+ ","+"Transport_Type="+this._transport_Type+ ","+"Receive_Man="+this._receive_Man+ ","+"Transport_Nature="+this._transport_Nature+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Odr_No="+this._odr_No+ ","+"Carriage_State="+this._carriage_State+ ","+"Receive_Phone="+this._receive_Phone+ ","+"Pay_Part="+this._pay_Part+ ","+"Pay_Way="+this._pay_Way+ ","+"Carriage_Cost="+this._carriage_Cost+ ","+"Carrier_Name="+this._carrier_Name+ ","+"Carrier_Phone="+this._carrier_Phone+ ","+"Trunk_Spec="+this._trunk_Spec+ ","+"Plate_Number="+this._plate_Number+ ","+"Driving_Num="+this._driving_Num+ ","+"LinkBill_Name="+this._linkBill_Name+ ","+"Carriage_Name="+this._carriage_Name+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Load_Place_Id="+this._load_Place_Id+ ","+"Unload_Place_Id="+this._unload_Place_Id+ ","+"Is_return_visit="+this._is_return_visit+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///运输单Id
		/// </summary>
		public const string Carriage_Id="Carriage_Id";
		/// <summary>
		///运输类型
		/// </summary>
		public const string Carriage_Type="Carriage_Type";
		/// <summary>
		///运输名称
		/// </summary>
		public const string Product_Name="Product_Name";
		/// <summary>
		///最长件
		/// </summary>
		public const string Max_Length="Max_Length";
		/// <summary>
		///车载
		/// </summary>
		public const string Product_Weight="Product_Weight";
		/// <summary>
		///体积
		/// </summary>
		public const string Product_Volume="Product_Volume";
		/// <summary>
		///件数
		/// </summary>
		public const string Product_Count="Product_Count";
		/// <summary>
		///装车时间
		/// </summary>
		public const string Load_Date="Load_Date";
		/// <summary>
		///到达时间
		/// </summary>
		public const string Arrive_Date="Arrive_Date";
		/// <summary>
		///装车地址
		/// </summary>
		public const string Load_Place_Text="Load_Place_Text";
		/// <summary>
		///卸车地址
		/// </summary>
		public const string Unload_Place_Text="Unload_Place_Text";
		/// <summary>
		///运输方式
		/// </summary>
		public const string Transport_Type="Transport_Type";
		/// <summary>
		///收货人
		/// </summary>
		public const string Receive_Man="Receive_Man";
		/// <summary>
		///运输性质
		/// </summary>
		public const string Transport_Nature="Transport_Nature";
		/// <summary>
		///操作日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///操作人
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///运输单状态
		/// </summary>
		public const string Carriage_State="Carriage_State";
		/// <summary>
		///收货电话
		/// </summary>
		public const string Receive_Phone="Receive_Phone";
		/// <summary>
		///支付方
		/// </summary>
		public const string Pay_Part="Pay_Part";
		/// <summary>
		///支付方式
		/// </summary>
		public const string Pay_Way="Pay_Way";
		/// <summary>
		///运费
		/// </summary>
		public const string Carriage_Cost="Carriage_Cost";
		/// <summary>
		///承运人
		/// </summary>
		public const string Carrier_Name="Carrier_Name";
		/// <summary>
		///承运人电话
		/// </summary>
		public const string Carrier_Phone="Carrier_Phone";
		/// <summary>
		///车辆规格
		/// </summary>
		public const string Trunk_Spec="Trunk_Spec";
		/// <summary>
		///车牌号
		/// </summary>
		public const string Plate_Number="Plate_Number";
		/// <summary>
		///驾驶证号码
		/// </summary>
		public const string Driving_Num="Driving_Num";
		/// <summary>
		///项目名称
		/// </summary>
		public const string LinkBill_Name="LinkBill_Name";
		/// <summary>
		///
		/// </summary>
		public const string Carriage_Name="Carriage_Name";
		/// <summary>
		///
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///
		/// </summary>
		public const string Load_Place_Id="Load_Place_Id";
		/// <summary>
		///
		/// </summary>
		public const string Unload_Place_Id="Unload_Place_Id";
		/// <summary>
		///是否回访
		/// </summary>
		public const string Is_return_visit="Is_return_visit";
	}

	}

}
