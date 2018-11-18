using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_product_info","gaoshan_db")]
	[Serializable]
	public class Tb_product_info
	{

		//自动生成属性
		private long _product_Id;
		/// <summary>
		///产品Id
		/// </summary>
		[Description("产品Id")]
		[DataFieldAttribute("product_Id", "bigint", "产品Id")]
		public long Product_Id
		{
			get { return _product_Id;}
			set 
			{ 
				_product_Id = value;
			}
		}

		private string _product_Name;
		/// <summary>
		///产品名称
		/// </summary>
		[Description("产品名称")]
		[DataFieldAttribute("product_Name", "varchar", "产品名称")]
		public string Product_Name
		{
			get { return _product_Name;}
			set 
			{ 
				_product_Name = value;
			}
		}

		private string _product_Unit;
		/// <summary>
		///产品单位
		/// </summary>
		[Description("产品单位")]
		[DataFieldAttribute("product_Unit", "varchar", "产品单位")]
		public string Product_Unit
		{
			get { return _product_Unit;}
			set 
			{ 
				_product_Unit = value;
			}
		}

		private decimal _seq_No;
		/// <summary>
		///序号
		/// </summary>
		[Description("序号")]
		[DataFieldAttribute("seq_No", "decimal", "序号")]
		public decimal Seq_No
		{
			get { return _seq_No;}
			set 
			{ 
				_seq_No = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Product_Id="+this._product_Id+ ","+"Product_Name="+this._product_Name+ ","+"Product_Unit="+this._product_Unit+ ","+"Seq_No="+this._seq_No+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///产品Id
		/// </summary>
		public const string Product_Id="Product_Id";
		/// <summary>
		///产品名称
		/// </summary>
		public const string Product_Name="Product_Name";
		/// <summary>
		///产品单位
		/// </summary>
		public const string Product_Unit="Product_Unit";
		/// <summary>
		///序号
		/// </summary>
		public const string Seq_No="Seq_No";
	}

	}

}
