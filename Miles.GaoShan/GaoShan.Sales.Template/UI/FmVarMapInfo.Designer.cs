namespace GaoShan.Sales.Template.UI
{
    partial class FmVarMapInfo
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
            this.d_Format = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d_ParmName = new Miles.Framework.UI.Controls.MLabel();
            this.txtBindOrderHead1 = new GaoShan.Sales.UI.Ctr.TxtBindOrderMain();
            this.label3 = new System.Windows.Forms.Label();
            this.d_Explain = new Miles.Framework.UI.Controls.MTextInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_Explain);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.txtBindOrderHead1);
            this.panelClient.Controls.Add(this.d_ParmName);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_Format);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(307, 187);
            // 
            // d_Format
            // 
            this.d_Format.BindDataField = "field_Format";
            this.d_Format.BindDataTag = null;
            this.d_Format.BindDataText = null;
            this.d_Format.Location = new System.Drawing.Point(115, 129);
            this.d_Format.Name = "d_Format";
            this.d_Format.Size = new System.Drawing.Size(170, 26);
            this.d_Format.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(19, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 75;
            this.label20.Text = "参数名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "绑定数据：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "数据格式：";
            // 
            // d_ParmName
            // 
            this.d_ParmName.AutoSize = true;
            this.d_ParmName.BindDataField = "var_Name";
            this.d_ParmName.BindDataTag = null;
            this.d_ParmName.BindDataText = null;
            this.d_ParmName.Location = new System.Drawing.Point(115, 23);
            this.d_ParmName.Name = "d_ParmName";
            this.d_ParmName.Size = new System.Drawing.Size(72, 16);
            this.d_ParmName.TabIndex = 78;
            this.d_ParmName.Text = "参数名称";
            // 
            // txtBindOrderHead1
            // 
            this.txtBindOrderHead1.BindDataField = "field_Name";
            this.txtBindOrderHead1.BindDataTag = null;
            this.txtBindOrderHead1.BindDataText = "field_Note";
            this.txtBindOrderHead1.DisplayMember = null;
            this.txtBindOrderHead1.Location = new System.Drawing.Point(115, 92);
            this.txtBindOrderHead1.Name = "txtBindOrderHead1";
            this.txtBindOrderHead1.Size = new System.Drawing.Size(170, 26);
            this.txtBindOrderHead1.TabIndex = 79;
            this.txtBindOrderHead1.ValueMember = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "参数说明：";
            // 
            // d_Explain
            // 
            this.d_Explain.BindDataField = "var_Explain";
            this.d_Explain.BindDataTag = null;
            this.d_Explain.BindDataText = null;
            this.d_Explain.Location = new System.Drawing.Point(115, 55);
            this.d_Explain.Name = "d_Explain";
            this.d_Explain.Size = new System.Drawing.Size(170, 26);
            this.d_Explain.TabIndex = 81;
            // 
            // FmParmMapInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 234);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmParmMapInfo";
            this.Text = "参数信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MLabel d_ParmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput d_Format;
        private System.Windows.Forms.Label label20;
        private GaoShan.Sales.UI.Ctr.TxtBindOrderMain txtBindOrderHead1;
        private Miles.Framework.UI.Controls.MTextInput d_Explain;
        private System.Windows.Forms.Label label3;
    }
}