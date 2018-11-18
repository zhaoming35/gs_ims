namespace GaoShan.Sales.Salary.UI.Cal
{
    partial class FmGuidePriceInfo
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
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label5 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Size = new System.Drawing.Size(265, 111);
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "GuidePric";
            this.mDecimalInput1.BindDataTag = null;
            this.mDecimalInput1.BindDataText = null;
            this.mDecimalInput1.DecimalLength = 2;
            this.mDecimalInput1.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput1.IsGetBind = true;
            this.mDecimalInput1.IsSetBind = true;
            this.mDecimalInput1.IsValid = true;
            this.mDecimalInput1.Location = new System.Drawing.Point(142, 44);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(76, 21);
            this.mDecimalInput1.TabIndex = 90;
            this.mDecimalInput1.Text = "0.00";
            this.mDecimalInput1.ValidEmptyMsg = "不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(45, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "销售指导价：";
            // 
            // FmGuidePriceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 158);
            this.Name = "FmGuidePriceInfo";
            this.Text = "FmGuidePriceInfo";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
    }
}