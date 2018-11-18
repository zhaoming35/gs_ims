using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_link_bill","gaoshan_db")]
	[Serializable]
	public class Tb_link_bill
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

		private long _linkBill_Id;
		/// <summary>
		///联络单主键
		/// </summary>
		[Description("联络单主键")]
		[DataFieldAttribute("linkBill_Id", "bigint", "联络单主键")]
		public long LinkBill_Id
		{
			get { return _linkBill_Id;}
			set 
			{ 
				_linkBill_Id = value;
			}
		}

		private string _jia_Name;
		/// <summary>
		///
		/// </summary>
		[Description("jia_Name")]
		[DataFieldAttribute("jia_Name", "varchar", "")]
		public string Jia_Name
		{
			get { return _jia_Name;}
			set 
			{ 
				_jia_Name = value;
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

		private string _employ_Phone;
		/// <summary>
		///业务员电话
		/// </summary>
		[Description("业务员电话")]
		[DataFieldAttribute("employ_Phone", "varchar", "业务员电话")]
		public string Employ_Phone
		{
			get { return _employ_Phone;}
			set 
			{ 
				_employ_Phone = value;
			}
		}

		private string _employ_Name;
		/// <summary>
		///业务员名称
		/// </summary>
		[Description("业务员名称")]
		[DataFieldAttribute("employ_Name", "varchar", "业务员名称")]
		public string Employ_Name
		{
			get { return _employ_Name;}
			set 
			{ 
				_employ_Name = value;
			}
		}

		private int _is_MatchTb;
		/// <summary>
		///是否已经建立配套表
		/// </summary>
		[Description("是否已经建立配套表")]
		[DataFieldAttribute("is_MatchTb", "int", "是否已经建立配套表")]
		public int Is_MatchTb
		{
			get { return _is_MatchTb;}
			set 
			{ 
				_is_MatchTb = value;
			}
		}

		private int _is_Carriage;
		/// <summary>
		///是否建立运输单
		/// </summary>
		[Description("是否建立运输单")]
		[DataFieldAttribute("is_Carriage", "int", "是否建立运输单")]
		public int Is_Carriage
		{
			get { return _is_Carriage;}
			set 
			{ 
				_is_Carriage = value;
			}
		}

		private int _is_ProjectCost;
		/// <summary>
		///是否工程部费用录入
		/// </summary>
		[Description("是否工程部费用录入")]
		[DataFieldAttribute("is_ProjectCost", "int", "是否工程部费用录入")]
		public int Is_ProjectCost
		{
			get { return _is_ProjectCost;}
			set 
			{ 
				_is_ProjectCost = value;
			}
		}

		private int _linkBill_Type;
		/// <summary>
		///联络单类型0是正常，1为取消单
		/// </summary>
		[Description("联络单类型0是正常，1为取消单")]
		[DataFieldAttribute("linkBill_Type", "int", "联络单类型0是正常，1为取消单")]
		public int LinkBill_Type
		{
			get { return _linkBill_Type;}
			set 
			{ 
				_linkBill_Type = value;
			}
		}

		private int _is_OutStore;
		/// <summary>
		///完成出库
		/// </summary>
		[Description("完成出库")]
		[DataFieldAttribute("is_OutStore", "int", "完成出库")]
		public int Is_OutStore
		{
			get { return _is_OutStore;}
			set 
			{ 
				_is_OutStore = value;
			}
		}

		private int _is_BackStore;
		/// <summary>
		///是否租赁回库
		/// </summary>
		[Description("是否租赁回库")]
		[DataFieldAttribute("is_BackStore", "int", "是否租赁回库")]
		public int Is_BackStore
		{
			get { return _is_BackStore;}
			set 
			{ 
				_is_BackStore = value;
			}
		}

		private string _build_Way;
		/// <summary>
		///搭建情况说明
		/// </summary>
		[Description("搭建情况说明")]
		[DataFieldAttribute("build_Way", "varchar", "搭建情况说明")]
		public string Build_Way
		{
			get { return _build_Way;}
			set 
			{ 
				_build_Way = value;
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

		private int _bill_State;
		/// <summary>
		///联络单状态
		/// </summary>
		[Description("联络单状态")]
		[DataFieldAttribute("bill_State", "int", "联络单状态")]
		public int Bill_State
		{
			get { return _bill_State;}
			set 
			{ 
				_bill_State = value;
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

		private string _odr_Trans_Party;
		/// <summary>
		///运输方
		/// </summary>
		[Description("运输方")]
		[DataFieldAttribute("odr_Trans_Party", "varchar", "运输方")]
		public string Odr_Trans_Party
		{
			get { return _odr_Trans_Party;}
			set 
			{ 
				_odr_Trans_Party = value;
			}
		}

		private string _odr_Place_Linkman;
		/// <summary>
		///场地联系人
		/// </summary>
		[Description("场地联系人")]
		[DataFieldAttribute("odr_Place_Linkman", "varchar", "场地联系人")]
		public string Odr_Place_Linkman
		{
			get { return _odr_Place_Linkman;}
			set 
			{ 
				_odr_Place_Linkman = value;
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

		private string _odr_Place_Phone;
		/// <summary>
		///场地联系电话
		/// </summary>
		[Description("场地联系电话")]
		[DataFieldAttribute("odr_Place_Phone", "varchar", "场地联系电话")]
		public string Odr_Place_Phone
		{
			get { return _odr_Place_Phone;}
			set 
			{ 
				_odr_Place_Phone = value;
			}
		}

		private string _odr_Ground_State;
		/// <summary>
		///地面状态
		/// </summary>
		[Description("地面状态")]
		[DataFieldAttribute("odr_Ground_State", "varchar", "地面状态")]
		public string Odr_Ground_State
		{
			get { return _odr_Ground_State;}
			set 
			{ 
				_odr_Ground_State = value;
			}
		}

		private string _odr_Water_proof;
		/// <summary>
		///地面防水
		/// </summary>
		[Description("地面防水")]
		[DataFieldAttribute("odr_Water_proof", "varchar", "地面防水")]
		public string Odr_Water_proof
		{
			get { return _odr_Water_proof;}
			set 
			{ 
				_odr_Water_proof = value;
			}
		}

		private string _odr_Fixed_Mode;
		/// <summary>
		///固定方式
		/// </summary>
		[Description("固定方式")]
		[DataFieldAttribute("odr_Fixed_Mode", "varchar", "固定方式")]
		public string Odr_Fixed_Mode
		{
			get { return _odr_Fixed_Mode;}
			set 
			{ 
				_odr_Fixed_Mode = value;
			}
		}

		private DateTime _let_Entry_Date;
		/// <summary>
		///租赁物料入场时间
		/// </summary>
		[Description("租赁物料入场时间")]
		[DataFieldAttribute("let_Entry_Date", "datetime", "租赁物料入场时间")]
		public DateTime Let_Entry_Date
		{
			get { return _let_Entry_Date;}
			set 
			{ 
				_let_Entry_Date = value;
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

		private string _odr_Bud_Party;
		/// <summary>
		///搭建方
		/// </summary>
		[Description("搭建方")]
		[DataFieldAttribute("odr_Bud_Party", "varchar", "搭建方")]
		public string Odr_Bud_Party
		{
			get { return _odr_Bud_Party;}
			set 
			{ 
				_odr_Bud_Party = value;
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

		private string _project_Man;
		/// <summary>
		///工程负责人信息
		/// </summary>
		[Description("工程负责人信息")]
		[DataFieldAttribute("project_Man", "varchar", "工程负责人信息")]
		public string Project_Man
		{
			get { return _project_Man;}
			set 
			{ 
				_project_Man = value;
			}
		}

		private string _duty_Info;
		/// <summary>
		///值班时间及人员信息
		/// </summary>
		[Description("值班时间及人员信息")]
		[DataFieldAttribute("duty_Info", "varchar", "值班时间及人员信息")]
		public string Duty_Info
		{
			get { return _duty_Info;}
			set 
			{ 
				_duty_Info = value;
			}
		}

		private string _is_put_tool;
		/// <summary>
		///是否放置工具信息
		/// </summary>
		[Description("是否放置工具信息")]
		[DataFieldAttribute("is_put_tool", "varchar", "是否放置工具信息")]
		public string Is_put_tool
		{
			get { return _is_put_tool;}
			set 
			{ 
				_is_put_tool = value;
			}
		}

		private string _special_info;
		/// <summary>
		///特殊场地信息
		/// </summary>
		[Description("特殊场地信息")]
		[DataFieldAttribute("special_info", "varchar", "特殊场地信息")]
		public string Special_info
		{
			get { return _special_info;}
			set 
			{ 
				_special_info = value;
			}
		}

		private string _supplier_Floor;
		/// <summary>
		///供应商地板信息
		/// </summary>
		[Description("供应商地板信息")]
		[DataFieldAttribute("supplier_Floor", "varchar", "供应商地板信息")]
		public string Supplier_Floor
		{
			get { return _supplier_Floor;}
			set 
			{ 
				_supplier_Floor = value;
			}
		}

		private string _supplier_Carpet;
		/// <summary>
		///供应商地毯信息
		/// </summary>
		[Description("供应商地毯信息")]
		[DataFieldAttribute("supplier_Carpet", "varchar", "供应商地毯信息")]
		public string Supplier_Carpet
		{
			get { return _supplier_Carpet;}
			set 
			{ 
				_supplier_Carpet = value;
			}
		}

		private string _provide_Info;
		/// <summary>
		///提供资料信息
		/// </summary>
		[Description("提供资料信息")]
		[DataFieldAttribute("provide_Info", "varchar", "提供资料信息")]
		public string Provide_Info
		{
			get { return _provide_Info;}
			set 
			{ 
				_provide_Info = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"LinkBill_Id="+this._linkBill_Id+ ","+"Jia_Name="+this._jia_Name+ ","+"LinkBill_Name="+this._linkBill_Name+ ","+"Employ_Phone="+this._employ_Phone+ ","+"Employ_Name="+this._employ_Name+ ","+"Is_MatchTb="+this._is_MatchTb+ ","+"Is_Carriage="+this._is_Carriage+ ","+"Is_ProjectCost="+this._is_ProjectCost+ ","+"LinkBill_Type="+this._linkBill_Type+ ","+"Is_OutStore="+this._is_OutStore+ ","+"Is_BackStore="+this._is_BackStore+ ","+"Build_Way="+this._build_Way+ ","+"Odr_Date="+this._odr_Date+ ","+"Bill_State="+this._bill_State+ ","+"Odr_Type="+this._odr_Type+ ","+"Odr_Prt_Name="+this._odr_Prt_Name+ ","+"Odr_Trans_Party="+this._odr_Trans_Party+ ","+"Odr_Place_Linkman="+this._odr_Place_Linkman+ ","+"Odr_Bud_Palce="+this._odr_Bud_Palce+ ","+"Odr_Place_Phone="+this._odr_Place_Phone+ ","+"Odr_Ground_State="+this._odr_Ground_State+ ","+"Odr_Water_proof="+this._odr_Water_proof+ ","+"Odr_Fixed_Mode="+this._odr_Fixed_Mode+ ","+"Let_Entry_Date="+this._let_Entry_Date+ ","+"Let_Bud_SDate="+this._let_Bud_SDate+ ","+"Let_Bud_EDate="+this._let_Bud_EDate+ ","+"Let_Use_SDate="+this._let_Use_SDate+ ","+"Let_Use_EDate="+this._let_Use_EDate+ ","+"Let_Rm_SDate="+this._let_Rm_SDate+ ","+"Let_Rm_EDate="+this._let_Rm_EDate+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Odr_Bud_Party="+this._odr_Bud_Party+ ","+"Employ_Code="+this._employ_Code+ ","+"Project_Man="+this._project_Man+ ","+"Duty_Info="+this._duty_Info+ ","+"Is_put_tool="+this._is_put_tool+ ","+"Special_info="+this._special_info+ ","+"Supplier_Floor="+this._supplier_Floor+ ","+"Supplier_Carpet="+this._supplier_Carpet+ ","+"Provide_Info="+this._provide_Info+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///联络单主键
		/// </summary>
		public const string LinkBill_Id="LinkBill_Id";
		/// <summary>
		///
		/// </summary>
		public const string Jia_Name="Jia_Name";
		/// <summary>
		///项目名称
		/// </summary>
		public const string LinkBill_Name="LinkBill_Name";
		/// <summary>
		///业务员电话
		/// </summary>
		public const string Employ_Phone="Employ_Phone";
		/// <summary>
		///业务员名称
		/// </summary>
		public const string Employ_Name="Employ_Name";
		/// <summary>
		///是否已经建立配套表
		/// </summary>
		public const string Is_MatchTb="Is_MatchTb";
		/// <summary>
		///是否建立运输单
		/// </summary>
		public const string Is_Carriage="Is_Carriage";
		/// <summary>
		///是否工程部费用录入
		/// </summary>
		public const string Is_ProjectCost="Is_ProjectCost";
		/// <summary>
		///联络单类型0是正常，1为取消单
		/// </summary>
		public const string LinkBill_Type="LinkBill_Type";
		/// <summary>
		///完成出库
		/// </summary>
		public const string Is_OutStore="Is_OutStore";
		/// <summary>
		///是否租赁回库
		/// </summary>
		public const string Is_BackStore="Is_BackStore";
		/// <summary>
		///搭建情况说明
		/// </summary>
		public const string Build_Way="Build_Way";
		/// <summary>
		///合同日期
		/// </summary>
		public const string Odr_Date="Odr_Date";
		/// <summary>
		///联络单状态
		/// </summary>
		public const string Bill_State="Bill_State";
		/// <summary>
		///合同类型
		/// </summary>
		public const string Odr_Type="Odr_Type";
		/// <summary>
		///合同产品名称
		/// </summary>
		public const string Odr_Prt_Name="Odr_Prt_Name";
		/// <summary>
		///运输方
		/// </summary>
		public const string Odr_Trans_Party="Odr_Trans_Party";
		/// <summary>
		///场地联系人
		/// </summary>
		public const string Odr_Place_Linkman="Odr_Place_Linkman";
		/// <summary>
		///搭建地点
		/// </summary>
		public const string Odr_Bud_Palce="Odr_Bud_Palce";
		/// <summary>
		///场地联系电话
		/// </summary>
		public const string Odr_Place_Phone="Odr_Place_Phone";
		/// <summary>
		///地面状态
		/// </summary>
		public const string Odr_Ground_State="Odr_Ground_State";
		/// <summary>
		///地面防水
		/// </summary>
		public const string Odr_Water_proof="Odr_Water_proof";
		/// <summary>
		///固定方式
		/// </summary>
		public const string Odr_Fixed_Mode="Odr_Fixed_Mode";
		/// <summary>
		///租赁物料入场时间
		/// </summary>
		public const string Let_Entry_Date="Let_Entry_Date";
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
		///搭建方
		/// </summary>
		public const string Odr_Bud_Party="Odr_Bud_Party";
		/// <summary>
		///
		/// </summary>
		public const string Employ_Code="Employ_Code";
		/// <summary>
		///工程负责人信息
		/// </summary>
		public const string Project_Man="Project_Man";
		/// <summary>
		///值班时间及人员信息
		/// </summary>
		public const string Duty_Info="Duty_Info";
		/// <summary>
		///是否放置工具信息
		/// </summary>
		public const string Is_put_tool="Is_put_tool";
		/// <summary>
		///特殊场地信息
		/// </summary>
		public const string Special_info="Special_info";
		/// <summary>
		///供应商地板信息
		/// </summary>
		public const string Supplier_Floor="Supplier_Floor";
		/// <summary>
		///供应商地毯信息
		/// </summary>
		public const string Supplier_Carpet="Supplier_Carpet";
		/// <summary>
		///提供资料信息
		/// </summary>
		public const string Provide_Info="Provide_Info";
	}

	}

}
