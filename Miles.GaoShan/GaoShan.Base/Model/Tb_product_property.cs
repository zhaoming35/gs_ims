using System;
using System.Collections.Generic;
using System.Text;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_product_property","gaoshan_db")]
	[Serializable]
	public class Tb_product_property
	{

		//自动生成属性
		private long _product_Id;
		/// <summary>
		///产品编码
		/// </summary>
		[DataFieldAttribute("product_Id", "bigint", "产品编码")]
		public long Product_Id
		{
			get { return _product_Id;}
			set 
			{ 
				_product_Id = value;
			}
		}

		private string _property_Name;
		/// <summary>
		///属性名称
		/// </summary>
		[DataFieldAttribute("property_Name", "varchar", "属性名称")]
		public string Property_Name
		{
			get { return _property_Name;}
			set 
			{ 
				_property_Name = value;
			}
		}

		private long _property_Id;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("property_Id", "bigint", "")]
		public long Property_Id
		{
			get { return _property_Id;}
			set 
			{ 
				_property_Id = value;
			}
		}

		private decimal _property_Seq;
		/// <summary>
		///显示顺序
		/// </summary>
		[DataFieldAttribute("property_Seq", "decimal", "显示顺序")]
		public decimal Property_Seq
		{
			get { return _property_Seq;}
			set 
			{ 
				_property_Seq = value;
			}
		}

		private string _property_Unit;
		/// <summary>
		///属性单位
		/// </summary>
		[DataFieldAttribute("property_Unit", "varchar", "属性单位")]
		public string Property_Unit
		{
			get { return _property_Unit;}
			set 
			{ 
				_property_Unit = value;
			}
		}

		private int _is_Spec;
		/// <summary>
		///是否是规格信息
		/// </summary>
		[DataFieldAttribute("is_Spec", "int", "是否是规格信息")]
		public int Is_Spec
		{
			get { return _is_Spec;}
			set 
			{ 
				_is_Spec = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Product_Id="+this._product_Id+ ","+"Property_Name="+this._property_Name+ ","+"Property_Id="+this._property_Id+ ","+"Property_Seq="+this._property_Seq+ ","+"Property_Unit="+this._property_Unit+ ","+"Is_Spec="+this._is_Spec+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///产品编码
		/// </summary>
		public const string Product_Id="Product_Id";
		/// <summary>
		///属性名称
		/// </summary>
		public const string Property_Name="Property_Name";
		/// <summary>
		///
		/// </summary>
		public const string Property_Id="Property_Id";
		/// <summary>
		///显示顺序
		/// </summary>
		public const string Property_Seq="Property_Seq";
		/// <summary>
		///属性单位
		/// </summary>
		public const string Property_Unit="Property_Unit";
		/// <summary>
		///是否是规格信息
		/// </summary>
		public const string Is_Spec="Is_Spec";
	}

	}

}
