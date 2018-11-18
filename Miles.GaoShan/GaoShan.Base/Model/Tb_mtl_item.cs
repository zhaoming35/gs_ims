using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_mtl_item","gaoshan_db")]
	[Serializable]
	public class Tb_mtl_item
	{

		//自动生成属性
		private string _mtl_Code;
		/// <summary>
		///物料编码
		/// </summary>
		[Description("物料编码")]
		[DataFieldAttribute("mtl_Code", "varchar", "物料编码")]
		public string Mtl_Code
		{
			get { return _mtl_Code;}
			set 
			{ 
				_mtl_Code = value;
			}
		}

		private string _mtl_Name;
		/// <summary>
		///物料名称
		/// </summary>
		[Description("物料名称")]
		[DataFieldAttribute("mtl_Name", "varchar", "物料名称")]
		public string Mtl_Name
		{
			get { return _mtl_Name;}
			set 
			{ 
				_mtl_Name = value;
			}
		}

		private string _mtl_Spec;
		/// <summary>
		///物料规格
		/// </summary>
		[Description("物料规格")]
		[DataFieldAttribute("mtl_Spec", "varchar", "物料规格")]
		public string Mtl_Spec
		{
			get { return _mtl_Spec;}
			set 
			{ 
				_mtl_Spec = value;
			}
		}

		private string _mtl_Unit;
		/// <summary>
		///物料单位
		/// </summary>
		[Description("物料单位")]
		[DataFieldAttribute("mtl_Unit", "varchar", "物料单位")]
		public string Mtl_Unit
		{
			get { return _mtl_Unit;}
			set 
			{ 
				_mtl_Unit = value;
			}
		}

		private string _mtl_Extend;
		/// <summary>
		///扩展
		/// </summary>
		[Description("扩展")]
		[DataFieldAttribute("mtl_Extend", "varchar", "扩展")]
		public string Mtl_Extend
		{
			get { return _mtl_Extend;}
			set 
			{ 
				_mtl_Extend = value;
			}
		}

		private string _kind_Code;
		/// <summary>
		///分类编码
		/// </summary>
		[Description("分类编码")]
		[DataFieldAttribute("kind_Code", "varchar", "分类编码")]
		public string Kind_Code
		{
			get { return _kind_Code;}
			set 
			{ 
				_kind_Code = value;
			}
		}

		private decimal _mtl_Weight;
		/// <summary>
		///单重
		/// </summary>
		[Description("单重")]
		[DataFieldAttribute("mtl_Weight", "decimal", "单重")]
		public decimal Mtl_Weight
		{
			get { return _mtl_Weight;}
			set 
			{ 
				_mtl_Weight = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Mtl_Code="+this._mtl_Code+ ","+"Mtl_Name="+this._mtl_Name+ ","+"Mtl_Spec="+this._mtl_Spec+ ","+"Mtl_Unit="+this._mtl_Unit+ ","+"Mtl_Extend="+this._mtl_Extend+ ","+"Kind_Code="+this._kind_Code+ ","+"Mtl_Weight="+this._mtl_Weight+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///物料编码
		/// </summary>
		public const string Mtl_Code="Mtl_Code";
		/// <summary>
		///物料名称
		/// </summary>
		public const string Mtl_Name="Mtl_Name";
		/// <summary>
		///物料规格
		/// </summary>
		public const string Mtl_Spec="Mtl_Spec";
		/// <summary>
		///物料单位
		/// </summary>
		public const string Mtl_Unit="Mtl_Unit";
		/// <summary>
		///扩展
		/// </summary>
		public const string Mtl_Extend="Mtl_Extend";
		/// <summary>
		///分类编码
		/// </summary>
		public const string Kind_Code="Kind_Code";
		/// <summary>
		///单重
		/// </summary>
		public const string Mtl_Weight="Mtl_Weight";
	}

	}

}
