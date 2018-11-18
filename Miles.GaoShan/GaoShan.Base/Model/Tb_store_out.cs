using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_store_out","gaoshan_db")]
	[Serializable]
	public class Tb_store_out
	{

		//自动生成属性
		private long _storeOut_Id;
		/// <summary>
		///配套表主键
		/// </summary>
		[Description("配套表主键")]
		[DataFieldAttribute("storeOut_Id", "bigint", "配套表主键")]
		public long StoreOut_Id
		{
			get { return _storeOut_Id;}
			set 
			{ 
				_storeOut_Id = value;
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

		private int _storeOut_State;
		/// <summary>
		///联络单状态
		/// </summary>
		[Description("联络单状态")]
		[DataFieldAttribute("storeOut_State", "int", "联络单状态")]
		public int StoreOut_State
		{
			get { return _storeOut_State;}
			set 
			{ 
				_storeOut_State = value;
			}
		}

		private int _storeOut_Type;
		/// <summary>
		///出库类型
		/// </summary>
		[Description("出库类型")]
		[DataFieldAttribute("storeOut_Type", "int", "出库类型")]
		public int StoreOut_Type
		{
			get { return _storeOut_Type;}
			set 
			{ 
				_storeOut_Type = value;
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
			return "["+"StoreOut_Id="+this._storeOut_Id+ ","+"LinkBill_Name="+this._linkBill_Name+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Odr_No="+this._odr_No+ ","+"StoreOut_State="+this._storeOut_State+ ","+"StoreOut_Type="+this._storeOut_Type+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///配套表主键
		/// </summary>
		public const string StoreOut_Id="StoreOut_Id";
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
		public const string StoreOut_State="StoreOut_State";
		/// <summary>
		///出库类型
		/// </summary>
		public const string StoreOut_Type="StoreOut_Type";
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
