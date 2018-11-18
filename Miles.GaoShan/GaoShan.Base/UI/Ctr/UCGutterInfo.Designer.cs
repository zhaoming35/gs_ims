namespace GaoShan.Sales.UI.Ctr
{
    partial class UCGutterInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mLabel1 = new Miles.Framework.UI.Controls.MLabel();
            this.mLabel2 = new Miles.Framework.UI.Controls.MLabel();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.mDecimalInput2 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "宽：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "长：";
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.BindDataField = "Width_Unit";
            this.mLabel1.BindDataTag = null;
            this.mLabel1.BindDataText = null;
            this.mLabel1.EmptyValue = null;
            this.mLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mLabel1.IsGetBind = false;
            this.mLabel1.IsSetBind = true;
            this.mLabel1.IsValid = false;
            this.mLabel1.Location = new System.Drawing.Point(133, 16);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(35, 14);
            this.mLabel1.TabIndex = 2;
            this.mLabel1.Text = "单位";
            this.mLabel1.ValidEmptyMsg = null;
            // 
            // mLabel2
            // 
            this.mLabel2.AutoSize = true;
            this.mLabel2.BindDataField = null;
            this.mLabel2.BindDataTag = null;
            this.mLabel2.BindDataText = null;
            this.mLabel2.EmptyValue = null;
            this.mLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mLabel2.IsGetBind = false;
            this.mLabel2.IsSetBind = true;
            this.mLabel2.IsValid = false;
            this.mLabel2.Location = new System.Drawing.Point(133, 50);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(35, 14);
            this.mLabel2.TabIndex = 3;
            this.mLabel2.Text = "单位";
            this.mLabel2.ValidEmptyMsg = null;
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "Width_Value";
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
            this.mDecimalInput1.Location = new System.Drawing.Point(52, 12);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(66, 23);
            this.mDecimalInput1.TabIndex = 4;
            this.mDecimalInput1.ValidEmptyMsg = null;
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // mDecimalInput2
            // 
            this.mDecimalInput2.BindDataField = "Length_Value";
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
            this.mDecimalInput2.Location = new System.Drawing.Point(52, 46);
            this.mDecimalInput2.Name = "mDecimalInput2";
            this.mDecimalInput2.Size = new System.Drawing.Size(66, 23);
            this.mDecimalInput2.TabIndex = 5;
            this.mDecimalInput2.ValidEmptyMsg = null;
            this.mDecimalInput2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // UCGutterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mDecimalInput2);
            this.Controls.Add(this.mDecimalInput1);
            this.Controls.Add(this.mLabel2);
            this.Controls.Add(this.mLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCGutterInfo";
            this.Size = new System.Drawing.Size(178, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MLabel mLabel1;
        private Miles.Framework.UI.Controls.MLabel mLabel2;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput2;
    }
}
