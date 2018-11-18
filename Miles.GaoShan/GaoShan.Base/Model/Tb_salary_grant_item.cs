using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_salary_grant_item","gaoshan_db")]
	[Serializable]
	public class Tb_salary_grant_item
	{

		//自动生成属性
		private string _odr_No_Main;
		/// <summary>
		///主合同编码
		/// </summary>
		[Description("主合同编码")]
		[DataFieldAttribute("odr_No_Main", "varchar", "主合同编码")]
		public string Odr_No_Main
		{
			get { return _odr_No_Main;}
			set 
			{ 
				_odr_No_Main = value;
			}
		}

		private string _employ_Code;
		/// <summary>
		///提成人
		/// </summary>
		[Description("提成人")]
		[DataFieldAttribute("employ_Code", "varchar", "提成人")]
		public string Employ_Code
		{
			get { return _employ_Code;}
			set 
			{ 
				_employ_Code = value;
			}
		}

		private long _record_Id;
		/// <summary>
		///
		/// </summary>
		[Description("record_Id")]
		[DataFieldAttribute("record_Id", "bigint", "")]
		public long Record_Id
		{
			get { return _record_Id;}
			set 
			{ 
				_record_Id = value;
			}
		}

		private DateTime _grant_Date;
		/// <summary>
		///发放日期
		/// </summary>
		[Description("发放日期")]
		[DataFieldAttribute("grant_Date", "datetime", "发放日期")]
		public DateTime Grant_Date
		{
			get { return _grant_Date;}
			set 
			{ 
				_grant_Date = value;
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

		private decimal _salary_Grant;
		/// <summary>
		///发放金额
		/// </summary>
		[Description("发放金额")]
		[DataFieldAttribute("salary_Grant", "decimal", "发放金额")]
		public decimal Salary_Grant
		{
			get { return _salary_Grant;}
			set 
			{ 
				_salary_Grant = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No_Main="+this._odr_No_Main+ ","+"Employ_Code="+this._employ_Code+ ","+"Record_Id="+this._record_Id+ ","+"Grant_Date="+this._grant_Date+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Salary_Grant="+this._salary_Grant+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///主合同编码
		/// </summary>
		public const string Odr_No_Main="Odr_No_Main";
		/// <summary>
		///提成人
		/// </summary>
		public const string Employ_Code="Employ_Code";
		/// <summary>
		///
		/// </summary>
		public const string Record_Id="Record_Id";
		/// <summary>
		///发放日期
		/// </summary>
		public const string Grant_Date="Grant_Date";
		/// <summary>
		///
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///发放金额
		/// </summary>
		public const string Salary_Grant="Salary_Grant";
	}

	}

}
