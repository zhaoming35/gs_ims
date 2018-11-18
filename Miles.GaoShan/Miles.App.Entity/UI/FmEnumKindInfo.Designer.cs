namespace Miles.App.Entity.UI
{
    partial class FmEnumKindInfo
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
            this.d_Kind = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.d_Value = new Miles.Framework.UI.Controls.MTextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_Value);
            this.panelClient.Controls.Add(this.d_Kind);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(336, 135);
            // 
            // d_Kind
            // 
            this.d_Kind.BindDataField = "enum_Kind";
            this.d_Kind.BindDataTag = null;
            this.d_Kind.BindDataText = null;
            this.d_Kind.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.d_Kind.Location = new System.Drawing.Point(114, 36);
            this.d_Kind.Name = "d_Kind";
            this.d_Kind.Size = new System.Drawing.Size(193, 26);
            this.d_Kind.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(28, 76);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 75;
            this.label20.Text = "类型说明：";
            // 
            // d_Value
            // 
            this.d_Value.BindDataField = "enum_Text";
            this.d_Value.BindDataTag = null;
            this.d_Value.BindDataText = null;
            this.d_Value.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.d_Value.Location = new System.Drawing.Point(114, 71);
            this.d_Value.Name = "d_Value";
            this.d_Value.Size = new System.Drawing.Size(193, 26);
            this.d_Value.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "类型名称：";
            // 
            // FmEnumKindInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 182);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmEnumKindInfo";
            this.Text = "枚举类别";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_Kind;
        private System.Windows.Forms.Label label20;
        private Miles.Framework.UI.Controls.MTextInput d_Value;
        private System.Windows.Forms.Label label1;
    }
}