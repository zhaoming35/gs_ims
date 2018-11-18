using System;
using System.Collections.Generic;
using System.Text;
using Miles.Coro.ORM;

namespace Miles.App.Entity.Model
{
    [TableAttribute("tb_enum", "gaoshan_db")]
    [Serializable]
    public class Tb_enum
    {

        //自动生成属性
        private long _item_Id;
        /// <summary>
        ///
        /// </summary>
        [DataFieldAttribute("item_Id", "bigint", "")]
        public long Item_Id
        {
            get { return _item_Id; }
            set
            {
                _item_Id = value;
            }
        }

        private string _enum_Kind;
        /// <summary>
        ///
        /// </summary>
        [DataFieldAttribute("enum_Kind", "varchar", "")]
        public string Enum_Kind
        {
            get { return _enum_Kind; }
            set
            {
                _enum_Kind = value;
            }
        }

        private decimal _enum_Value;
        /// <summary>
        ///
        /// </summary>
        [DataFieldAttribute("enum_Value", "decimal", "")]
        public decimal Enum_Value
        {
            get { return _enum_Value; }
            set
            {
                _enum_Value = value;
            }
        }

        private string _enum_Text;
        /// <summary>
        ///
        /// </summary>
        [DataFieldAttribute("enum_Text", "varchar", "")]
        public string Enum_Text
        {
            get { return _enum_Text; }
            set
            {
                _enum_Text = value;
            }
        }

        private int _item_Flag;
        /// <summary>
        ///1为大类，0为子项
        /// </summary>
        [DataFieldAttribute("item_Flag", "int", "1为大类，0为子项")]
        public int Item_Flag
        {
            get { return _item_Flag; }
            set
            {
                _item_Flag = value;
            }
        }

        //自动生成ToString方法
        public override string ToString()
        {
            return "[" + "Item_Id=" + this._item_Id + "," + "Enum_Kind=" + this._enum_Kind + "," + "Enum_Value=" + this._enum_Value + "," + "Enum_Text=" + this._enum_Text + "," + "Item_Flag=" + this._item_Flag + "]";
        }

        public class Table
        {

            //自动生成静态属性名称
            /// <summary>
            ///
            /// </summary>
            public const string Item_Id = "Item_Id";
            /// <summary>
            ///
            /// </summary>
            public const string Enum_Kind = "Enum_Kind";
            /// <summary>
            ///
            /// </summary>
            public const string Enum_Value = "Enum_Value";
            /// <summary>
            ///
            /// </summary>
            public const string Enum_Text = "Enum_Text";
            /// <summary>
            ///1为大类，0为子项
            /// </summary>
            public const string Item_Flag = "Item_Flag";
        }

    }

}
