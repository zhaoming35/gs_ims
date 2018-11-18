namespace GaoShan.Sales.Com.UI
{
    partial class FmMtlKind
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
            this.d_kind_Code = new Miles.Framework.UI.Controls.MTextInput();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.lblParent);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.d_kind_Code);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Size = new System.Drawing.Size(322, 136);
            // 
            // d_kind_Code
            // 
            this.d_kind_Code.BindDataField = "kind_Code";
            this.d_kind_Code.BindDataTag = null;
            this.d_kind_Code.BindDataText = null;
            this.d_kind_Code.EmptyValue = null;
            this.d_kind_Code.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.d_kind_Code.IsGetBind = true;
            this.d_kind_Code.IsSetBind = true;
            this.d_kind_Code.IsValid = true;
            this.d_kind_Code.Location = new System.Drawing.Point(114, 52);
            this.d_kind_Code.Name = "d_kind_Code";
            this.d_kind_Code.Size = new System.Drawing.Size(180, 26);
            this.d_kind_Code.TabIndex = 76;
            this.d_kind_Code.ValidEmptyMsg = "编码不能为空";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(26, 57);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 77;
            this.label20.Text = "分类编码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "所属类别：";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParent.ForeColor = System.Drawing.Color.Blue;
            this.lblParent.Location = new System.Drawing.Point(111, 20);
            this.lblParent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(72, 16);
            this.lblParent.TabIndex = 79;
            this.lblParent.Text = "顶级分类";
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "kind_Name";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = true;
            this.mTextInput1.Location = new System.Drawing.Point(114, 89);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.Size = new System.Drawing.Size(180, 26);
            this.mTextInput1.TabIndex = 80;
            this.mTextInput1.ValidEmptyMsg = "名称不能为空";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "分类名称：";
            // 
            // FmMtlKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 183);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmMtlKind";
            this.Text = "物料类别";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MTextInput d_kind_Code;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label label1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private System.Windows.Forms.Label label2;
    }
}