using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_matchTb_tmp_set","gaoshan_db")]
	[Serializable]
	public class Tb_matchTb_tmp_set
	{

		//自动生成属性
		private decimal _tent_Weight;
		/// <summary>
		///
		/// </summary>
		[Description("tent_Weight")]
		[DataFieldAttribute("tent_Weight", "decimal", "")]
		public decimal Tent_Weight
		{
			get { return _tent_Weight;}
			set 
			{ 
				_tent_Weight = value;
			}
		}

		private string _tent_MainSpec;
		/// <summary>
		///
		/// </summary>
		[Description("tent_MainSpec")]
		[DataFieldAttribute("tent_MainSpec", "varchar", "")]
		public string Tent_MainSpec
		{
			get { return _tent_MainSpec;}
			set 
			{ 
				_tent_MainSpec = value;
			}
		}

		private string _set_Items;
		/// <summary>
		/// 物流组成编码集合
		/// </summary>
		[Description(" 物流组成编码集合")]
		[DataFieldAttribute("set_Items", "nvarchar", " 物流组成编码集合")]
		public string Set_Items
		{
			get { return _set_Items;}
			set 
			{ 
				_set_Items = value;
			}
		}

		private long _set_Id;
		/// <summary>
		///
		/// </summary>
		[Description("set_Id")]
		[DataFieldAttribute("set_Id", "bigint", "")]
		public long Set_Id
		{
			get { return _set_Id;}
			set 
			{ 
				_set_Id = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Tent_Weight="+this._tent_Weight+ ","+"Tent_MainSpec="+this._tent_MainSpec+ ","+"Set_Items="+this._set_Items+ ","+"Set_Id="+this._set_Id+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Tent_Weight="Tent_Weight";
		/// <summary>
		///
		/// </summary>
		public const string Tent_MainSpec="Tent_MainSpec";
		/// <summary>
		/// 物流组成编码集合
		/// </summary>
		public const string Set_Items="Set_Items";
		/// <summary>
		///
		/// </summary>
		public const string Set_Id="Set_Id";
	}

	}

}
