using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_xls_doc","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_xls_doc
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

		private string _tmp_Name;
		/// <summary>
		///
		/// </summary>
		[Description("tmp_Name")]
		[DataFieldAttribute("tmp_Name", "varchar", "")]
		public string Tmp_Name
		{
			get { return _tmp_Name;}
			set 
			{ 
				_tmp_Name = value;
			}
		}

		private string _tmp_Explain;
		/// <summary>
		///
		/// </summary>
		[Description("tmp_Explain")]
		[DataFieldAttribute("tmp_Explain", "varchar", "")]
		public string Tmp_Explain
		{
			get { return _tmp_Explain;}
			set 
			{ 
				_tmp_Explain = value;
			}
		}

		private byte[] _tmp_Body;
		/// <summary>
		///模板正文
		/// </summary>
		[Description("模板正文")]
		[DataFieldAttribute("tmp_Body", "image", "模板正文")]
		public byte[] Tmp_Body
		{
			get { return _tmp_Body;}
			set 
			{ 
				_tmp_Body = value;
			}
		}

		private string _input_Cols;
		/// <summary>
		///
		/// </summary>
		[Description("input_Cols")]
		[DataFieldAttribute("input_Cols", "varchar", "")]
		public string Input_Cols
		{
			get { return _input_Cols;}
			set 
			{ 
				_input_Cols = value;
			}
		}

		private decimal _row_Count;
		/// <summary>
		///
		/// </summary>
		[Description("row_Count")]
		[DataFieldAttribute("row_Count", "decimal", "")]
		public decimal Row_Count
		{
			get { return _row_Count;}
			set 
			{ 
				_row_Count = value;
			}
		}

		private decimal _column_Count;
		/// <summary>
		///
		/// </summary>
		[Description("column_Count")]
		[DataFieldAttribute("column_Count", "decimal", "")]
		public decimal Column_Count
		{
			get { return _column_Count;}
			set 
			{ 
				_column_Count = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Tmp_Id="+this._tmp_Id+ ","+"Tmp_Name="+this._tmp_Name+ ","+"Tmp_Explain="+this._tmp_Explain+ ","+"Tmp_Body="+this._tmp_Body+ ","+"Input_Cols="+this._input_Cols+ ","+"Row_Count="+this._row_Count+ ","+"Column_Count="+this._column_Count+"]";
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
		public const string Tmp_Name="Tmp_Name";
		/// <summary>
		///
		/// </summary>
		public const string Tmp_Explain="Tmp_Explain";
		/// <summary>
		///模板正文
		/// </summary>
		public const string Tmp_Body="Tmp_Body";
		/// <summary>
		///
		/// </summary>
		public const string Input_Cols="Input_Cols";
		/// <summary>
		///
		/// </summary>
		public const string Row_Count="Row_Count";
		/// <summary>
		///
		/// </summary>
		public const string Column_Count="Column_Count";
	}

	}

}
