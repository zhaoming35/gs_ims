namespace GaoShan.Sales.UI.ProjectCost
{
    partial class FmProjectCostManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucProjectCostList1 = new GaoShan.Sales.UI.ProjectCost.UCProjectCostList();
            this.ucProjectCostInfo1 = new GaoShan.Sales.UI.ProjectCost.UCProjectCostInfo();
            this.ucLinkBillList1 = new GaoShan.Sales.UI.LinkBill.UCLinkBillList();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.splitContainer1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucProjectCostInfo1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
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
            this.tabControl1.Size = new System.Drawing.Size(243, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucLinkBillList1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(235, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未填写费用联络单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucProjectCostList1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(137, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "待提交费用";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucProjectCostList1
            // 
            this.ucProjectCostList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectCostList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucProjectCostList1.FontSize = 12F;
            this.ucProjectCostList1.Location = new System.Drawing.Point(3, 3);
            this.ucProjectCostList1.Name = "ucProjectCostList1";
            this.ucProjectCostList1.Size = new System.Drawing.Size(131, 336);
            this.ucProjectCostList1.TabIndex = 2;
            // 
            // ucProjectCostInfo1
            // 
            this.ucProjectCostInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectCostInfo1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucProjectCostInfo1.FontSize = 12F;
            this.ucProjectCostInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectCostInfo1.Name = "ucProjectCostInfo1";
            this.ucProjectCostInfo1.Size = new System.Drawing.Size(553, 425);
            this.ucProjectCostInfo1.TabIndex = 0;
            // 
            // ucLinkBillList1
            // 
            this.ucLinkBillList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkBillList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucLinkBillList1.FontSize = 12F;
            this.ucLinkBillList1.Location = new System.Drawing.Point(3, 3);
            this.ucLinkBillList1.Name = "ucLinkBillList1";
            this.ucLinkBillList1.Size = new System.Drawing.Size(229, 389);
            this.ucLinkBillList1.TabIndex = 0;
            // 
            // FmProjectCostManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmProjectCostManager";
            this.ShowNavPanel = false;
            this.Text = "FmProjectCostManager";
            this.panelClient.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UCProjectCostInfo ucProjectCostInfo1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UCProjectCostList ucProjectCostList1;
        private LinkBill.UCLinkBillList ucLinkBillList1;
    }
}