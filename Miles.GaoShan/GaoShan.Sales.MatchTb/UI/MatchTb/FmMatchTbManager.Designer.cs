namespace GaoShan.Sales.MatchTb.UI
{
    partial class FmMatchTbManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucLinkBillPend1 = new GaoShan.Sales.UI.UC.UCLinkBillPend();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ucMacchTbList1 = new GaoShan.Sales.MatchTb.UI.UCMatchTbList();
            this.ucMatchTbInfo1 = new GaoShan.Sales.MatchTb.UI.UCMatchTbInfo();
            this.panelClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.tabControl1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(987, 425);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucLinkBillPend1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未完成配套表联络单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucLinkBillPend1
            // 
            this.ucLinkBillPend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkBillPend1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucLinkBillPend1.FontSize = 12F;
            this.ucLinkBillPend1.Location = new System.Drawing.Point(3, 3);
            this.ucLinkBillPend1.Name = "ucLinkBillPend1";
            this.ucLinkBillPend1.Size = new System.Drawing.Size(973, 389);
            this.ucLinkBillPend1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "待提交配套表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ucMacchTbList1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ucMatchTbInfo1);
            this.splitContainer2.Size = new System.Drawing.Size(973, 389);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.TabIndex = 1;
            // 
            // ucMacchTbList1
            // 
            this.ucMacchTbList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMacchTbList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucMacchTbList1.FontSize = 12F;
            this.ucMacchTbList1.Location = new System.Drawing.Point(0, 0);
            this.ucMacchTbList1.Name = "ucMacchTbList1";
            this.ucMacchTbList1.Size = new System.Drawing.Size(271, 389);
            this.ucMacchTbList1.TabIndex = 0;
            // 
            // ucMatchTbInfo1
            // 
            this.ucMatchTbInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMatchTbInfo1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucMatchTbInfo1.FontSize = 12F;
            this.ucMatchTbInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucMatchTbInfo1.Name = "ucMatchTbInfo1";
            this.ucMatchTbInfo1.Size = new System.Drawing.Size(698, 389);
            this.ucMatchTbInfo1.TabIndex = 0;
            // 
            // FmMatchTbManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Name = "FmMatchTbManager";
            this.ShowNavPanel = false;
            this.Text = "FmMatchTbManager";
            this.panelClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UCMatchTbList ucMacchTbList1;
        private UCMatchTbInfo ucMatchTbInfo1;
        private GaoShan.Sales.UI.UC.UCLinkBillPend ucLinkBillPend1;
    }
}