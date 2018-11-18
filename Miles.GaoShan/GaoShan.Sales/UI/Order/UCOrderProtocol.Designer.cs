namespace GaoShan.Sales.UI.Order
{
    partial class UCOrderProtocol
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrderProtocol));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSyn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.mRichEditOnly1 = new Miles.Dev.Controls.MRichEditOnly();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSyn,
            this.toolStripSeparator2,
            this.btnImport,
            this.toolStripSeparator3,
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 31);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // btnSyn
            // 
            this.btnSyn.Image = ((System.Drawing.Image)(resources.GetObject("btnSyn.Image")));
            this.btnSyn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.Size = new System.Drawing.Size(96, 28);
            this.btnSyn.Text = "从模板同步";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnImport
            // 
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(60, 28);
            this.btnImport.Text = "导入";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 28);
            this.btnExport.Text = "导出";
            // 
            // mRichEditOnly1
            // 
            this.mRichEditOnly1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mRichEditOnly1.Location = new System.Drawing.Point(0, 31);
            this.mRichEditOnly1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mRichEditOnly1.Name = "mRichEditOnly1";
            this.mRichEditOnly1.ReadOnly = true;
            this.mRichEditOnly1.Size = new System.Drawing.Size(842, 510);
            this.mRichEditOnly1.TabIndex = 12;
            // 
            // UCOrderProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mRichEditOnly1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCOrderProtocol";
            this.Size = new System.Drawing.Size(842, 541);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSyn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExport;
        private Miles.Dev.Controls.MRichEditOnly mRichEditOnly1;
    }
}
