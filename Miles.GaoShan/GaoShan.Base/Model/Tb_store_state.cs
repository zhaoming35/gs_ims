using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_store_state","gaoshan_db")]
	[Serializable]
	public class Tb_store_state
	{

		//自动生成属性
		private int _state;
		/// <summary>
		///
		/// </summary>
		[Description("state")]
		[DataFieldAttribute("state", "int", "")]
		public int State
		{
			get { return _state;}
			set 
			{ 
				_state = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"State="+this._state+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string State="State";
	}

	}

}
