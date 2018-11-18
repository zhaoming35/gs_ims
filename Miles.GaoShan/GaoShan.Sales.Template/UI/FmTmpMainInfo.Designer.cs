namespace GaoShan.Sales.Template.UI
{
    partial class FmTmpMainInfo
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
            this.d_linkWay1 = new Miles.Framework.UI.Controls.MTextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.d_linkWay2 = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_linkWay2);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.d_linkWay1);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Size = new System.Drawing.Size(315, 135);
            // 
            // d_linkWay1
            // 
            this.d_linkWay1.BindDataField = "linkWay1";
            this.d_linkWay1.BindDataTag = null;
            this.d_linkWay1.BindDataText = null;
            this.d_linkWay1.EmptyValue = null;
            this.d_linkWay1.IsGetBind = true;
            this.d_linkWay1.IsSetBind = true;
            this.d_linkWay1.IsValid = true;
            this.d_linkWay1.Location = new System.Drawing.Point(108, 33);
            this.d_linkWay1.Name = "d_linkWay1";
            this.d_linkWay1.Size = new System.Drawing.Size(169, 21);
            this.d_linkWay1.TabIndex = 73;
            this.d_linkWay1.ValidEmptyMsg = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "监督电话：";
            // 
            // d_linkWay2
            // 
            this.d_linkWay2.BindDataField = "linkWay2";
            this.d_linkWay2.BindDataTag = null;
            this.d_linkWay2.BindDataText = null;
            this.d_linkWay2.EmptyValue = null;
            this.d_linkWay2.IsGetBind = true;
            this.d_linkWay2.IsSetBind = true;
            this.d_linkWay2.IsValid = true;
            this.d_linkWay2.Location = new System.Drawing.Point(108, 78);
            this.d_linkWay2.Name = "d_linkWay2";
            this.d_linkWay2.Size = new System.Drawing.Size(169, 21);
            this.d_linkWay2.TabIndex = 75;
            this.d_linkWay2.ValidEmptyMsg = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 74;
            this.label2.Text = "合同版本号：";
            // 
            // FmTmpMainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 182);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmTmpMainInfo";
            this.Text = "合同页脚";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_linkWay1;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput d_linkWay2;
        private System.Windows.Forms.Label label2;
    }
}