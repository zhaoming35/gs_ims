namespace GaoShan.Sales.Store.UI
{
    partial class FmStoreOutQuery
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
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelTop.TabIndex = 3;
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
            this.beginDate.Location = new System.Drawing.Point(72, 9);
            this.beginDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.beginDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.beginDate.Name = "beginDate";
            this.beginDate.ShowUpDown = false;
            this.beginDate.Size = new System.Drawing.Size(169, 21);
            this.beginDate.TabIndex = 35;
            this.beginDate.ValidEmptyMsg = null;
            this.beginDate.Value = new System.DateTime(2018, 11, 16, 9, 12, 29, 231);
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
            this.endDate.Location = new System.Drawing.Point(306, 9);
            this.endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.ShowUpDown = false;
            this.endDate.Size = new System.Drawing.Size(169, 21);
            this.endDate.TabIndex = 34;
            this.endDate.ValidEmptyMsg = null;
            this.endDate.Value = new System.DateTime(2018, 11, 16, 9, 12, 29, 233);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(543, 9);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(191, 21);
            this.txtOrderNo.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "合同编码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "截止时间";
            // 
            // mDataGrid1
            // 
            this.mDataGrid1.AllowUserToAddRows = false;
            this.mDataGrid1.AllowUserToDeleteRows = false;
            this.mDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column8});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(0, 39);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.ReadOnly = true;
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.Size = new System.Drawing.Size(800, 386);
            this.mDataGrid1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mtl_Code";
            this.Column1.HeaderText = "物料编码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Mtl_Name";
            this.Column2.HeaderText = "物料名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mtl_Unit";
            this.Column3.HeaderText = "物料单位";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mtl_Spec";
            this.Column4.HeaderText = "物料规格";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mtl_Qty";
            this.Column7.HeaderText = "出库数量";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Oper_Date";
            this.Column5.HeaderText = "出库时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StoreOutType";
            this.Column6.HeaderText = "出库类型";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Odr_No";
            this.Column8.HeaderText = "合同编码";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // FmStoreOutQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmStoreOutQuery";
            this.ShowNavPanel = false;
            this.Text = "FmStoreInQuery";
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
        private Miles.Framework.UI.Controls.MDateTimeEdit beginDate;
        private Miles.Framework.UI.Controls.MDateTimeEdit endDate;
        private System.Windows.Forms.TextBox txtOrderNo;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}