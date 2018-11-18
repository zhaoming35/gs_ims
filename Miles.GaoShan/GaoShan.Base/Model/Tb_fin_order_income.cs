using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_fin_order_income","gaoshan_db")]
	[Serializable]
	public class Tb_fin_order_income
	{

		//自动生成属性
		private long _fin_Id;
		/// <summary>
		///Id
		/// </summary>
		[Description("Id")]
		[DataFieldAttribute("fin_Id", "bigint", "Id")]
		public long Fin_Id
		{
			get { return _fin_Id;}
			set 
			{ 
				_fin_Id = value;
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

		private DateTime _fin_Date;
		/// <summary>
		///回款日期
		/// </summary>
		[Description("回款日期")]
		[DataFieldAttribute("fin_Date", "datetime", "回款日期")]
		public DateTime Fin_Date
		{
			get { return _fin_Date;}
			set 
			{ 
				_fin_Date = value;
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

		private string _jia_Name;
		/// <summary>
		///甲方(需方)
		/// </summary>
		[Description("甲方(需方)")]
		[DataFieldAttribute("jia_Name", "varchar", "甲方(需方)")]
		public string Jia_Name
		{
			get { return _jia_Name;}
			set 
			{ 
				_jia_Name = value;
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

		private decimal _pay_Cost;
		/// <summary>
		///支付金额
		/// </summary>
		[Description("支付金额")]
		[DataFieldAttribute("pay_Cost", "decimal", "支付金额")]
		public decimal Pay_Cost
		{
			get { return _pay_Cost;}
			set 
			{ 
				_pay_Cost = value;
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

		private string _pay_Way;
		/// <summary>
		///回款类型
		/// </summary>
		[Description("回款类型")]
		[DataFieldAttribute("pay_Way", "varchar", "回款类型")]
		public string Pay_Way
		{
			get { return _pay_Way;}
			set 
			{ 
				_pay_Way = value;
			}
		}

		private string _pay_Account;
		/// <summary>
		///入款账户
		/// </summary>
		[Description("入款账户")]
		[DataFieldAttribute("pay_Account", "varchar", "入款账户")]
		public string Pay_Account
		{
			get { return _pay_Account;}
			set 
			{ 
				_pay_Account = value;
			}
		}

		private string _pay_remark;
		/// <summary>
		///备注
		/// </summary>
		[Description("备注")]
		[DataFieldAttribute("pay_remark", "varchar", "备注")]
		public string Pay_remark
		{
			get { return _pay_remark;}
			set 
			{ 
				_pay_remark = value;
			}
		}

		private string _employ_Code;
		/// <summary>
		///业务员编码
		/// </summary>
		[Description("业务员编码")]
		[DataFieldAttribute("employ_Code", "varchar", "业务员编码")]
		public string Employ_Code
		{
			get { return _employ_Code;}
			set 
			{ 
				_employ_Code = value;
			}
		}

		private string _audit_Code;
		/// <summary>
		///审核人
		/// </summary>
		[Description("审核人")]
		[DataFieldAttribute("audit_Code", "varchar", "审核人")]
		public string Audit_Code
		{
			get { return _audit_Code;}
			set 
			{ 
				_audit_Code = value;
			}
		}

		private DateTime _audit_Date;
		/// <summary>
		///审核日期
		/// </summary>
		[Description("审核日期")]
		[DataFieldAttribute("audit_Date", "datetime", "审核日期")]
		public DateTime Audit_Date
		{
			get { return _audit_Date;}
			set 
			{ 
				_audit_Date = value;
			}
		}

		private int _fin_State;
		/// <summary>
		///回款状态
		/// </summary>
		[Description("回款状态")]
		[DataFieldAttribute("fin_State", "int", "回款状态")]
		public int Fin_State
		{
			get { return _fin_State;}
			set 
			{ 
				_fin_State = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Fin_Id="+this._fin_Id+ ","+"Odr_No="+this._odr_No+ ","+"Fin_Date="+this._fin_Date+ ","+"Odr_Type="+this._odr_Type+ ","+"Jia_Name="+this._jia_Name+ ","+"Odr_Prt_Name="+this._odr_Prt_Name+ ","+"Pay_Cost="+this._pay_Cost+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Pay_Way="+this._pay_Way+ ","+"Pay_Account="+this._pay_Account+ ","+"Pay_remark="+this._pay_remark+ ","+"Employ_Code="+this._employ_Code+ ","+"Audit_Code="+this._audit_Code+ ","+"Audit_Date="+this._audit_Date+ ","+"Fin_State="+this._fin_State+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///Id
		/// </summary>
		public const string Fin_Id="Fin_Id";
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///回款日期
		/// </summary>
		public const string Fin_Date="Fin_Date";
		/// <summary>
		///合同类型
		/// </summary>
		public const string Odr_Type="Odr_Type";
		/// <summary>
		///甲方(需方)
		/// </summary>
		public const string Jia_Name="Jia_Name";
		/// <summary>
		///合同产品名称
		/// </summary>
		public const string Odr_Prt_Name="Odr_Prt_Name";
		/// <summary>
		///支付金额
		/// </summary>
		public const string Pay_Cost="Pay_Cost";
		/// <summary>
		///操作日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///操作人
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///回款类型
		/// </summary>
		public const string Pay_Way="Pay_Way";
		/// <summary>
		///入款账户
		/// </summary>
		public const string Pay_Account="Pay_Account";
		/// <summary>
		///备注
		/// </summary>
		public const string Pay_remark="Pay_remark";
		/// <summary>
		///业务员编码
		/// </summary>
		public const string Employ_Code="Employ_Code";
		/// <summary>
		///审核人
		/// </summary>
		public const string Audit_Code="Audit_Code";
		/// <summary>
		///审核日期
		/// </summary>
		public const string Audit_Date="Audit_Date";
		/// <summary>
		///回款状态
		/// </summary>
		public const string Fin_State="Fin_State";
	}

	}

}
