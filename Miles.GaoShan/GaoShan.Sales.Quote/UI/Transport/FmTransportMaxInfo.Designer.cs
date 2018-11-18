namespace GaoShan.Sales.Quote.UI
{
    partial class FmTransportMaxInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mDecimalInput2 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mDecimalInput3 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mDecimalInput4 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.cmbTransEdgeHeight1 = new GaoShan.Sales.UI.Ctr.CmbTransEdgeHeight();
            this.cmbTransMainSpec1 = new GaoShan.Sales.UI.Ctr.CmbTransMainSpec();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.cmbTransEdgeHeight1);
            this.panelClient.Controls.Add(this.cmbTransMainSpec1);
            this.panelClient.Controls.Add(this.mDecimalInput4);
            this.panelClient.Controls.Add(this.mDecimalInput3);
            this.panelClient.Controls.Add(this.mDecimalInput2);
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label6);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Size = new System.Drawing.Size(347, 211);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "型材规格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(46, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "篷房跨度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(46, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "吨位/排：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(46, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "最长件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(46, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "篷房间距：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(46, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "篷房边高：";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "tent_Width";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(136, 49);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(163, 21);
            this.mDecimalInput1.TabIndex = 88;
            this.mDecimalInput1.Text = "0.00";
            this.mDecimalInput1.ValidEmptyMsg = "跨度不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // mDecimalInput2
            // 
            this.mDecimalInput2.BindDataField = "tent_Space";
            this.mDecimalInput2.BindDataTag = null;
            this.mDecimalInput2.BindDataText = null;
            this.mDecimalInput2.DecimalLength = 2;
            this.mDecimalInput2.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput2.IsGetBind = true;
            this.mDecimalInput2.IsSetBind = true;
            this.mDecimalInput2.IsValid = true;
            this.mDecimalInput2.Location = new System.Drawing.Point(136, 79);
            this.mDecimalInput2.Name = "mDecimalInput2";
            this.mDecimalInput2.Size = new System.Drawing.Size(163, 21);
            this.mDecimalInput2.TabIndex = 89;
            this.mDecimalInput2.Text = "0.00";
            this.mDecimalInput2.ValidEmptyMsg = "间距不能为空";
            this.mDecimalInput2.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // mDecimalInput3
            // 
            this.mDecimalInput3.BindDataField = "max_Length";
            this.mDecimalInput3.BindDataTag = null;
            this.mDecimalInput3.BindDataText = null;
            this.mDecimalInput3.DecimalLength = 2;
            this.mDecimalInput3.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput3.IsGetBind = true;
            this.mDecimalInput3.IsSetBind = true;
            this.mDecimalInput3.IsValid = true;
            this.mDecimalInput3.Location = new System.Drawing.Point(136, 139);
            this.mDecimalInput3.Name = "mDecimalInput3";
            this.mDecimalInput3.Size = new System.Drawing.Size(163, 21);
            this.mDecimalInput3.TabIndex = 90;
            this.mDecimalInput3.Text = "0.00";
            this.mDecimalInput3.ValidEmptyMsg = "最长件不能空";
            this.mDecimalInput3.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // mDecimalInput4
            // 
            this.mDecimalInput4.BindDataField = "row_Weight";
            this.mDecimalInput4.BindDataTag = null;
            this.mDecimalInput4.BindDataText = null;
            this.mDecimalInput4.DecimalLength = 2;
            this.mDecimalInput4.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput4.IsGetBind = true;
            this.mDecimalInput4.IsSetBind = true;
            this.mDecimalInput4.IsValid = true;
            this.mDecimalInput4.Location = new System.Drawing.Point(136, 169);
            this.mDecimalInput4.Name = "mDecimalInput4";
            this.mDecimalInput4.Size = new System.Drawing.Size(163, 21);
            this.mDecimalInput4.TabIndex = 91;
            this.mDecimalInput4.Text = "0.00";
            this.mDecimalInput4.ValidEmptyMsg = "吨位/排不能空";
            this.mDecimalInput4.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // cmbTransEdgeHeight1
            // 
            this.cmbTransEdgeHeight1.BindDataField = "tent_edgeHeight";
            this.cmbTransEdgeHeight1.BindDataTag = null;
            this.cmbTransEdgeHeight1.BindDataText = "";
            this.cmbTransEdgeHeight1.EmptyValue = null;
            this.cmbTransEdgeHeight1.IsGetBind = true;
            this.cmbTransEdgeHeight1.IsSetBind = true;
            this.cmbTransEdgeHeight1.IsValid = true;
            this.cmbTransEdgeHeight1.Location = new System.Drawing.Point(136, 109);
            this.cmbTransEdgeHeight1.Name = "cmbTransEdgeHeight1";
            this.cmbTransEdgeHeight1.Size = new System.Drawing.Size(163, 20);
            this.cmbTransEdgeHeight1.TabIndex = 93;
            this.cmbTransEdgeHeight1.ValidEmptyMsg = "边高不能为空";
            // 
            // cmbTransMainSpec1
            // 
            this.cmbTransMainSpec1.BindDataField = null;
            this.cmbTransMainSpec1.BindDataTag = null;
            this.cmbTransMainSpec1.BindDataText = "tent_MainSpec";
            this.cmbTransMainSpec1.EmptyValue = null;
            this.cmbTransMainSpec1.IsGetBind = true;
            this.cmbTransMainSpec1.IsSetBind = true;
            this.cmbTransMainSpec1.IsValid = true;
            this.cmbTransMainSpec1.Location = new System.Drawing.Point(136, 19);
            this.cmbTransMainSpec1.Name = "cmbTransMainSpec1";
            this.cmbTransMainSpec1.Size = new System.Drawing.Size(163, 20);
            this.cmbTransMainSpec1.TabIndex = 92;
            this.cmbTransMainSpec1.ValidEmptyMsg = "规格不能为空";
            // 
            // FmTransportMaxInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 258);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmTransportMaxInfo";
            this.Text = "最长件信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput4;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput3;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput2;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GaoShan.Sales.UI.Ctr.CmbTransMainSpec cmbTransMainSpec1;
        private GaoShan.Sales.UI.Ctr.CmbTransEdgeHeight cmbTransEdgeHeight1;
    }
}