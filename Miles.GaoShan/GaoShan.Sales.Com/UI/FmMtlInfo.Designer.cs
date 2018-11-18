namespace GaoShan.Sales.Com.UI
{
    partial class FmMtlInfo
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
            this.d_mtl_Code = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.mTextInput2 = new Miles.Framework.UI.Controls.MTextInput();
            this.label3 = new System.Windows.Forms.Label();
            this.mTextInput3 = new Miles.Framework.UI.Controls.MTextInput();
            this.label4 = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.chbInput = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mDecimalInput1 = new Miles.Framework.UI.Controls.MDecimalInput();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mDecimalInput1);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Controls.Add(this.chbInput);
            this.panelClient.Controls.Add(this.mTextInput3);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Controls.Add(this.mTextInput2);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.lblParent);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_mtl_Code);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(322, 273);
            // 
            // d_mtl_Code
            // 
            this.d_mtl_Code.BindDataField = "mtl_Code";
            this.d_mtl_Code.BindDataTag = null;
            this.d_mtl_Code.BindDataText = null;
            this.d_mtl_Code.EmptyValue = null;
            this.d_mtl_Code.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.d_mtl_Code.IsGetBind = true;
            this.d_mtl_Code.IsSetBind = true;
            this.d_mtl_Code.IsValid = true;
            this.d_mtl_Code.Location = new System.Drawing.Point(108, 57);
            this.d_mtl_Code.Name = "d_mtl_Code";
            this.d_mtl_Code.Size = new System.Drawing.Size(180, 26);
            this.d_mtl_Code.TabIndex = 76;
            this.d_mtl_Code.ValidEmptyMsg = "物料编码不能为空";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(20, 62);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 77;
            this.label20.Text = "物料编码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "所属类别：";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "mtl_Name";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = true;
            this.mTextInput1.Location = new System.Drawing.Point(108, 92);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(180, 26);
            this.mTextInput1.TabIndex = 80;
            this.mTextInput1.ValidEmptyMsg = "物料名称不能为空";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "物料名称：";
            // 
            // mTextInput2
            // 
            this.mTextInput2.BindDataField = "mtl_Spec";
            this.mTextInput2.BindDataTag = null;
            this.mTextInput2.BindDataText = null;
            this.mTextInput2.EmptyValue = null;
            this.mTextInput2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mTextInput2.IsGetBind = true;
            this.mTextInput2.IsSetBind = true;
            this.mTextInput2.IsValid = false;
            this.mTextInput2.Location = new System.Drawing.Point(108, 127);
            this.mTextInput2.Name = "mTextInput2";
            this.mTextInput2.Size = new System.Drawing.Size(180, 26);
            this.mTextInput2.TabIndex = 82;
            this.mTextInput2.ValidEmptyMsg = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "物料规格：";
            // 
            // mTextInput3
            // 
            this.mTextInput3.BindDataField = "mtl_Unit";
            this.mTextInput3.BindDataTag = null;
            this.mTextInput3.BindDataText = null;
            this.mTextInput3.EmptyValue = null;
            this.mTextInput3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mTextInput3.IsGetBind = true;
            this.mTextInput3.IsSetBind = true;
            this.mTextInput3.IsValid = true;
            this.mTextInput3.Location = new System.Drawing.Point(108, 162);
            this.mTextInput3.Name = "mTextInput3";
            this.mTextInput3.Size = new System.Drawing.Size(180, 26);
            this.mTextInput3.TabIndex = 84;
            this.mTextInput3.ValidEmptyMsg = "物料单位不能为空";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(20, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "物料单位：";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParent.ForeColor = System.Drawing.Color.Blue;
            this.lblParent.Location = new System.Drawing.Point(105, 27);
            this.lblParent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(72, 16);
            this.lblParent.TabIndex = 79;
            this.lblParent.Text = "顶级分类";
            // 
            // chbInput
            // 
            this.chbInput.AutoSize = true;
            this.chbInput.Location = new System.Drawing.Point(108, 233);
            this.chbInput.Name = "chbInput";
            this.chbInput.Size = new System.Drawing.Size(72, 16);
            this.chbInput.TabIndex = 86;
            this.chbInput.Text = "连续录入";
            this.chbInput.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(20, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "物料单重：";
            // 
            // mDecimalInput1
            // 
            this.mDecimalInput1.BindDataField = "mtl_Weight";
            this.mDecimalInput1.BindDataTag = null;
            this.mDecimalInput1.BindDataText = null;
            this.mDecimalInput1.DecimalLength = 2;
            this.mDecimalInput1.EmptyValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mDecimalInput1.IsGetBind = true;
            this.mDecimalInput1.IsSetBind = true;
            this.mDecimalInput1.IsValid = true;
            this.mDecimalInput1.Location = new System.Drawing.Point(108, 199);
            this.mDecimalInput1.Name = "mDecimalInput1";
            this.mDecimalInput1.Size = new System.Drawing.Size(180, 21);
            this.mDecimalInput1.TabIndex = 88;
            this.mDecimalInput1.Text = "0.00";
            this.mDecimalInput1.ValidEmptyMsg = "物料单重不能为空";
            this.mDecimalInput1.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // FmMtlInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 320);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmMtlInfo";
            this.Text = "物料信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_mtl_Code;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput3;
        private System.Windows.Forms.Label label4;
        private Miles.Framework.UI.Controls.MTextInput mTextInput2;
        private System.Windows.Forms.Label label3;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.CheckBox chbInput;
        private Miles.Framework.UI.Controls.MDecimalInput mDecimalInput1;
        private System.Windows.Forms.Label label5;
    }
}