namespace GaoShan.Sales.Com.UI
{
    partial class FmFinActInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.d_actName = new Miles.Framework.UI.Controls.MTextInput();
            this.d_payBankName = new Miles.Framework.UI.Controls.MTextInput();
            this.d_payActNo = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.d_payActName = new Miles.Framework.UI.Controls.MTextInput();
            this.d_DefineCode = new Miles.Framework.UI.Controls.MTextInput();
            this.label7 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_actName);
            this.panelClient.Controls.Add(this.d_DefineCode);
            this.panelClient.Controls.Add(this.label7);
            this.panelClient.Controls.Add(this.d_payActName);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Controls.Add(this.d_payActNo);
            this.panelClient.Controls.Add(this.d_payBankName);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(473, 231);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "账户名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "开户银行：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "银行账号：";
            // 
            // d_actName
            // 
            this.d_actName.BindDataField = "pay_Name";
            this.d_actName.BindDataTag = null;
            this.d_actName.BindDataText = null;
            this.d_actName.EmptyValue = null;
            this.d_actName.IsGetBind = true;
            this.d_actName.IsSetBind = true;
            this.d_actName.IsValid = true;
            this.d_actName.Location = new System.Drawing.Point(113, 31);
            this.d_actName.Name = "d_actName";
            this.d_actName.Size = new System.Drawing.Size(339, 26);
            this.d_actName.TabIndex = 67;
            this.d_actName.ValidEmptyMsg = null;
            // 
            // d_payBankName
            // 
            this.d_payBankName.BindDataField = "pay_Bank_Name";
            this.d_payBankName.BindDataTag = null;
            this.d_payBankName.BindDataText = null;
            this.d_payBankName.EmptyValue = null;
            this.d_payBankName.IsGetBind = true;
            this.d_payBankName.IsSetBind = true;
            this.d_payBankName.IsValid = true;
            this.d_payBankName.Location = new System.Drawing.Point(113, 66);
            this.d_payBankName.Name = "d_payBankName";
            this.d_payBankName.Size = new System.Drawing.Size(339, 26);
            this.d_payBankName.TabIndex = 68;
            this.d_payBankName.ValidEmptyMsg = null;
            // 
            // d_payActNo
            // 
            this.d_payActNo.BindDataField = "pay_Act_No";
            this.d_payActNo.BindDataTag = null;
            this.d_payActNo.BindDataText = null;
            this.d_payActNo.EmptyValue = null;
            this.d_payActNo.IsGetBind = true;
            this.d_payActNo.IsSetBind = true;
            this.d_payActNo.IsValid = true;
            this.d_payActNo.Location = new System.Drawing.Point(113, 136);
            this.d_payActNo.Name = "d_payActNo";
            this.d_payActNo.Size = new System.Drawing.Size(339, 26);
            this.d_payActNo.TabIndex = 69;
            this.d_payActNo.ValidEmptyMsg = null;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(18, 36);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 73;
            this.label20.Text = "内部名称：";
            // 
            // d_payActName
            // 
            this.d_payActName.BindDataField = "pay_Act_Name";
            this.d_payActName.BindDataTag = null;
            this.d_payActName.BindDataText = null;
            this.d_payActName.EmptyValue = null;
            this.d_payActName.IsGetBind = true;
            this.d_payActName.IsSetBind = true;
            this.d_payActName.IsValid = true;
            this.d_payActName.Location = new System.Drawing.Point(113, 101);
            this.d_payActName.Margin = new System.Windows.Forms.Padding(4);
            this.d_payActName.Name = "d_payActName";
            this.d_payActName.Size = new System.Drawing.Size(339, 26);
            this.d_payActName.TabIndex = 84;
            this.d_payActName.ValidEmptyMsg = null;
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
            this.d_DefineCode.Location = new System.Drawing.Point(113, 171);
            this.d_DefineCode.Name = "d_DefineCode";
            this.d_DefineCode.Size = new System.Drawing.Size(339, 26);
            this.d_DefineCode.TabIndex = 88;
            this.d_DefineCode.ValidEmptyMsg = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(18, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "自定义码：";
            // 
            // FmFinActInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 278);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmFinActInfo";
            this.Text = "账户信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Miles.Framework.UI.Controls.MTextInput d_payActNo;
        private Miles.Framework.UI.Controls.MTextInput d_payBankName;
        private Miles.Framework.UI.Controls.MTextInput d_actName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private Miles.Framework.UI.Controls.MTextInput d_payActName;
        private Miles.Framework.UI.Controls.MTextInput d_DefineCode;
        private System.Windows.Forms.Label label7;
    }
}