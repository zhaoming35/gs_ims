using GaoShan.Sales.Model;
using Miles.Framework.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Sales.UI.Ctr
{
    public class DropDownSteelDrill : DropDownComboBox, IDataBind
    {
        private UCSteelDrill ucSteelDrill = null;
        private Model.Bu_SteelDrill steelDrill;
        public Model.Bu_SteelDrill SteelDrill { get { return steelDrill; } }

        public DropDownSteelDrill() : base()
        {
            ucSteelDrill = new UCSteelDrill();
            ucSteelDrill.Size = new System.Drawing.Size(235, 90);
            this.AllowResizeDropDown = false;
            this.DropDownSizeMode = SizeMode.UseControlSize;
            this.DropDownClosed += DropDownProductSpec_DropDownClosed;
            this.Text = "";
            this.DropDownControl = ucSteelDrill;
            this.ControlSize = ucSteelDrill.Size;
        }

        private void DropDownProductSpec_DropDownClosed(object sender, EventArgs e)
        {
            UpdateItemSpec();
        }

        private void UpdateItemSpec()
        {
            steelDrill = ucSteelDrill.GetDataSource();
            this.Text = steelDrill.ToString();
        }

        public void SetDataSource(Bu_SteelDrill info)
        {
            steelDrill = info;
            this.ucSteelDrill.SetDataBind(info);
            UpdateItemSpec();
        }



        [Browsable(true)]
        [Description("Bind DataField ")]
        [Category("DataBind")]
        public string BindDataField
        {
            get;
            set;
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
            return true;// ucSteelDrill.ValidIsEmpty();
        }

        public virtual void ClearBindValue()
        {
            this.Text = "";
            ucSteelDrill.ClearBindValue();
        }

        public virtual void SetDataBind(object dataSource)
        {
            if (IsSetBind && !string.IsNullOrEmpty(this.BindDataField))
            {
                Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;

                object value = memberAccessor.GetValue(dataSource, this.BindDataField);

                string jsonStr = value == null ? null : value.ToString();

                Bu_SteelDrill gutterInfo = new Bu_SteelDrill();
                if (!string.IsNullOrEmpty(jsonStr))
                {
                    gutterInfo = (Bu_SteelDrill)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStr, typeof(Bu_SteelDrill));

                }
                this.SetDataSource(gutterInfo);
            }
        }

        public virtual void GetDataBind(ref object dataSource)
        {
            if (IsGetBind && !string.IsNullOrEmpty(this.BindDataField))
            {
                Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;

                if (this.SteelDrill != null)
                {
                    object value = Newtonsoft.Json.JsonConvert.SerializeObject(this.SteelDrill);
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
