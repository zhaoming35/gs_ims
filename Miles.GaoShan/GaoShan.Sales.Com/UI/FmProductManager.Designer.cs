namespace GaoShan.Sales.Com.UI
{
    partial class FmProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmProductManager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navGroupPanel1 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.toolStripItem = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.navGroupPanel2 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.mDataGrid2 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddPro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditPro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeletePro = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.navGroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).BeginInit();
            this.toolStripItem.SuspendLayout();
            this.navGroupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid2)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.navGroupPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.navGroupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // navGroupPanel1
            // 
            this.navGroupPanel1.AssociatedSplitter = null;
            this.navGroupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel1.CaptionFont = new System.Drawing.Font("微软雅黑", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel1.CaptionHeight = 27;
            this.navGroupPanel1.Controls.Add(this.mDataGrid1);
            this.navGroupPanel1.Controls.Add(this.toolStripItem);
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
            this.navGroupPanel1.Size = new System.Drawing.Size(266, 425);
            this.navGroupPanel1.TabIndex = 0;
            this.navGroupPanel1.Text = "产品信息";
            this.navGroupPanel1.ToolTipTextCloseIcon = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // mDataGrid1
            // 
            this.mDataGrid1.AllowUserToAddRows = false;
            this.mDataGrid1.AllowUserToDeleteRows = false;
            this.mDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(1, 59);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.ReadOnly = true;
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGrid1.Size = new System.Drawing.Size(264, 365);
            this.mDataGrid1.TabIndex = 6;
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
            this.toolStripItem.Location = new System.Drawing.Point(1, 28);
            this.toolStripItem.Name = "toolStripItem";
            this.toolStripItem.Size = new System.Drawing.Size(264, 31);
            this.toolStripItem.TabIndex = 5;
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
            this.btnAdd.ToolTipText = "添加商品";
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
            this.btnEdit.ToolTipText = "修改商品";
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
            this.btnDelete.ToolTipText = "删除商品";
            // 
            // navGroupPanel2
            // 
            this.navGroupPanel2.AssociatedSplitter = null;
            this.navGroupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel2.CaptionFont = new System.Drawing.Font("微软雅黑", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel2.CaptionHeight = 27;
            this.navGroupPanel2.Controls.Add(this.mDataGrid2);
            this.navGroupPanel2.Controls.Add(this.toolStrip1);
            this.navGroupPanel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.navGroupPanel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navGroupPanel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.navGroupPanel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
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
            this.navGroupPanel2.Size = new System.Drawing.Size(530, 425);
            this.navGroupPanel2.TabIndex = 0;
            this.navGroupPanel2.Text = "产品属性信息";
            this.navGroupPanel2.ToolTipTextCloseIcon = null;
            this.navGroupPanel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // mDataGrid2
            // 
            this.mDataGrid2.AllowUserToAddRows = false;
            this.mDataGrid2.AllowUserToDeleteRows = false;
            this.mDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.mDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid2.Location = new System.Drawing.Point(1, 59);
            this.mDataGrid2.MultiSelect = false;
            this.mDataGrid2.Name = "mDataGrid2";
            this.mDataGrid2.ReadOnly = true;
            this.mDataGrid2.RowFilter = null;
            this.mDataGrid2.RowTemplate.Height = 23;
            this.mDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGrid2.Size = new System.Drawing.Size(528, 365);
            this.mDataGrid2.TabIndex = 6;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "property_Name";
            this.Column3.HeaderText = "属性名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "property_Unit";
            this.Column4.HeaderText = "属性单位";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "property_Seq";
            this.Column5.HeaderText = "属性序号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "is_Spec";
            this.Column6.FalseValue = "0";
            this.Column6.HeaderText = "是规格属性";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.TrueValue = "1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnAddPro,
            this.toolStripSeparator3,
            this.btnEditPro,
            this.toolStripSeparator4,
            this.btnDeletePro});
            this.toolStrip1.Location = new System.Drawing.Point(1, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPro.Image")));
            this.btnAddPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(60, 28);
            this.btnAddPro.Text = "添加";
            this.btnAddPro.ToolTipText = "添加商品";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEditPro
            // 
            this.btnEditPro.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPro.Image")));
            this.btnEditPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(60, 28);
            this.btnEditPro.Text = "修改";
            this.btnEditPro.ToolTipText = "修改商品";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePro.Image")));
            this.btnDeletePro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(60, 28);
            this.btnDeletePro.Text = "删除";
            this.btnDeletePro.ToolTipText = "删除商品";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_Name";
            this.Column1.HeaderText = "产品名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_Unit";
            this.Column2.HeaderText = "单位";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "seq_No";
            this.Column7.HeaderText = "序号";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmProductManager";
            this.ShowNavPanel = false;
            this.Text = "FmProductManager";
            this.panelClient.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.navGroupPanel1.ResumeLayout(false);
            this.navGroupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).EndInit();
            this.toolStripItem.ResumeLayout(false);
            this.toolStripItem.PerformLayout();
            this.navGroupPanel2.ResumeLayout(false);
            this.navGroupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel1;
        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel2;
        private System.Windows.Forms.ToolStrip toolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEditPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDeletePro;
        private Miles.Framework.UI.Controls.MDataGrid mDataGrid1;
        private Miles.Framework.UI.Controls.MDataGrid mDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}