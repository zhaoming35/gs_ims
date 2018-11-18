namespace GaoShan.Sales.Com.UI
{
    partial class FmProductInfo
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
            this.d_ProductName = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.d_ProductUnit = new Miles.Framework.UI.Controls.MTextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.d_ProductUnit);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_ProductName);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(344, 128);
            // 
            // d_ProductName
            // 
            this.d_ProductName.BindDataField = "product_Name";
            this.d_ProductName.BindDataTag = null;
            this.d_ProductName.BindDataText = null;
            this.d_ProductName.EmptyValue = null;
            this.d_ProductName.IsGetBind = true;
            this.d_ProductName.IsSetBind = true;
            this.d_ProductName.IsValid = false;
            this.d_ProductName.Location = new System.Drawing.Point(125, 11);
            this.d_ProductName.Name = "d_ProductName";
            this.d_ProductName.Size = new System.Drawing.Size(179, 26);
            this.d_ProductName.TabIndex = 74;
            this.d_ProductName.ValidEmptyMsg = null;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(38, 16);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 75;
            this.label20.Text = "产品名称：";
            // 
            // d_ProductUnit
            // 
            this.d_ProductUnit.BindDataField = "product_Unit";
            this.d_ProductUnit.BindDataTag = null;
            this.d_ProductUnit.BindDataText = null;
            this.d_ProductUnit.EmptyValue = null;
            this.d_ProductUnit.IsGetBind = true;
            this.d_ProductUnit.IsSetBind = true;
            this.d_ProductUnit.IsValid = false;
            this.d_ProductUnit.Location = new System.Drawing.Point(125, 48);
            this.d_ProductUnit.Name = "d_ProductUnit";
            this.d_ProductUnit.Size = new System.Drawing.Size(179, 26);
            this.d_ProductUnit.TabIndex = 76;
            this.d_ProductUnit.ValidEmptyMsg = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "产品单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "产品序号：";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "seq_No";
            this.mDecimalInput1.BindDataTag = null;
            this.mDecimalInput1.BindDataText = null;
            this.mDecimalInput1.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput1.IsGetBind = true;
            this.mDecimalInput1.IsSetBind = true;
            this.mDecimalInput1.IsValid = false;
            this.mDecimalInput1.Location = new System.Drawing.Point(125, 85);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(179, 26);
            this.mDecimalInput1.TabIndex = 79;
            this.mDecimalInput1.ValidEmptyMsg = null;
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FmProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 175);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmProductInfo";
            this.Text = "产品信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_ProductUnit;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput d_ProductName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
    }
}