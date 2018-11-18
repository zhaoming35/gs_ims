namespace GaoShan.Sales.UI.ProjectCost
{
    partial class FmProjectCostSelfQuery
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.beginDate = new Miles.Framework.UI.Controls.MDateTimeEdit();
            this.endDate = new Miles.Framework.UI.Controls.MDateTimeEdit();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelClient.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDataGrid1);
            this.panelClient.Controls.Add(this.panelBottom);
            this.panelClient.Controls.Add(this.panelTop);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.beginDate);
            this.panelTop.Controls.Add(this.endDate);
            this.panelTop.Controls.Add(this.txtOrderNo);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 39);
            this.panelTop.TabIndex = 1;
            // 
            // beginDate
            // 
            this.beginDate.BackColor = System.Drawing.SystemColors.Window;
            this.beginDate.BindDataField = null;
            this.beginDate.BindDataTag = null;
            this.beginDate.BindDataText = null;
            this.beginDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beginDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.beginDate.EmptyValue = null;
            this.beginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDate.IsGetBind = true;
            this.beginDate.IsSetBind = true;
            this.beginDate.IsValid = false;
            this.beginDate.Location = new System.Drawing.Point(65, 9);
            this.beginDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.beginDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.beginDate.Name = "beginDate";
            this.beginDate.ShowUpDown = false;
            this.beginDate.Size = new System.Drawing.Size(169, 21);
            this.beginDate.TabIndex = 29;
            this.beginDate.ValidEmptyMsg = null;
            this.beginDate.Value = new System.DateTime(2018, 11, 16, 12, 35, 18, 908);
            // 
            // endDate
            // 
            this.endDate.BackColor = System.Drawing.SystemColors.Window;
            this.endDate.BindDataField = null;
            this.endDate.BindDataTag = null;
            this.endDate.BindDataText = null;
            this.endDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDate.EmptyValue = null;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.IsGetBind = true;
            this.endDate.IsSetBind = true;
            this.endDate.IsValid = false;
            this.endDate.Location = new System.Drawing.Point(299, 9);
            this.endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.ShowUpDown = false;
            this.endDate.Size = new System.Drawing.Size(169, 21);
            this.endDate.TabIndex = 28;
            this.endDate.ValidEmptyMsg = null;
            this.endDate.Value = new System.DateTime(2018, 11, 16, 12, 35, 18, 910);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(536, 9);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(191, 21);
            this.txtOrderNo.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "合同编码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "截止时间";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelBottom.Controls.Add(this.txtSumCost);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 388);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 37);
            this.panelBottom.TabIndex = 2;
            // 
            // txtSumCost
            // 
            this.txtSumCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumCost.Location = new System.Drawing.Point(659, 8);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.ReadOnly = true;
            this.txtSumCost.Size = new System.Drawing.Size(100, 21);
            this.txtSumCost.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "合计金额";
            // 
            // mDataGrid1
            // 
            this.mDataGrid1.AllowUserToAddRows = false;
            this.mDataGrid1.AllowUserToDeleteRows = false;
            this.mDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11,
            this.Column10});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(0, 39);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.ReadOnly = true;
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.Size = new System.Drawing.Size(800, 349);
            this.mDataGrid1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "odr_No";
            this.Column1.HeaderText = "合同编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "odr_Prt_Name";
            this.Column2.HeaderText = "产品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "OrderTypeText";
            this.Column9.HeaderText = "合同类型";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "employ_Name";
            this.Column3.HeaderText = "业务员";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "oper_Date";
            this.Column4.HeaderText = "录入时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "item_Name";
            this.Column5.HeaderText = "费用项目";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "item_Price";
            this.Column6.HeaderText = "项目单价";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "item_Qty";
            this.Column7.HeaderText = "项目数量";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SumCost";
            this.Column8.HeaderText = "总金额";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "item_Date";
            this.Column11.FillWeight = 150F;
            this.Column11.HeaderText = "项目时间";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "define_Flag";
            this.Column10.FalseValue = "0";
            this.Column10.HeaderText = "提成成本";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.TrueValue = "1";
            // 
            // FmProjectCostSelfQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmProjectCostSelfQuery";
            this.ShowNavPanel = false;
            this.Text = "FmProjectCostQuery";
            this.panelClient.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private Miles.Framework.UI.Controls.MDateTimeEdit beginDate;
        private Miles.Framework.UI.Controls.MDateTimeEdit endDate;
        private System.Windows.Forms.TextBox txtOrderNo;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottom;
        protected System.Windows.Forms.Label label4;
        private Miles.Framework.UI.Controls.MDataGrid mDataGrid1;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
    }
}