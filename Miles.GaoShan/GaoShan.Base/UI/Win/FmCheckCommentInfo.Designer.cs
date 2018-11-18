namespace GaoShan.Sales.UI.Win
{
    partial class FmCheckCommentInfo
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
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Size = new System.Drawing.Size(338, 171);
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = null;
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsValid = false;
            this.mTextInput1.Location = new System.Drawing.Point(0, 0);
            this.mTextInput1.Multiline = true;
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(336, 169);
            this.mTextInput1.TabIndex = 0;
            this.mTextInput1.Text = "审核不通过";
            this.mTextInput1.ValidEmptyMsg = null;
            // 
            // FmCheckCommentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 218);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmCheckCommentInfo";
            this.Text = "审核意见";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
    }
}