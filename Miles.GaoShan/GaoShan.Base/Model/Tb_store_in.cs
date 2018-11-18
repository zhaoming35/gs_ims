using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_store_in","gaoshan_db")]
	[Serializable]
	public class Tb_store_in
	{

		//自动生成属性
		private long _storeIn_Id;
		/// <summary>
		///主键
		/// </summary>
		[Description("主键")]
		[DataFieldAttribute("storeIn_Id", "bigint", "主键")]
		public long StoreIn_Id
		{
			get { return _storeIn_Id;}
			set 
			{ 
				_storeIn_Id = value;
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

		private long _linkBill_Id;
		/// <summary>
		///
		/// </summary>
		[Description("linkBill_Id")]
		[DataFieldAttribute("linkBill_Id", "bigint", "")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

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

		private int _storeIn_State;
		/// <summary>
		///联络单状态
		/// </summary>
		[Description("联络单状态")]
		[DataFieldAttribute("storeIn_State", "int", "联络单状态")]
		public int StoreIn_State
		{
			get { return _storeIn_State;}
			set 
			{ 
				_storeIn_State = value;
			}
		}

		private int _storeIn_Type;
		/// <summary>
		///出库类型
		/// </summary>
		[Description("出库类型")]
		[DataFieldAttribute("storeIn_Type", "int", "出库类型")]
		public int StoreIn_Type
		{
			get { return _storeIn_Type;}
			set 
			{ 
				_storeIn_Type = value;
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

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"StoreIn_Id="+this._storeIn_Id+ ","+"LinkBill_Name="+this._linkBill_Name+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Odr_No="+this._odr_No+ ","+"StoreIn_State="+this._storeIn_State+ ","+"StoreIn_Type="+this._storeIn_Type+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///主键
		/// </summary>
		public const string StoreIn_Id="StoreIn_Id";
		/// <summary>
		///项目名称
		/// </summary>
		public const string LinkBill_Name="LinkBill_Name";
		/// <summary>
		///
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///联络单状态
		/// </summary>
		public const string StoreIn_State="StoreIn_State";
		/// <summary>
		///出库类型
		/// </summary>
		public const string StoreIn_Type="StoreIn_Type";
		/// <summary>
		///操作日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///操作人
		/// </summary>
		public const string Oper_Code="Oper_Code";
	}

	}

}
