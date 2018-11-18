namespace GaoShan.Sales.Quote.UI
{
    partial class FmPlaceInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.lblParentName);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label19);
            this.panelClient.Size = new System.Drawing.Size(317, 147);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(23, 36);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 76;
            this.label19.Text = "上级名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "行政名称：";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblParentName.Location = new System.Drawing.Point(119, 36);
            this.lblParentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(88, 16);
            this.lblParentName.TabIndex = 78;
            this.lblParentName.Text = "上级名称：";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "place_Name";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = true;
            this.mTextInput1.Location = new System.Drawing.Point(113, 73);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(163, 21);
            this.mTextInput1.TabIndex = 79;
            this.mTextInput1.ValidEmptyMsg = "名称不能空";
            // 
            // FmPlaceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 194);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmPlaceInfo";
            this.Text = "行政区域信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label lblParentName;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
    }
}