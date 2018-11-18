namespace GaoShan.Sales.Com.UI
{
    partial class FmAccountInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.d_actName = new Miles.Framework.UI.Controls.MTextInput();
            this.d_Remark = new Miles.Framework.UI.Controls.MTextInput();
            this.d_Enable = new Miles.Framework.UI.Controls.MCheckBox();
            this.d_actPhone = new Miles.Framework.UI.Controls.MTextInput();
            this.d_actFaRen = new Miles.Framework.UI.Controls.MTextInput();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.d_payActName = new Miles.Framework.UI.Controls.MTextInput();
            this.d_actAdress = new Miles.Framework.UI.Controls.MTextInput();
            this.label6 = new System.Windows.Forms.Label();
            this.d_DefineCode = new Miles.Framework.UI.Controls.MTextInput();
            this.label7 = new System.Windows.Forms.Label();
            this.d_payTaxCode = new Miles.Framework.UI.Controls.MTextInput();
            this.label5 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_payTaxCode);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Controls.Add(this.d_actName);
            this.panelClient.Controls.Add(this.d_DefineCode);
            this.panelClient.Controls.Add(this.label7);
            this.panelClient.Controls.Add(this.d_actAdress);
            this.panelClient.Controls.Add(this.label6);
            this.panelClient.Controls.Add(this.d_payActName);
            this.panelClient.Controls.Add(this.d_actPhone);
            this.panelClient.Controls.Add(this.d_actFaRen);
            this.panelClient.Controls.Add(this.label16);
            this.panelClient.Controls.Add(this.label19);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Controls.Add(this.d_Enable);
            this.panelClient.Controls.Add(this.d_Remark);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(796, 231);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(69, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "备注：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "内部名称：";
            // 
            // d_actName
            // 
            this.d_actName.BindDataField = "act_Name";
            this.d_actName.BindDataTag = null;
            this.d_actName.BindDataText = null;
            this.d_actName.EmptyValue = null;
            this.d_actName.IsGetBind = true;
            this.d_actName.IsSetBind = true;
            this.d_actName.IsValid = true;
            this.d_actName.Location = new System.Drawing.Point(120, 58);
            this.d_actName.Name = "d_actName";
            this.d_actName.Size = new System.Drawing.Size(339, 26);
            this.d_actName.TabIndex = 67;
            this.d_actName.ValidEmptyMsg = null;
            // 
            // d_Remark
            // 
            this.d_Remark.BindDataField = "remark";
            this.d_Remark.BindDataTag = null;
            this.d_Remark.BindDataText = null;
            this.d_Remark.EmptyValue = null;
            this.d_Remark.IsGetBind = true;
            this.d_Remark.IsSetBind = true;
            this.d_Remark.IsValid = false;
            this.d_Remark.Location = new System.Drawing.Point(120, 150);
            this.d_Remark.Name = "d_Remark";
            this.d_Remark.Size = new System.Drawing.Size(339, 26);
            this.d_Remark.TabIndex = 70;
            this.d_Remark.ValidEmptyMsg = null;
            // 
            // d_Enable
            // 
            this.d_Enable.AutoSize = true;
            this.d_Enable.BindDataField = "valid_Flag";
            this.d_Enable.BindDataTag = null;
            this.d_Enable.BindDataText = null;
            this.d_Enable.Checked = true;
            this.d_Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.d_Enable.EmptyValue = null;
            this.d_Enable.IsGetBind = true;
            this.d_Enable.IsSetBind = true;
            this.d_Enable.IsValid = false;
            this.d_Enable.Location = new System.Drawing.Point(112, 188);
            this.d_Enable.Name = "d_Enable";
            this.d_Enable.Size = new System.Drawing.Size(59, 20);
            this.d_Enable.TabIndex = 71;
            this.d_Enable.Text = "可用";
            this.d_Enable.UseVisualStyleBackColor = true;
            this.d_Enable.ValidEmptyMsg = null;
            // 
            // d_actPhone
            // 
            this.d_actPhone.BindDataField = "act_Phone";
            this.d_actPhone.BindDataTag = null;
            this.d_actPhone.BindDataText = null;
            this.d_actPhone.EmptyValue = null;
            this.d_actPhone.IsGetBind = true;
            this.d_actPhone.IsSetBind = true;
            this.d_actPhone.IsValid = true;
            this.d_actPhone.Location = new System.Drawing.Point(570, 58);
            this.d_actPhone.Margin = new System.Windows.Forms.Padding(4);
            this.d_actPhone.Name = "d_actPhone";
            this.d_actPhone.Size = new System.Drawing.Size(199, 26);
            this.d_actPhone.TabIndex = 83;
            this.d_actPhone.ValidEmptyMsg = null;
            // 
            // d_actFaRen
            // 
            this.d_actFaRen.BindDataField = "act_FaRen";
            this.d_actFaRen.BindDataTag = null;
            this.d_actFaRen.BindDataText = null;
            this.d_actFaRen.EmptyValue = null;
            this.d_actFaRen.IsGetBind = true;
            this.d_actFaRen.IsSetBind = true;
            this.d_actFaRen.IsValid = true;
            this.d_actFaRen.Location = new System.Drawing.Point(570, 12);
            this.d_actFaRen.Margin = new System.Windows.Forms.Padding(4);
            this.d_actFaRen.Name = "d_actFaRen";
            this.d_actFaRen.Size = new System.Drawing.Size(199, 26);
            this.d_actFaRen.TabIndex = 79;
            this.d_actFaRen.ValidEmptyMsg = null;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(523, 63);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "电话：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(475, 17);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 74;
            this.label19.Text = "法人代表人：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(21, 63);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 16);
            this.label20.TabIndex = 73;
            this.label20.Text = "名称(供方)：";
            // 
            // d_payActName
            // 
            this.d_payActName.BindDataField = "define_Name";
            this.d_payActName.BindDataTag = null;
            this.d_payActName.BindDataText = null;
            this.d_payActName.EmptyValue = null;
            this.d_payActName.IsGetBind = true;
            this.d_payActName.IsSetBind = true;
            this.d_payActName.IsValid = true;
            this.d_payActName.Location = new System.Drawing.Point(120, 12);
            this.d_payActName.Margin = new System.Windows.Forms.Padding(4);
            this.d_payActName.Name = "d_payActName";
            this.d_payActName.Size = new System.Drawing.Size(339, 26);
            this.d_payActName.TabIndex = 84;
            this.d_payActName.ValidEmptyMsg = null;
            // 
            // d_actAdress
            // 
            this.d_actAdress.BindDataField = "act_Adress";
            this.d_actAdress.BindDataTag = null;
            this.d_actAdress.BindDataText = null;
            this.d_actAdress.EmptyValue = null;
            this.d_actAdress.IsGetBind = true;
            this.d_actAdress.IsSetBind = true;
            this.d_actAdress.IsValid = true;
            this.d_actAdress.Location = new System.Drawing.Point(120, 104);
            this.d_actAdress.Margin = new System.Windows.Forms.Padding(4);
            this.d_actAdress.Name = "d_actAdress";
            this.d_actAdress.Size = new System.Drawing.Size(339, 26);
            this.d_actAdress.TabIndex = 86;
            this.d_actAdress.ValidEmptyMsg = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(69, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "地址：";
            // 
            // d_DefineCode
            // 
            this.d_DefineCode.BindDataField = "Define_Code";
            this.d_DefineCode.BindDataTag = null;
            this.d_DefineCode.BindDataText = null;
            this.d_DefineCode.EmptyValue = null;
            this.d_DefineCode.IsGetBind = true;
            this.d_DefineCode.IsSetBind = true;
            this.d_DefineCode.IsValid = false;
            this.d_DefineCode.Location = new System.Drawing.Point(570, 150);
            this.d_DefineCode.Name = "d_DefineCode";
            this.d_DefineCode.Size = new System.Drawing.Size(199, 26);
            this.d_DefineCode.TabIndex = 88;
            this.d_DefineCode.ValidEmptyMsg = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(491, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "自定义码：";
            // 
            // d_payTaxCode
            // 
            this.d_payTaxCode.BindDataField = "pay_Tax_Code";
            this.d_payTaxCode.BindDataTag = null;
            this.d_payTaxCode.BindDataText = null;
            this.d_payTaxCode.EmptyValue = null;
            this.d_payTaxCode.IsGetBind = true;
            this.d_payTaxCode.IsSetBind = true;
            this.d_payTaxCode.IsValid = true;
            this.d_payTaxCode.Location = new System.Drawing.Point(570, 104);
            this.d_payTaxCode.Name = "d_payTaxCode";
            this.d_payTaxCode.Size = new System.Drawing.Size(199, 26);
            this.d_payTaxCode.TabIndex = 90;
            this.d_payTaxCode.ValidEmptyMsg = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(459, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "纳税人识别码：";
            // 
            // FmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 278);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmAccountInfo";
            this.Text = "账户信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MCheckBox d_Enable;
        private Miles.Framework.UI.Controls.MTextInput d_Remark;
        private Miles.Framework.UI.Controls.MTextInput d_actName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Miles.Framework.UI.Controls.MTextInput d_actPhone;
        private Miles.Framework.UI.Controls.MTextInput d_actFaRen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Miles.Framework.UI.Controls.MTextInput d_actAdress;
        private System.Windows.Forms.Label label6;
        private Miles.Framework.UI.Controls.MTextInput d_payActName;
        private Miles.Framework.UI.Controls.MTextInput d_DefineCode;
        private System.Windows.Forms.Label label7;
        private Miles.Framework.UI.Controls.MTextInput d_payTaxCode;
        private System.Windows.Forms.Label label5;
    }
}