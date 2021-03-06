﻿namespace GaoShan.Sales.MatchTb.UI
{
    partial class FmSzcFormula
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
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mDecimalInput2 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mDecimalInput3 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDecimalInput3);
            this.panelClient.Controls.Add(this.mDecimalInput2);
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(340, 166);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(35, 35);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 16);
            this.label20.TabIndex = 79;
            this.label20.Text = "下限：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "上限：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "结果：";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "RT";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(98, 105);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(180, 21);
            this.mDecimalInput1.TabIndex = 89;
            this.mDecimalInput1.ValidEmptyMsg = "不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // mDecimalInput2
            // 
            this.mDecimalInput2.BindDataField = "DL";
            this.mDecimalInput2.BindDataTag = null;
            this.mDecimalInput2.BindDataText = null;
            this.mDecimalInput2.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput2.IsGetBind = true;
            this.mDecimalInput2.IsSetBind = true;
            this.mDecimalInput2.IsValid = true;
            this.mDecimalInput2.Location = new System.Drawing.Point(98, 33);
            this.mDecimalInput2.Name = "mDecimalInput2";
            this.mDecimalInput2.Size = new System.Drawing.Size(180, 21);
            this.mDecimalInput2.TabIndex = 90;
            this.mDecimalInput2.ValidEmptyMsg = "不能为空";
            this.mDecimalInput2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // mDecimalInput3
            // 
            this.mDecimalInput3.BindDataField = "UL";
            this.mDecimalInput3.BindDataTag = null;
            this.mDecimalInput3.BindDataText = null;
            this.mDecimalInput3.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput3.IsGetBind = true;
            this.mDecimalInput3.IsSetBind = true;
            this.mDecimalInput3.IsValid = true;
            this.mDecimalInput3.Location = new System.Drawing.Point(98, 69);
            this.mDecimalInput3.Name = "mDecimalInput3";
            this.mDecimalInput3.Size = new System.Drawing.Size(180, 21);
            this.mDecimalInput3.TabIndex = 91;
            this.mDecimalInput3.ValidEmptyMsg = "不能为空";
            this.mDecimalInput3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FmSzcFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmSzcFormula";
            this.Text = "变量信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput3;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput2;
    }
}