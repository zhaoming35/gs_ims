using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_order_text","gaoshan_db")]
	[Serializable]
	public class Tb_order_text
	{

		//自动生成属性
		private string _odr_No;
		/// <summary>
		///合同id
		/// </summary>
		[Description("合同id")]
		[DataFieldAttribute("odr_No", "varchar", "合同id")]
		public string Odr_No
		{
			get { return _odr_No;}
			set 
			{ 
				_odr_No = value;
			}
		}

		private byte[] _odr_Text;
		/// <summary>
		///合同全文
		/// </summary>
		[Description("合同全文")]
		[DataFieldAttribute("odr_Text", "image", "合同全文")]
		public byte[] Odr_Text
		{
			get { return _odr_Text;}
			set 
			{ 
				_odr_Text = value;
			}
		}

		private byte[] _odr_Clause;
		/// <summary>
		///合同条款文本部分
		/// </summary>
		[Description("合同条款文本部分")]
		[DataFieldAttribute("odr_Clause", "image", "合同条款文本部分")]
		public byte[] Odr_Clause
		{
			get { return _odr_Clause;}
			set 
			{ 
				_odr_Clause = value;
			}
		}

		private string _odr_Pay;
		/// <summary>
		///支付方式
		/// </summary>
		[Description("支付方式")]
		[DataFieldAttribute("odr_Pay", "ntext", "支付方式")]
		public string Odr_Pay
		{
			get { return _odr_Pay;}
			set 
			{ 
				_odr_Pay = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"Odr_Text="+this._odr_Text+ ","+"Odr_Clause="+this._odr_Clause+ ","+"Odr_Pay="+this._odr_Pay+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///合同id
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///合同全文
		/// </summary>
		public const string Odr_Text="Odr_Text";
		/// <summary>
		///合同条款文本部分
		/// </summary>
		public const string Odr_Clause="Odr_Clause";
		/// <summary>
		///支付方式
		/// </summary>
		public const string Odr_Pay="Odr_Pay";
	}

	}

}
