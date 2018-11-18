namespace GaoShan.Sales.UI.Admin
{
    partial class FmProjectCostCorrect
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
            this.ucProjectCostList1 = new GaoShan.Sales.UI.ProjectCost.UCProjectCostList();
            this.ucProjectCostInfo1 = new GaoShan.Sales.UI.ProjectCost.UCProjectCostInfo();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Size = new System.Drawing.Size(239, 425);
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
            this.splitContainer1.Panel1.Controls.Add(this.ucProjectCostList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucProjectCostInfo1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucProjectCostList1
            // 
            this.ucProjectCostList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectCostList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucProjectCostList1.FontSize = 12F;
            this.ucProjectCostList1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectCostList1.Name = "ucProjectCostList1";
            this.ucProjectCostList1.Size = new System.Drawing.Size(266, 425);
            this.ucProjectCostList1.TabIndex = 0;
            // 
            // ucProjectCostInfo1
            // 
            this.ucProjectCostInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectCostInfo1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucProjectCostInfo1.FontSize = 12F;
            this.ucProjectCostInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectCostInfo1.Name = "ucProjectCostInfo1";
            this.ucProjectCostInfo1.Size = new System.Drawing.Size(530, 425);
            this.ucProjectCostInfo1.TabIndex = 0;
            // 
            // FmProjectCostCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmProjectCostCorrect";
            this.ShowNavPanel = false;
            this.Text = "FmProjectCostCorrect";
            this.panelClient.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ProjectCost.UCProjectCostList ucProjectCostList1;
        private ProjectCost.UCProjectCostInfo ucProjectCostInfo1;
    }
}