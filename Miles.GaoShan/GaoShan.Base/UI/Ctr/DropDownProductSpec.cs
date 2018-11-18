using GaoShan.Sales.Model;
using Miles.Framework.UI.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public class DropDownProductSpec : DropDownComboBox, IDataBind
    {
        private UCDropDownSpec ucDropDownSpec;
        private Bu_ItemSpec itemSpec = null;
        public Bu_ItemSpec ItemSpec
        {
            get { return itemSpec; }
            set
            {
                itemSpec = value;
                if (itemSpec == null) { return; }
                this.SetDataSource(itemSpec.Items);
            }
        }

        public DropDownProductSpec() : base()
        {
            ucDropDownSpec = new UCDropDownSpec();

            this.DropDownSizeMode = SizeMode.UseControlSize;
            this.DropDownClosed += DropDownProductSpec_DropDownClosed;
        }

        private void DropDownProductSpec_DropDownClosed(object sender, EventArgs e)
        {
            this.ucDropDownSpec.EndEdit();
            UpdateItemSpec();
        }

        private void UpdateItemSpec()
        {
            itemSpec = new Bu_ItemSpec();
            itemSpec.AddItems(ucDropDownSpec.GetDataSource());
            this.Text = itemSpec.ToString();
        }

        public void SetDataSource(List<Model.Info_product_property> list)
        {
            this.Text = "";
            this.ucDropDownSpec.SetDataSource(list);
            this.DropDownControl = ucDropDownSpec;
            this.ControlSize = ucDropDownSpec.Size;

            UpdateItemSpec();
        }

        private string bindDatafield = "Item_Spec";
        [Browsable(true)]
        [Description("Bind DataField ")]
        [Category("DataBind")]
        public string BindDataField
        {
            get { return bindDatafield; }
            set { bindDatafield = value; }
        }

        [Browsable(true)]
        [Description("Bind DataText ")]
        [Category("DataBind")]
        public string BindDataText
        {
            get;
            set;
        }

        [Browsable(true)]
        [Description("Bind BindDataTag")]
        [Category("DataBind")]
        public string BindDataTag
        {
            get;
            set;
        }

        [Browsable(true)]
        [Description("ValidEmpty IsValid")]
        [Category("ValidEmpty")]
        public bool IsValid
        {
            get;
            set;
        }

        [Browsable(true)]
        [Description("ValidEmpty EmptyValue")]
        [Category("ValidEmpty")]
        public object EmptyValue
        {
            get;
            set;
        }

        [Browsable(true)]
        [Description("ValidEmpty ValidEmptyMsg")]
        [Category("ValidEmpty")]
        public string ValidEmptyMsg { get; set; }

        public virtual bool ValidIsEmpty()
        {
            return ucDropDownSpec.ValidIsEmpty();
        }

        public virtual void ClearBindValue()
        {
            this.Text = "";
            //ucDropDownSpec.ClearBindValue();
        }

        public virtual void SetDataBind(object dataSource)
        {
            if (IsSetBind && !string.IsNullOrEmpty(this.BindDataField))
            {
                Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;

                object value = memberAccessor.GetValue(dataSource, this.BindDataField);

                string jsonStr = value == null ? null : value.ToString();
                Bu_ItemSpec itemSpec = new Bu_ItemSpec();

                if (!string.IsNullOrEmpty(jsonStr))
                {
                    itemSpec = (Bu_ItemSpec)JsonConvert.DeserializeObject(jsonStr, typeof(Bu_ItemSpec));

                }
                this.ItemSpec = itemSpec;
            }
        }

        public virtual void GetDataBind(ref object dataSource)
        {
            if (IsGetBind && !string.IsNullOrEmpty(this.BindDataField))
            {
                Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;
                if (this.ItemSpec != null) {
                object value = Newtonsoft.Json.JsonConvert.SerializeObject(this.ItemSpec);
                memberAccessor.SetValue(dataSource, this.BindDataField, value);
            }
            }
        }

        public void SetReadOnly()
        {
            this.Enabled = false;
        }

        public void SetDataBind(Dictionary<string, object> dicSource)
        {
            throw new NotImplementedException();
        }

        public void GetDataBind(ref Dictionary<string, object> dicSource)
        {
            throw new NotImplementedException();
        }

        bool _IsGetBind = true;
        [Browsable(true)]
        [Description("Bind IsGetBind")]
        [Category("DataBind")]
        public bool IsGetBind { get { return _IsGetBind; } set { _IsGetBind = value; } }

        bool _IsSetBind = true;
        [Browsable(true)]
        [Description("Bind IsSetBind")]
        [Category("DataBind")]
        public bool IsSetBind { get { return _IsSetBind; } set { _IsSetBind = value; } }



    }
}
