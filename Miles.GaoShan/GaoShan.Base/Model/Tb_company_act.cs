using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_company_act","gaoshan_db")]
	[Serializable]
	public class Tb_company_act
	{

		//自动生成属性
		private long _act_Id;
		/// <summary>
		///
		/// </summary>
		[Description("act_Id")]
		[DataFieldAttribute("act_Id", "bigint", "")]
		public long Act_Id
		{
			get { return _act_Id;}
			set 
			{ 
				_act_Id = value;
			}
		}

		private string _act_Name;
		/// <summary>
		///
		/// </summary>
		[Description("act_Name")]
		[DataFieldAttribute("act_Name", "nvarchar", "")]
		public string Act_Name
		{
			get { return _act_Name;}
			set 
			{ 
				_act_Name = value;
			}
		}

		private string _act_FaRen;
		/// <summary>
		///
		/// </summary>
		[Description("act_FaRen")]
		[DataFieldAttribute("act_FaRen", "varchar", "")]
		public string Act_FaRen
		{
			get { return _act_FaRen;}
			set 
			{ 
				_act_FaRen = value;
			}
		}

		private string _act_Adress;
		/// <summary>
		///
		/// </summary>
		[Description("act_Adress")]
		[DataFieldAttribute("act_Adress", "varchar", "")]
		public string Act_Adress
		{
			get { return _act_Adress;}
			set 
			{ 
				_act_Adress = value;
			}
		}

		private string _act_Phone;
		/// <summary>
		///
		/// </summary>
		[Description("act_Phone")]
		[DataFieldAttribute("act_Phone", "varchar", "")]
		public string Act_Phone
		{
			get { return _act_Phone;}
			set 
			{ 
				_act_Phone = value;
			}
		}

		private string _pay_Tax_Code;
		/// <summary>
		///
		/// </summary>
		[Description("pay_Tax_Code")]
		[DataFieldAttribute("pay_Tax_Code", "varchar", "")]
		public string Pay_Tax_Code
		{
			get { return _pay_Tax_Code;}
			set 
			{ 
				_pay_Tax_Code = value;
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

		private int _valid_Flag;
		/// <summary>
		///
		/// </summary>
		[Description("valid_Flag")]
		[DataFieldAttribute("valid_Flag", "int", "")]
		public int Valid_Flag
		{
			get { return _valid_Flag;}
			set 
			{ 
				_valid_Flag = value;
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

		private string _define_Name;
		/// <summary>
		///
		/// </summary>
		[Description("define_Name")]
		[DataFieldAttribute("define_Name", "varchar", "")]
		public string Define_Name
		{
			get { return _define_Name;}
			set 
			{ 
				_define_Name = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Act_Id="+this._act_Id+ ","+"Act_Name="+this._act_Name+ ","+"Act_FaRen="+this._act_FaRen+ ","+"Act_Adress="+this._act_Adress+ ","+"Act_Phone="+this._act_Phone+ ","+"Pay_Tax_Code="+this._pay_Tax_Code+ ","+"Define_Code="+this._define_Code+ ","+"Valid_Flag="+this._valid_Flag+ ","+"Remark="+this._remark+ ","+"Define_Name="+this._define_Name+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Act_Id="Act_Id";
		/// <summary>
		///
		/// </summary>
		public const string Act_Name="Act_Name";
		/// <summary>
		///
		/// </summary>
		public const string Act_FaRen="Act_FaRen";
		/// <summary>
		///
		/// </summary>
		public const string Act_Adress="Act_Adress";
		/// <summary>
		///
		/// </summary>
		public const string Act_Phone="Act_Phone";
		/// <summary>
		///
		/// </summary>
		public const string Pay_Tax_Code="Pay_Tax_Code";
		/// <summary>
		///
		/// </summary>
		public const string Define_Code="Define_Code";
		/// <summary>
		///
		/// </summary>
		public const string Valid_Flag="Valid_Flag";
		/// <summary>
		///
		/// </summary>
		public const string Remark="Remark";
		/// <summary>
		///
		/// </summary>
		public const string Define_Name="Define_Name";
	}

	}

}
