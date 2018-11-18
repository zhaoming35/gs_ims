using System;
using System.Collections.Generic;
using System.Text;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_order_code","gaoshan_db")]
	[Serializable]
	public class Tb_order_code
	{

		//自动生成属性
		private string _employ_Code;
		/// <summary>
		///编号
		/// </summary>
		[DataFieldAttribute("employ_Code", "varchar")]
		public string Employ_Code
		{
			get { return _employ_Code;}
			set 
			{ 
				_employ_Code = value;
			}
		}

		private string _order_Date;
		/// <summary>
		///身份证号
		/// </summary>
		[DataFieldAttribute("order_Date", "varchar")]
		public string Order_Date
		{
			get { return _order_Date;}
			set 
			{ 
				_order_Date = value;
			}
		}

		private int _seq_No;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("seq_No", "int")]
		public int Seq_No
		{
			get { return _seq_No;}
			set 
			{ 
				_seq_No = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Employ_Code="+this._employ_Code+ ","+"Order_Date="+this._order_Date+ ","+"Seq_No="+this._seq_No+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///编号
		/// </summary>
		public const string Employ_Code="Employ_Code";
		/// <summary>
		///身份证号
		/// </summary>
		public const string Order_Date="Order_Date";
		/// <summary>
		///
		/// </summary>
		public const string Seq_No="Seq_No";
	}

	}

}
