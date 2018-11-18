using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_main","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_main
	{

		//自动生成属性
		private string _linkWay1;
		/// <summary>
		///
		/// </summary>
		[Description("linkWay1")]
		[DataFieldAttribute("linkWay1", "varchar", "")]
		public string LinkWay1
		{
			get { return _linkWay1;}
			set 
			{ 
				_linkWay1 = value;
			}
		}

		private string _linkWay2;
		/// <summary>
		///
		/// </summary>
		[Description("linkWay2")]
		[DataFieldAttribute("linkWay2", "varchar", "")]
		public string LinkWay2
		{
			get { return _linkWay2;}
			set 
			{ 
				_linkWay2 = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"LinkWay1="+this._linkWay1+ ","+"LinkWay2="+this._linkWay2+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string LinkWay1="LinkWay1";
		/// <summary>
		///
		/// </summary>
		public const string LinkWay2="LinkWay2";
	}

	}

}
