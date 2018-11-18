using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_send_sms_info","gaoshan_db")]
	[Serializable]
	public class Tb_send_sms_info
	{

		//自动生成属性
		private string _company_Phone;
		/// <summary>
		///监督电话
		/// </summary>
		[Description("监督电话")]
		[DataFieldAttribute("company_Phone", "varchar", "监督电话")]
		public string Company_Phone
		{
			get { return _company_Phone;}
			set 
			{ 
				_company_Phone = value;
			}
		}

		private string _sms_user;
		/// <summary>
		///发送短信用户
		/// </summary>
		[Description("发送短信用户")]
		[DataFieldAttribute("sms_user", "varchar", "发送短信用户")]
		public string Sms_user
		{
			get { return _sms_user;}
			set 
			{ 
				_sms_user = value;
			}
		}

		private string _sms_password;
		/// <summary>
		///发送短信密码
		/// </summary>
		[Description("发送短信密码")]
		[DataFieldAttribute("sms_password", "varchar", "发送短信密码")]
		public string Sms_password
		{
			get { return _sms_password;}
			set 
			{ 
				_sms_password = value;
			}
		}

		private string _sms_content;
		/// <summary>
		///发送内容
		/// </summary>
		[Description("发送内容")]
		[DataFieldAttribute("sms_content", "varchar", "发送内容")]
		public string Sms_content
		{
			get { return _sms_content;}
			set 
			{ 
				_sms_content = value;
			}
		}

		private string _sms_Url;
		/// <summary>
		///发送短信Url
		/// </summary>
		[Description("发送短信Url")]
		[DataFieldAttribute("sms_Url", "varchar", "发送短信Url")]
		public string Sms_Url
		{
			get { return _sms_Url;}
			set 
			{ 
				_sms_Url = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Company_Phone="+this._company_Phone+ ","+"Sms_user="+this._sms_user+ ","+"Sms_password="+this._sms_password+ ","+"Sms_content="+this._sms_content+ ","+"Sms_Url="+this._sms_Url+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///监督电话
		/// </summary>
		public const string Company_Phone="Company_Phone";
		/// <summary>
		///发送短信用户
		/// </summary>
		public const string Sms_user="Sms_user";
		/// <summary>
		///发送短信密码
		/// </summary>
		public const string Sms_password="Sms_password";
		/// <summary>
		///发送内容
		/// </summary>
		public const string Sms_content="Sms_content";
		/// <summary>
		///发送短信Url
		/// </summary>
		public const string Sms_Url="Sms_Url";
	}

	}

}
