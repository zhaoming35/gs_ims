using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_default_adress","gaoshan_db")]
	[Serializable]
	public class Tb_default_adress
	{

		//自动生成属性
		private long _place_Id;
		/// <summary>
		///
		/// </summary>
		[Description("place_Id")]
		[DataFieldAttribute("place_Id", "bigint", "")]
		public long Place_Id
		{
			get { return _place_Id;}
			set 
			{ 
				_place_Id = value;
			}
		}

		private string _detail_Adress;
		/// <summary>
		///
		/// </summary>
		[Description("detail_Adress")]
		[DataFieldAttribute("detail_Adress", "varchar", "")]
		public string Detail_Adress
		{
			get { return _detail_Adress;}
			set 
			{ 
				_detail_Adress = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Place_Id="+this._place_Id+ ","+"Detail_Adress="+this._detail_Adress+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Place_Id="Place_Id";
		/// <summary>
		///
		/// </summary>
		public const string Detail_Adress="Detail_Adress";
	}

	}

}
