using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_fin_transport_max","gaoshan_db")]
	[Serializable]
	public class Tb_fin_transport_max
	{

		//自动生成属性
		private long _max_Id;
		/// <summary>
		///配套表主键
		/// </summary>
		[Description("配套表主键")]
		[DataFieldAttribute("max_Id", "bigint", "配套表主键")]
		public long Max_Id
		{
			get { return _max_Id;}
			set 
			{ 
				_max_Id = value;
			}
		}

		private decimal _tent_Width;
		/// <summary>
		///篷房宽
		/// </summary>
		[Description("篷房宽")]
		[DataFieldAttribute("tent_Width", "decimal", "篷房宽")]
		public decimal Tent_Width
		{
			get { return _tent_Width;}
			set 
			{ 
				_tent_Width = value;
			}
		}

		private decimal _row_Weight;
		/// <summary>
		///每排重
		/// </summary>
		[Description("每排重")]
		[DataFieldAttribute("row_Weight", "decimal", "每排重")]
		public decimal Row_Weight
		{
			get { return _row_Weight;}
			set 
			{ 
				_row_Weight = value;
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

		private decimal _tent_Space;
		/// <summary>
		///篷房间距
		/// </summary>
		[Description("篷房间距")]
		[DataFieldAttribute("tent_Space", "decimal", "篷房间距")]
		public decimal Tent_Space
		{
			get { return _tent_Space;}
			set 
			{ 
				_tent_Space = value;
			}
		}

		private decimal _tent_edgeHeight;
		/// <summary>
		///篷房边高
		/// </summary>
		[Description("篷房边高")]
		[DataFieldAttribute("tent_edgeHeight", "decimal", "篷房边高")]
		public decimal Tent_edgeHeight
		{
			get { return _tent_edgeHeight;}
			set 
			{ 
				_tent_edgeHeight = value;
			}
		}

		private string _tent_MainSpec;
		/// <summary>
		///主材规格
		/// </summary>
		[Description("主材规格")]
		[DataFieldAttribute("tent_MainSpec", "varchar", "主材规格")]
		public string Tent_MainSpec
		{
			get { return _tent_MainSpec;}
			set 
			{ 
				_tent_MainSpec = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Max_Id="+this._max_Id+ ","+"Tent_Width="+this._tent_Width+ ","+"Row_Weight="+this._row_Weight+ ","+"Max_Length="+this._max_Length+ ","+"Tent_Space="+this._tent_Space+ ","+"Tent_edgeHeight="+this._tent_edgeHeight+ ","+"Tent_MainSpec="+this._tent_MainSpec+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///配套表主键
		/// </summary>
		public const string Max_Id="Max_Id";
		/// <summary>
		///篷房宽
		/// </summary>
		public const string Tent_Width="Tent_Width";
		/// <summary>
		///每排重
		/// </summary>
		public const string Row_Weight="Row_Weight";
		/// <summary>
		///最长件
		/// </summary>
		public const string Max_Length="Max_Length";
		/// <summary>
		///篷房间距
		/// </summary>
		public const string Tent_Space="Tent_Space";
		/// <summary>
		///篷房边高
		/// </summary>
		public const string Tent_edgeHeight="Tent_edgeHeight";
		/// <summary>
		///主材规格
		/// </summary>
		public const string Tent_MainSpec="Tent_MainSpec";
	}

	}

}
