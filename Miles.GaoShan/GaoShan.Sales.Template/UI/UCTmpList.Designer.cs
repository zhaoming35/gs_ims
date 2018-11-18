namespace GaoShan.Sales.Template.UI
{
    partial class UCTmpList
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTmpList));
            this.navGroupPanel1 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.mDataGridNvl = new Miles.Framework.UI.Controls.MDataGrid();
            this.toolStripItem = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.d_OrderType = new System.Windows.Forms.ToolStripComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navGroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridNvl)).BeginInit();
            this.toolStripItem.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navGroupPanel1
            // 
            this.navGroupPanel1.AssociatedSplitter = null;
            this.navGroupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel1.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel1.CaptionHeight = 27;
            this.navGroupPanel1.Controls.Add(this.mDataGridNvl);
            this.navGroupPanel1.Controls.Add(this.toolStripItem);
            this.navGroupPanel1.Controls.Add(this.toolStrip1);
            this.navGroupPanel1.Controls.Add(this.toolStrip3);
            this.navGroupPanel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.navGroupPanel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel1.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navGroupPanel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.navGroupPanel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.navGroupPanel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel1.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel1.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.navGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navGroupPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navGroupPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.Image = null;
            this.navGroupPanel1.Location = new System.Drawing.Point(0, 0);
            this.navGroupPanel1.MinimumSize = new System.Drawing.Size(27, 27);
            this.navGroupPanel1.Name = "navGroupPanel1";
            this.navGroupPanel1.PanelStyle = Miles.Framework.UI.Controls.NavBarGroup.PanelStyle.Office2007;
            this.navGroupPanel1.Size = new System.Drawing.Size(528, 516);
            this.navGroupPanel1.TabIndex = 2;
            this.navGroupPanel1.Text = "模板列表";
            this.navGroupPanel1.ToolTipTextCloseIcon = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // mDataGridNvl
            // 
            this.mDataGridNvl.AllowUserToAddRows = false;
            this.mDataGridNvl.AllowUserToDeleteRows = false;
            this.mDataGridNvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridNvl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.mDataGridNvl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridNvl.Location = new System.Drawing.Point(1, 109);
            this.mDataGridNvl.MultiSelect = false;
            this.mDataGridNvl.Name = "mDataGridNvl";
            this.mDataGridNvl.ReadOnly = true;
            this.mDataGridNvl.RowFilter = null;
            this.mDataGridNvl.RowTemplate.Height = 23;
            this.mDataGridNvl.Size = new System.Drawing.Size(526, 406);
            this.mDataGridNvl.TabIndex = 10;
            // 
            // toolStripItem
            // 
            this.toolStripItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnAdd,
            this.toolStripSeparator5,
            this.btnEdit,
            this.toolStripSeparator6,
            this.btnDelete});
            this.toolStripItem.Location = new System.Drawing.Point(1, 78);
            this.toolStripItem.Name = "toolStripItem";
            this.toolStripItem.Size = new System.Drawing.Size(526, 31);
            this.toolStripItem.TabIndex = 8;
            this.toolStripItem.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 28);
            this.btnAdd.Text = "添加";
            this.btnAdd.ToolTipText = "添加";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 28);
            this.btnEdit.Text = "修改";
            this.btnEdit.ToolTipText = "修改";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 28);
            this.btnDelete.Text = "删除";
            this.btnDelete.ToolTipText = "删除";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(1, 53);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "      查找";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = false;
            this.txtSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 23);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.d_OrderType});
            this.toolStrip3.Location = new System.Drawing.Point(1, 28);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(526, 25);
            this.toolStrip3.TabIndex = 6;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel3.Text = "合同类型";
            // 
            // d_OrderType
            // 
            this.d_OrderType.AutoSize = false;
            this.d_OrderType.BackColor = System.Drawing.Color.White;
            this.d_OrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_OrderType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.d_OrderType.Name = "d_OrderType";
            this.d_OrderType.Size = new System.Drawing.Size(174, 23);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tmp_Name";
            this.Column1.HeaderText = "模板名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tmp_Explain";
            this.Column2.HeaderText = "模板说明";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OrderTypeText";
            this.Column3.HeaderText = "合同类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UCTmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navGroupPanel1);
            this.Name = "UCTmpList";
            this.Size = new System.Drawing.Size(528, 516);
            this.navGroupPanel1.ResumeLayout(false);
            this.navGroupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridNvl)).EndInit();
            this.toolStripItem.ResumeLayout(false);
            this.toolStripItem.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox d_OrderType;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStrip toolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private Miles.Framework.UI.Controls.MDataGrid mDataGridNvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
