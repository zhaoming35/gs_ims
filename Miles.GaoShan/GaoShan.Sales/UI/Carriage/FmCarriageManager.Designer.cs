namespace GaoShan.Sales.UI.Carriage
{
    partial class FmCarriageManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucCarriageList1 = new GaoShan.Sales.UI.Carriage.UCCarriageList();
            this.ucCarriageInfo1 = new GaoShan.Sales.UI.Carriage.UCCarriageInfo();
            this.panelClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.tabControl1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(876, 425);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucLinkBillPend1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未完成运输单项目";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucLinkBillPend1
            // 
            this.ucLinkBillPend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkBillPend1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucLinkBillPend1.FontSize = 12F;
            this.ucLinkBillPend1.Location = new System.Drawing.Point(3, 3);
            this.ucLinkBillPend1.Name = "ucLinkBillPend1";
            this.ucLinkBillPend1.Size = new System.Drawing.Size(862, 389);
            this.ucLinkBillPend1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "待提交运输单";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucCarriageList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucCarriageInfo1);
            this.splitContainer1.Size = new System.Drawing.Size(862, 389);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucCarriageList1
            // 
            this.ucCarriageList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCarriageList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucCarriageList1.FontSize = 12F;
            this.ucCarriageList1.Location = new System.Drawing.Point(0, 0);
            this.ucCarriageList1.Name = "ucCarriageList1";
            this.ucCarriageList1.Size = new System.Drawing.Size(246, 389);
            this.ucCarriageList1.TabIndex = 0;
            // 
            // ucCarriageInfo1
            // 
            this.ucCarriageInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCarriageInfo1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucCarriageInfo1.FontSize = 12F;
            this.ucCarriageInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucCarriageInfo1.Name = "ucCarriageInfo1";
            this.ucCarriageInfo1.Size = new System.Drawing.Size(612, 389);
            this.ucCarriageInfo1.TabIndex = 0;
            // 
            // FmCarriageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Name = "FmCarriageManager";
            this.ShowNavPanel = false;
            this.Text = "FmCarriageManager";
            this.panelClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.UCLinkBillPend ucLinkBillPend1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UCCarriageList ucCarriageList1;
        private UCCarriageInfo ucCarriageInfo1;
    }
}