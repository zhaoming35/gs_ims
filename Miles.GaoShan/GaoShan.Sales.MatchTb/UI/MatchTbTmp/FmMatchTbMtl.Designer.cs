namespace GaoShan.Sales.MatchTb.UI
{
    partial class FmMatchTbMtl
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
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(340, 166);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(17, 55);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 79;
            this.label20.Text = "篷房宽度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "主材规格：";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "tent_MainSpec";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = true;
            this.mTextInput1.Location = new System.Drawing.Point(105, 89);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(217, 26);
            this.mTextInput1.TabIndex = 82;
            this.mTextInput1.ValidEmptyMsg = "不能为空";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "tent_Weight";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(105, 50);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(170, 21);
            this.mDecimalInput1.TabIndex = 89;
            this.mDecimalInput1.ValidEmptyMsg = "不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 90;
            this.label2.Text = "米";
            // 
            // FmMatchTbMtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmMatchTbMtl";
            this.Text = "配套表物料组成";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label2;
    }
}