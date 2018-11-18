namespace GaoShan.Sales.UI.Carriage
{
    partial class FmCarriageQuery
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
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDate = new Miles.Framework.UI.Controls.MDateTimeEdit();
            this.endDate = new Miles.Framework.UI.Controls.MDateTimeEdit();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDataGrid1);
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
            this.panelTop.TabIndex = 2;
            // 
            // mDataGrid1
            // 
            this.mDataGrid1.AllowUserToAddRows = false;
            this.mDataGrid1.AllowUserToDeleteRows = false;
            this.mDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column23,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(0, 39);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.ReadOnly = true;
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.Size = new System.Drawing.Size(800, 386);
            this.mDataGrid1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "odr_No";
            this.Column1.HeaderText = "合同编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "carriage_Name";
            this.Column23.HeaderText = "运货单名称";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 160;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "carriage_Type";
            this.Column2.HeaderText = "运输类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "product_Name";
            this.Column3.HeaderText = "运输产品";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "max_Length";
            this.Column4.HeaderText = "最长件";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "product_Weight";
            this.Column5.HeaderText = "车载";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "product_Volume";
            this.Column6.HeaderText = "体积";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "product_Count";
            this.Column7.HeaderText = "件数";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "load_Date";
            this.Column8.HeaderText = "装车时间";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "arrive_Date";
            this.Column9.HeaderText = "到达时间";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "LoadPlace";
            this.Column10.HeaderText = "装车地址";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "UnloadPlace";
            this.Column11.HeaderText = "卸车地址";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "transport_Type";
            this.Column12.HeaderText = "运输方式";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "receive_Man";
            this.Column13.HeaderText = "收货人";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "receive_Phone";
            this.Column14.HeaderText = "收货电话";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "pay_Part";
            this.Column15.HeaderText = "支付方";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "pay_Way";
            this.Column16.HeaderText = "支付方式";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "carriage_Cost";
            this.Column17.HeaderText = "运费";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "carrier_Name";
            this.Column18.HeaderText = "承运人";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "carrier_Phone";
            this.Column19.HeaderText = "承运人电话";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 120;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "trunk_Spec";
            this.Column20.HeaderText = "车辆规格";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "plate_Number";
            this.Column21.HeaderText = "车牌号";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "driving_Num";
            this.Column22.HeaderText = "驾驶证号码";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Width = 150;
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
            this.beginDate.Location = new System.Drawing.Point(64, 9);
            this.beginDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.beginDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.beginDate.Name = "beginDate";
            this.beginDate.ShowUpDown = false;
            this.beginDate.Size = new System.Drawing.Size(169, 21);
            this.beginDate.TabIndex = 23;
            this.beginDate.ValidEmptyMsg = null;
            this.beginDate.Value = new System.DateTime(2018, 11, 14, 14, 3, 18, 81);
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
            this.endDate.Location = new System.Drawing.Point(298, 9);
            this.endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.ShowUpDown = false;
            this.endDate.Size = new System.Drawing.Size(169, 21);
            this.endDate.TabIndex = 22;
            this.endDate.ValidEmptyMsg = null;
            this.endDate.Value = new System.DateTime(2018, 11, 14, 14, 3, 18, 83);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(535, 9);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(191, 21);
            this.txtOrderNo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "合同编码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "截止时间";
            // 
            // FmCarriageQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmCarriageQuery";
            this.ShowNavPanel = false;
            this.Text = "FmCarriageQuery";
            this.panelClient.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Miles.Framework.UI.Controls.MDataGrid mDataGrid1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private Miles.Framework.UI.Controls.MDateTimeEdit beginDate;
        private Miles.Framework.UI.Controls.MDateTimeEdit endDate;
        private System.Windows.Forms.TextBox txtOrderNo;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
    }
}