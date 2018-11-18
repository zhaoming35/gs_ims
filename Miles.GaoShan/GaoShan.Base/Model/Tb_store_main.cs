using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_store_main","gaoshan_db")]
	[Serializable]
	public class Tb_store_main
	{

		//自动生成属性
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

		private string _store_Room;
		/// <summary>
		///
		/// </summary>
		[Description("store_Room")]
		[DataFieldAttribute("store_Room", "varchar", "")]
		public string Store_Room
		{
			get { return _store_Room;}
			set 
			{ 
				_store_Room = value;
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

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Mtl_Code="+this._mtl_Code+ ","+"Store_Room="+this._store_Room+ ","+"Mtl_Qty="+this._mtl_Qty+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Mtl_Code="Mtl_Code";
		/// <summary>
		///
		/// </summary>
		public const string Store_Room="Store_Room";
		/// <summary>
		///
		/// </summary>
		public const string Mtl_Qty="Mtl_Qty";
	}

	}

}
