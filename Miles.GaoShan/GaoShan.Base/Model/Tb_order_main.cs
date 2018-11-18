using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_order_main","gaoshan_db")]
	[Serializable]
	public class Tb_order_main
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

		private int _odr_Seq;
		/// <summary>
		///合同追加的次数
		/// </summary>
		[Description("合同追加的次数")]
		[DataFieldAttribute("odr_Seq", "int", "合同追加的次数")]
		public int Odr_Seq
		{
			get { return _odr_Seq;}
			set 
			{ 
				_odr_Seq = value;
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

		private int _odr_State;
		/// <summary>
		///合同状态
		/// </summary>
		[Description("合同状态")]
		[DataFieldAttribute("odr_State", "int", "合同状态")]
		public int Odr_State
		{
			get { return _odr_State;}
			set 
			{ 
				_odr_State = value;
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

		private string _jia_Name;
		/// <summary>
		///甲方(需方)
		/// </summary>
		[Description("甲方(需方)")]
		[DataFieldAttribute("jia_Name", "varchar", "甲方(需方)")]
		public string Jia_Name
		{
			get { return _jia_Name;}
			set 
			{ 
				_jia_Name = value;
			}
		}

		private string _jia_FaRen;
		/// <summary>
		///甲方法人代表
		/// </summary>
		[Description("甲方法人代表")]
		[DataFieldAttribute("jia_FaRen", "varchar", "甲方法人代表")]
		public string Jia_FaRen
		{
			get { return _jia_FaRen;}
			set 
			{ 
				_jia_FaRen = value;
			}
		}

		private string _jia_DaiLi;
		/// <summary>
		///甲方委托代理人
		/// </summary>
		[Description("甲方委托代理人")]
		[DataFieldAttribute("jia_DaiLi", "varchar", "甲方委托代理人")]
		public string Jia_DaiLi
		{
			get { return _jia_DaiLi;}
			set 
			{ 
				_jia_DaiLi = value;
			}
		}

		private string _jia_Adress;
		/// <summary>
		///甲方地址
		/// </summary>
		[Description("甲方地址")]
		[DataFieldAttribute("jia_Adress", "varchar", "甲方地址")]
		public string Jia_Adress
		{
			get { return _jia_Adress;}
			set 
			{ 
				_jia_Adress = value;
			}
		}

		private string _jia_Phone;
		/// <summary>
		///甲方电话
		/// </summary>
		[Description("甲方电话")]
		[DataFieldAttribute("jia_Phone", "varchar", "甲方电话")]
		public string Jia_Phone
		{
			get { return _jia_Phone;}
			set 
			{ 
				_jia_Phone = value;
			}
		}

		private string _jia_Fax;
		/// <summary>
		///甲方传真
		/// </summary>
		[Description("甲方传真")]
		[DataFieldAttribute("jia_Fax", "varchar", "甲方传真")]
		public string Jia_Fax
		{
			get { return _jia_Fax;}
			set 
			{ 
				_jia_Fax = value;
			}
		}

		private string _yi_Name;
		/// <summary>
		///乙方(供方）
		/// </summary>
		[Description("乙方(供方）")]
		[DataFieldAttribute("yi_Name", "varchar", "乙方(供方）")]
		public string Yi_Name
		{
			get { return _yi_Name;}
			set 
			{ 
				_yi_Name = value;
			}
		}

		private string _yi_FaRen;
		/// <summary>
		///乙方法人代表
		/// </summary>
		[Description("乙方法人代表")]
		[DataFieldAttribute("yi_FaRen", "varchar", "乙方法人代表")]
		public string Yi_FaRen
		{
			get { return _yi_FaRen;}
			set 
			{ 
				_yi_FaRen = value;
			}
		}

		private string _yi_DaiLi;
		/// <summary>
		///乙方代理人
		/// </summary>
		[Description("乙方代理人")]
		[DataFieldAttribute("yi_DaiLi", "varchar", "乙方代理人")]
		public string Yi_DaiLi
		{
			get { return _yi_DaiLi;}
			set 
			{ 
				_yi_DaiLi = value;
			}
		}

		private string _yi_Adress;
		/// <summary>
		///乙方地址
		/// </summary>
		[Description("乙方地址")]
		[DataFieldAttribute("yi_Adress", "varchar", "乙方地址")]
		public string Yi_Adress
		{
			get { return _yi_Adress;}
			set 
			{ 
				_yi_Adress = value;
			}
		}

		private string _yi_Phone;
		/// <summary>
		///乙方电话
		/// </summary>
		[Description("乙方电话")]
		[DataFieldAttribute("yi_Phone", "varchar", "乙方电话")]
		public string Yi_Phone
		{
			get { return _yi_Phone;}
			set 
			{ 
				_yi_Phone = value;
			}
		}

		private string _yi_Act_Name;
		/// <summary>
		///乙方银行用户名
		/// </summary>
		[Description("乙方银行用户名")]
		[DataFieldAttribute("yi_Act_Name", "varchar", "乙方银行用户名")]
		public string Yi_Act_Name
		{
			get { return _yi_Act_Name;}
			set 
			{ 
				_yi_Act_Name = value;
			}
		}

		private string _yi_Bank_Name;
		/// <summary>
		///乙方开户行
		/// </summary>
		[Description("乙方开户行")]
		[DataFieldAttribute("yi_Bank_Name", "varchar", "乙方开户行")]
		public string Yi_Bank_Name
		{
			get { return _yi_Bank_Name;}
			set 
			{ 
				_yi_Bank_Name = value;
			}
		}

		private string _yi_Act_No;
		/// <summary>
		///乙方银行账号
		/// </summary>
		[Description("乙方银行账号")]
		[DataFieldAttribute("yi_Act_No", "varchar", "乙方银行账号")]
		public string Yi_Act_No
		{
			get { return _yi_Act_No;}
			set 
			{ 
				_yi_Act_No = value;
			}
		}

		private string _yi_Tax_Code;
		/// <summary>
		///乙方纳税人识别码
		/// </summary>
		[Description("乙方纳税人识别码")]
		[DataFieldAttribute("yi_Tax_Code", "varchar", "乙方纳税人识别码")]
		public string Yi_Tax_Code
		{
			get { return _yi_Tax_Code;}
			set 
			{ 
				_yi_Tax_Code = value;
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

		private decimal _odr_Sum_Area;
		/// <summary>
		///合同总面积
		/// </summary>
		[Description("合同总面积")]
		[DataFieldAttribute("odr_Sum_Area", "decimal", "合同总面积")]
		public decimal Odr_Sum_Area
		{
			get { return _odr_Sum_Area;}
			set 
			{ 
				_odr_Sum_Area = value;
			}
		}

		private string _odr_Prt_Purpose;
		/// <summary>
		///产品用途
		/// </summary>
		[Description("产品用途")]
		[DataFieldAttribute("odr_Prt_Purpose", "varchar", "产品用途")]
		public string Odr_Prt_Purpose
		{
			get { return _odr_Prt_Purpose;}
			set 
			{ 
				_odr_Prt_Purpose = value;
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

		private string _odr_Tax_Type;
		/// <summary>
		///合同税票
		/// </summary>
		[Description("合同税票")]
		[DataFieldAttribute("odr_Tax_Type", "varchar", "合同税票")]
		public string Odr_Tax_Type
		{
			get { return _odr_Tax_Type;}
			set 
			{ 
				_odr_Tax_Type = value;
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

		private decimal _tot_Cost;
		/// <summary>
		///合同总金额
		/// </summary>
		[Description("合同总金额")]
		[DataFieldAttribute("tot_Cost", "decimal", "合同总金额")]
		public decimal Tot_Cost
		{
			get { return _tot_Cost;}
			set 
			{ 
				_tot_Cost = value;
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

		private string _col_Extend;
		/// <summary>
		///变量字段
		/// </summary>
		[Description("变量字段")]
		[DataFieldAttribute("col_Extend", "text", "变量字段")]
		public string Col_Extend
		{
			get { return _col_Extend;}
			set 
			{ 
				_col_Extend = value;
			}
		}

		private long _tmp_Id;
		/// <summary>
		///模板Id
		/// </summary>
		[Description("模板Id")]
		[DataFieldAttribute("tmp_Id", "bigint", "模板Id")]
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
		///模板名称
		/// </summary>
		[Description("模板名称")]
		[DataFieldAttribute("tmp_Name", "varchar", "模板名称")]
		public string Tmp_Name
		{
			get { return _tmp_Name;}
			set 
			{ 
				_tmp_Name = value;
			}
		}

		private string _tmp_Explain;
		/// <summary>
		///模板说明
		/// </summary>
		[Description("模板说明")]
		[DataFieldAttribute("tmp_Explain", "varchar", "模板说明")]
		public string Tmp_Explain
		{
			get { return _tmp_Explain;}
			set 
			{ 
				_tmp_Explain = value;
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

		private string _odr_No_Main;
		/// <summary>
		///主合同编码
		/// </summary>
		[Description("主合同编码")]
		[DataFieldAttribute("odr_No_Main", "varchar", "主合同编码")]
		public string Odr_No_Main
		{
			get { return _odr_No_Main;}
			set 
			{ 
				_odr_No_Main = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"Odr_Seq="+this._odr_Seq+ ","+"Odr_Date="+this._odr_Date+ ","+"Odr_State="+this._odr_State+ ","+"Odr_Type="+this._odr_Type+ ","+"Jia_Name="+this._jia_Name+ ","+"Jia_FaRen="+this._jia_FaRen+ ","+"Jia_DaiLi="+this._jia_DaiLi+ ","+"Jia_Adress="+this._jia_Adress+ ","+"Jia_Phone="+this._jia_Phone+ ","+"Jia_Fax="+this._jia_Fax+ ","+"Yi_Name="+this._yi_Name+ ","+"Yi_FaRen="+this._yi_FaRen+ ","+"Yi_DaiLi="+this._yi_DaiLi+ ","+"Yi_Adress="+this._yi_Adress+ ","+"Yi_Phone="+this._yi_Phone+ ","+"Yi_Act_Name="+this._yi_Act_Name+ ","+"Yi_Bank_Name="+this._yi_Bank_Name+ ","+"Yi_Act_No="+this._yi_Act_No+ ","+"Yi_Tax_Code="+this._yi_Tax_Code+ ","+"Odr_Prt_Name="+this._odr_Prt_Name+ ","+"Odr_Sum_Area="+this._odr_Sum_Area+ ","+"Odr_Prt_Purpose="+this._odr_Prt_Purpose+ ","+"Odr_Trans_Party="+this._odr_Trans_Party+ ","+"Odr_Place_Linkman="+this._odr_Place_Linkman+ ","+"Odr_Bud_Palce="+this._odr_Bud_Palce+ ","+"Odr_Place_Phone="+this._odr_Place_Phone+ ","+"Odr_Ground_State="+this._odr_Ground_State+ ","+"Odr_Water_proof="+this._odr_Water_proof+ ","+"Odr_Fixed_Mode="+this._odr_Fixed_Mode+ ","+"Odr_Tax_Type="+this._odr_Tax_Type+ ","+"Let_Entry_Date="+this._let_Entry_Date+ ","+"Let_Bud_SDate="+this._let_Bud_SDate+ ","+"Let_Bud_EDate="+this._let_Bud_EDate+ ","+"Let_Use_SDate="+this._let_Use_SDate+ ","+"Let_Use_EDate="+this._let_Use_EDate+ ","+"Let_Rm_SDate="+this._let_Rm_SDate+ ","+"Let_Rm_EDate="+this._let_Rm_EDate+ ","+"Tot_Cost="+this._tot_Cost+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Col_Extend="+this._col_Extend+ ","+"Tmp_Id="+this._tmp_Id+ ","+"Tmp_Name="+this._tmp_Name+ ","+"Tmp_Explain="+this._tmp_Explain+ ","+"Odr_Bud_Party="+this._odr_Bud_Party+ ","+"Odr_No_Main="+this._odr_No_Main+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///合同追加的次数
		/// </summary>
		public const string Odr_Seq="Odr_Seq";
		/// <summary>
		///合同日期
		/// </summary>
		public const string Odr_Date="Odr_Date";
		/// <summary>
		///合同状态
		/// </summary>
		public const string Odr_State="Odr_State";
		/// <summary>
		///合同类型
		/// </summary>
		public const string Odr_Type="Odr_Type";
		/// <summary>
		///甲方(需方)
		/// </summary>
		public const string Jia_Name="Jia_Name";
		/// <summary>
		///甲方法人代表
		/// </summary>
		public const string Jia_FaRen="Jia_FaRen";
		/// <summary>
		///甲方委托代理人
		/// </summary>
		public const string Jia_DaiLi="Jia_DaiLi";
		/// <summary>
		///甲方地址
		/// </summary>
		public const string Jia_Adress="Jia_Adress";
		/// <summary>
		///甲方电话
		/// </summary>
		public const string Jia_Phone="Jia_Phone";
		/// <summary>
		///甲方传真
		/// </summary>
		public const string Jia_Fax="Jia_Fax";
		/// <summary>
		///乙方(供方）
		/// </summary>
		public const string Yi_Name="Yi_Name";
		/// <summary>
		///乙方法人代表
		/// </summary>
		public const string Yi_FaRen="Yi_FaRen";
		/// <summary>
		///乙方代理人
		/// </summary>
		public const string Yi_DaiLi="Yi_DaiLi";
		/// <summary>
		///乙方地址
		/// </summary>
		public const string Yi_Adress="Yi_Adress";
		/// <summary>
		///乙方电话
		/// </summary>
		public const string Yi_Phone="Yi_Phone";
		/// <summary>
		///乙方银行用户名
		/// </summary>
		public const string Yi_Act_Name="Yi_Act_Name";
		/// <summary>
		///乙方开户行
		/// </summary>
		public const string Yi_Bank_Name="Yi_Bank_Name";
		/// <summary>
		///乙方银行账号
		/// </summary>
		public const string Yi_Act_No="Yi_Act_No";
		/// <summary>
		///乙方纳税人识别码
		/// </summary>
		public const string Yi_Tax_Code="Yi_Tax_Code";
		/// <summary>
		///合同产品名称
		/// </summary>
		public const string Odr_Prt_Name="Odr_Prt_Name";
		/// <summary>
		///合同总面积
		/// </summary>
		public const string Odr_Sum_Area="Odr_Sum_Area";
		/// <summary>
		///产品用途
		/// </summary>
		public const string Odr_Prt_Purpose="Odr_Prt_Purpose";
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
		///合同税票
		/// </summary>
		public const string Odr_Tax_Type="Odr_Tax_Type";
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
		///合同总金额
		/// </summary>
		public const string Tot_Cost="Tot_Cost";
		/// <summary>
		///操作日期
		/// </summary>
		public const string Oper_Date="Oper_Date";
		/// <summary>
		///操作人
		/// </summary>
		public const string Oper_Code="Oper_Code";
		/// <summary>
		///变量字段
		/// </summary>
		public const string Col_Extend="Col_Extend";
		/// <summary>
		///模板Id
		/// </summary>
		public const string Tmp_Id="Tmp_Id";
		/// <summary>
		///模板名称
		/// </summary>
		public const string Tmp_Name="Tmp_Name";
		/// <summary>
		///模板说明
		/// </summary>
		public const string Tmp_Explain="Tmp_Explain";
		/// <summary>
		///搭建方
		/// </summary>
		public const string Odr_Bud_Party="Odr_Bud_Party";
		/// <summary>
		///主合同编码
		/// </summary>
		public const string Odr_No_Main="Odr_No_Main";
	}

	}

}
