namespace GaoShan.Sales.Salary.UI.Cal
{
    partial class FmSalaryGrantInfo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mDateTimeInput1 = new Miles.Framework.UI.Controls.MDateTimeInput();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.mTextInput2 = new Miles.Framework.UI.Controls.MTextInput();
            this.label3 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mTextInput2);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.mDateTimeInput1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Size = new System.Drawing.Size(319, 156);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(42, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "发放日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "提成人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "发放金额：";
            // 
            // mDateTimeInput1
            // 
            this.mDateTimeInput1.BindDataField = "grant_Date";
            this.mDateTimeInput1.BindDataTag = null;
            this.mDateTimeInput1.BindDataText = null;
            this.mDateTimeInput1.EmptyValue = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.mDateTimeInput1.IsGetBind = true;
            this.mDateTimeInput1.IsSetBind = true;
            this.mDateTimeInput1.IsValid = true;
            this.mDateTimeInput1.Location = new System.Drawing.Point(121, 82);
            this.mDateTimeInput1.Name = "mDateTimeInput1";
            this.mDateTimeInput1.Size = new System.Drawing.Size(154, 21);
            this.mDateTimeInput1.TabIndex = 93;
            this.mDateTimeInput1.ValidEmptyMsg = null;
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "salary_Grant";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(121, 112);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(154, 21);
            this.mDecimalInput1.TabIndex = 94;
            this.mDecimalInput1.Text = "0.00";
            this.mDecimalInput1.ValidEmptyMsg = "不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsGetBind = false;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = false;
            this.mTextInput1.Location = new System.Drawing.Point(121, 52);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.ReadOnly = true;
            this.mTextInput1.Size = new System.Drawing.Size(154, 21);
            this.mTextInput1.TabIndex = 95;
            this.mTextInput1.ValidEmptyMsg = null;
            // 
            // mTextInput2
            // 
            this.mTextInput2.BindDataField = "";
            this.mTextInput2.BindDataTag = null;
            this.mTextInput2.BindDataText = null;
            this.mTextInput2.EmptyValue = null;
            this.mTextInput2.IsGetBind = false;
            this.mTextInput2.IsSetBind = true;
            this.mTextInput2.IsValid = false;
            this.mTextInput2.Location = new System.Drawing.Point(121, 22);
            this.mTextInput2.Name = "mTextInput2";
            this.mTextInput2.ReadOnly = true;
            this.mTextInput2.Size = new System.Drawing.Size(154, 21);
            this.mTextInput2.TabIndex = 97;
            this.mTextInput2.ValidEmptyMsg = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "合同编号：";
            // 
            // FmSalaryGrantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 203);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmSalaryGrantInfo";
            this.Text = "提成发放记录";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MDateTimeInput mDateTimeInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput2;
        private System.Windows.Forms.Label label3;
    }
}