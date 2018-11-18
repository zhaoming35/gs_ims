using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_mtl_kind","gaoshan_db")]
	[Serializable]
	public class Tb_mtl_kind
	{

		//自动生成属性
		private string _kind_Code;
		/// <summary>
		///类型编码
		/// </summary>
		[Description("类型编码")]
		[DataFieldAttribute("kind_Code", "varchar", "类型编码")]
		public string Kind_Code
		{
			get { return _kind_Code;}
			set 
			{ 
				_kind_Code = value;
			}
		}

		private string _kind_Name;
		/// <summary>
		///物料类型名称
		/// </summary>
		[Description("物料类型名称")]
		[DataFieldAttribute("kind_Name", "varchar", "物料类型名称")]
		public string Kind_Name
		{
			get { return _kind_Name;}
			set 
			{ 
				_kind_Name = value;
			}
		}

		private int _kind_Level;
		/// <summary>
		///分类级别0,1
		/// </summary>
		[Description("分类级别0,1")]
		[DataFieldAttribute("kind_Level", "int", "分类级别0,1")]
		public int Kind_Level
		{
			get { return _kind_Level;}
			set 
			{ 
				_kind_Level = value;
			}
		}

		private string _kind_Parent;
		/// <summary>
		///父类
		/// </summary>
		[Description("父类")]
		[DataFieldAttribute("kind_Parent", "varchar", "父类")]
		public string Kind_Parent
		{
			get { return _kind_Parent;}
			set 
			{ 
				_kind_Parent = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Kind_Code="+this._kind_Code+ ","+"Kind_Name="+this._kind_Name+ ","+"Kind_Level="+this._kind_Level+ ","+"Kind_Parent="+this._kind_Parent+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///类型编码
		/// </summary>
		public const string Kind_Code="Kind_Code";
		/// <summary>
		///物料类型名称
		/// </summary>
		public const string Kind_Name="Kind_Name";
		/// <summary>
		///分类级别0,1
		/// </summary>
		public const string Kind_Level="Kind_Level";
		/// <summary>
		///父类
		/// </summary>
		public const string Kind_Parent="Kind_Parent";
	}

	}

}
