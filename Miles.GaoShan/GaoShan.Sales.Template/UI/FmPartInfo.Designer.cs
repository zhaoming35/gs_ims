namespace GaoShan.Sales.Template.UI
{
    partial class FmPartInfo
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
            this.d_partName = new Miles.Framework.UI.Controls.MTextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.d_partExplain = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.d_partSeq = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label3 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_partSeq);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.d_partExplain);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.d_partName);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(344, 208);
            // 
            // d_partName
            // 
            this.d_partName.BindDataField = "part_Name";
            this.d_partName.BindDataTag = null;
            this.d_partName.BindDataText = null;
            this.d_partName.Location = new System.Drawing.Point(115, 22);
            this.d_partName.Name = "d_partName";
            this.d_partName.Size = new System.Drawing.Size(198, 26);
            this.d_partName.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "组成名称：";
            // 
            // d_partExplain
            // 
            this.d_partExplain.BindDataField = "part_Explain";
            this.d_partExplain.BindDataTag = null;
            this.d_partExplain.BindDataText = null;
            this.d_partExplain.Location = new System.Drawing.Point(115, 59);
            this.d_partExplain.Multiline = true;
            this.d_partExplain.Name = "d_partExplain";
            this.d_partExplain.Size = new System.Drawing.Size(198, 63);
            this.d_partExplain.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "组成说明：";
            // 
            // d_partSeq
            // 
            this.d_partSeq.BindDataField = "part_Seq";
            this.d_partSeq.BindDataTag = null;
            this.d_partSeq.BindDataText = null;
            this.d_partSeq.Location = new System.Drawing.Point(115, 136);
            this.d_partSeq.Name = "d_partSeq";
            this.d_partSeq.Size = new System.Drawing.Size(198, 26);
            this.d_partSeq.TabIndex = 86;
            this.d_partSeq.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(30, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "组成顺序：";
            // 
            // FmPartInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmPartInfo";
            this.Text = "模板组成信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_partName;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput d_partExplain;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MDecimalInput d_partSeq;
        private System.Windows.Forms.Label label3;
    }
}