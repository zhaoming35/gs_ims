using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_place_info","gaoshan_db")]
	[Serializable]
	public class Tb_place_info
	{

		//自动生成属性
		private long _place_Id;
		/// <summary>
		///
		/// </summary>
		[Description("place_Id")]
		[DataFieldAttribute("place_Id", "bigint", "")]
		public long Place_Id
		{
			get { return _place_Id;}
			set 
			{ 
				_place_Id = value;
			}
		}

		private string _place_Name;
		/// <summary>
		///
		/// </summary>
		[Description("place_Name")]
		[DataFieldAttribute("place_Name", "varchar", "")]
		public string Place_Name
		{
			get { return _place_Name;}
			set 
			{ 
				_place_Name = value;
			}
		}

		private long _parent_Id;
		/// <summary>
		///
		/// </summary>
		[Description("parent_Id")]
		[DataFieldAttribute("parent_Id", "bigint", "")]
		public long Parent_Id
		{
			get { return _parent_Id;}
			set 
			{ 
				_parent_Id = value;
			}
		}

		private int _level;
		/// <summary>
		///
		/// </summary>
		[Description("level")]
		[DataFieldAttribute("level", "int", "")]
		public int Level
		{
			get { return _level;}
			set 
			{ 
				_level = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Place_Id="+this._place_Id+ ","+"Place_Name="+this._place_Name+ ","+"Parent_Id="+this._parent_Id+ ","+"Level="+this._level+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Place_Id="Place_Id";
		/// <summary>
		///
		/// </summary>
		public const string Place_Name="Place_Name";
		/// <summary>
		///
		/// </summary>
		public const string Parent_Id="Parent_Id";
		/// <summary>
		///
		/// </summary>
		public const string Level="Level";
	}

	}

}
