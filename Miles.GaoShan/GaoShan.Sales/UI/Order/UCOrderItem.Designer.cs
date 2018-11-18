namespace GaoShan.Sales.UI.Order
{
    partial class UCOrderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrderItem));
            this.toolStripItem = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripItem.Location = new System.Drawing.Point(0, 0);
            this.toolStripItem.Name = "toolStripItem";
            this.toolStripItem.Size = new System.Drawing.Size(659, 31);
            this.toolStripItem.TabIndex = 13;
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
            // mDataGrid1
            // 
            this.mDataGrid1.AllowUserToAddRows = false;
            this.mDataGrid1.AllowUserToDeleteRows = false;
            this.mDataGrid1.AllowUserToResizeRows = false;
            this.mDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.mDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Column1,
            this.Column3});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(0, 31);
            this.mDataGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.ReadOnly = true;
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.mDataGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.Size = new System.Drawing.Size(659, 398);
            this.mDataGrid1.TabIndex = 17;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "product_Name";
            this.Column4.HeaderText = "产品名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "item_Type";
            this.Column2.HeaderText = "型号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemSpec";
            this.Column1.HeaderText = "规格";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductCountUnit";
            this.Column3.HeaderText = "数量";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UCOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mDataGrid1);
            this.Controls.Add(this.toolStripItem);
            this.Name = "UCOrderItem";
            this.Size = new System.Drawing.Size(659, 429);
            this.toolStripItem.ResumeLayout(false);
            this.toolStripItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private Miles.Framework.UI.Controls.MDataGrid mDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
