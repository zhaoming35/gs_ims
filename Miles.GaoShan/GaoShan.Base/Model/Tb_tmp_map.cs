using System;
using System.Collections.Generic;
using System.Text;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_map","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_map
	{

		//自动生成属性
		private string _var_Name;
		/// <summary>
		///变量名
		/// </summary>
		[DataFieldAttribute("var_Name", "varchar", "变量名")]
		public string Var_Name
		{
			get { return _var_Name;}
			set 
			{ 
				_var_Name = value;
			}
		}

		private long _tmp_Id;
		/// <summary>
		///模板Id
		/// </summary>
		[DataFieldAttribute("tmp_Id", "bigint", "模板Id")]
		public long Tmp_Id
		{
			get { return _tmp_Id;}
			set 
			{ 
				_tmp_Id = value;
			}
		}

		private string _var_Explain;
		/// <summary>
		///变量说明
		/// </summary>
		[DataFieldAttribute("var_Explain", "varchar", "变量说明")]
		public string Var_Explain
		{
			get { return _var_Explain;}
			set 
			{ 
				_var_Explain = value;
			}
		}

		private string _var_Text;
		/// <summary>
		///变量具体形式
		/// </summary>
		[DataFieldAttribute("var_Text", "varchar", "变量具体形式")]
		public string Var_Text
		{
			get { return _var_Text;}
			set 
			{ 
				_var_Text = value;
			}
		}

		private string _field_Format;
		/// <summary>
		///绑定数据格式
		/// </summary>
		[DataFieldAttribute("field_Format", "varchar", "绑定数据格式")]
		public string Field_Format
		{
			get { return _field_Format;}
			set 
			{ 
				_field_Format = value;
			}
		}

		private string _field_Name;
		/// <summary>
		///数据库字段名称
		/// </summary>
		[DataFieldAttribute("field_Name", "varchar", "数据库字段名称")]
		public string Field_Name
		{
			get { return _field_Name;}
			set 
			{ 
				_field_Name = value;
			}
		}

		private string _field_Note;
		/// <summary>
		///数据字段说明
		/// </summary>
		[DataFieldAttribute("field_Note", "varchar", "数据字段说明")]
		public string Field_Note
		{
			get { return _field_Note;}
			set 
			{ 
				_field_Note = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Var_Name="+this._var_Name+ ","+"Tmp_Id="+this._tmp_Id+ ","+"Var_Explain="+this._var_Explain+ ","+"Var_Text="+this._var_Text+ ","+"Field_Format="+this._field_Format+ ","+"Field_Name="+this._field_Name+ ","+"Field_Note="+this._field_Note+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///变量名
		/// </summary>
		public const string Var_Name="Var_Name";
		/// <summary>
		///模板Id
		/// </summary>
		public const string Tmp_Id="Tmp_Id";
		/// <summary>
		///变量说明
		/// </summary>
		public const string Var_Explain="Var_Explain";
		/// <summary>
		///变量具体形式
		/// </summary>
		public const string Var_Text="Var_Text";
		/// <summary>
		///绑定数据格式
		/// </summary>
		public const string Field_Format="Field_Format";
		/// <summary>
		///数据库字段名称
		/// </summary>
		public const string Field_Name="Field_Name";
		/// <summary>
		///数据字段说明
		/// </summary>
		public const string Field_Note="Field_Note";
	}

	}

}
