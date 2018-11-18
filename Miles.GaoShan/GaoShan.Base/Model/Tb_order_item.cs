using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_order_item","gaoshan_db")]
	[Serializable]
	public class Tb_order_item
	{

		//自动生成属性
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

		private string _odr_No;
		/// <summary>
		///
		/// </summary>
		[Description("odr_No")]
		[DataFieldAttribute("odr_No", "varchar", "")]
		public string Odr_No
		{
			get { return _odr_No;}
			set 
			{ 
				_odr_No = value;
			}
		}

		private int _item_Seq;
		/// <summary>
		///
		/// </summary>
		[Description("item_Seq")]
		[DataFieldAttribute("item_Seq", "int", "")]
		public int Item_Seq
		{
			get { return _item_Seq;}
			set 
			{ 
				_item_Seq = value;
			}
		}

		private string _item_Spec;
		/// <summary>
		///
		/// </summary>
		[Description("item_Spec")]
		[DataFieldAttribute("item_Spec", "ntext", "")]
		public string Item_Spec
		{
			get { return _item_Spec;}
			set 
			{ 
				_item_Spec = value;
			}
		}

		private string _item_Type;
		/// <summary>
		///
		/// </summary>
		[Description("item_Type")]
		[DataFieldAttribute("item_Type", "varchar", "")]
		public string Item_Type
		{
			get { return _item_Type;}
			set 
			{ 
				_item_Type = value;
			}
		}

		private string _product_Name;
		/// <summary>
		///
		/// </summary>
		[Description("product_Name")]
		[DataFieldAttribute("product_Name", "varchar", "")]
		public string Product_Name
		{
			get { return _product_Name;}
			set 
			{ 
				_product_Name = value;
			}
		}

		private decimal _product_Count;
		/// <summary>
		///
		/// </summary>
		[Description("product_Count")]
		[DataFieldAttribute("product_Count", "decimal", "")]
		public decimal Product_Count
		{
			get { return _product_Count;}
			set 
			{ 
				_product_Count = value;
			}
		}

		private string _product_Unit;
		/// <summary>
		///
		/// </summary>
		[Description("product_Unit")]
		[DataFieldAttribute("product_Unit", "varchar", "")]
		public string Product_Unit
		{
			get { return _product_Unit;}
			set 
			{ 
				_product_Unit = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Item_Id="+this._item_Id+ ","+"Odr_No="+this._odr_No+ ","+"Item_Seq="+this._item_Seq+ ","+"Item_Spec="+this._item_Spec+ ","+"Item_Type="+this._item_Type+ ","+"Product_Name="+this._product_Name+ ","+"Product_Count="+this._product_Count+ ","+"Product_Unit="+this._product_Unit+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Item_Id="Item_Id";
		/// <summary>
		///
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///
		/// </summary>
		public const string Item_Seq="Item_Seq";
		/// <summary>
		///
		/// </summary>
		public const string Item_Spec="Item_Spec";
		/// <summary>
		///
		/// </summary>
		public const string Item_Type="Item_Type";
		/// <summary>
		///
		/// </summary>
		public const string Product_Name="Product_Name";
		/// <summary>
		///
		/// </summary>
		public const string Product_Count="Product_Count";
		/// <summary>
		///
		/// </summary>
		public const string Product_Unit="Product_Unit";
	}

	}

}
