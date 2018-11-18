using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_matchTb_tmp","gaoshan_db")]
	[Serializable]
	public class Tb_matchTb_tmp
	{

		//自动生成属性
		private string _var_Input;
		/// <summary>
		///配套表输入参数
		/// </summary>
		[Description("配套表输入参数")]
		[DataFieldAttribute("var_Input", "ntext", "配套表输入参数")]
		public string Var_Input
		{
			get { return _var_Input;}
			set 
			{ 
				_var_Input = value;
			}
		}

		private string _var_Cal;
		/// <summary>
		///配套表计算参数
		/// </summary>
		[Description("配套表计算参数")]
		[DataFieldAttribute("var_Cal", "ntext", "配套表计算参数")]
		public string Var_Cal
		{
			get { return _var_Cal;}
			set 
			{ 
				_var_Cal = value;
			}
		}

		private string _szc_lt30;
		/// <summary>
		///宽度小于30米的十字撑计算公式集合
		/// </summary>
		[Description("宽度小于30米的十字撑计算公式集合")]
		[DataFieldAttribute("szc_lt30", "ntext", "宽度小于30米的十字撑计算公式集合")]
		public string Szc_lt30
		{
			get { return _szc_lt30;}
			set 
			{ 
				_szc_lt30 = value;
			}
		}

		private string _szc_gt30;
		/// <summary>
		///宽度大于30米的十字撑计算公式集合
		/// </summary>
		[Description("宽度大于30米的十字撑计算公式集合")]
		[DataFieldAttribute("szc_gt30", "ntext", "宽度大于30米的十字撑计算公式集合")]
		public string Szc_gt30
		{
			get { return _szc_gt30;}
			set 
			{ 
				_szc_gt30 = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Var_Input="+this._var_Input+ ","+"Var_Cal="+this._var_Cal+ ","+"Szc_lt30="+this._szc_lt30+ ","+"Szc_gt30="+this._szc_gt30+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///配套表输入参数
		/// </summary>
		public const string Var_Input="Var_Input";
		/// <summary>
		///配套表计算参数
		/// </summary>
		public const string Var_Cal="Var_Cal";
		/// <summary>
		///宽度小于30米的十字撑计算公式集合
		/// </summary>
		public const string Szc_lt30="Szc_lt30";
		/// <summary>
		///宽度大于30米的十字撑计算公式集合
		/// </summary>
		public const string Szc_gt30="Szc_gt30";
	}

	}

}
