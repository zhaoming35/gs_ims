using System;
using System.Collections.Generic;
using System.Text;
using Miles.Coro.ORM;

namespace GaoShan.Sales.Model
{
	[TableAttribute("tb_tmp_part","gaoshan_db")]
	[Serializable]
	public class Tb_tmp_part
	{

		//自动生成属性
		private long _part_Id;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("part_Id", "bigint", "")]
		public long Part_Id
		{
			get { return _part_Id;}
			set 
			{ 
				_part_Id = value;
			}
		}

		private string _part_Name;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("part_Name", "varchar", "")]
		public string Part_Name
		{
			get { return _part_Name;}
			set 
			{ 
				_part_Name = value;
			}
		}

		private long _tmp_Id;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("tmp_Id", "bigint", "")]
		public long Tmp_Id
		{
			get { return _tmp_Id;}
			set 
			{ 
				_tmp_Id = value;
			}
		}

		private string _part_Explain;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("part_Explain", "varchar", "")]
		public string Part_Explain
		{
			get { return _part_Explain;}
			set 
			{ 
				_part_Explain = value;
			}
		}

		private byte[] _part_File;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("part_File", "image", "")]
		public byte[] Part_File
		{
			get { return _part_File;}
			set 
			{ 
				_part_File = value;
			}
		}

		private decimal _part_Seq;
		/// <summary>
		///
		/// </summary>
		[DataFieldAttribute("part_Seq", "decimal", "")]
		public decimal Part_Seq
		{
			get { return _part_Seq;}
			set 
			{ 
				_part_Seq = value;
			}
		}

		//自动生成ToString方法
		public override string ToString()
		{
			return "["+"Part_Id="+this._part_Id+ ","+"Part_Name="+this._part_Name+ ","+"Tmp_Id="+this._tmp_Id+ ","+"Part_Explain="+this._part_Explain+ ","+"Part_File="+this._part_File+ ","+"Part_Seq="+this._part_Seq+"]";
		}

	public class Table
	{

		//自动生成静态属性名称
		/// <summary>
		///
		/// </summary>
		public const string Part_Id="Part_Id";
		/// <summary>
		///
		/// </summary>
		public const string Part_Name="Part_Name";
		/// <summary>
		///
		/// </summary>
		public const string Tmp_Id="Tmp_Id";
		/// <summary>
		///
		/// </summary>
		public const string Part_Explain="Part_Explain";
		/// <summary>
		///
		/// </summary>
		public const string Part_File="Part_File";
		/// <summary>
		///
		/// </summary>
		public const string Part_Seq="Part_Seq";
	}

	}

}
