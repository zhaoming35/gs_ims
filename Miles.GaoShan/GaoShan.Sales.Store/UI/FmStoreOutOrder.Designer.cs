namespace GaoShan.Sales.Store.UI
{
    partial class FmStoreOutOrder
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
            this.ucOutOrder1 = new GaoShan.Sales.Store.UI.UC.UCOutOrder();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucOutOrderList1 = new GaoShan.Sales.Store.UI.UC.UCOutOrderList();
            this.navGroupPanel2 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.ucOutOrderItem1 = new GaoShan.Sales.Store.UI.UC.UCOutOrderItem();
            this.panelClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.navGroupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.tabControl1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucOutOrder1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未完成出库项目";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucOutOrder1
            // 
            this.ucOutOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOutOrder1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucOutOrder1.FontSize = 12F;
            this.ucOutOrder1.Location = new System.Drawing.Point(3, 3);
            this.ucOutOrder1.Name = "ucOutOrder1";
            this.ucOutOrder1.Size = new System.Drawing.Size(786, 391);
            this.ucOutOrder1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "未提交出库单";
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
            this.splitContainer1.Panel1.Controls.Add(this.ucOutOrderList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.navGroupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(786, 391);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucOutOrderList1
            // 
            this.ucOutOrderList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOutOrderList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucOutOrderList1.FontSize = 12F;
            this.ucOutOrderList1.Location = new System.Drawing.Point(0, 0);
            this.ucOutOrderList1.Name = "ucOutOrderList1";
            this.ucOutOrderList1.Size = new System.Drawing.Size(239, 391);
            this.ucOutOrderList1.TabIndex = 0;
            // 
            // navGroupPanel2
            // 
            this.navGroupPanel2.AssociatedSplitter = null;
            this.navGroupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel2.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel2.CaptionHeight = 27;
            this.navGroupPanel2.Controls.Add(this.ucOutOrderItem1);
            this.navGroupPanel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.navGroupPanel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navGroupPanel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.navGroupPanel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.navGroupPanel2.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel2.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel2.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.navGroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navGroupPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.Image = null;
            this.navGroupPanel2.Location = new System.Drawing.Point(0, 0);
            this.navGroupPanel2.MinimumSize = new System.Drawing.Size(27, 27);
            this.navGroupPanel2.Name = "navGroupPanel2";
            this.navGroupPanel2.PanelStyle = Miles.Framework.UI.Controls.NavBarGroup.PanelStyle.Office2007;
            this.navGroupPanel2.Size = new System.Drawing.Size(543, 391);
            this.navGroupPanel2.TabIndex = 1;
            this.navGroupPanel2.Text = "出库单物料信息";
            this.navGroupPanel2.ToolTipTextCloseIcon = null;
            this.navGroupPanel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // ucOutOrderItem1
            // 
            this.ucOutOrderItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOutOrderItem1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucOutOrderItem1.FontSize = 12F;
            this.ucOutOrderItem1.Location = new System.Drawing.Point(1, 28);
            this.ucOutOrderItem1.Name = "ucOutOrderItem1";
            this.ucOutOrderItem1.Size = new System.Drawing.Size(541, 362);
            this.ucOutOrderItem1.TabIndex = 0;
            // 
            // FmStoreOutOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmStoreOutOrder";
            this.ShowNavPanel = false;
            this.Text = "FmStoreOutOrder";
            this.panelClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.navGroupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UC.UCOutOrder ucOutOrder1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel2;
        private UC.UCOutOrderList ucOutOrderList1;
        private UC.UCOutOrderItem ucOutOrderItem1;
    }
}