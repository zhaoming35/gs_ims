using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_fin_order_gen","gaoshan_db")]
	[Serializable]
	public class Tb_fin_order_gen
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

		private DateTime _gen_Date;
		/// <summary>
		///制表时间
		/// </summary>
		[Description("制表时间")]
		[DataFieldAttribute("gen_Date", "datetime", "制表时间")]
		public DateTime Gen_Date
		{
			get { return _gen_Date;}
			set 
			{ 
				_gen_Date = value;
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

		private decimal _tot_Cost;
		/// <summary>
		///合同成交金额
		/// </summary>
		[Description("合同成交金额")]
		[DataFieldAttribute("tot_Cost", "decimal", "合同成交金额")]
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

		private DateTime _deliver_Date;
		/// <summary>
		///提货时间
		/// </summary>
		[Description("提货时间")]
		[DataFieldAttribute("deliver_Date", "datetime", "提货时间")]
		public DateTime Deliver_Date
		{
			get { return _deliver_Date;}
			set 
			{ 
				_deliver_Date = value;
			}
		}

		private string _supplier_Info;
		/// <summary>
		///供货方信息
		/// </summary>
		[Description("供货方信息")]
		[DataFieldAttribute("supplier_Info", "varchar", "供货方信息")]
		public string Supplier_Info
		{
			get { return _supplier_Info;}
			set 
			{ 
				_supplier_Info = value;
			}
		}

		private string _remark;
		/// <summary>
		///备注
		/// </summary>
		[Description("备注")]
		[DataFieldAttribute("remark", "varchar", "备注")]
		public string Remark
		{
			get { return _remark;}
			set 
			{ 
				_remark = value;
			}
		}

		private decimal _odr_Cost;
		/// <summary>
		///合同金额
		/// </summary>
		[Description("合同金额")]
		[DataFieldAttribute("odr_Cost", "decimal", "合同金额")]
		public decimal Odr_Cost
		{
			get { return _odr_Cost;}
			set 
			{ 
				_odr_Cost = value;
			}
		}

		private decimal _part_Cost;
		/// <summary>
		///配套金额
		/// </summary>
		[Description("配套金额")]
		[DataFieldAttribute("part_Cost", "decimal", "配套金额")]
		public decimal Part_Cost
		{
			get { return _part_Cost;}
			set 
			{ 
				_part_Cost = value;
			}
		}

		private decimal _sales_Cost;
		/// <summary>
		///销售费用
		/// </summary>
		[Description("销售费用")]
		[DataFieldAttribute("sales_Cost", "decimal", "销售费用")]
		public decimal Sales_Cost
		{
			get { return _sales_Cost;}
			set 
			{ 
				_sales_Cost = value;
			}
		}

		private decimal _tax_Cost;
		/// <summary>
		///税费
		/// </summary>
		[Description("税费")]
		[DataFieldAttribute("tax_Cost", "decimal", "税费")]
		public decimal Tax_Cost
		{
			get { return _tax_Cost;}
			set 
			{ 
				_tax_Cost = value;
			}
		}

		private string _employ_Code;
		/// <summary>
		///业务员
		/// </summary>
		[Description("业务员")]
		[DataFieldAttribute("employ_Code", "varchar", "业务员")]
		public string Employ_Code
		{
			get { return _employ_Code;}
			set 
			{ 
				_employ_Code = value;
			}
		}

		private int _gen_State;
		/// <summary>
		///合同摘要状态
		/// </summary>
		[Description("合同摘要状态")]
		[DataFieldAttribute("gen_State", "int", "合同摘要状态")]
		public int Gen_State
		{
			get { return _gen_State;}
			set 
			{ 
				_gen_State = value;
			}
		}

		private decimal _pay_Cost;
		/// <summary>
		///已经支付的金额
		/// </summary>
		[Description("已经支付的金额")]
		[DataFieldAttribute("pay_Cost", "decimal", "已经支付的金额")]
		public decimal Pay_Cost
		{
			get { return _pay_Cost;}
			set 
			{ 
				_pay_Cost = value;
			}
		}

		private int _is_Salary;
		/// <summary>
		///是否计算提成了
		/// </summary>
		[Description("是否计算提成了")]
		[DataFieldAttribute("is_Salary", "int", "是否计算提成了")]
		public int Is_Salary
		{
			get { return _is_Salary;}
			set 
			{ 
				_is_Salary = value;
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

		private decimal _rent_Cost;
		/// <summary>
		///外租金
		/// </summary>
		[Description("外租金")]
		[DataFieldAttribute("rent_Cost", "decimal", "外租金")]
		public decimal Rent_Cost
		{
			get { return _rent_Cost;}
			set 
			{ 
				_rent_Cost = value;
			}
		}

		private decimal _discount_Cost;
		/// <summary>
		///优惠金额
		/// </summary>
		[Description("优惠金额")]
		[DataFieldAttribute("discount_Cost", "decimal", "优惠金额")]
		public decimal Discount_Cost
		{
			get { return _discount_Cost;}
			set 
			{ 
				_discount_Cost = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Odr_No="+this._odr_No+ ","+"Gen_Date="+this._gen_Date+ ","+"Odr_Type="+this._odr_Type+ ","+"Jia_Name="+this._jia_Name+ ","+"Jia_Adress="+this._jia_Adress+ ","+"Jia_Phone="+this._jia_Phone+ ","+"Jia_Fax="+this._jia_Fax+ ","+"Odr_Prt_Name="+this._odr_Prt_Name+ ","+"Odr_Sum_Area="+this._odr_Sum_Area+ ","+"Odr_Prt_Purpose="+this._odr_Prt_Purpose+ ","+"Odr_Trans_Party="+this._odr_Trans_Party+ ","+"Odr_Place_Linkman="+this._odr_Place_Linkman+ ","+"Odr_Bud_Palce="+this._odr_Bud_Palce+ ","+"Odr_Place_Phone="+this._odr_Place_Phone+ ","+"Odr_Ground_State="+this._odr_Ground_State+ ","+"Odr_Water_proof="+this._odr_Water_proof+ ","+"Odr_Fixed_Mode="+this._odr_Fixed_Mode+ ","+"Odr_Tax_Type="+this._odr_Tax_Type+ ","+"Tot_Cost="+this._tot_Cost+ ","+"Oper_Date="+this._oper_Date+ ","+"Oper_Code="+this._oper_Code+ ","+"Deliver_Date="+this._deliver_Date+ ","+"Supplier_Info="+this._supplier_Info+ ","+"Remark="+this._remark+ ","+"Odr_Cost="+this._odr_Cost+ ","+"Part_Cost="+this._part_Cost+ ","+"Sales_Cost="+this._sales_Cost+ ","+"Tax_Cost="+this._tax_Cost+ ","+"Employ_Code="+this._employ_Code+ ","+"Gen_State="+this._gen_State+ ","+"Pay_Cost="+this._pay_Cost+ ","+"Is_Salary="+this._is_Salary+ ","+"Odr_No_Main="+this._odr_No_Main+ ","+"Rent_Cost="+this._rent_Cost+ ","+"Discount_Cost="+this._discount_Cost+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///合同编码
		/// </summary>
		public const string Odr_No="Odr_No";
		/// <summary>
		///制表时间
		/// </summary>
		public const string Gen_Date="Gen_Date";
		/// <summary>
		///合同类型
		/// </summary>
		public const string Odr_Type="Odr_Type";
		/// <summary>
		///甲方(需方)
		/// </summary>
		public const string Jia_Name="Jia_Name";
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
		///合同成交金额
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
		///提货时间
		/// </summary>
		public const string Deliver_Date="Deliver_Date";
		/// <summary>
		///供货方信息
		/// </summary>
		public const string Supplier_Info="Supplier_Info";
		/// <summary>
		///备注
		/// </summary>
		public const string Remark="Remark";
		/// <summary>
		///合同金额
		/// </summary>
		public const string Odr_Cost="Odr_Cost";
		/// <summary>
		///配套金额
		/// </summary>
		public const string Part_Cost="Part_Cost";
		/// <summary>
		///销售费用
		/// </summary>
		public const string Sales_Cost="Sales_Cost";
		/// <summary>
		///税费
		/// </summary>
		public const string Tax_Cost="Tax_Cost";
		/// <summary>
		///业务员
		/// </summary>
		public const string Employ_Code="Employ_Code";
		/// <summary>
		///合同摘要状态
		/// </summary>
		public const string Gen_State="Gen_State";
		/// <summary>
		///已经支付的金额
		/// </summary>
		public const string Pay_Cost="Pay_Cost";
		/// <summary>
		///是否计算提成了
		/// </summary>
		public const string Is_Salary="Is_Salary";
		/// <summary>
		///主合同编码
		/// </summary>
		public const string Odr_No_Main="Odr_No_Main";
		/// <summary>
		///外租金
		/// </summary>
		public const string Rent_Cost="Rent_Cost";
		/// <summary>
		///优惠金额
		/// </summary>
		public const string Discount_Cost="Discount_Cost";
	}

	}

}
