using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_matchTb_item","gaoshan_db")]
	[Serializable]
	public class Tb_matchTb_item
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

		private long _item_Id;
		/// <summary>
		///
		/// </summary>
		[Description("item_Id")]
		[DataFieldAttribute("item_Id", "bigint", "")]
		public long Item_Id
		{
			get { return _item_Id;}
			set 
			{ 
				_item_Id = value;
			}
		}

		private long _matchTb_Id;
		/// <summary>
		///
		/// </summary>
		[Description("matchTb_Id")]
		[DataFieldAttribute("matchTb_Id", "bigint", "")]
		public long MatchTb_Id
		{
			get { return _matchTb_Id;}
			set 
			{ 
				_matchTb_Id = value;
			}
		}

		private decimal _item_Count;
		/// <summary>
		///
		/// </summary>
		[Description("item_Count")]
		[DataFieldAttribute("item_Count", "decimal", "")]
		public decimal Item_Count
		{
			get { return _item_Count;}
			set 
			{ 
				_item_Count = value;
			}
		}

		private string _group_Name;
		/// <summary>
		///
		/// </summary>
		[Description("group_Name")]
		[DataFieldAttribute("group_Name", "varchar", "")]
		public string Group_Name
		{
			get { return _group_Name;}
			set 
			{ 
				_group_Name = value;
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

		private string _kind_Name;
		/// <summary>
		///分类名称
		/// </summary>
		[Description("分类名称")]
		[DataFieldAttribute("kind_Name", "varchar", "分类名称")]
		public string Kind_Name
		{
			get { return _kind_Name;}
			set 
			{ 
				_kind_Name = value;
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
			return "["+"Mtl_Code="+this._mtl_Code+ ","+"Item_Id="+this._item_Id+ ","+"MatchTb_Id="+this._matchTb_Id+ ","+"Item_Count="+this._item_Count+ ","+"Group_Name="+this._group_Name+ ","+"Mtl_Name="+this._mtl_Name+ ","+"Mtl_Spec="+this._mtl_Spec+ ","+"Mtl_Unit="+this._mtl_Unit+ ","+"Kind_Name="+this._kind_Name+ ","+"Mtl_Weight="+this._mtl_Weight+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///物料编码
		/// </summary>
		public const string Mtl_Code="Mtl_Code";
		/// <summary>
		///
		/// </summary>
		public const string Item_Id="Item_Id";
		/// <summary>
		///
		/// </summary>
		public const string MatchTb_Id="MatchTb_Id";
		/// <summary>
		///
		/// </summary>
		public const string Item_Count="Item_Count";
		/// <summary>
		///
		/// </summary>
		public const string Group_Name="Group_Name";
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
		///分类名称
		/// </summary>
		public const string Kind_Name="Kind_Name";
		/// <summary>
		///单重
		/// </summary>
		public const string Mtl_Weight="Mtl_Weight";
	}

	}

}
