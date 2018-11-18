namespace GaoShan.Sales.Template.UI
{
    partial class FmTmpInfo
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
            this.d_Explain = new Miles.Framework.UI.Controls.MTextInput();
            this.d_Name = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrderType1 = new GaoShan.Sales.UI.Ctr.CmbOrderType();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.cmbOrderType1);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.d_Explain);
            this.panelClient.Controls.Add(this.d_Name);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(304, 170);
            // 
            // d_Explain
            // 
            this.d_Explain.BindDataField = "tmp_Explain";
            this.d_Explain.BindDataTag = null;
            this.d_Explain.BindDataText = null;
            this.d_Explain.EmptyValue = null;
            this.d_Explain.IsGetBind = true;
            this.d_Explain.IsSetBind = true;
            this.d_Explain.IsValid = false;
            this.d_Explain.Location = new System.Drawing.Point(103, 87);
            this.d_Explain.Multiline = true;
            this.d_Explain.Name = "d_Explain";
            this.d_Explain.Size = new System.Drawing.Size(169, 63);
            this.d_Explain.TabIndex = 72;
            this.d_Explain.ValidEmptyMsg = null;
            // 
            // d_Name
            // 
            this.d_Name.BindDataField = "tmp_Name";
            this.d_Name.BindDataTag = null;
            this.d_Name.BindDataText = null;
            this.d_Name.EmptyValue = null;
            this.d_Name.IsGetBind = true;
            this.d_Name.IsSetBind = true;
            this.d_Name.IsValid = false;
            this.d_Name.Location = new System.Drawing.Point(103, 51);
            this.d_Name.Name = "d_Name";
            this.d_Name.Size = new System.Drawing.Size(169, 26);
            this.d_Name.TabIndex = 71;
            this.d_Name.ValidEmptyMsg = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "模板说明：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "模板名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(30, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "合同类型：";
            // 
            // cmbOrderType1
            // 
            this.cmbOrderType1.BindDataField = null;
            this.cmbOrderType1.BindDataTag = null;
            this.cmbOrderType1.BindDataText = null;
            this.cmbOrderType1.EmptyValue = null;
            this.cmbOrderType1.IsGetBind = true;
            this.cmbOrderType1.IsSetBind = true;
            this.cmbOrderType1.IsValid = false;
            this.cmbOrderType1.Location = new System.Drawing.Point(103, 19);
            this.cmbOrderType1.Name = "cmbOrderType1";
            this.cmbOrderType1.Size = new System.Drawing.Size(169, 24);
            this.cmbOrderType1.TabIndex = 74;
            this.cmbOrderType1.ValidEmptyMsg = null;
            // 
            // FmTmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 217);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmTmpInfo";
            this.Text = "模板信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_Explain;
        private Miles.Framework.UI.Controls.MTextInput d_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Sales.UI.Ctr.CmbOrderType cmbOrderType1;
    }
}