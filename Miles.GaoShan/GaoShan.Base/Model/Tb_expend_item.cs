using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_expend_item","gaoshan_db")]
	[Serializable]
	public class Tb_expend_item
	{

		//自动生成属性
		private int _item_Value;
		/// <summary>
		///费用项目数值
		/// </summary>
		[Description("费用项目数值")]
		[DataFieldAttribute("item_Value", "int", "费用项目数值")]
		public int Item_Value
		{
			get { return _item_Value;}
			set 
			{ 
				_item_Value = value;
			}
		}

		private string _item_Name;
		/// <summary>
		///项目名称
		/// </summary>
		[Description("项目名称")]
		[DataFieldAttribute("item_Name", "varchar", "项目名称")]
		public string Item_Name
		{
			get { return _item_Name;}
			set 
			{ 
				_item_Name = value;
			}
		}

		private int _define_Flag;
		/// <summary>
		///提成计算标记
		/// </summary>
		[Description("提成计算标记")]
		[DataFieldAttribute("define_Flag", "int", "提成计算标记")]
		public int Define_Flag
		{
			get { return _define_Flag;}
			set 
			{ 
				_define_Flag = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Item_Value="+this._item_Value+ ","+"Item_Name="+this._item_Name+ ","+"Define_Flag="+this._define_Flag+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///费用项目数值
		/// </summary>
		public const string Item_Value="Item_Value";
		/// <summary>
		///项目名称
		/// </summary>
		public const string Item_Name="Item_Name";
		/// <summary>
		///提成计算标记
		/// </summary>
		public const string Define_Flag="Define_Flag";
	}

	}

}
