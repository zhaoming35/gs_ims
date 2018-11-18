namespace GaoShan.Sales.UI.LinkBill
{
    partial class FmCancelBillInfo
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtOrderNo = new Miles.Framework.UI.Controls.MTextInput();
            this.lblType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mTextInput3 = new Miles.Framework.UI.Controls.MTextInput();
            this.mTextInput2 = new Miles.Framework.UI.Controls.MTextInput();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.groupBox1);
            this.panelClient.Controls.Add(this.btnQuery);
            this.panelClient.Controls.Add(this.txtOrderNo);
            this.panelClient.Controls.Add(this.lblType);
            this.panelClient.Size = new System.Drawing.Size(497, 261);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(276, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 105;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BindDataField = "odr_No";
            this.txtOrderNo.BindDataTag = null;
            this.txtOrderNo.BindDataText = null;
            this.txtOrderNo.EmptyValue = null;
            this.txtOrderNo.IsGetBind = false;
            this.txtOrderNo.IsSetBind = true;
            this.txtOrderNo.IsValid = true;
            this.txtOrderNo.Location = new System.Drawing.Point(94, 22);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(168, 21);
            this.txtOrderNo.TabIndex = 104;
            this.txtOrderNo.ValidEmptyMsg = null;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(4, 22);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(93, 16);
            this.lblType.TabIndex = 103;
            this.lblType.Text = "合同编号：";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mTextInput3);
            this.groupBox1.Controls.Add(this.mTextInput2);
            this.groupBox1.Controls.Add(this.mTextInput1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(7, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 153);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // mTextInput3
            // 
            this.mTextInput3.BindDataField = "linkBill_Name";
            this.mTextInput3.BindDataTag = null;
            this.mTextInput3.BindDataText = null;
            this.mTextInput3.EmptyValue = null;
            this.mTextInput3.IsGetBind = true;
            this.mTextInput3.IsSetBind = true;
            this.mTextInput3.IsValid = false;
            this.mTextInput3.Location = new System.Drawing.Point(126, 29);
            this.mTextInput3.Name = "mTextInput3";
            this.mTextInput3.ReadOnly = true;
            this.mTextInput3.Size = new System.Drawing.Size(280, 26);
            this.mTextInput3.TabIndex = 5;
            this.mTextInput3.ValidEmptyMsg = null;
            // 
            // mTextInput2
            // 
            this.mTextInput2.BindDataField = "OrderTypeText";
            this.mTextInput2.BindDataTag = null;
            this.mTextInput2.BindDataText = null;
            this.mTextInput2.EmptyValue = null;
            this.mTextInput2.IsGetBind = true;
            this.mTextInput2.IsSetBind = true;
            this.mTextInput2.IsValid = false;
            this.mTextInput2.Location = new System.Drawing.Point(126, 99);
            this.mTextInput2.Name = "mTextInput2";
            this.mTextInput2.ReadOnly = true;
            this.mTextInput2.Size = new System.Drawing.Size(280, 26);
            this.mTextInput2.TabIndex = 4;
            this.mTextInput2.ValidEmptyMsg = null;
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "jia_Name";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = false;
            this.mTextInput1.Location = new System.Drawing.Point(126, 64);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.ReadOnly = true;
            this.mTextInput1.Size = new System.Drawing.Size(280, 26);
            this.mTextInput1.TabIndex = 3;
            this.mTextInput1.ValidEmptyMsg = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "项目名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "合同类型:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称:";
            // 
            // FmCancelBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 308);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmCancelBillInfo";
            this.Text = "项目联络单取消";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private Miles.Framework.UI.Controls.MTextInput txtOrderNo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput3;
        private Miles.Framework.UI.Controls.MTextInput mTextInput2;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
    }
}