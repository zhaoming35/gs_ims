using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_store_out_item","gaoshan_db")]
	[Serializable]
	public class Tb_store_out_item
	{

		//自动生成属性
		private long _storeOut_Id;
		/// <summary>
		///配套表主键
		/// </summary>
		[Description("配套表主键")]
		[DataFieldAttribute("storeOut_Id", "bigint", "配套表主键")]
		public long StoreOut_Id
		{
			get { return _storeOut_Id;}
			set 
			{ 
				_storeOut_Id = value;
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

		private string _mtl_Code;
		/// <summary>
		///
		/// </summary>
		[Description("mtl_Code")]
		[DataFieldAttribute("mtl_Code", "varchar", "")]
		public string Mtl_Code
		{
			get { return _mtl_Code;}
			set 
			{ 
				_mtl_Code = value;
			}
		}

		private decimal _mtl_Qty;
		/// <summary>
		///
		/// </summary>
		[Description("mtl_Qty")]
		[DataFieldAttribute("mtl_Qty", "decimal", "")]
		public decimal Mtl_Qty
		{
			get { return _mtl_Qty;}
			set 
			{ 
				_mtl_Qty = value;
			}
		}

		private string _store_Room;
		/// <summary>
		///仓库
		/// </summary>
		[Description("仓库")]
		[DataFieldAttribute("store_Room", "varchar", "仓库")]
		public string Store_Room
		{
			get { return _store_Room;}
			set 
			{ 
				_store_Room = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"StoreOut_Id="+this._storeOut_Id+ ","+"Item_Id="+this._item_Id+ ","+"Mtl_Code="+this._mtl_Code+ ","+"Mtl_Qty="+this._mtl_Qty+ ","+"Store_Room="+this._store_Room+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///配套表主键
		/// </summary>
		public const string StoreOut_Id="StoreOut_Id";
		/// <summary>
		///
		/// </summary>
		public const string Item_Id="Item_Id";
		/// <summary>
		///
		/// </summary>
		public const string Mtl_Code="Mtl_Code";
		/// <summary>
		///
		/// </summary>
		public const string Mtl_Qty="Mtl_Qty";
		/// <summary>
		///仓库
		/// </summary>
		public const string Store_Room="Store_Room";
	}

	}

}
