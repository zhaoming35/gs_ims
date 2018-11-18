namespace GaoShan.Sales.Salary.UI.Cal
{
    partial class UCSumOrderCost
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.mDataGrid1 = new Miles.Framework.UI.Controls.MDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mDecimalInput2 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label1 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label13 = new System.Windows.Forms.Label();
            this.d_tax_Cost = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_sales_Cost = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_freight_Cost = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_part_Cost = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mDecimalInput3 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 8);
            this.panel1.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox16.Controls.Add(this.mDataGrid1);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox16.ForeColor = System.Drawing.Color.Black;
            this.groupBox16.Location = new System.Drawing.Point(0, 122);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox16.Size = new System.Drawing.Size(807, 350);
            this.groupBox16.TabIndex = 92;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "产品信息";
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
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.mDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDataGrid1.Location = new System.Drawing.Point(4, 20);
            this.mDataGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.mDataGrid1.MultiSelect = false;
            this.mDataGrid1.Name = "mDataGrid1";
            this.mDataGrid1.ReadOnly = true;
            this.mDataGrid1.RowFilter = null;
            this.mDataGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.mDataGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.mDataGrid1.RowTemplate.Height = 23;
            this.mDataGrid1.Size = new System.Drawing.Size(799, 326);
            this.mDataGrid1.TabIndex = 15;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "item_Name";
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
            this.Column1.DataPropertyName = "itemSpec";
            this.Column1.HeaderText = "规格";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "item_Count";
            this.Column3.HeaderText = "数量";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "item_Price";
            this.Column5.HeaderText = "单价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Item_Total";
            this.Column6.HeaderText = "总价";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "item_Material";
            this.Column7.HeaderText = "材质-型材-规格";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "remark";
            this.Column8.HeaderText = "备注";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.mDecimalInput3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mDecimalInput2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mDecimalInput1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.d_tax_Cost);
            this.groupBox1.Controls.Add(this.d_sales_Cost);
            this.groupBox1.Controls.Add(this.d_freight_Cost);
            this.groupBox1.Controls.Add(this.d_part_Cost);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(807, 114);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "相关费用";
            // 
            // mDecimalInput2
            // 
            this.mDecimalInput2.BindDataField = "Build_Cost";
            this.mDecimalInput2.BindDataTag = null;
            this.mDecimalInput2.BindDataText = null;
            this.mDecimalInput2.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput2.IsGetBind = true;
            this.mDecimalInput2.IsSetBind = true;
            this.mDecimalInput2.IsValid = false;
            this.mDecimalInput2.Location = new System.Drawing.Point(96, 21);
            this.mDecimalInput2.Name = "mDecimalInput2";
            this.mDecimalInput2.ReadOnly = true;
            this.mDecimalInput2.Size = new System.Drawing.Size(158, 23);
            this.mDecimalInput2.TabIndex = 98;
            this.mDecimalInput2.ValidEmptyMsg = null;
            this.mDecimalInput2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "搭建费用：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "rent_Cost";
            this.mDecimalInput1.BindDataTag = null;
            this.mDecimalInput1.BindDataText = null;
            this.mDecimalInput1.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput1.IsGetBind = true;
            this.mDecimalInput1.IsSetBind = true;
            this.mDecimalInput1.IsValid = false;
            this.mDecimalInput1.Location = new System.Drawing.Point(616, 49);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.ReadOnly = true;
            this.mDecimalInput1.Size = new System.Drawing.Size(158, 23);
            this.mDecimalInput1.TabIndex = 96;
            this.mDecimalInput1.ValidEmptyMsg = null;
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(552, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 95;
            this.label13.Text = "外租费：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // d_tax_Cost
            // 
            this.d_tax_Cost.BindDataField = "tax_Cost";
            this.d_tax_Cost.BindDataTag = null;
            this.d_tax_Cost.BindDataText = null;
            this.d_tax_Cost.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_tax_Cost.IsGetBind = true;
            this.d_tax_Cost.IsSetBind = true;
            this.d_tax_Cost.IsValid = false;
            this.d_tax_Cost.Location = new System.Drawing.Point(358, 49);
            this.d_tax_Cost.Name = "d_tax_Cost";
            this.d_tax_Cost.ReadOnly = true;
            this.d_tax_Cost.Size = new System.Drawing.Size(158, 23);
            this.d_tax_Cost.TabIndex = 93;
            this.d_tax_Cost.ValidEmptyMsg = null;
            this.d_tax_Cost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // d_sales_Cost
            // 
            this.d_sales_Cost.BindDataField = "sales_Cost";
            this.d_sales_Cost.BindDataTag = null;
            this.d_sales_Cost.BindDataText = null;
            this.d_sales_Cost.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_sales_Cost.IsGetBind = true;
            this.d_sales_Cost.IsSetBind = true;
            this.d_sales_Cost.IsValid = false;
            this.d_sales_Cost.Location = new System.Drawing.Point(96, 49);
            this.d_sales_Cost.Name = "d_sales_Cost";
            this.d_sales_Cost.ReadOnly = true;
            this.d_sales_Cost.Size = new System.Drawing.Size(158, 23);
            this.d_sales_Cost.TabIndex = 92;
            this.d_sales_Cost.ValidEmptyMsg = null;
            this.d_sales_Cost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // d_freight_Cost
            // 
            this.d_freight_Cost.BindDataField = "freight_Cost";
            this.d_freight_Cost.BindDataTag = null;
            this.d_freight_Cost.BindDataText = null;
            this.d_freight_Cost.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_freight_Cost.IsGetBind = true;
            this.d_freight_Cost.IsSetBind = true;
            this.d_freight_Cost.IsValid = false;
            this.d_freight_Cost.Location = new System.Drawing.Point(616, 21);
            this.d_freight_Cost.Name = "d_freight_Cost";
            this.d_freight_Cost.ReadOnly = true;
            this.d_freight_Cost.Size = new System.Drawing.Size(158, 23);
            this.d_freight_Cost.TabIndex = 91;
            this.d_freight_Cost.ValidEmptyMsg = null;
            this.d_freight_Cost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // d_part_Cost
            // 
            this.d_part_Cost.BindDataField = "part_Cost";
            this.d_part_Cost.BindDataTag = null;
            this.d_part_Cost.BindDataText = null;
            this.d_part_Cost.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.d_part_Cost.IsGetBind = true;
            this.d_part_Cost.IsSetBind = true;
            this.d_part_Cost.IsValid = false;
            this.d_part_Cost.Location = new System.Drawing.Point(358, 17);
            this.d_part_Cost.Name = "d_part_Cost";
            this.d_part_Cost.ReadOnly = true;
            this.d_part_Cost.Size = new System.Drawing.Size(158, 23);
            this.d_part_Cost.TabIndex = 90;
            this.d_part_Cost.ValidEmptyMsg = null;
            this.d_part_Cost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(307, 52);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 87;
            this.label12.Text = "税费：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 86;
            this.label11.Text = "销售费用：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(535, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 85;
            this.label10.Text = "运费金额：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(273, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "配套金额：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mDecimalInput3
            // 
            this.mDecimalInput3.BindDataField = "discount_Cost";
            this.mDecimalInput3.BindDataTag = null;
            this.mDecimalInput3.BindDataText = null;
            this.mDecimalInput3.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput3.IsGetBind = true;
            this.mDecimalInput3.IsSetBind = true;
            this.mDecimalInput3.IsValid = false;
            this.mDecimalInput3.Location = new System.Drawing.Point(96, 78);
            this.mDecimalInput3.Name = "mDecimalInput3";
            this.mDecimalInput3.ReadOnly = true;
            this.mDecimalInput3.Size = new System.Drawing.Size(158, 23);
            this.mDecimalInput3.TabIndex = 100;
            this.mDecimalInput3.ValidEmptyMsg = null;
            this.mDecimalInput3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 99;
            this.label14.Text = "优惠金额：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCSumOrderCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UCSumOrderCost";
            this.Size = new System.Drawing.Size(807, 472);
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox16;
        private Miles.Framework.UI.Controls.MDataGrid mDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput2;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label13;
        private Miles.Framework.UI.Controls.MDecimalInput d_tax_Cost;
        private Miles.Framework.UI.Controls.MDecimalInput d_sales_Cost;
        private Miles.Framework.UI.Controls.MDecimalInput d_freight_Cost;
        private Miles.Framework.UI.Controls.MDecimalInput d_part_Cost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput3;
        private System.Windows.Forms.Label label14;
    }
}
