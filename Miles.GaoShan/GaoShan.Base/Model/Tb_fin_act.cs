using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_fin_act","gaoshan_db")]
	[Serializable]
	public class Tb_fin_act
	{

		//自动生成属性
		private long _pay_Id;
		/// <summary>
		///
		/// </summary>
		[Description("pay_Id")]
		[DataFieldAttribute("pay_Id", "bigint", "")]
		public long Pay_Id
		{
			get { return _pay_Id;}
			set 
			{ 
				_pay_Id = value;
			}
		}

		private string _pay_Name;
		/// <summary>
		///
		/// </summary>
		[Description("pay_Name")]
		[DataFieldAttribute("pay_Name", "nvarchar", "")]
		public string Pay_Name
		{
			get { return _pay_Name;}
			set 
			{ 
				_pay_Name = value;
			}
		}

		private string _pay_Act_Name;
		/// <summary>
		///
		/// </summary>
		[Description("pay_Act_Name")]
		[DataFieldAttribute("pay_Act_Name", "varchar", "")]
		public string Pay_Act_Name
		{
			get { return _pay_Act_Name;}
			set 
			{ 
				_pay_Act_Name = value;
			}
		}

		private string _pay_Bank_Name;
		/// <summary>
		///
		/// </summary>
		[Description("pay_Bank_Name")]
		[DataFieldAttribute("pay_Bank_Name", "varchar", "")]
		public string Pay_Bank_Name
		{
			get { return _pay_Bank_Name;}
			set 
			{ 
				_pay_Bank_Name = value;
			}
		}

		private string _pay_Act_No;
		/// <summary>
		///
		/// </summary>
		[Description("pay_Act_No")]
		[DataFieldAttribute("pay_Act_No", "varchar", "")]
		public string Pay_Act_No
		{
			get { return _pay_Act_No;}
			set 
			{ 
				_pay_Act_No = value;
			}
		}

		private string _define_Code;
		/// <summary>
		///
		/// </summary>
		[Description("define_Code")]
		[DataFieldAttribute("define_Code", "varchar", "")]
		public string Define_Code
		{
			get { return _define_Code;}
			set 
			{ 
				_define_Code = value;
			}
		}

		private string _remark;
		/// <summary>
		///
		/// </summary>
		[Description("remark")]
		[DataFieldAttribute("remark", "nvarchar", "")]
		public string Remark
		{
			get { return _remark;}
			set 
			{ 
				_remark = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Pay_Id="+this._pay_Id+ ","+"Pay_Name="+this._pay_Name+ ","+"Pay_Act_Name="+this._pay_Act_Name+ ","+"Pay_Bank_Name="+this._pay_Bank_Name+ ","+"Pay_Act_No="+this._pay_Act_No+ ","+"Define_Code="+this._define_Code+ ","+"Remark="+this._remark+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Pay_Id="Pay_Id";
		/// <summary>
		///
		/// </summary>
		public const string Pay_Name="Pay_Name";
		/// <summary>
		///
		/// </summary>
		public const string Pay_Act_Name="Pay_Act_Name";
		/// <summary>
		///
		/// </summary>
		public const string Pay_Bank_Name="Pay_Bank_Name";
		/// <summary>
		///
		/// </summary>
		public const string Pay_Act_No="Pay_Act_No";
		/// <summary>
		///
		/// </summary>
		public const string Define_Code="Define_Code";
		/// <summary>
		///
		/// </summary>
		public const string Remark="Remark";
	}

	}

}
