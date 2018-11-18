namespace GaoShan.Sales.UI.Fin
{
    partial class FmProjectIncomeManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucIncomeList1 = new GaoShan.Sales.UI.Fin.UCIncomeList();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reoGridControl1 = new unvell.ReoGrid.ReoGridControl();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.cmbCompanyAccount1 = new GaoShan.Sales.UI.Ctr.CmbCompanyAccount();
            this.cmbReceivePayWay1 = new GaoShan.Sales.UI.Ctr.CmbReceivePayWay();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mDateTimeEdit1 = new Miles.Framework.UI.Controls.MDateTimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.splitContainer1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(958, 425);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucIncomeList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(958, 425);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucIncomeList1
            // 
            this.ucIncomeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucIncomeList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucIncomeList1.FontSize = 12F;
            this.ucIncomeList1.Location = new System.Drawing.Point(0, 0);
            this.ucIncomeList1.Name = "ucIncomeList1";
            this.ucIncomeList1.Size = new System.Drawing.Size(258, 425);
            this.ucIncomeList1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox16);
            this.splitContainer2.Size = new System.Drawing.Size(696, 425);
            this.splitContainer2.SplitterDistance = 283;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.reoGridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 283);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合同摘要信息";
            // 
            // reoGridControl1
            // 
            this.reoGridControl1.BackColor = System.Drawing.Color.White;
            this.reoGridControl1.ColumnHeaderContextMenuStrip = null;
            this.reoGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reoGridControl1.LeadHeaderContextMenuStrip = null;
            this.reoGridControl1.Location = new System.Drawing.Point(3, 22);
            this.reoGridControl1.Name = "reoGridControl1";
            this.reoGridControl1.RowHeaderContextMenuStrip = null;
            this.reoGridControl1.Script = null;
            this.reoGridControl1.SheetTabContextMenuStrip = null;
            this.reoGridControl1.SheetTabNewButtonVisible = true;
            this.reoGridControl1.SheetTabVisible = true;
            this.reoGridControl1.SheetTabWidth = 60;
            this.reoGridControl1.ShowScrollEndSpacing = true;
            this.reoGridControl1.Size = new System.Drawing.Size(690, 258);
            this.reoGridControl1.TabIndex = 1;
            this.reoGridControl1.Text = "reoGridControl1";
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox16.Controls.Add(this.cmbCompanyAccount1);
            this.groupBox16.Controls.Add(this.cmbReceivePayWay1);
            this.groupBox16.Controls.Add(this.mTextInput1);
            this.groupBox16.Controls.Add(this.mDecimalInput1);
            this.groupBox16.Controls.Add(this.label7);
            this.groupBox16.Controls.Add(this.label6);
            this.groupBox16.Controls.Add(this.label5);
            this.groupBox16.Controls.Add(this.label3);
            this.groupBox16.Controls.Add(this.mDateTimeEdit1);
            this.groupBox16.Controls.Add(this.label1);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox16.ForeColor = System.Drawing.Color.Black;
            this.groupBox16.Location = new System.Drawing.Point(0, 0);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox16.Size = new System.Drawing.Size(696, 138);
            this.groupBox16.TabIndex = 90;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "回款信息";
            // 
            // cmbCompanyAccount1
            // 
            this.cmbCompanyAccount1.BindDataField = null;
            this.cmbCompanyAccount1.BindDataTag = null;
            this.cmbCompanyAccount1.BindDataText = "pay_Account";
            this.cmbCompanyAccount1.EmptyValue = null;
            this.cmbCompanyAccount1.IsGetBind = true;
            this.cmbCompanyAccount1.IsSetBind = true;
            this.cmbCompanyAccount1.IsValid = true;
            this.cmbCompanyAccount1.Location = new System.Drawing.Point(96, 51);
            this.cmbCompanyAccount1.Name = "cmbCompanyAccount1";
            this.cmbCompanyAccount1.Size = new System.Drawing.Size(357, 24);
            this.cmbCompanyAccount1.TabIndex = 106;
            this.cmbCompanyAccount1.ValidEmptyMsg = "入账账户不能为空";
            // 
            // cmbReceivePayWay1
            // 
            this.cmbReceivePayWay1.BindDataField = null;
            this.cmbReceivePayWay1.BindDataTag = null;
            this.cmbReceivePayWay1.BindDataText = "pay_Way";
            this.cmbReceivePayWay1.EmptyValue = null;
            this.cmbReceivePayWay1.IsGetBind = true;
            this.cmbReceivePayWay1.IsSetBind = true;
            this.cmbReceivePayWay1.IsValid = true;
            this.cmbReceivePayWay1.Location = new System.Drawing.Point(545, 21);
            this.cmbReceivePayWay1.Name = "cmbReceivePayWay1";
            this.cmbReceivePayWay1.Size = new System.Drawing.Size(144, 24);
            this.cmbReceivePayWay1.TabIndex = 105;
            this.cmbReceivePayWay1.ValidEmptyMsg = "回款类型不能为空";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "pay_remark";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = false;
            this.mTextInput1.Location = new System.Drawing.Point(96, 80);
            this.mTextInput1.Multiline = true;
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(536, 37);
            this.mTextInput1.TabIndex = 104;
            this.mTextInput1.ValidEmptyMsg = null;
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.AllowNegative = false;
            this.mDecimalInput1.BindDataField = "pay_Cost";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(334, 20);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(119, 26);
            this.mDecimalInput1.TabIndex = 103;
            this.mDecimalInput1.ValidEmptyMsg = "回款金额不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(41, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 102;
            this.label7.Text = "备注：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "入账账户：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(456, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "回款类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(244, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "回款金额：";
            // 
            // mDateTimeEdit1
            // 
            this.mDateTimeEdit1.BackColor = System.Drawing.SystemColors.Window;
            this.mDateTimeEdit1.BindDataField = "fin_Date";
            this.mDateTimeEdit1.BindDataTag = null;
            this.mDateTimeEdit1.BindDataText = null;
            this.mDateTimeEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mDateTimeEdit1.CustomFormat = null;
            this.mDateTimeEdit1.EmptyValue = null;
            this.mDateTimeEdit1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.mDateTimeEdit1.IsGetBind = true;
            this.mDateTimeEdit1.IsSetBind = true;
            this.mDateTimeEdit1.IsValid = true;
            this.mDateTimeEdit1.Location = new System.Drawing.Point(96, 22);
            this.mDateTimeEdit1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.mDateTimeEdit1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.mDateTimeEdit1.Name = "mDateTimeEdit1";
            this.mDateTimeEdit1.ShowUpDown = false;
            this.mDateTimeEdit1.Size = new System.Drawing.Size(144, 21);
            this.mDateTimeEdit1.TabIndex = 98;
            this.mDateTimeEdit1.ValidEmptyMsg = "回款日期不能为空";
            this.mDateTimeEdit1.Value = new System.DateTime(2018, 10, 14, 12, 56, 0, 121);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "回款日期：";
            // 
            // FmProjectIncomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Name = "FmProjectIncomeManager";
            this.ShowNavPanel = false;
            this.Text = "FmProjectIncomeManager";
            this.panelClient.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UCIncomeList ucIncomeList1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox16;
        private Ctr.CmbCompanyAccount cmbCompanyAccount1;
        private Ctr.CmbReceivePayWay cmbReceivePayWay1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Miles.Framework.UI.Controls.MDateTimeEdit mDateTimeEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private unvell.ReoGrid.ReoGridControl reoGridControl1;
    }
}