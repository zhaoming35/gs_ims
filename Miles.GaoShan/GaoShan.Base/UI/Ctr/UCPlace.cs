using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaoShan.Sales.Model;
using Miles.Framework.UI.Controls;

namespace GaoShan.Sales.UI.Ctr
{
    public partial class UCPlace : UC.UCBase, IDataBind
    {
        public Info_place_info PlaceInfo
        {
            get
            {
                Model.Info_place_info placeInfo = this.dataSource as Model.Info_place_info;
                return placeInfo;
            }
        }
        public UCPlace()
        {
            InitializeComponent();
            this.cmbTransPlace1.SelectItemEvent += CmbTransPlace1_SelectItemEvent;
            this.cmbTransPlace2.SelectItemEvent += CmbTransPlace2_SelectItemEvent;
            this.cmbTransPlace3.SelectItemEvent += CmbTransPlace3_SelectItemEvent;
            this.mTextInput2.TextChanged += MTextInput2_TextChanged;
            this.btnSaveDefault.Click += BtnSaveDefault_Click;
            this.btnUseDefault.Click += BtnUseDefault_Click;
        }

        private void CmbTransPlace1_SelectItemEvent(object obj)
        {
            if (cmbTransPlace1.SelectKey == null) { return; }

            long placeId = (long)cmbTransPlace1.SelectKey;
            cmbTransPlace2.LoadData(placeId);
        }

        private void CmbTransPlace2_SelectItemEvent(object obj)
        {
            if (cmbTransPlace2.SelectKey == null) { return; }
            long placeId = (long)cmbTransPlace2.SelectKey;
            cmbTransPlace3.LoadData(placeId);
        }

        private void CmbTransPlace3_SelectItemEvent(object obj)
        {
            if (cmbTransPlace3.SelectKey == null) { return; }
            Model.Info_place_info placeInfo = cmbTransPlace3.SelectedItem as Model.Info_place_info;
            SetCurrentValue(placeInfo);
        }

        protected override void LazyInit()
        {
            cmbTransPlace1.LoadData(0);
        }

        Logic.DefaultAdressManager defaultAdressManager = new Logic.DefaultAdressManager();
        private void BtnUseDefault_Click(object sender, EventArgs e)
        {
            Model.Tb_default_adress info = defaultAdressManager.FindThe();
            if (info == null) { return; }
            Info_place_info placeInfo = Cache.LogicCache.DicPlaces[info.Place_Id];
            placeInfo.DetailAdress = info.Detail_Adress;

            SetDataSource(placeInfo);
        }

        private void BtnSaveDefault_Click(object sender, EventArgs e)
        {
            if (ValidIsEmpty()) { return; }

            Model.Tb_default_adress info = new Tb_default_adress();
            info.Place_Id = this.PlaceInfo.Place_Id;
            info.Detail_Adress = this.PlaceInfo.DetailAdress;

            if (defaultAdressManager.Save(info))
            {
                Miles.Framework.UI.Function.MForm.SetToolTip(this.btnSaveDefault, "默认地址保存成功", 1000);
            }
        }


        private void SetCurrentValue(Info_place_info placeInfo)
        {
            base.SetDataSource(placeInfo);
            this.selectValue = placeInfo;
        }

        private void MTextInput2_TextChanged(object sender, EventArgs e)
        {
            if (this.dataSource == null) { return; }
            Model.Info_place_info placeInfo = this.dataSource as Model.Info_place_info;
            placeInfo.DetailAdress = mTextInput2.Text;
        }

        public override void SetDataSource(object dataSource)
        {
            if (!IsLazyInit) { LazyInit(); lazyInit = true; }

            Model.Info_place_info info = dataSource as Model.Info_place_info;
            SetCurrentValue(info);
            //oldPlaceInfo = info;
            this.cmbTransPlace1.SetKeyValue(info.Parent.Parent.Place_Id);
            this.cmbTransPlace2.SetKeyValue(info.Parent.Place_Id);
            this.cmbTransPlace3.SetKeyValue(info.Place_Id);
            mTextInput2.Text = info.DetailAdress;
            //base.SetDataBind(dataSource);
        }

        #region 绑定
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
            if (this.dataSource == null) { return true; }
            Model.Info_place_info placeInfo = this.dataSource as Model.Info_place_info;

            if (string.IsNullOrEmpty(placeInfo.DetailAdress)) { return true; }

            return false;
        }

        public override void ClearBindValue()
        {
            this.cmbTransPlace3.Text = "";
            this.cmbTransPlace2.Text = "";
            this.cmbTransPlace1.Text = "";
        }

        public override void SetDataBind(object dataSource)
        {
            if (IsSetBind && !string.IsNullOrEmpty(this.BindDataField))
            {
                Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;

                object valueId = memberAccessor.GetValue(dataSource, this.BindDataField);

                object valueDetail = memberAccessor.GetValue(dataSource, this.BindDataText);

                if (!Cache.LogicCache.DicPlaces.ContainsKey((long)valueId)) { return; }

                Model.Info_place_info placeInfo = Cache.LogicCache.DicPlaces[(long)valueId];
                placeInfo.DetailAdress = valueDetail.ToString();

                this.SetDataSource(placeInfo);
            }
        }

        public void GetDataBind(ref object dataSource)
        {
            if (IsGetBind && !string.IsNullOrEmpty(this.BindDataField))
            {
                Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor memberAccessor = Miles.Coro.Common.MemberAccessor.DelegatedExpressionMemberAccessor.Instance;
                if (this.PlaceInfo != null)
                {
                    memberAccessor.SetValue(dataSource, this.BindDataText, this.PlaceInfo.DetailAdress);
                    memberAccessor.SetValue(dataSource, this.BindDataField, this.PlaceInfo.Place_Id);
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
        #endregion


    }
}
