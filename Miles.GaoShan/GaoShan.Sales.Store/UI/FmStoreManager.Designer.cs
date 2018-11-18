namespace GaoShan.Sales.Store.UI
{
    partial class FmStoreManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.navGroupPanel1 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.mDataGridItem = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMtlKind1 = new Ctr.CmbMtlKind();
            this.cmbMtlInfo1 = new GaoShan.Sales.UI.Ctr.CmbMtlInfo();
            this.panelClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.navGroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Size = new System.Drawing.Size(239, 425);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.navGroupPanel1);
            this.panelClient.Controls.Add(this.groupBox1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cmbMtlInfo1);
            this.groupBox1.Controls.Add(this.cmbMtlKind1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // navGroupPanel1
            // 
            this.navGroupPanel1.AssociatedSplitter = null;
            this.navGroupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel1.CaptionFont = new System.Drawing.Font("微软雅黑", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel1.CaptionHeight = 27;
            this.navGroupPanel1.Controls.Add(this.mDataGridItem);
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
            this.navGroupPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navGroupPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.Image = null;
            this.navGroupPanel1.Location = new System.Drawing.Point(0, 65);
            this.navGroupPanel1.MinimumSize = new System.Drawing.Size(27, 27);
            this.navGroupPanel1.Name = "navGroupPanel1";
            this.navGroupPanel1.PanelStyle = Miles.Framework.UI.Controls.NavBarGroup.PanelStyle.Office2007;
            this.navGroupPanel1.Size = new System.Drawing.Size(800, 360);
            this.navGroupPanel1.TabIndex = 2;
            this.navGroupPanel1.Text = "物料库存";
            this.navGroupPanel1.ToolTipTextCloseIcon = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // mDataGridItem
            // 
            this.mDataGridItem.AllowUserToAddRows = false;
            this.mDataGridItem.AllowUserToDeleteRows = false;
            this.mDataGridItem.ColumnHeadersHeight = 25;
            this.mDataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column6,
            this.Column4});
            this.mDataGridItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridItem.Location = new System.Drawing.Point(1, 28);
            this.mDataGridItem.MultiSelect = false;
            this.mDataGridItem.Name = "mDataGridItem";
            this.mDataGridItem.ReadOnly = true;
            this.mDataGridItem.RowFilter = null;
            this.mDataGridItem.RowHeadersWidth = 30;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mDataGridItem.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mDataGridItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mDataGridItem.RowTemplate.Height = 23;
            this.mDataGridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mDataGridItem.Size = new System.Drawing.Size(798, 331);
            this.mDataGridItem.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mtl_Code";
            this.Column1.HeaderText = "物料编码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mtl_Name";
            this.Column2.HeaderText = "物料名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Kind_Name";
            this.Column3.HeaderText = "分类";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mtl_Spec";
            this.Column7.HeaderText = "规格";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 220;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mtl_Unit";
            this.Column6.HeaderText = "单位";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mtl_Qty";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "所属分类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(324, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "物料信息：";
            // 
            // cmbMtlKind1
            // 
            this.cmbMtlKind1.BindDataField = null;
            this.cmbMtlKind1.BindDataTag = null;
            this.cmbMtlKind1.BindDataText = null;
            this.cmbMtlKind1.EmptyValue = null;
            this.cmbMtlKind1.IsGetBind = true;
            this.cmbMtlKind1.IsSetBind = true;
            this.cmbMtlKind1.IsValid = false;
            this.cmbMtlKind1.Location = new System.Drawing.Point(96, 27);
            this.cmbMtlKind1.Name = "cmbMtlKind1";
            this.cmbMtlKind1.Size = new System.Drawing.Size(148, 24);
            this.cmbMtlKind1.TabIndex = 82;
            this.cmbMtlKind1.ValidEmptyMsg = null;
            // 
            // cmbMtlInfo1
            // 
            this.cmbMtlInfo1.BindDataField = null;
            this.cmbMtlInfo1.BindDataTag = null;
            this.cmbMtlInfo1.BindDataText = null;
            this.cmbMtlInfo1.EmptyValue = null;
            this.cmbMtlInfo1.IsGetBind = true;
            this.cmbMtlInfo1.IsSetBind = true;
            this.cmbMtlInfo1.IsValid = false;
            this.cmbMtlInfo1.Location = new System.Drawing.Point(401, 27);
            this.cmbMtlInfo1.Name = "cmbMtlInfo1";
            this.cmbMtlInfo1.Size = new System.Drawing.Size(148, 24);
            this.cmbMtlInfo1.TabIndex = 83;
            this.cmbMtlInfo1.ValidEmptyMsg = null;
            // 
            // FmStoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmStoreManager";
            this.ShowNavPanel = false;
            this.Text = "FmStoreManager";
            this.panelClient.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.navGroupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel1;
        private Miles.Framework.UI.Controls.MDataGrid mDataGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private GaoShan.Sales.UI.Ctr.CmbMtlInfo cmbMtlInfo1;
        private Ctr.CmbMtlKind cmbMtlKind1;
    }
}