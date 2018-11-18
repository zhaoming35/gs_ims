using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_salary_tmp","gaoshan_db")]
	[Serializable]
	public class Tb_salary_tmp
	{

		//自动生成属性
		private string _var_Input;
		/// <summary>
		///配套表输入参数
		/// </summary>
		[Description("配套表输入参数")]
		[DataFieldAttribute("var_Input", "nvarchar", "配套表输入参数")]
		public string Var_Input
		{
			get { return _var_Input;}
			set 
			{ 
				_var_Input = value;
			}
		}

		private string _var_Cal;
		/// <summary>
		///配套表计算参数
		/// </summary>
		[Description("配套表计算参数")]
		[DataFieldAttribute("var_Cal", "nvarchar", "配套表计算参数")]
		public string Var_Cal
		{
			get { return _var_Cal;}
			set 
			{ 
				_var_Cal = value;
			}
		}

		private string _sales_Man;
		/// <summary>
		///成交人提成表格
		/// </summary>
		[Description("成交人提成表格")]
		[DataFieldAttribute("sales_Man", "nvarchar", "成交人提成表格")]
		public string Sales_Man
		{
			get { return _sales_Man;}
			set 
			{ 
				_sales_Man = value;
			}
		}

		private string _dept_Award;
		/// <summary>
		///部门奖表格
		/// </summary>
		[Description("部门奖表格")]
		[DataFieldAttribute("dept_Award", "nvarchar", "部门奖表格")]
		public string Dept_Award
		{
			get { return _dept_Award;}
			set 
			{ 
				_dept_Award = value;
			}
		}

		private string _organ_Award;
		/// <summary>
		///固定方式
		/// </summary>
		[Description("固定方式")]
		[DataFieldAttribute("organ_Award", "nvarchar", "固定方式")]
		public string Organ_Award
		{
			get { return _organ_Award;}
			set 
			{ 
				_organ_Award = value;
			}
		}

		private int _salary_Type;
		/// <summary>
		///计算提成合同类型
		/// </summary>
		[Description("计算提成合同类型")]
		[DataFieldAttribute("salary_Type", "int", "计算提成合同类型")]
		public int Salary_Type
		{
			get { return _salary_Type;}
			set 
			{ 
				_salary_Type = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Var_Input="+this._var_Input+ ","+"Var_Cal="+this._var_Cal+ ","+"Sales_Man="+this._sales_Man+ ","+"Dept_Award="+this._dept_Award+ ","+"Organ_Award="+this._organ_Award+ ","+"Salary_Type="+this._salary_Type+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///配套表输入参数
		/// </summary>
		public const string Var_Input="Var_Input";
		/// <summary>
		///配套表计算参数
		/// </summary>
		public const string Var_Cal="Var_Cal";
		/// <summary>
		///成交人提成表格
		/// </summary>
		public const string Sales_Man="Sales_Man";
		/// <summary>
		///部门奖表格
		/// </summary>
		public const string Dept_Award="Dept_Award";
		/// <summary>
		///固定方式
		/// </summary>
		public const string Organ_Award="Organ_Award";
		/// <summary>
		///计算提成合同类型
		/// </summary>
		public const string Salary_Type="Salary_Type";
	}

	}

}
