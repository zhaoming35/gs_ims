using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_order_log","gaoshan_db")]
	[Serializable]
	public class Tb_order_log
	{

		//自动生成属性
		private string _odr_No;
		/// <summary>
		///关联Id
		/// </summary>
		[Description("关联Id")]
		[DataFieldAttribute("odr_No", "varchar", "关联Id")]
		public string Odr_No
		{
			get { return _odr_No;}
			set 
			{ 
				_odr_No = value;
			}
		}

		private string _msg;
		/// <summary>
		///
		/// </summary>
		[Description("msg")]
		[DataFieldAttribute("msg", "varchar", "")]
		public string Msg
		{
			get { return _msg;}
			set 
			{ 
				_msg = value;
			}
		}

		private DateTime _oper_Date;
		/// <summary>
		///
		/// </summary>
		[Description("oper_Date")]
		[DataFieldAttribute("oper_Date", "datetime", "")]
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
		///
		/// </summary>
		[Description("oper_Code")]
		[DataFieldAttribute("oper_Code", "varchar", "")]
		public string Oper_Code
		{
			get { return _oper_Code;}
			set 
			{ 
				_oper_Code = value;
			}
		}

		private string _oper_log;
		/// <summary>
		///
		/// </summary>
		[Description("oper_log")]
		[DataFieldAttribute("oper_log", "varchar", "")]
		public string Oper_log
		{
			get { return _oper_log;}
			set 
			{ 
				_oper_log = value;
			}
		}

		private string _oper_Info;
		/// <summary>
		///
		/// </summary>
		[Description("oper_Info")]
		[DataFieldAttribute("oper_Info", "ntext", "")]
		public string Oper_Info
		{
			get { return _oper_Info;}
			set 
			{ 
				_oper_Info = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"Msg="+this._msg+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Oper_log="+this._oper_log+ ","+"Oper_Info="+this._oper_Info+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///关联Id
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///
		/// </summary>
		public const string Msg="Msg";
		/// <summary>
		///
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///
		/// </summary>
		public const string Oper_log="Oper_log";
		/// <summary>
		///
		/// </summary>
		public const string Oper_Info="Oper_Info";
	}

	}

}
