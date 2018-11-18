namespace GaoShan.Sales.UI.Ctr
{
    partial class UCSteelDrill
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
            this.mCheckBox1 = new Miles.Framework.UI.Controls.MCheckBox();
            this.mCheckBox2 = new Miles.Framework.UI.Controls.MCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mLabel1 = new Miles.Framework.UI.Controls.MLabel();
            this.SuspendLayout();
            // 
            // mCheckBox1
            // 
            this.mCheckBox1.AutoSize = true;
            this.mCheckBox1.BindDataField = "StandardState";
            this.mCheckBox1.BindDataTag = null;
            this.mCheckBox1.BindDataText = null;
            this.mCheckBox1.EmptyValue = null;
            this.mCheckBox1.IsGetBind = true;
            this.mCheckBox1.IsSetBind = true;
            this.mCheckBox1.IsValid = false;
            this.mCheckBox1.Location = new System.Drawing.Point(19, 17);
            this.mCheckBox1.Name = "mCheckBox1";
            this.mCheckBox1.Size = new System.Drawing.Size(68, 18);
            this.mCheckBox1.TabIndex = 0;
            this.mCheckBox1.Text = "标准的";
            this.mCheckBox1.UseVisualStyleBackColor = true;
            this.mCheckBox1.ValidEmptyMsg = null;
            // 
            // mCheckBox2
            // 
            this.mCheckBox2.AutoSize = true;
            this.mCheckBox2.BindDataField = "ScrewState";
            this.mCheckBox2.BindDataTag = null;
            this.mCheckBox2.BindDataText = null;
            this.mCheckBox2.EmptyValue = null;
            this.mCheckBox2.IsGetBind = true;
            this.mCheckBox2.IsSetBind = true;
            this.mCheckBox2.IsValid = false;
            this.mCheckBox2.Location = new System.Drawing.Point(111, 17);
            this.mCheckBox2.Name = "mCheckBox2";
            this.mCheckBox2.Size = new System.Drawing.Size(68, 18);
            this.mCheckBox2.TabIndex = 1;
            this.mCheckBox2.Text = "螺纹钢";
            this.mCheckBox2.UseVisualStyleBackColor = true;
            this.mCheckBox2.ValidEmptyMsg = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "钢钎长度";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "Length";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(94, 51);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(87, 23);
            this.mDecimalInput1.TabIndex = 3;
            this.mDecimalInput1.ValidEmptyMsg = null;
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.BindDataField = "LengthUnit";
            this.mLabel1.BindDataTag = null;
            this.mLabel1.BindDataText = null;
            this.mLabel1.EmptyValue = null;
            this.mLabel1.IsGetBind = true;
            this.mLabel1.IsSetBind = false;
            this.mLabel1.IsValid = false;
            this.mLabel1.Location = new System.Drawing.Point(195, 55);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(21, 14);
            this.mLabel1.TabIndex = 4;
            this.mLabel1.Text = "米";
            this.mLabel1.ValidEmptyMsg = null;
            // 
            // UCSteelDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mLabel1);
            this.Controls.Add(this.mDecimalInput1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mCheckBox2);
            this.Controls.Add(this.mCheckBox1);
            this.Name = "UCSteelDrill";
            this.Size = new System.Drawing.Size(235, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Miles.Framework.UI.Controls.MCheckBox mCheckBox1;
        private Miles.Framework.UI.Controls.MCheckBox mCheckBox2;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private Miles.Framework.UI.Controls.MLabel mLabel1;
    }
}
