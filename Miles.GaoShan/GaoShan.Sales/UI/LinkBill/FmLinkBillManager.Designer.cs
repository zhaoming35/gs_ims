namespace GaoShan.Sales.UI.LinkBill
{
    partial class FmLinkBillManager
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
            this.ucLinkBillList1 = new GaoShan.Sales.UI.LinkBill.UCLinkBillList();
            this.ucLinkBillInfo1 = new GaoShan.Sales.UI.LinkBill.UCLinkBillInfo();
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
            this.splitContainer1.Panel1.Controls.Add(this.ucLinkBillList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucLinkBillInfo1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucLinkBillList1
            // 
            this.ucLinkBillList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkBillList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucLinkBillList1.FontSize = 12F;
            this.ucLinkBillList1.Location = new System.Drawing.Point(0, 0);
            this.ucLinkBillList1.Name = "ucLinkBillList1";
            this.ucLinkBillList1.Size = new System.Drawing.Size(201, 425);
            this.ucLinkBillList1.TabIndex = 0;
            // 
            // ucLinkBillInfo1
            // 
            this.ucLinkBillInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkBillInfo1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucLinkBillInfo1.FontSize = 12F;
            this.ucLinkBillInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucLinkBillInfo1.Name = "ucLinkBillInfo1";
            this.ucLinkBillInfo1.Size = new System.Drawing.Size(595, 425);
            this.ucLinkBillInfo1.TabIndex = 0;
            // 
            // FmLinkBillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmLinkBillManager";
            this.ShowNavPanel = false;
            this.Text = "FmLinkBillManager";
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
        private UCLinkBillList ucLinkBillList1;
        private UCLinkBillInfo ucLinkBillInfo1;
    }
}