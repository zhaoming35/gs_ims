namespace GaoShan.Sales.UI.Carriage
{
    partial class UCCarriageList
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
            this.navGroupPanel1 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.mDataGridNvl = new Miles.Framework.UI.Controls.MDataGrid();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearchCode = new System.Windows.Forms.ToolStripTextBox();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navGroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridNvl)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navGroupPanel1
            // 
            this.navGroupPanel1.AssociatedSplitter = null;
            this.navGroupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel1.CaptionFont = new System.Drawing.Font("微软雅黑", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel1.CaptionHeight = 27;
            this.navGroupPanel1.Controls.Add(this.mDataGridNvl);
            this.navGroupPanel1.Controls.Add(this.toolStrip3);
            this.navGroupPanel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.navGroupPanel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel1.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navGroupPanel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.navGroupPanel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.navGroupPanel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel1.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel1.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.navGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navGroupPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.Image = null;
            this.navGroupPanel1.Location = new System.Drawing.Point(0, 0);
            this.navGroupPanel1.MinimumSize = new System.Drawing.Size(27, 27);
            this.navGroupPanel1.Name = "navGroupPanel1";
            this.navGroupPanel1.PanelStyle = Miles.Framework.UI.Controls.NavBarGroup.PanelStyle.Office2007;
            this.navGroupPanel1.Size = new System.Drawing.Size(362, 468);
            this.navGroupPanel1.TabIndex = 1;
            this.navGroupPanel1.Text = "运输单列表";
            this.navGroupPanel1.ToolTipTextCloseIcon = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // mDataGridNvl
            // 
            this.mDataGridNvl.AllowUserToAddRows = false;
            this.mDataGridNvl.AllowUserToDeleteRows = false;
            this.mDataGridNvl.AllowUserToResizeRows = false;
            this.mDataGridNvl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.mDataGridNvl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mDataGridNvl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mDataGridNvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridNvl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column1,
            this.Column15});
            this.mDataGridNvl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridNvl.Location = new System.Drawing.Point(1, 53);
            this.mDataGridNvl.MultiSelect = false;
            this.mDataGridNvl.Name = "mDataGridNvl";
            this.mDataGridNvl.ReadOnly = true;
            this.mDataGridNvl.RowFilter = null;
            this.mDataGridNvl.RowHeadersWidth = 30;
            this.mDataGridNvl.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.mDataGridNvl.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.mDataGridNvl.RowTemplate.Height = 23;
            this.mDataGridNvl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGridNvl.Size = new System.Drawing.Size(360, 414);
            this.mDataGridNvl.TabIndex = 6;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.txtSearchCode});
            this.toolStrip3.Location = new System.Drawing.Point(1, 28);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(360, 25);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel3.Text = "编号查找";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.AutoSize = false;
            this.txtSearchCode.BackColor = System.Drawing.Color.Aquamarine;
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(174, 23);
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "odr_No";
            this.Column14.HeaderText = "合同编号";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "carriage_Name";
            this.Column1.HeaderText = "运输单名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "linkBill_Name";
            this.Column15.HeaderText = "项目名称";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 180;
            // 
            // UCCarriageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navGroupPanel1);
            this.Name = "UCCarriageList";
            this.Size = new System.Drawing.Size(362, 468);
            this.navGroupPanel1.ResumeLayout(false);
            this.navGroupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridNvl)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtSearchCode;
        private Miles.Framework.UI.Controls.MDataGrid mDataGridNvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}
