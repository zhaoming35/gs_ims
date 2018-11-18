using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_project_Cost","gaoshan_db")]
	[Serializable]
	public class Tb_project_Cost
	{

		//自动生成属性
		private string _odr_No;
		/// <summary>
		///合同编码
		/// </summary>
		[Description("合同编码")]
		[DataFieldAttribute("odr_No", "varchar", "合同编码")]
		public string Odr_No
		{
			get { return _odr_No;}
			set 
			{ 
				_odr_No = value;
			}
		}

		private long _linkBill_Id;
		/// <summary>
		///联络单主键
		/// </summary>
		[Description("联络单主键")]
		[DataFieldAttribute("linkBill_Id", "bigint", "联络单主键")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

		private string _jia_Name;
		/// <summary>
		///
		/// </summary>
		[Description("jia_Name")]
		[DataFieldAttribute("jia_Name", "varchar", "")]
		public string Jia_Name
		{
			get { return _jia_Name;}
			set 
			{ 
				_jia_Name = value;
			}
		}

		private string _linkBill_Name;
		/// <summary>
		///项目名称
		/// </summary>
		[Description("项目名称")]
		[DataFieldAttribute("linkBill_Name", "varchar", "项目名称")]
		public string LinkBill_Name
		{
			get { return _linkBill_Name;}
			set 
			{ 
				_linkBill_Name = value;
			}
		}

		private string _employ_Name;
		/// <summary>
		///业务员名称
		/// </summary>
		[Description("业务员名称")]
		[DataFieldAttribute("employ_Name", "varchar", "业务员名称")]
		public string Employ_Name
		{
			get { return _employ_Name;}
			set 
			{ 
				_employ_Name = value;
			}
		}

		private int _linkBill_Type;
		/// <summary>
		///项目联络单类型，正常还是取消
		/// </summary>
		[Description("项目联络单类型，正常还是取消")]
		[DataFieldAttribute("linkBill_Type", "int", "项目联络单类型，正常还是取消")]
		public int LinkBill_Type
		{
			get { return _linkBill_Type;}
			set 
			{ 
				_linkBill_Type = value;
			}
		}

		private int _cost_State;
		/// <summary>
		///联络单状态
		/// </summary>
		[Description("联络单状态")]
		[DataFieldAttribute("cost_State", "int", "联络单状态")]
		public int Cost_State
		{
			get { return _cost_State;}
			set 
			{ 
				_cost_State = value;
			}
		}

		private int _odr_Type;
		/// <summary>
		///合同类型
		/// </summary>
		[Description("合同类型")]
		[DataFieldAttribute("odr_Type", "int", "合同类型")]
		public int Odr_Type
		{
			get { return _odr_Type;}
			set 
			{ 
				_odr_Type = value;
			}
		}

		private string _odr_Prt_Name;
		/// <summary>
		///合同产品名称
		/// </summary>
		[Description("合同产品名称")]
		[DataFieldAttribute("odr_Prt_Name", "varchar", "合同产品名称")]
		public string Odr_Prt_Name
		{
			get { return _odr_Prt_Name;}
			set 
			{ 
				_odr_Prt_Name = value;
			}
		}

		private string _odr_Bud_Palce;
		/// <summary>
		///搭建地点
		/// </summary>
		[Description("搭建地点")]
		[DataFieldAttribute("odr_Bud_Palce", "varchar", "搭建地点")]
		public string Odr_Bud_Palce
		{
			get { return _odr_Bud_Palce;}
			set 
			{ 
				_odr_Bud_Palce = value;
			}
		}

		private DateTime _oper_Date;
		/// <summary>
		///操作日期
		/// </summary>
		[Description("操作日期")]
		[DataFieldAttribute("oper_Date", "datetime", "操作日期")]
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
		///操作人
		/// </summary>
		[Description("操作人")]
		[DataFieldAttribute("oper_Code", "varchar", "操作人")]
		public string Oper_Code
		{
			get { return _oper_Code;}
			set 
			{ 
				_oper_Code = value;
			}
		}

		private string _employ_Code;
		/// <summary>
		///
		/// </summary>
		[Description("employ_Code")]
		[DataFieldAttribute("employ_Code", "varchar", "")]
		public string Employ_Code
		{
			get { return _employ_Code;}
			set 
			{ 
				_employ_Code = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Jia_Name="+this._jia_Name+ ","+"LinkBill_Name="+this._linkBill_Name+ ","+"Employ_Name="+this._employ_Name+ ","+"LinkBill_Type="+this._linkBill_Type+ ","+"Cost_State="+this._cost_State+ ","+"Odr_Type="+this._odr_Type+ ","+"Odr_Prt_Name="+this._odr_Prt_Name+ ","+"Odr_Bud_Palce="+this._odr_Bud_Palce+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Employ_Code="+this._employ_Code+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///联络单主键
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///
		/// </summary>
		public const string Jia_Name="Jia_Name";
		/// <summary>
		///项目名称
		/// </summary>
		public const string LinkBill_Name="LinkBill_Name";
		/// <summary>
		///业务员名称
		/// </summary>
		public const string Employ_Name="Employ_Name";
		/// <summary>
		///项目联络单类型，正常还是取消
		/// </summary>
		public const string LinkBill_Type="LinkBill_Type";
		/// <summary>
		///联络单状态
		/// </summary>
		public const string Cost_State="Cost_State";
		/// <summary>
		///合同类型
		/// </summary>
		public const string Odr_Type="Odr_Type";
		/// <summary>
		///合同产品名称
		/// </summary>
		public const string Odr_Prt_Name="Odr_Prt_Name";
		/// <summary>
		///搭建地点
		/// </summary>
		public const string Odr_Bud_Palce="Odr_Bud_Palce";
		/// <summary>
		///操作日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///操作人
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///
		/// </summary>
		public const string Employ_Code="Employ_Code";
	}

	}

}
