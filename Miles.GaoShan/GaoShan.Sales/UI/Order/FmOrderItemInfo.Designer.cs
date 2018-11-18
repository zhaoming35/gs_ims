namespace GaoShan.Sales.UI.Order
{
    partial class FmOrderItemInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.lblType = new System.Windows.Forms.Label();
            this.d_ProductType = new Miles.Framework.UI.Controls.MTextInput();
            this.cmbProductInfo1 = new GaoShan.Sales.UI.Ctr.CmbProductInfo();
            this.dropDownProductSpec1 = new GaoShan.Sales.UI.Ctr.DropDownProductSpec();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.dropDownProductSpec1);
            this.panelClient.Controls.Add(this.d_ProductType);
            this.panelClient.Controls.Add(this.lblType);
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.cmbProductInfo1);
            this.panelClient.Controls.Add(this.label34);
            this.panelClient.Size = new System.Drawing.Size(404, 179);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(24, 27);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 16);
            this.label34.TabIndex = 69;
            this.label34.Text = "产品名称：";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "产品数量：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "Product_Count";
            this.mDecimalInput1.BindDataTag = null;
            this.mDecimalInput1.BindDataText = null;
            this.mDecimalInput1.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput1.IsGetBind = true;
            this.mDecimalInput1.IsSetBind = true;
            this.mDecimalInput1.IsValid = true;
            this.mDecimalInput1.Location = new System.Drawing.Point(119, 130);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(186, 21);
            this.mDecimalInput1.TabIndex = 73;
            this.mDecimalInput1.ValidEmptyMsg = "产品数量不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(24, 62);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(93, 16);
            this.lblType.TabIndex = 74;
            this.lblType.Text = "产品型号：";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // d_ProductType
            // 
            this.d_ProductType.BindDataField = "item_Type";
            this.d_ProductType.BindDataTag = null;
            this.d_ProductType.BindDataText = null;
            this.d_ProductType.EmptyValue = null;
            this.d_ProductType.IsGetBind = true;
            this.d_ProductType.IsSetBind = true;
            this.d_ProductType.IsValid = false;
            this.d_ProductType.Location = new System.Drawing.Point(119, 60);
            this.d_ProductType.Name = "d_ProductType";
            this.d_ProductType.Size = new System.Drawing.Size(186, 21);
            this.d_ProductType.TabIndex = 75;
            this.d_ProductType.ValidEmptyMsg = null;
            // 
            // cmbProductInfo1
            // 
            this.cmbProductInfo1.BindDataField = "";
            this.cmbProductInfo1.BindDataTag = null;
            this.cmbProductInfo1.BindDataText = "product_Name";
            this.cmbProductInfo1.EmptyValue = null;
            this.cmbProductInfo1.IsGetBind = true;
            this.cmbProductInfo1.IsSetBind = true;
            this.cmbProductInfo1.IsValid = true;
            this.cmbProductInfo1.Location = new System.Drawing.Point(119, 25);
            this.cmbProductInfo1.Name = "cmbProductInfo1";
            this.cmbProductInfo1.Size = new System.Drawing.Size(186, 20);
            this.cmbProductInfo1.TabIndex = 70;
            this.cmbProductInfo1.ValidEmptyMsg = "产品名称不能为空";
            // 
            // dropDownProductSpec1
            // 
            this.dropDownProductSpec1.AllowResizeDropDown = true;
            this.dropDownProductSpec1.ControlSize = new System.Drawing.Size(1, 1);
            this.dropDownProductSpec1.DropDownControl = null;
            this.dropDownProductSpec1.DropDownSizeMode = Miles.Framework.UI.Controls.DropDownComboBox.SizeMode.UseControlSize;
            this.dropDownProductSpec1.DropSize = new System.Drawing.Size(121, 106);
            this.dropDownProductSpec1.FormattingEnabled = true;
            this.dropDownProductSpec1.Location = new System.Drawing.Point(119, 95);
            this.dropDownProductSpec1.Name = "dropDownProductSpec1";
            this.dropDownProductSpec1.Size = new System.Drawing.Size(259, 20);
            this.dropDownProductSpec1.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "产品规格：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FmOrderItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 226);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmOrderItemInfo";
            this.Text = "产品信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label34;
        private Ctr.CmbProductInfo cmbProductInfo1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput d_ProductType;
        private System.Windows.Forms.Label lblType;
        private Ctr.DropDownProductSpec dropDownProductSpec1;
        private System.Windows.Forms.Label label2;
    }
}