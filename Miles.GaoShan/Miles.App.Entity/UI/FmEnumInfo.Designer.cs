namespace Miles.App.Entity.UI
{
    partial class FmEnumInfo
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
            this.d_Text = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d_Value = new Miles.Framework.UI.Controls.MDecimalInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_Value);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.lblType);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_Text);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(322, 136);
            // 
            // d_Text
            // 
            this.d_Text.BindDataField = "enum_Text";
            this.d_Text.BindDataTag = null;
            this.d_Text.BindDataText = null;
            this.d_Text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.d_Text.Location = new System.Drawing.Point(105, 86);
            this.d_Text.Name = "d_Text";
            this.d_Text.Size = new System.Drawing.Size(180, 26);
            this.d_Text.TabIndex = 76;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(20, 91);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 77;
            this.label20.Text = "项目说明：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "所属类别：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.Blue;
            this.lblType.Location = new System.Drawing.Point(105, 27);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(88, 16);
            this.lblType.TabIndex = 79;
            this.lblType.Text = "明细项目：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "项目数值：";
            // 
            // d_Value
            // 
            this.d_Value.BindDataField = "enum_Value";
            this.d_Value.BindDataTag = null;
            this.d_Value.BindDataText = null;
            this.d_Value.Location = new System.Drawing.Point(105, 57);
            this.d_Value.Name = "d_Value";
            this.d_Value.Size = new System.Drawing.Size(180, 21);
            this.d_Value.TabIndex = 82;
            this.d_Value.Text = "-1";
            this.d_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // FmEnumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 183);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmEnumInfo";
            this.Text = "枚举明细";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_Text;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MDecimalInput d_Value;
    }
}