using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_salary_main","gaoshan_db")]
	[Serializable]
	public class Tb_salary_main
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

		private decimal _cal_tot_Cost;
		/// <summary>
		///计算提成时合同总金额
		/// </summary>
		[Description("计算提成时合同总金额")]
		[DataFieldAttribute("cal_tot_Cost", "decimal", "计算提成时合同总金额")]
		public decimal Cal_tot_Cost
		{
			get { return _cal_tot_Cost;}
			set 
			{ 
				_cal_tot_Cost = value;
			}
		}

		private decimal _cal_pay_Cost;
		/// <summary>
		///计算提成时支付总金额
		/// </summary>
		[Description("计算提成时支付总金额")]
		[DataFieldAttribute("cal_pay_Cost", "decimal", "计算提成时支付总金额")]
		public decimal Cal_pay_Cost
		{
			get { return _cal_pay_Cost;}
			set 
			{ 
				_cal_pay_Cost = value;
			}
		}

		private string _related_Man;
		/// <summary>
		///提成相关人信息Json
		/// </summary>
		[Description("提成相关人信息Json")]
		[DataFieldAttribute("related_Man", "nvarchar", "提成相关人信息Json")]
		public string Related_Man
		{
			get { return _related_Man;}
			set 
			{ 
				_related_Man = value;
			}
		}

		private decimal _cal_Value;
		/// <summary>
		///计算比例值
		/// </summary>
		[Description("计算比例值")]
		[DataFieldAttribute("cal_Value", "decimal", "计算比例值")]
		public decimal Cal_Value
		{
			get { return _cal_Value;}
			set 
			{ 
				_cal_Value = value;
			}
		}

		private decimal _cal_base_Salary;
		/// <summary>
		///计算基数
		/// </summary>
		[Description("计算基数")]
		[DataFieldAttribute("cal_base_Salary", "decimal", "计算基数")]
		public decimal Cal_base_Salary
		{
			get { return _cal_base_Salary;}
			set 
			{ 
				_cal_base_Salary = value;
			}
		}

		private decimal _guide_Price;
		/// <summary>
		///销售指导价
		/// </summary>
		[Description("销售指导价")]
		[DataFieldAttribute("guide_Price", "decimal", "销售指导价")]
		public decimal Guide_Price
		{
			get { return _guide_Price;}
			set 
			{ 
				_guide_Price = value;
			}
		}

		private DateTime _oper_Date;
		/// <summary>
		///计算日期
		/// </summary>
		[Description("计算日期")]
		[DataFieldAttribute("oper_Date", "datetime", "计算日期")]
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

		private string _cal_Process;
		/// <summary>
		///计算过程各个变量值
		/// </summary>
		[Description("计算过程各个变量值")]
		[DataFieldAttribute("cal_Process", "varchar", "计算过程各个变量值")]
		public string Cal_Process
		{
			get { return _cal_Process;}
			set 
			{ 
				_cal_Process = value;
			}
		}

		private int _recal_Flag;
		/// <summary>
		///需要重新计算标志
		/// </summary>
		[Description("需要重新计算标志")]
		[DataFieldAttribute("recal_Flag", "int", "需要重新计算标志")]
		public int Recal_Flag
		{
			get { return _recal_Flag;}
			set 
			{ 
				_recal_Flag = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No_Main="+this._odr_No_Main+ ","+"Cal_tot_Cost="+this._cal_tot_Cost+ ","+"Cal_pay_Cost="+this._cal_pay_Cost+ ","+"Related_Man="+this._related_Man+ ","+"Cal_Value="+this._cal_Value+ ","+"Cal_base_Salary="+this._cal_base_Salary+ ","+"Guide_Price="+this._guide_Price+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Cal_Process="+this._cal_Process+ ","+"Recal_Flag="+this._recal_Flag+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///主合同编码
		/// </summary>
		public const string Odr_No_Main="Odr_No_Main";
		/// <summary>
		///计算提成时合同总金额
		/// </summary>
		public const string Cal_tot_Cost="Cal_tot_Cost";
		/// <summary>
		///计算提成时支付总金额
		/// </summary>
		public const string Cal_pay_Cost="Cal_pay_Cost";
		/// <summary>
		///提成相关人信息Json
		/// </summary>
		public const string Related_Man="Related_Man";
		/// <summary>
		///计算比例值
		/// </summary>
		public const string Cal_Value="Cal_Value";
		/// <summary>
		///计算基数
		/// </summary>
		public const string Cal_base_Salary="Cal_base_Salary";
		/// <summary>
		///销售指导价
		/// </summary>
		public const string Guide_Price="Guide_Price";
		/// <summary>
		///计算日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///计算过程各个变量值
		/// </summary>
		public const string Cal_Process="Cal_Process";
		/// <summary>
		///需要重新计算标志
		/// </summary>
		public const string Recal_Flag="Recal_Flag";
	}

	}

}
