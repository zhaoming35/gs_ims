namespace GaoShan.Sales.Com.UI
{
    partial class FmExpendItemManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmExpendItemManager));
            this.toolStripItem = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.panelClient.SuspendLayout();
            this.toolStripItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Size = new System.Drawing.Size(239, 425);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDataGrid1);
            this.panelClient.Controls.Add(this.toolStripItem);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // toolStripItem
            // 
            this.toolStripItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnAdd,
            this.toolStripSeparator5,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnSave});
            this.toolStripItem.Location = new System.Drawing.Point(0, 0);
            this.toolStripItem.Name = "toolStripItem";
            this.toolStripItem.Size = new System.Drawing.Size(800, 31);
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
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 28);
            this.btnDelete.Text = "删除";
            this.btnDelete.ToolTipText = "删除商品";
            // 
            // mDataGrid1
            // 
            this.mDataGrid1.AllowUserToAddRows = false;
            this.mDataGrid1.AllowUserToDeleteRows = false;
            this.mDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(0, 31);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.Size = new System.Drawing.Size(800, 394);
            this.mDataGrid1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "item_Value";
            this.Column1.HeaderText = "项目编号";
            this.Column1.Name = "Column1";
            //this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "item_Name";
            this.Column2.HeaderText = "项目名称";
            this.Column2.Name = "Column2";
            //this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "define_Flag";
            this.Column3.FalseValue = "0";
            this.Column3.HeaderText = "参与提成计算";
            this.Column3.Name = "Column3";
            //this.Column3.ReadOnly = true;
            this.Column3.TrueValue = "1";
            this.Column3.Width = 150;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 28);
            this.btnSave.Text = "保存";
            // 
            // FmExpendItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmExpendItemManager";
            this.ShowNavPanel = false;
            this.Text = "FmExpendItemManager";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnDelete;
        private Miles.Framework.UI.Controls.MDataGrid mDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
    }
}