using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_fin_order_item","gaoshan_db")]
	[Serializable]
	public class Tb_fin_order_item
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

		private string _item_Name;
		/// <summary>
		///
		/// </summary>
		[Description("item_Name")]
		[DataFieldAttribute("item_Name", "varchar", "")]
		public string Item_Name
		{
			get { return _item_Name;}
			set 
			{ 
				_item_Name = value;
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

		private string _item_Material;
		/// <summary>
		///
		/// </summary>
		[Description("item_Material")]
		[DataFieldAttribute("item_Material", "varchar", "")]
		public string Item_Material
		{
			get { return _item_Material;}
			set 
			{ 
				_item_Material = value;
			}
		}

		private decimal _item_Price;
		/// <summary>
		///
		/// </summary>
		[Description("item_Price")]
		[DataFieldAttribute("item_Price", "decimal", "")]
		public decimal Item_Price
		{
			get { return _item_Price;}
			set 
			{ 
				_item_Price = value;
			}
		}

		private string _remark;
		/// <summary>
		///
		/// </summary>
		[Description("remark")]
		[DataFieldAttribute("remark", "varchar", "")]
		public string Remark
		{
			get { return _remark;}
			set 
			{ 
				_remark = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Item_Id="+this._item_Id+ ","+"Odr_No="+this._odr_No+ ","+"Item_Seq="+this._item_Seq+ ","+"Item_Spec="+this._item_Spec+ ","+"Item_Type="+this._item_Type+ ","+"Item_Name="+this._item_Name+ ","+"Item_Count="+this._item_Count+ ","+"Item_Material="+this._item_Material+ ","+"Item_Price="+this._item_Price+ ","+"Remark="+this._remark+"]";
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
		public const string Item_Name="Item_Name";
		/// <summary>
		///
		/// </summary>
		public const string Item_Count="Item_Count";
		/// <summary>
		///
		/// </summary>
		public const string Item_Material="Item_Material";
		/// <summary>
		///
		/// </summary>
		public const string Item_Price="Item_Price";
		/// <summary>
		///
		/// </summary>
		public const string Remark="Remark";
	}

	}

}
