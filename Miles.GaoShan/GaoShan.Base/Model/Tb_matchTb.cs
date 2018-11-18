using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_matchTb","gaoshan_db")]
	[Serializable]
	public class Tb_matchTb
	{

		//自动生成属性
		private string _odr_No;
		/// <summary>
		///合同编码
		/// </summary>
		[Description("合同编码")]
		[DataFieldAttribute("odr_No", "varchar", "合同编码")]
		public string Odr_No
		{
			get { return _odr_No;}
			set 
			{ 
				_odr_No = value;
			}
		}

		private long _matchTb_Id;
		/// <summary>
		///配套表主键
		/// </summary>
		[Description("配套表主键")]
		[DataFieldAttribute("matchTb_Id", "bigint", "配套表主键")]
		public long MatchTb_Id
		{
			get { return _matchTb_Id;}
			set 
			{ 
				_matchTb_Id = value;
			}
		}

		private string _matchTb_Name;
		/// <summary>
		///配套表名称
		/// </summary>
		[Description("配套表名称")]
		[DataFieldAttribute("matchTb_Name", "varchar", "配套表名称")]
		public string MatchTb_Name
		{
			get { return _matchTb_Name;}
			set 
			{ 
				_matchTb_Name = value;
			}
		}

		private string _linkBill_Name;
		/// <summary>
		///项目名称
		/// </summary>
		[Description("项目名称")]
		[DataFieldAttribute("linkBill_Name", "varchar", "项目名称")]
		public string LinkBill_Name
		{
			get { return _linkBill_Name;}
			set 
			{ 
				_linkBill_Name = value;
			}
		}

		private decimal _tent_Width;
		/// <summary>
		///篷房宽
		/// </summary>
		[Description("篷房宽")]
		[DataFieldAttribute("tent_Width", "decimal", "篷房宽")]
		public decimal Tent_Width
		{
			get { return _tent_Width;}
			set 
			{ 
				_tent_Width = value;
			}
		}

		private decimal _tent_Length;
		/// <summary>
		///篷房长
		/// </summary>
		[Description("篷房长")]
		[DataFieldAttribute("tent_Length", "decimal", "篷房长")]
		public decimal Tent_Length
		{
			get { return _tent_Length;}
			set 
			{ 
				_tent_Length = value;
			}
		}

		private decimal _tent_Count;
		/// <summary>
		///篷房数量
		/// </summary>
		[Description("篷房数量")]
		[DataFieldAttribute("tent_Count", "decimal", "篷房数量")]
		public decimal Tent_Count
		{
			get { return _tent_Count;}
			set 
			{ 
				_tent_Count = value;
			}
		}

		private decimal _tent_Space;
		/// <summary>
		///篷房间距
		/// </summary>
		[Description("篷房间距")]
		[DataFieldAttribute("tent_Space", "decimal", "篷房间距")]
		public decimal Tent_Space
		{
			get { return _tent_Space;}
			set 
			{ 
				_tent_Space = value;
			}
		}

		private decimal _tent_edgeHeight;
		/// <summary>
		///篷房边高
		/// </summary>
		[Description("篷房边高")]
		[DataFieldAttribute("tent_edgeHeight", "decimal", "篷房边高")]
		public decimal Tent_edgeHeight
		{
			get { return _tent_edgeHeight;}
			set 
			{ 
				_tent_edgeHeight = value;
			}
		}

		private string _tent_MainSpec;
		/// <summary>
		///主材规格
		/// </summary>
		[Description("主材规格")]
		[DataFieldAttribute("tent_MainSpec", "varchar", "主材规格")]
		public string Tent_MainSpec
		{
			get { return _tent_MainSpec;}
			set 
			{ 
				_tent_MainSpec = value;
			}
		}

		private long _linkBill_Id;
		/// <summary>
		///
		/// </summary>
		[Description("linkBill_Id")]
		[DataFieldAttribute("linkBill_Id", "bigint", "")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

		private DateTime _odr_Date;
		/// <summary>
		///合同日期
		/// </summary>
		[Description("合同日期")]
		[DataFieldAttribute("odr_Date", "datetime", "合同日期")]
		public DateTime Odr_Date
		{
			get { return _odr_Date;}
			set 
			{ 
				_odr_Date = value;
			}
		}

		private int _matchTb_State;
		/// <summary>
		///联络单状态
		/// </summary>
		[Description("联络单状态")]
		[DataFieldAttribute("matchTb_State", "int", "联络单状态")]
		public int MatchTb_State
		{
			get { return _matchTb_State;}
			set 
			{ 
				_matchTb_State = value;
			}
		}

		private int _odr_Type;
		/// <summary>
		///合同类型
		/// </summary>
		[Description("合同类型")]
		[DataFieldAttribute("odr_Type", "int", "合同类型")]
		public int Odr_Type
		{
			get { return _odr_Type;}
			set 
			{ 
				_odr_Type = value;
			}
		}

		private string _odr_Prt_Name;
		/// <summary>
		///合同产品名称
		/// </summary>
		[Description("合同产品名称")]
		[DataFieldAttribute("odr_Prt_Name", "varchar", "合同产品名称")]
		public string Odr_Prt_Name
		{
			get { return _odr_Prt_Name;}
			set 
			{ 
				_odr_Prt_Name = value;
			}
		}

		private string _odr_Bud_Palce;
		/// <summary>
		///搭建地点
		/// </summary>
		[Description("搭建地点")]
		[DataFieldAttribute("odr_Bud_Palce", "varchar", "搭建地点")]
		public string Odr_Bud_Palce
		{
			get { return _odr_Bud_Palce;}
			set 
			{ 
				_odr_Bud_Palce = value;
			}
		}

		private DateTime _let_Bud_SDate;
		/// <summary>
		///租赁搭建起始时间
		/// </summary>
		[Description("租赁搭建起始时间")]
		[DataFieldAttribute("let_Bud_SDate", "datetime", "租赁搭建起始时间")]
		public DateTime Let_Bud_SDate
		{
			get { return _let_Bud_SDate;}
			set 
			{ 
				_let_Bud_SDate = value;
			}
		}

		private DateTime _let_Bud_EDate;
		/// <summary>
		///租赁搭建截止时间
		/// </summary>
		[Description("租赁搭建截止时间")]
		[DataFieldAttribute("let_Bud_EDate", "datetime", "租赁搭建截止时间")]
		public DateTime Let_Bud_EDate
		{
			get { return _let_Bud_EDate;}
			set 
			{ 
				_let_Bud_EDate = value;
			}
		}

		private DateTime _let_Use_SDate;
		/// <summary>
		///租赁使用开始时间
		/// </summary>
		[Description("租赁使用开始时间")]
		[DataFieldAttribute("let_Use_SDate", "datetime", "租赁使用开始时间")]
		public DateTime Let_Use_SDate
		{
			get { return _let_Use_SDate;}
			set 
			{ 
				_let_Use_SDate = value;
			}
		}

		private DateTime _let_Use_EDate;
		/// <summary>
		///租赁使用截止时间
		/// </summary>
		[Description("租赁使用截止时间")]
		[DataFieldAttribute("let_Use_EDate", "datetime", "租赁使用截止时间")]
		public DateTime Let_Use_EDate
		{
			get { return _let_Use_EDate;}
			set 
			{ 
				_let_Use_EDate = value;
			}
		}

		private DateTime _let_Rm_SDate;
		/// <summary>
		///租赁拆除开始时间
		/// </summary>
		[Description("租赁拆除开始时间")]
		[DataFieldAttribute("let_Rm_SDate", "datetime", "租赁拆除开始时间")]
		public DateTime Let_Rm_SDate
		{
			get { return _let_Rm_SDate;}
			set 
			{ 
				_let_Rm_SDate = value;
			}
		}

		private DateTime _let_Rm_EDate;
		/// <summary>
		///租赁拆除截止时间
		/// </summary>
		[Description("租赁拆除截止时间")]
		[DataFieldAttribute("let_Rm_EDate", "datetime", "租赁拆除截止时间")]
		public DateTime Let_Rm_EDate
		{
			get { return _let_Rm_EDate;}
			set 
			{ 
				_let_Rm_EDate = value;
			}
		}

		private DateTime _oper_Date;
		/// <summary>
		///操作日期
		/// </summary>
		[Description("操作日期")]
		[DataFieldAttribute("oper_Date", "datetime", "操作日期")]
		public DateTime Oper_Date
		{
			get { return _oper_Date;}
			set 
			{ 
				_oper_Date = value;
			}
		}

		private string _oper_Code;
		/// <summary>
		///操作人
		/// </summary>
		[Description("操作人")]
		[DataFieldAttribute("oper_Code", "varchar", "操作人")]
		public string Oper_Code
		{
			get { return _oper_Code;}
			set 
			{ 
				_oper_Code = value;
			}
		}

		private string _employ_Code;
		/// <summary>
		///
		/// </summary>
		[Description("employ_Code")]
		[DataFieldAttribute("employ_Code", "varchar", "")]
		public string Employ_Code
		{
			get { return _employ_Code;}
			set 
			{ 
				_employ_Code = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"MatchTb_Id="+this._matchTb_Id+ ","+"MatchTb_Name="+this._matchTb_Name+ ","+"LinkBill_Name="+this._linkBill_Name+ ","+"Tent_Width="+this._tent_Width+ ","+"Tent_Length="+this._tent_Length+ ","+"Tent_Count="+this._tent_Count+ ","+"Tent_Space="+this._tent_Space+ ","+"Tent_edgeHeight="+this._tent_edgeHeight+ ","+"Tent_MainSpec="+this._tent_MainSpec+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Odr_Date="+this._odr_Date+ ","+"MatchTb_State="+this._matchTb_State+ ","+"Odr_Type="+this._odr_Type+ ","+"Odr_Prt_Name="+this._odr_Prt_Name+ ","+"Odr_Bud_Palce="+this._odr_Bud_Palce+ ","+"Let_Bud_SDate="+this._let_Bud_SDate+ ","+"Let_Bud_EDate="+this._let_Bud_EDate+ ","+"Let_Use_SDate="+this._let_Use_SDate+ ","+"Let_Use_EDate="+this._let_Use_EDate+ ","+"Let_Rm_SDate="+this._let_Rm_SDate+ ","+"Let_Rm_EDate="+this._let_Rm_EDate+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Employ_Code="+this._employ_Code+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///配套表主键
		/// </summary>
		public const string MatchTb_Id="MatchTb_Id";
		/// <summary>
		///配套表名称
		/// </summary>
		public const string MatchTb_Name="MatchTb_Name";
		/// <summary>
		///项目名称
		/// </summary>
		public const string LinkBill_Name="LinkBill_Name";
		/// <summary>
		///篷房宽
		/// </summary>
		public const string Tent_Width="Tent_Width";
		/// <summary>
		///篷房长
		/// </summary>
		public const string Tent_Length="Tent_Length";
		/// <summary>
		///篷房数量
		/// </summary>
		public const string Tent_Count="Tent_Count";
		/// <summary>
		///篷房间距
		/// </summary>
		public const string Tent_Space="Tent_Space";
		/// <summary>
		///篷房边高
		/// </summary>
		public const string Tent_edgeHeight="Tent_edgeHeight";
		/// <summary>
		///主材规格
		/// </summary>
		public const string Tent_MainSpec="Tent_MainSpec";
		/// <summary>
		///
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///合同日期
		/// </summary>
		public const string Odr_Date="Odr_Date";
		/// <summary>
		///联络单状态
		/// </summary>
		public const string MatchTb_State="MatchTb_State";
		/// <summary>
		///合同类型
		/// </summary>
		public const string Odr_Type="Odr_Type";
		/// <summary>
		///合同产品名称
		/// </summary>
		public const string Odr_Prt_Name="Odr_Prt_Name";
		/// <summary>
		///搭建地点
		/// </summary>
		public const string Odr_Bud_Palce="Odr_Bud_Palce";
		/// <summary>
		///租赁搭建起始时间
		/// </summary>
		public const string Let_Bud_SDate="Let_Bud_SDate";
		/// <summary>
		///租赁搭建截止时间
		/// </summary>
		public const string Let_Bud_EDate="Let_Bud_EDate";
		/// <summary>
		///租赁使用开始时间
		/// </summary>
		public const string Let_Use_SDate="Let_Use_SDate";
		/// <summary>
		///租赁使用截止时间
		/// </summary>
		public const string Let_Use_EDate="Let_Use_EDate";
		/// <summary>
		///租赁拆除开始时间
		/// </summary>
		public const string Let_Rm_SDate="Let_Rm_SDate";
		/// <summary>
		///租赁拆除截止时间
		/// </summary>
		public const string Let_Rm_EDate="Let_Rm_EDate";
		/// <summary>
		///操作日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///操作人
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///
		/// </summary>
		public const string Employ_Code="Employ_Code";
	}

	}

}
