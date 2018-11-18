namespace GaoShan.Sales.Template.UI
{
    partial class FmTemplateManager
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
            this.ucTmpList1 = new GaoShan.Sales.Template.UI.UCTmpList();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucPartInfo1 = new GaoShan.Sales.Template.UI.UCPartInfo();
            this.ucPartBody1 = new GaoShan.Sales.Template.UI.UCPartBody();
            this.panelTop = new System.Windows.Forms.Panel();
            this.d_TmpExplain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.d_TmpName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.splitContainer1);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.splitContainer1.Panel1.Controls.Add(this.ucTmpList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucTmpList1
            // 
            this.ucTmpList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTmpList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTmpList1.FontSize = 12F;
            this.ucTmpList1.Location = new System.Drawing.Point(0, 0);
            this.ucTmpList1.Name = "ucTmpList1";
            this.ucTmpList1.Size = new System.Drawing.Size(266, 425);
            this.ucTmpList1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 425);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucPartInfo1);
            this.tabPage1.Controls.Add(this.ucPartBody1);
            this.tabPage1.Controls.Add(this.panelTop);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "模板信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucPartInfo1
            // 
            this.ucPartInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPartInfo1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucPartInfo1.FontSize = 12F;
            this.ucPartInfo1.Location = new System.Drawing.Point(3, 33);
            this.ucPartInfo1.Name = "ucPartInfo1";
            this.ucPartInfo1.Size = new System.Drawing.Size(516, 121);
            this.ucPartInfo1.TabIndex = 3;
            // 
            // ucPartBody1
            // 
            this.ucPartBody1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPartBody1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucPartBody1.FontSize = 12F;
            this.ucPartBody1.Location = new System.Drawing.Point(3, 154);
            this.ucPartBody1.Name = "ucPartBody1";
            this.ucPartBody1.Size = new System.Drawing.Size(516, 238);
            this.ucPartBody1.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.d_TmpExplain);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.d_TmpName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(516, 30);
            this.panelTop.TabIndex = 1;
            // 
            // d_TmpExplain
            // 
            this.d_TmpExplain.AutoSize = true;
            this.d_TmpExplain.ForeColor = System.Drawing.Color.DeepPink;
            this.d_TmpExplain.Location = new System.Drawing.Point(343, 7);
            this.d_TmpExplain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d_TmpExplain.Name = "d_TmpExplain";
            this.d_TmpExplain.Size = new System.Drawing.Size(72, 16);
            this.d_TmpExplain.TabIndex = 71;
            this.d_TmpExplain.Text = "模板说明";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(258, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "模板说明：";
            // 
            // d_TmpName
            // 
            this.d_TmpName.AutoSize = true;
            this.d_TmpName.ForeColor = System.Drawing.Color.DeepPink;
            this.d_TmpName.Location = new System.Drawing.Point(93, 7);
            this.d_TmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d_TmpName.Name = "d_TmpName";
            this.d_TmpName.Size = new System.Drawing.Size(72, 16);
            this.d_TmpName.TabIndex = 69;
            this.d_TmpName.Text = "模板名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "模板名称：";
            // 
            // FmTemplateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmTemplateManager";
            this.ShowNavPanel = false;
            this.Text = "FmTemplateManager";
            this.panelClient.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UCTmpList ucTmpList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label d_TmpExplain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label d_TmpName;
        private System.Windows.Forms.Label label1;
        private UCPartBody ucPartBody1;
        private UCPartInfo ucPartInfo1;
    }
}