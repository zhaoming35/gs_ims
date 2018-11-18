namespace GaoShan.Sales.Xls.UI
{
    partial class FmXlsDocInfo
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
            this.d_Explain = new Miles.Framework.UI.Controls.MTextInput();
            this.d_Name = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.d_column_Count = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_row_Count = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_column_Count);
            this.panelClient.Controls.Add(this.d_row_Count);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.d_Explain);
            this.panelClient.Controls.Add(this.d_Name);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(365, 215);
            // 
            // d_Explain
            // 
            this.d_Explain.BindDataField = "tmp_Explain";
            this.d_Explain.BindDataTag = null;
            this.d_Explain.BindDataText = null;
            this.d_Explain.EmptyValue = null;
            this.d_Explain.IsGetBind = true;
            this.d_Explain.IsSetBind = true;
            this.d_Explain.IsValid = true;
            this.d_Explain.Location = new System.Drawing.Point(147, 60);
            this.d_Explain.Name = "d_Explain";
            this.d_Explain.Size = new System.Drawing.Size(180, 26);
            this.d_Explain.TabIndex = 72;
            this.d_Explain.ValidEmptyMsg = "模板说明不能为空";
            // 
            // d_Name
            // 
            this.d_Name.BindDataField = "tmp_Name";
            this.d_Name.BindDataTag = null;
            this.d_Name.BindDataText = null;
            this.d_Name.EmptyValue = null;
            this.d_Name.IsGetBind = true;
            this.d_Name.IsSetBind = true;
            this.d_Name.IsValid = true;
            this.d_Name.Location = new System.Drawing.Point(147, 27);
            this.d_Name.Name = "d_Name";
            this.d_Name.Size = new System.Drawing.Size(180, 26);
            this.d_Name.TabIndex = 71;
            this.d_Name.ValidEmptyMsg = "模板名称不能为空";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "模板说明：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "模板名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "输入列集合：";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "input_Cols";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = false;
            this.mTextInput1.Location = new System.Drawing.Point(147, 159);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(180, 26);
            this.mTextInput1.TabIndex = 74;
            this.mTextInput1.ValidEmptyMsg = "不能为空";
            // 
            // d_column_Count
            // 
            this.d_column_Count.BindDataField = "column_Count";
            this.d_column_Count.BindDataTag = null;
            this.d_column_Count.BindDataText = null;
            this.d_column_Count.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_column_Count.IsGetBind = true;
            this.d_column_Count.IsSetBind = true;
            this.d_column_Count.IsValid = true;
            this.d_column_Count.Location = new System.Drawing.Point(147, 126);
            this.d_column_Count.Name = "d_column_Count";
            this.d_column_Count.Size = new System.Drawing.Size(180, 26);
            this.d_column_Count.TabIndex = 94;
            this.d_column_Count.ValidEmptyMsg = "初始列数不能为空";
            this.d_column_Count.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // d_row_Count
            // 
            this.d_row_Count.BindDataField = "row_Count";
            this.d_row_Count.BindDataTag = null;
            this.d_row_Count.BindDataText = null;
            this.d_row_Count.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_row_Count.IsGetBind = true;
            this.d_row_Count.IsSetBind = true;
            this.d_row_Count.IsValid = true;
            this.d_row_Count.Location = new System.Drawing.Point(147, 93);
            this.d_row_Count.Name = "d_row_Count";
            this.d_row_Count.Size = new System.Drawing.Size(180, 26);
            this.d_row_Count.TabIndex = 93;
            this.d_row_Count.ValidEmptyMsg = "初始行数不能为空";
            this.d_row_Count.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(68, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "总列数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(68, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "总行数：";
            // 
            // FmXlsDocInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmXlsDocInfo";
            this.Text = "模板信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_Explain;
        private Miles.Framework.UI.Controls.MTextInput d_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private Miles.Framework.UI.Controls.MDecimalInput d_column_Count;
        private Miles.Framework.UI.Controls.MDecimalInput d_row_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}