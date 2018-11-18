using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_xls_var","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_xls_var
	{

		//自动生成属性
		private long _tmp_Id;
		/// <summary>
		///
		/// </summary>
		[Description("tmp_Id")]
		[DataFieldAttribute("tmp_Id", "bigint", "")]
		public long Tmp_Id
		{
			get { return _tmp_Id;}
			set 
			{ 
				_tmp_Id = value;
			}
		}

		private string _var_Text;
		/// <summary>
		///
		/// </summary>
		[Description("var_Text")]
		[DataFieldAttribute("var_Text", "varchar", "")]
		public string Var_Text
		{
			get { return _var_Text;}
			set 
			{ 
				_var_Text = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Tmp_Id="+this._tmp_Id+ ","+"Var_Text="+this._var_Text+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Tmp_Id="Tmp_Id";
		/// <summary>
		///
		/// </summary>
		public const string Var_Text="Var_Text";
	}

	}

}
