using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_xls","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_xls
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

		private decimal _row_Count;
		/// <summary>
		///行最大数量
		/// </summary>
		[Description("行最大数量")]
		[DataFieldAttribute("row_Count", "decimal", "行最大数量")]
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
		///列最大数量
		/// </summary>
		[Description("列最大数量")]
		[DataFieldAttribute("column_Count", "decimal", "列最大数量")]
		public decimal Column_Count
		{
			get { return _column_Count;}
			set 
			{ 
				_column_Count = value;
			}
		}

		private decimal _item_Start_Row;
		/// <summary>
		///插入动态行的位置
		/// </summary>
		[Description("插入动态行的位置")]
		[DataFieldAttribute("item_Start_Row", "decimal", "插入动态行的位置")]
		public decimal Item_Start_Row
		{
			get { return _item_Start_Row;}
			set 
			{ 
				_item_Start_Row = value;
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

		private string _source_Type;
		/// <summary>
		///
		/// </summary>
		[Description("source_Type")]
		[DataFieldAttribute("source_Type", "varchar", "")]
		public string Source_Type
		{
			get { return _source_Type;}
			set 
			{ 
				_source_Type = value;
			}
		}

		private decimal _item_Row_Count;
		/// <summary>
		///动态项目占行数
		/// </summary>
		[Description("动态项目占行数")]
		[DataFieldAttribute("item_Row_Count", "decimal", "动态项目占行数")]
		public decimal Item_Row_Count
		{
			get { return _item_Row_Count;}
			set 
			{ 
				_item_Row_Count = value;
			}
		}

		private decimal _item_Start_Column;
		/// <summary>
		///动态数据起始列
		/// </summary>
		[Description("动态数据起始列")]
		[DataFieldAttribute("item_Start_Column", "decimal", "动态数据起始列")]
		public decimal Item_Start_Column
		{
			get { return _item_Start_Column;}
			set 
			{ 
				_item_Start_Column = value;
			}
		}

		private decimal _item_Column_Count;
		/// <summary>
		///动态项目占据列数
		/// </summary>
		[Description("动态项目占据列数")]
		[DataFieldAttribute("item_Column_Count", "decimal", "动态项目占据列数")]
		public decimal Item_Column_Count
		{
			get { return _item_Column_Count;}
			set 
			{ 
				_item_Column_Count = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Tmp_Id="+this._tmp_Id+ ","+"Tmp_Name="+this._tmp_Name+ ","+"Tmp_Explain="+this._tmp_Explain+ ","+"Row_Count="+this._row_Count+ ","+"Column_Count="+this._column_Count+ ","+"Item_Start_Row="+this._item_Start_Row+ ","+"Tmp_Body="+this._tmp_Body+ ","+"Source_Type="+this._source_Type+ ","+"Item_Row_Count="+this._item_Row_Count+ ","+"Item_Start_Column="+this._item_Start_Column+ ","+"Item_Column_Count="+this._item_Column_Count+"]";
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
		///行最大数量
		/// </summary>
		public const string Row_Count="Row_Count";
		/// <summary>
		///列最大数量
		/// </summary>
		public const string Column_Count="Column_Count";
		/// <summary>
		///插入动态行的位置
		/// </summary>
		public const string Item_Start_Row="Item_Start_Row";
		/// <summary>
		///模板正文
		/// </summary>
		public const string Tmp_Body="Tmp_Body";
		/// <summary>
		///
		/// </summary>
		public const string Source_Type="Source_Type";
		/// <summary>
		///动态项目占行数
		/// </summary>
		public const string Item_Row_Count="Item_Row_Count";
		/// <summary>
		///动态数据起始列
		/// </summary>
		public const string Item_Start_Column="Item_Start_Column";
		/// <summary>
		///动态项目占据列数
		/// </summary>
		public const string Item_Column_Count="Item_Column_Count";
	}

	}

}
