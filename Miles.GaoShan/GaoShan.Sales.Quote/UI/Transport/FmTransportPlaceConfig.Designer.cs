namespace GaoShan.Sales.Quote.UI
{
    partial class FmTransportPlaceConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTransportPlaceConfig));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStripItem = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddPlace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditPlace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeletePlace = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mDataGridTruck = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddTruck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteTruck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveTruck = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mDataGridFee = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddFee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditFee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteFee = new System.Windows.Forms.ToolStripButton();
            this.panelClient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripItem.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridTruck)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridFee)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.tabControl1);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "flag red.png");
            this.imageList1.Images.SetKeyName(2, "flag blue.png");
            this.imageList1.Images.SetKeyName(3, "flag green.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.toolStripItem);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "运输地点信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 34);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(786, 358);
            this.treeView1.TabIndex = 13;
            // 
            // toolStripItem
            // 
            this.toolStripItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnAddPlace,
            this.toolStripSeparator5,
            this.btnEditPlace,
            this.toolStripSeparator6,
            this.btnDeletePlace});
            this.toolStripItem.Location = new System.Drawing.Point(3, 3);
            this.toolStripItem.Name = "toolStripItem";
            this.toolStripItem.Size = new System.Drawing.Size(786, 31);
            this.toolStripItem.TabIndex = 12;
            this.toolStripItem.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPlace.Image")));
            this.btnAddPlace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(60, 28);
            this.btnAddPlace.Text = "添加";
            this.btnAddPlace.ToolTipText = "添加";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEditPlace
            // 
            this.btnEditPlace.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPlace.Image")));
            this.btnEditPlace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPlace.Name = "btnEditPlace";
            this.btnEditPlace.Size = new System.Drawing.Size(60, 28);
            this.btnEditPlace.Text = "修改";
            this.btnEditPlace.ToolTipText = "修改";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDeletePlace
            // 
            this.btnDeletePlace.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePlace.Image")));
            this.btnDeletePlace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePlace.Name = "btnDeletePlace";
            this.btnDeletePlace.Size = new System.Drawing.Size(60, 28);
            this.btnDeletePlace.Text = "删除";
            this.btnDeletePlace.ToolTipText = "删除";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mDataGridTruck);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "车辆规格";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mDataGridTruck
            // 
            this.mDataGridTruck.AllowUserToAddRows = false;
            this.mDataGridTruck.AllowUserToDeleteRows = false;
            this.mDataGridTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridTruck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.mDataGridTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridTruck.Location = new System.Drawing.Point(3, 34);
            this.mDataGridTruck.MultiSelect = false;
            this.mDataGridTruck.Name = "mDataGridTruck";
            this.mDataGridTruck.RowFilter = null;
            this.mDataGridTruck.RowTemplate.Height = 23;
            this.mDataGridTruck.Size = new System.Drawing.Size(786, 358);
            this.mDataGridTruck.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "truck_Name";
            this.Column1.HeaderText = "车辆规格";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "truck_Length";
            this.Column4.HeaderText = "车辆长度";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "truck_Load";
            this.Column2.HeaderText = "车辆吨位";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "per_Cost";
            this.Column3.HeaderText = "每公里费用";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator10,
            this.btnAddTruck,
            this.toolStripSeparator11,
            this.btnDeleteTruck,
            this.toolStripSeparator12,
            this.btnSaveTruck});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 31);
            this.toolStrip3.TabIndex = 14;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAddTruck
            // 
            this.btnAddTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTruck.Image")));
            this.btnAddTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTruck.Name = "btnAddTruck";
            this.btnAddTruck.Size = new System.Drawing.Size(60, 28);
            this.btnAddTruck.Text = "添加";
            this.btnAddTruck.ToolTipText = "添加";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDeleteTruck
            // 
            this.btnDeleteTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTruck.Image")));
            this.btnDeleteTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTruck.Name = "btnDeleteTruck";
            this.btnDeleteTruck.Size = new System.Drawing.Size(60, 28);
            this.btnDeleteTruck.Text = "删除";
            this.btnDeleteTruck.ToolTipText = "删除";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSaveTruck
            // 
            this.btnSaveTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTruck.Image")));
            this.btnSaveTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveTruck.Name = "btnSaveTruck";
            this.btnSaveTruck.Size = new System.Drawing.Size(60, 28);
            this.btnSaveTruck.Text = "保存";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mDataGridFee);
            this.tabPage3.Controls.Add(this.toolStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "车辆运费信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mDataGridFee
            // 
            this.mDataGridFee.AllowUserToAddRows = false;
            this.mDataGridFee.AllowUserToDeleteRows = false;
            this.mDataGridFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.mDataGridFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGridFee.Location = new System.Drawing.Point(3, 34);
            this.mDataGridFee.MultiSelect = false;
            this.mDataGridFee.Name = "mDataGridFee";
            this.mDataGridFee.ReadOnly = true;
            this.mDataGridFee.RowFilter = null;
            this.mDataGridFee.RowTemplate.Height = 23;
            this.mDataGridFee.Size = new System.Drawing.Size(786, 358);
            this.mDataGridFee.TabIndex = 16;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MerName";
            this.Column5.HeaderText = "地点";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "place_Distance";
            this.Column6.HeaderText = "公里数";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "trans_Direction";
            this.Column7.HeaderText = "往返状态";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "truck_Name";
            this.Column8.HeaderText = "货车规格";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "trans_Cost";
            this.Column9.HeaderText = "货运费用";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnAddFee,
            this.toolStripSeparator3,
            this.btnEditFee,
            this.toolStripSeparator4,
            this.btnDeleteFee});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 31);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAddFee
            // 
            this.btnAddFee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFee.Image")));
            this.btnAddFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(60, 28);
            this.btnAddFee.Text = "添加";
            this.btnAddFee.ToolTipText = "添加";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEditFee
            // 
            this.btnEditFee.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFee.Image")));
            this.btnEditFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditFee.Name = "btnEditFee";
            this.btnEditFee.Size = new System.Drawing.Size(60, 28);
            this.btnEditFee.Text = "修改";
            this.btnEditFee.ToolTipText = "修改";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDeleteFee
            // 
            this.btnDeleteFee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFee.Image")));
            this.btnDeleteFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteFee.Name = "btnDeleteFee";
            this.btnDeleteFee.Size = new System.Drawing.Size(60, 28);
            this.btnDeleteFee.Text = "删除";
            this.btnDeleteFee.ToolTipText = "删除";
            // 
            // FmTransportPlaceConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmTransportPlaceConfig";
            this.ShowNavPanel = false;
            this.Text = "FmPlaceManager";
            this.panelClient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStripItem.ResumeLayout(false);
            this.toolStripItem.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridTruck)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridFee)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddPlace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEditPlace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnDeletePlace;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnAddTruck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btnDeleteTruck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btnSaveTruck;
        private Miles.Framework.UI.Controls.MDataGrid mDataGridTruck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddFee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEditFee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDeleteFee;
        private Miles.Framework.UI.Controls.MDataGrid mDataGridFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}