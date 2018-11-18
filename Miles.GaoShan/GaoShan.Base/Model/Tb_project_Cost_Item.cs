using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_project_Cost_Item","gaoshan_db")]
	[Serializable]
	public class Tb_project_Cost_Item
	{

		//自动生成属性
		private long _linkBill_Id;
		/// <summary>
		///联络单主键
		/// </summary>
		[Description("联络单主键")]
		[DataFieldAttribute("linkBill_Id", "bigint", "联络单主键")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

		private long _item_Id;
		/// <summary>
		///Id
		/// </summary>
		[Description("Id")]
		[DataFieldAttribute("item_Id", "bigint", "Id")]
		public long Item_Id
		{
			get { return _item_Id;}
			set 
			{ 
				_item_Id = value;
			}
		}

		private string _item_Name;
		/// <summary>
		///支出项目名称
		/// </summary>
		[Description("支出项目名称")]
		[DataFieldAttribute("item_Name", "varchar", "支出项目名称")]
		public string Item_Name
		{
			get { return _item_Name;}
			set 
			{ 
				_item_Name = value;
			}
		}

		private string _item_Unit;
		/// <summary>
		///单位
		/// </summary>
		[Description("单位")]
		[DataFieldAttribute("item_Unit", "varchar", "单位")]
		public string Item_Unit
		{
			get { return _item_Unit;}
			set 
			{ 
				_item_Unit = value;
			}
		}

		private decimal _item_Qty;
		/// <summary>
		///数量
		/// </summary>
		[Description("数量")]
		[DataFieldAttribute("item_Qty", "decimal", "数量")]
		public decimal Item_Qty
		{
			get { return _item_Qty;}
			set 
			{ 
				_item_Qty = value;
			}
		}

		private decimal _item_Price;
		/// <summary>
		///单价
		/// </summary>
		[Description("单价")]
		[DataFieldAttribute("item_Price", "decimal", "单价")]
		public decimal Item_Price
		{
			get { return _item_Price;}
			set 
			{ 
				_item_Price = value;
			}
		}

		private string _item_Link;
		/// <summary>
		///联系方式
		/// </summary>
		[Description("联系方式")]
		[DataFieldAttribute("item_Link", "varchar", "联系方式")]
		public string Item_Link
		{
			get { return _item_Link;}
			set 
			{ 
				_item_Link = value;
			}
		}

		private string _remark;
		/// <summary>
		///备注
		/// </summary>
		[Description("备注")]
		[DataFieldAttribute("remark", "varchar", "备注")]
		public string Remark
		{
			get { return _remark;}
			set 
			{ 
				_remark = value;
			}
		}

		private int _is_return_visit;
		/// <summary>
		///是否回访
		/// </summary>
		[Description("是否回访")]
		[DataFieldAttribute("is_return_visit", "int", "是否回访")]
		public int Is_return_visit
		{
			get { return _is_return_visit;}
			set 
			{ 
				_is_return_visit = value;
			}
		}

		private int _item_Value;
		/// <summary>
		///费用项目值
		/// </summary>
		[Description("费用项目值")]
		[DataFieldAttribute("item_Value", "int", "费用项目值")]
		public int Item_Value
		{
			get { return _item_Value;}
			set 
			{ 
				_item_Value = value;
			}
		}

		private DateTime _item_Date;
		/// <summary>
		///费用发生时间
		/// </summary>
		[Description("费用发生时间")]
		[DataFieldAttribute("item_Date", "datetime", "费用发生时间")]
		public DateTime Item_Date
		{
			get { return _item_Date;}
			set 
			{ 
				_item_Date = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"LinkBill_Id="+this._linkBill_Id+ ","+"Item_Id="+this._item_Id+ ","+"Item_Name="+this._item_Name+ ","+"Item_Unit="+this._item_Unit+ ","+"Item_Qty="+this._item_Qty+ ","+"Item_Price="+this._item_Price+ ","+"Item_Link="+this._item_Link+ ","+"Remark="+this._remark+ ","+"Is_return_visit="+this._is_return_visit+ ","+"Item_Value="+this._item_Value+ ","+"Item_Date="+this._item_Date+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///联络单主键
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///Id
		/// </summary>
		public const string Item_Id="Item_Id";
		/// <summary>
		///支出项目名称
		/// </summary>
		public const string Item_Name="Item_Name";
		/// <summary>
		///单位
		/// </summary>
		public const string Item_Unit="Item_Unit";
		/// <summary>
		///数量
		/// </summary>
		public const string Item_Qty="Item_Qty";
		/// <summary>
		///单价
		/// </summary>
		public const string Item_Price="Item_Price";
		/// <summary>
		///联系方式
		/// </summary>
		public const string Item_Link="Item_Link";
		/// <summary>
		///备注
		/// </summary>
		public const string Remark="Remark";
		/// <summary>
		///是否回访
		/// </summary>
		public const string Is_return_visit="Is_return_visit";
		/// <summary>
		///费用项目值
		/// </summary>
		public const string Item_Value="Item_Value";
		/// <summary>
		///费用发生时间
		/// </summary>
		public const string Item_Date="Item_Date";
	}

	}

}
