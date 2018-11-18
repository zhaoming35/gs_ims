using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_salary_main_item","gaoshan_db")]
	[Serializable]
	public class Tb_salary_main_item
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

		private int _salary_Kind;
		/// <summary>
		///提成类别
		/// </summary>
		[Description("提成类别")]
		[DataFieldAttribute("salary_Kind", "int", "提成类别")]
		public int Salary_Kind
		{
			get { return _salary_Kind;}
			set 
			{ 
				_salary_Kind = value;
			}
		}

		private decimal _salary_Ratio;
		/// <summary>
		///提成比例
		/// </summary>
		[Description("提成比例")]
		[DataFieldAttribute("salary_Ratio", "decimal", "提成比例")]
		public decimal Salary_Ratio
		{
			get { return _salary_Ratio;}
			set 
			{ 
				_salary_Ratio = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No_Main="+this._odr_No_Main+ ","+"Employ_Code="+this._employ_Code+ ","+"Salary_Kind="+this._salary_Kind+ ","+"Salary_Ratio="+this._salary_Ratio+"]";
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
		///提成类别
		/// </summary>
		public const string Salary_Kind="Salary_Kind";
		/// <summary>
		///提成比例
		/// </summary>
		public const string Salary_Ratio="Salary_Ratio";
	}

	}

}
