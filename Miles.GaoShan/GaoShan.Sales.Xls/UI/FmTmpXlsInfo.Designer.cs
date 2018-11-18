namespace GaoShan.Sales.Xls.UI
{
    partial class FmTmpXlsInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.d_row_Count = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_column_Count = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_item_Start_Row = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModelType1 = new GaoShan.Sales.UI.Ctr.CmbModelType();
            this.d_item_Row_Count = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label7 = new System.Windows.Forms.Label();
            this.d_item_Start_Column = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label8 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label9 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label9);
            this.panelClient.Controls.Add(this.d_item_Start_Column);
            this.panelClient.Controls.Add(this.label8);
            this.panelClient.Controls.Add(this.d_item_Row_Count);
            this.panelClient.Controls.Add(this.label7);
            this.panelClient.Controls.Add(this.cmbModelType1);
            this.panelClient.Controls.Add(this.label6);
            this.panelClient.Controls.Add(this.d_item_Start_Row);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Controls.Add(this.d_column_Count);
            this.panelClient.Controls.Add(this.d_row_Count);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.d_Explain);
            this.panelClient.Controls.Add(this.d_Name);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(365, 359);
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
            this.d_Explain.Location = new System.Drawing.Point(131, 57);
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
            this.d_Name.Location = new System.Drawing.Point(131, 22);
            this.d_Name.Name = "d_Name";
            this.d_Name.Size = new System.Drawing.Size(180, 26);
            this.d_Name.TabIndex = 71;
            this.d_Name.ValidEmptyMsg = "模板名称不能为空";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(36, 62);
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
            this.label1.Location = new System.Drawing.Point(36, 27);
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
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "初始行数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "初始列数：";
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
            this.d_row_Count.Location = new System.Drawing.Point(131, 92);
            this.d_row_Count.Name = "d_row_Count";
            this.d_row_Count.Size = new System.Drawing.Size(180, 26);
            this.d_row_Count.TabIndex = 89;
            this.d_row_Count.ValidEmptyMsg = "初始行数不能为空";
            this.d_row_Count.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.d_column_Count.Location = new System.Drawing.Point(131, 127);
            this.d_column_Count.Name = "d_column_Count";
            this.d_column_Count.Size = new System.Drawing.Size(180, 26);
            this.d_column_Count.TabIndex = 90;
            this.d_column_Count.ValidEmptyMsg = "初始列数不能为空";
            this.d_column_Count.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // d_item_Start_Row
            // 
            this.d_item_Start_Row.BindDataField = "item_Start_Row";
            this.d_item_Start_Row.BindDataTag = null;
            this.d_item_Start_Row.BindDataText = null;
            this.d_item_Start_Row.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_item_Start_Row.IsGetBind = true;
            this.d_item_Start_Row.IsSetBind = true;
            this.d_item_Start_Row.IsValid = false;
            this.d_item_Start_Row.Location = new System.Drawing.Point(170, 162);
            this.d_item_Start_Row.Name = "d_item_Start_Row";
            this.d_item_Start_Row.Size = new System.Drawing.Size(141, 26);
            this.d_item_Start_Row.TabIndex = 92;
            this.d_item_Start_Row.ValidEmptyMsg = "动态起始行不能为空";
            this.d_item_Start_Row.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(36, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "动态数据起始行：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "数据源类型";
            // 
            // cmbModelType1
            // 
            this.cmbModelType1.BindDataField = "source_Type";
            this.cmbModelType1.BindDataTag = null;
            this.cmbModelType1.BindDataText = "";
            this.cmbModelType1.EmptyValue = null;
            this.cmbModelType1.IsGetBind = true;
            this.cmbModelType1.IsSetBind = true;
            this.cmbModelType1.IsValid = false;
            this.cmbModelType1.Location = new System.Drawing.Point(131, 303);
            this.cmbModelType1.Name = "cmbModelType1";
            this.cmbModelType1.Size = new System.Drawing.Size(180, 24);
            this.cmbModelType1.TabIndex = 95;
            this.cmbModelType1.ValidEmptyMsg = null;
            // 
            // d_item_Row_Count
            // 
            this.d_item_Row_Count.BindDataField = "item_Row_Count";
            this.d_item_Row_Count.BindDataTag = null;
            this.d_item_Row_Count.BindDataText = null;
            this.d_item_Row_Count.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_item_Row_Count.IsGetBind = true;
            this.d_item_Row_Count.IsSetBind = true;
            this.d_item_Row_Count.IsValid = false;
            this.d_item_Row_Count.Location = new System.Drawing.Point(170, 232);
            this.d_item_Row_Count.Name = "d_item_Row_Count";
            this.d_item_Row_Count.Size = new System.Drawing.Size(141, 26);
            this.d_item_Row_Count.TabIndex = 97;
            this.d_item_Row_Count.Text = "1";
            this.d_item_Row_Count.ValidEmptyMsg = "动态数据占行数不能为空";
            this.d_item_Row_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(36, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "动态数据占行数：";
            // 
            // d_item_Start_Column
            // 
            this.d_item_Start_Column.BindDataField = "item_Start_Column";
            this.d_item_Start_Column.BindDataTag = null;
            this.d_item_Start_Column.BindDataText = null;
            this.d_item_Start_Column.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_item_Start_Column.IsGetBind = true;
            this.d_item_Start_Column.IsSetBind = true;
            this.d_item_Start_Column.IsValid = false;
            this.d_item_Start_Column.Location = new System.Drawing.Point(170, 197);
            this.d_item_Start_Column.Name = "d_item_Start_Column";
            this.d_item_Start_Column.Size = new System.Drawing.Size(141, 26);
            this.d_item_Start_Column.TabIndex = 99;
            this.d_item_Start_Column.ValidEmptyMsg = "动态起始列不能为空";
            this.d_item_Start_Column.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(36, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 98;
            this.label8.Text = "动态数据起始列：";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "item_Column_Count";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(170, 267);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(141, 26);
            this.mDecimalInput1.TabIndex = 101;
            this.mDecimalInput1.Text = "1";
            this.mDecimalInput1.ValidEmptyMsg = "动态数据占列数不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(36, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 100;
            this.label9.Text = "动态数据占列数：";
            // 
            // FmTmpXlsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 406);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmTmpXlsInfo";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Miles.Framework.UI.Controls.MDecimalInput d_item_Start_Row;
        private System.Windows.Forms.Label label5;
        private Miles.Framework.UI.Controls.MDecimalInput d_column_Count;
        private Miles.Framework.UI.Controls.MDecimalInput d_row_Count;
        private System.Windows.Forms.Label label6;
        private GaoShan.Sales.UI.Ctr.CmbModelType cmbModelType1;
        private Miles.Framework.UI.Controls.MDecimalInput d_item_Row_Count;
        private System.Windows.Forms.Label label7;
        private Miles.Framework.UI.Controls.MDecimalInput d_item_Start_Column;
        private System.Windows.Forms.Label label8;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label9;
    }
}