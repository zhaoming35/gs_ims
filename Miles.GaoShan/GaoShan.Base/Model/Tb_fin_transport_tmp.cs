using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_fin_transport_tmp","gaoshan_db")]
	[Serializable]
	public class Tb_fin_transport_tmp
	{

		//自动生成属性
		private string _var_Input;
		/// <summary>
		///配套表输入参数
		/// </summary>
		[Description("配套表输入参数")]
		[DataFieldAttribute("var_Input", "nvarchar", "配套表输入参数")]
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
		[DataFieldAttribute("var_Cal", "nvarchar", "配套表计算参数")]
		public string Var_Cal
		{
			get { return _var_Cal;}
			set 
			{ 
				_var_Cal = value;
			}
		}

		private string _main_Spec;
		/// <summary>
		///型材规格集合
		/// </summary>
		[Description("型材规格集合")]
		[DataFieldAttribute("main_Spec", "nvarchar", "型材规格集合")]
		public string Main_Spec
		{
			get { return _main_Spec;}
			set 
			{ 
				_main_Spec = value;
			}
		}

		private string _edge_Height;
		/// <summary>
		///边高集合
		/// </summary>
		[Description("边高集合")]
		[DataFieldAttribute("edge_Height", "nvarchar", "边高集合")]
		public string Edge_Height
		{
			get { return _edge_Height;}
			set 
			{ 
				_edge_Height = value;
			}
		}

		private string _trans_Fixed;
		/// <summary>
		///固定方式
		/// </summary>
		[Description("固定方式")]
		[DataFieldAttribute("trans_Fixed", "nvarchar", "固定方式")]
		public string Trans_Fixed
		{
			get { return _trans_Fixed;}
			set 
			{ 
				_trans_Fixed = value;
			}
		}

		private string _dml_Formula;
		/// <summary>
		///端柱面公式
		/// </summary>
		[Description("端柱面公式")]
		[DataFieldAttribute("dml_Formula", "nvarchar", "端柱面公式")]
		public string Dml_Formula
		{
			get { return _dml_Formula;}
			set 
			{ 
				_dml_Formula = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Var_Input="+this._var_Input+ ","+"Var_Cal="+this._var_Cal+ ","+"Main_Spec="+this._main_Spec+ ","+"Edge_Height="+this._edge_Height+ ","+"Trans_Fixed="+this._trans_Fixed+ ","+"Dml_Formula="+this._dml_Formula+"]";
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
		///型材规格集合
		/// </summary>
		public const string Main_Spec="Main_Spec";
		/// <summary>
		///边高集合
		/// </summary>
		public const string Edge_Height="Edge_Height";
		/// <summary>
		///固定方式
		/// </summary>
		public const string Trans_Fixed="Trans_Fixed";
		/// <summary>
		///端柱面公式
		/// </summary>
		public const string Dml_Formula="Dml_Formula";
	}

	}

}
