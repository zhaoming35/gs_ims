using System;
using System.Collections.Generic;
using System.Text;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_info","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_info
	{

		//自动生成属性
		private long _tmp_Id;
		/// <summary>
		///
		/// </summary>
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
		[DataFieldAttribute("tmp_Name", "varchar", "")]
		public string Tmp_Name
		{
			get { return _tmp_Name;}
			set 
			{ 
				_tmp_Name = value;
			}
		}

		private int _order_Type;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("order_Type", "int", "")]
		public int Order_Type
		{
			get { return _order_Type;}
			set 
			{ 
				_order_Type = value;
			}
		}

		private string _tmp_Explain;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("tmp_Explain", "varchar", "")]
		public string Tmp_Explain
		{
			get { return _tmp_Explain;}
			set 
			{ 
				_tmp_Explain = value;
			}
		}

		private decimal _item_Table_Seq;
		/// <summary>
		///产品表格在全局中的位置
		/// </summary>
		[DataFieldAttribute("item_Table_Seq", "decimal", "产品表格在全局中的位置")]
		public decimal Item_Table_Seq
		{
			get { return _item_Table_Seq;}
			set 
			{ 
				_item_Table_Seq = value;
			}
		}

		private decimal _item_Clause_Seq;
		/// <summary>
		///条款模板部分所在位置
		/// </summary>
		[DataFieldAttribute("item_Clause_Seq", "decimal", "条款模板部分所在位置")]
		public decimal Item_Clause_Seq
		{
			get { return _item_Clause_Seq;}
			set 
			{ 
				_item_Clause_Seq = value;
			}
		}

		private decimal _item_Pay_Seq;
		/// <summary>
		///付款方式在模板中的序号
		/// </summary>
		[DataFieldAttribute("item_Pay_Seq", "decimal", "付款方式在模板中的序号")]
		public decimal Item_Pay_Seq
		{
			get { return _item_Pay_Seq;}
			set 
			{ 
				_item_Pay_Seq = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Tmp_Id="+this._tmp_Id+ ","+"Tmp_Name="+this._tmp_Name+ ","+"Order_Type="+this._order_Type+ ","+"Tmp_Explain="+this._tmp_Explain+ ","+"Item_Table_Seq="+this._item_Table_Seq+ ","+"Item_Clause_Seq="+this._item_Clause_Seq+ ","+"Item_Pay_Seq="+this._item_Pay_Seq+"]";
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
		public const string Order_Type="Order_Type";
		/// <summary>
		///
		/// </summary>
		public const string Tmp_Explain="Tmp_Explain";
		/// <summary>
		///产品表格在全局中的位置
		/// </summary>
		public const string Item_Table_Seq="Item_Table_Seq";
		/// <summary>
		///条款模板部分所在位置
		/// </summary>
		public const string Item_Clause_Seq="Item_Clause_Seq";
		/// <summary>
		///付款方式在模板中的序号
		/// </summary>
		public const string Item_Pay_Seq="Item_Pay_Seq";
	}

	}

}
