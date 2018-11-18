using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_truck_info","gaoshan_db")]
	[Serializable]
	public class Tb_truck_info
	{

		//自动生成属性
		private string _truck_Name;
		/// <summary>
		///名称
		/// </summary>
		[Description("名称")]
		[DataFieldAttribute("truck_Name", "varchar", "名称")]
		public string Truck_Name
		{
			get { return _truck_Name;}
			set 
			{ 
				_truck_Name = value;
			}
		}

		private decimal _truck_Load;
		/// <summary>
		///载重
		/// </summary>
		[Description("载重")]
		[DataFieldAttribute("truck_Load", "decimal", "载重")]
		public decimal Truck_Load
		{
			get { return _truck_Load;}
			set 
			{ 
				_truck_Load = value;
			}
		}

		private decimal _per_Cost;
		/// <summary>
		///每公里费用
		/// </summary>
		[Description("每公里费用")]
		[DataFieldAttribute("per_Cost", "decimal", "每公里费用")]
		public decimal Per_Cost
		{
			get { return _per_Cost;}
			set 
			{ 
				_per_Cost = value;
			}
		}

		private decimal _truck_Length;
		/// <summary>
		///车载长度
		/// </summary>
		[Description("车载长度")]
		[DataFieldAttribute("truck_Length", "decimal", "车载长度")]
		public decimal Truck_Length
		{
			get { return _truck_Length;}
			set 
			{ 
				_truck_Length = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Truck_Name="+this._truck_Name+ ","+"Truck_Load="+this._truck_Load+ ","+"Per_Cost="+this._per_Cost+ ","+"Truck_Length="+this._truck_Length+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///名称
		/// </summary>
		public const string Truck_Name="Truck_Name";
		/// <summary>
		///载重
		/// </summary>
		public const string Truck_Load="Truck_Load";
		/// <summary>
		///每公里费用
		/// </summary>
		public const string Per_Cost="Per_Cost";
		/// <summary>
		///车载长度
		/// </summary>
		public const string Truck_Length="Truck_Length";
	}

	}

}
