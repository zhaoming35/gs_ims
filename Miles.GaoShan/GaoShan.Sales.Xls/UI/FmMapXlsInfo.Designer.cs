namespace GaoShan.Sales.Xls.UI
{
    partial class FmMapXlsInfo
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
            this.d_field_Format = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d_var_Text = new Miles.Framework.UI.Controls.MLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.d_Explain = new Miles.Framework.UI.Controls.MTextInput();
            this.d_field_Name = new GaoShan.Sales.UI.Ctr.TxtBindMember();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_field_Name);
            this.panelClient.Controls.Add(this.d_Explain);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.d_var_Text);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_field_Format);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(307, 187);
            // 
            // d_field_Format
            // 
            this.d_field_Format.BindDataField = "field_Format";
            this.d_field_Format.BindDataTag = null;
            this.d_field_Format.BindDataText = null;
            this.d_field_Format.EmptyValue = null;
            this.d_field_Format.IsGetBind = true;
            this.d_field_Format.IsSetBind = true;
            this.d_field_Format.IsValid = false;
            this.d_field_Format.Location = new System.Drawing.Point(115, 129);
            this.d_field_Format.Name = "d_field_Format";
            this.d_field_Format.Size = new System.Drawing.Size(170, 26);
            this.d_field_Format.TabIndex = 74;
            this.d_field_Format.ValidEmptyMsg = null;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(19, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 75;
            this.label20.Text = "参数名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "绑定数据：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "数据格式：";
            // 
            // d_var_Text
            // 
            this.d_var_Text.AutoSize = true;
            this.d_var_Text.BindDataField = "var_Text";
            this.d_var_Text.BindDataTag = null;
            this.d_var_Text.BindDataText = null;
            this.d_var_Text.EmptyValue = null;
            this.d_var_Text.IsGetBind = true;
            this.d_var_Text.IsSetBind = true;
            this.d_var_Text.IsValid = false;
            this.d_var_Text.Location = new System.Drawing.Point(115, 23);
            this.d_var_Text.Name = "d_var_Text";
            this.d_var_Text.Size = new System.Drawing.Size(72, 16);
            this.d_var_Text.TabIndex = 78;
            this.d_var_Text.Text = "参数名称";
            this.d_var_Text.ValidEmptyMsg = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "参数说明：";
            // 
            // d_Explain
            // 
            this.d_Explain.BindDataField = "var_Explain";
            this.d_Explain.BindDataTag = null;
            this.d_Explain.BindDataText = null;
            this.d_Explain.EmptyValue = null;
            this.d_Explain.IsGetBind = true;
            this.d_Explain.IsSetBind = true;
            this.d_Explain.IsValid = false;
            this.d_Explain.Location = new System.Drawing.Point(115, 55);
            this.d_Explain.Name = "d_Explain";
            this.d_Explain.Size = new System.Drawing.Size(170, 26);
            this.d_Explain.TabIndex = 81;
            this.d_Explain.ValidEmptyMsg = null;
            // 
            // d_field_Name
            // 
            this.d_field_Name.BindDataField = "field_Name";
            this.d_field_Name.BindDataTag = null;
            this.d_field_Name.BindDataText = "field_Note";
            this.d_field_Name.DisplayMember = null;
            this.d_field_Name.EmptyValue = null;
            this.d_field_Name.IsGetBind = true;
            this.d_field_Name.IsSetBind = true;
            this.d_field_Name.IsValid = false;
            this.d_field_Name.Location = new System.Drawing.Point(115, 92);
            this.d_field_Name.Name = "d_field_Name";
            this.d_field_Name.Size = new System.Drawing.Size(170, 26);
            this.d_field_Name.TabIndex = 82;
            this.d_field_Name.ValidEmptyMsg = null;
            this.d_field_Name.ValueMember = null;
            // 
            // FmMapXlsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 234);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmMapXlsInfo";
            this.Text = "参数信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MLabel d_var_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput d_field_Format;
        private System.Windows.Forms.Label label20;
        private Miles.Framework.UI.Controls.MTextInput d_Explain;
        private System.Windows.Forms.Label label3;
        private GaoShan.Sales.UI.Ctr.TxtBindMember d_field_Name;
    }
}