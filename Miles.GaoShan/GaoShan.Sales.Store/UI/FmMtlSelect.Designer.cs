namespace GaoShan.Sales.Store.UI
{
    partial class FmMtlSelect
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
            this.label19 = new System.Windows.Forms.Label();
            this.cmbMtlInfo1 = new GaoShan.Sales.UI.Ctr.CmbMtlInfo();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.cmbMtlInfo1);
            this.panelClient.Controls.Add(this.label19);
            this.panelClient.Size = new System.Drawing.Size(272, 116);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(16, 49);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 75;
            this.label19.Text = "物料信息：";
            // 
            // cmbMtlInfo1
            // 
            this.cmbMtlInfo1.BindDataField = null;
            this.cmbMtlInfo1.BindDataTag = null;
            this.cmbMtlInfo1.BindDataText = null;
            this.cmbMtlInfo1.EmptyValue = null;
            this.cmbMtlInfo1.IsGetBind = true;
            this.cmbMtlInfo1.IsSetBind = true;
            this.cmbMtlInfo1.IsValid = true;
            this.cmbMtlInfo1.Location = new System.Drawing.Point(104, 47);
            this.cmbMtlInfo1.Name = "cmbMtlInfo1";
            this.cmbMtlInfo1.Size = new System.Drawing.Size(151, 20);
            this.cmbMtlInfo1.TabIndex = 76;
            this.cmbMtlInfo1.ValidEmptyMsg = "物料信息不能为空";
            // 
            // FmMtlSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 163);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmMtlSelect";
            this.Text = "物料选择";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GaoShan.Sales.UI.Ctr.CmbMtlInfo cmbMtlInfo1;
        private System.Windows.Forms.Label label19;
    }
}