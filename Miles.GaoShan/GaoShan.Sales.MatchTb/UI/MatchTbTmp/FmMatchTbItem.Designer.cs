namespace GaoShan.Sales.MatchTb.UI
{
    partial class FmMatchTbItem
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
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMtlInfo1 = new GaoShan.Sales.UI.Ctr.CmbMtlInfo();
            this.cmbMatchTbVars1 = new GaoShan.Sales.UI.Ctr.CmbMatchTbVars();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.cmbMatchTbVars1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.cmbMtlInfo1);
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(340, 166);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(17, 35);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 79;
            this.label20.Text = "物料名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "数量公式：";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "ItemFormula";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = true;
            this.mTextInput1.Location = new System.Drawing.Point(105, 69);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(217, 26);
            this.mTextInput1.TabIndex = 82;
            this.mTextInput1.ValidEmptyMsg = "不能为空";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "参照变量：";
            // 
            // cmbMtlInfo1
            // 
            this.cmbMtlInfo1.BindDataField = "mtl_Code";
            this.cmbMtlInfo1.BindDataTag = null;
            this.cmbMtlInfo1.BindDataText = null;
            this.cmbMtlInfo1.EmptyValue = null;
            this.cmbMtlInfo1.IsGetBind = true;
            this.cmbMtlInfo1.IsSetBind = true;
            this.cmbMtlInfo1.IsValid = false;
            this.cmbMtlInfo1.Location = new System.Drawing.Point(105, 33);
            this.cmbMtlInfo1.Name = "cmbMtlInfo1";
            this.cmbMtlInfo1.Size = new System.Drawing.Size(217, 20);
            this.cmbMtlInfo1.TabIndex = 83;
            this.cmbMtlInfo1.ValidEmptyMsg = null;
            // 
            // cmbMatchTbVars1
            // 
            this.cmbMatchTbVars1.BindDataField = null;
            this.cmbMatchTbVars1.BindDataTag = null;
            this.cmbMatchTbVars1.BindDataText = null;
            this.cmbMatchTbVars1.EmptyValue = null;
            this.cmbMatchTbVars1.IsGetBind = true;
            this.cmbMatchTbVars1.IsSetBind = true;
            this.cmbMatchTbVars1.IsValid = false;
            this.cmbMatchTbVars1.Location = new System.Drawing.Point(105, 111);
            this.cmbMatchTbVars1.Name = "cmbMatchTbVars1";
            this.cmbMatchTbVars1.Size = new System.Drawing.Size(217, 20);
            this.cmbMatchTbVars1.TabIndex = 85;
            this.cmbMatchTbVars1.ValidEmptyMsg = null;
            // 
            // FmMatchTbItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmMatchTbItem";
            this.Text = "物料组成信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private GaoShan.Sales.UI.Ctr.CmbMtlInfo cmbMtlInfo1;
        private System.Windows.Forms.Label label2;
        private GaoShan.Sales.UI.Ctr.CmbMatchTbVars cmbMatchTbVars1;
    }
}