using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_place_fee","gaoshan_db")]
	[Serializable]
	public class Tb_place_fee
	{

		//自动生成属性
		private long _place_Id;
		/// <summary>
		///地点Id
		/// </summary>
		[Description("地点Id")]
		[DataFieldAttribute("place_Id", "bigint", "地点Id")]
		public long Place_Id
		{
			get { return _place_Id;}
			set 
			{ 
				_place_Id = value;
			}
		}

		private string _truck_Name;
		/// <summary>
		///货车名称
		/// </summary>
		[Description("货车名称")]
		[DataFieldAttribute("truck_Name", "varchar", "货车名称")]
		public string Truck_Name
		{
			get { return _truck_Name;}
			set 
			{ 
				_truck_Name = value;
			}
		}

		private string _trans_Direction;
		/// <summary>
		///往返状态
		/// </summary>
		[Description("往返状态")]
		[DataFieldAttribute("trans_Direction", "varchar", "往返状态")]
		public string Trans_Direction
		{
			get { return _trans_Direction;}
			set 
			{ 
				_trans_Direction = value;
			}
		}

		private decimal _place_Distance;
		/// <summary>
		///公里数
		/// </summary>
		[Description("公里数")]
		[DataFieldAttribute("place_Distance", "decimal", "公里数")]
		public decimal Place_Distance
		{
			get { return _place_Distance;}
			set 
			{ 
				_place_Distance = value;
			}
		}

		private decimal _trans_Cost;
		/// <summary>
		///运输费用
		/// </summary>
		[Description("运输费用")]
		[DataFieldAttribute("trans_Cost", "decimal", "运输费用")]
		public decimal Trans_Cost
		{
			get { return _trans_Cost;}
			set 
			{ 
				_trans_Cost = value;
			}
		}

		private long _fee_Id;
		/// <summary>
		///
		/// </summary>
		[Description("fee_Id")]
		[DataFieldAttribute("fee_Id", "bigint", "")]
		public long Fee_Id
		{
			get { return _fee_Id;}
			set 
			{ 
				_fee_Id = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Place_Id="+this._place_Id+ ","+"Truck_Name="+this._truck_Name+ ","+"Trans_Direction="+this._trans_Direction+ ","+"Place_Distance="+this._place_Distance+ ","+"Trans_Cost="+this._trans_Cost+ ","+"Fee_Id="+this._fee_Id+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///地点Id
		/// </summary>
		public const string Place_Id="Place_Id";
		/// <summary>
		///货车名称
		/// </summary>
		public const string Truck_Name="Truck_Name";
		/// <summary>
		///往返状态
		/// </summary>
		public const string Trans_Direction="Trans_Direction";
		/// <summary>
		///公里数
		/// </summary>
		public const string Place_Distance="Place_Distance";
		/// <summary>
		///运输费用
		/// </summary>
		public const string Trans_Cost="Trans_Cost";
		/// <summary>
		///
		/// </summary>
		public const string Fee_Id="Fee_Id";
	}

	}

}
