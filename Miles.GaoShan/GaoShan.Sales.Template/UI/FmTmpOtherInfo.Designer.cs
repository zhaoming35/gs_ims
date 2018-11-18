namespace GaoShan.Sales.Template.UI
{
    partial class FmTmpOtherInfo
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
            this.d_TableSeq = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label3 = new System.Windows.Forms.Label();
            this.d_itemClauseSeq = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label1 = new System.Windows.Forms.Label();
            this.d_itemPaySeq = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_itemPaySeq);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.d_itemClauseSeq);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_TableSeq);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(288, 165);
            // 
            // d_TableSeq
            // 
            this.d_TableSeq.BindDataField = "item_Table_Seq";
            this.d_TableSeq.BindDataTag = null;
            this.d_TableSeq.BindDataText = null;
            this.d_TableSeq.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_TableSeq.IsValid = false;
            this.d_TableSeq.Location = new System.Drawing.Point(158, 28);
            this.d_TableSeq.Name = "d_TableSeq";
            this.d_TableSeq.Size = new System.Drawing.Size(93, 26);
            this.d_TableSeq.TabIndex = 88;
            this.d_TableSeq.ValidEmptyMsg = "产品表格序号不能为空";
            this.d_TableSeq.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "产品表格序号：";
            // 
            // d_itemClauseSeq
            // 
            this.d_itemClauseSeq.BindDataField = "item_Clause_Seq";
            this.d_itemClauseSeq.BindDataTag = null;
            this.d_itemClauseSeq.BindDataText = null;
            this.d_itemClauseSeq.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_itemClauseSeq.IsValid = true;
            this.d_itemClauseSeq.Location = new System.Drawing.Point(158, 108);
            this.d_itemClauseSeq.Name = "d_itemClauseSeq";
            this.d_itemClauseSeq.Size = new System.Drawing.Size(93, 26);
            this.d_itemClauseSeq.TabIndex = 90;
            this.d_itemClauseSeq.ValidEmptyMsg = "条款模板序号不能为空";
            this.d_itemClauseSeq.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(36, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "条款模板序号：";
            // 
            // d_itemPaySeq
            // 
            this.d_itemPaySeq.BindDataField = "item_Pay_Seq";
            this.d_itemPaySeq.BindDataTag = null;
            this.d_itemPaySeq.BindDataText = null;
            this.d_itemPaySeq.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_itemPaySeq.IsValid = true;
            this.d_itemPaySeq.Location = new System.Drawing.Point(158, 68);
            this.d_itemPaySeq.Name = "d_itemPaySeq";
            this.d_itemPaySeq.Size = new System.Drawing.Size(93, 26);
            this.d_itemPaySeq.TabIndex = 92;
            this.d_itemPaySeq.ValidEmptyMsg = "付款模板序号不能为空";
            this.d_itemPaySeq.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "付款模板序号：";
            // 
            // FmTmpOtherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 212);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmTmpOtherInfo";
            this.Text = "模板其它属性";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MDecimalInput d_TableSeq;
        private System.Windows.Forms.Label label3;
        private Miles.Framework.UI.Controls.MDecimalInput d_itemClauseSeq;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MDecimalInput d_itemPaySeq;
        private System.Windows.Forms.Label label2;
    }
}