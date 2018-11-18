namespace GaoShan.Sales.Com.UI
{
    partial class FmProductPropertyInfo
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
            this.label20 = new System.Windows.Forms.Label();
            this.d_propertyName = new Miles.Framework.UI.Controls.MTextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new Miles.Framework.UI.Controls.MLabel();
            this.d_propertyUnit = new Miles.Framework.UI.Controls.MTextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.d_propertySeq = new Miles.Framework.UI.Controls.MDecimalInput();
            this.d_isSpec = new Miles.Framework.UI.Controls.MCheckBox();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.d_isSpec);
            this.panelClient.Controls.Add(this.d_propertySeq);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.d_propertyUnit);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.lblProductName);
            this.panelClient.Controls.Add(this.d_propertyName);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label20);
            this.panelClient.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelClient.Size = new System.Drawing.Size(348, 231);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(45, 24);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 77;
            this.label20.Text = "产品名称：";
            // 
            // d_propertyName
            // 
            this.d_propertyName.BindDataField = "property_Name";
            this.d_propertyName.BindDataTag = null;
            this.d_propertyName.BindDataText = null;
            this.d_propertyName.Location = new System.Drawing.Point(132, 58);
            this.d_propertyName.Name = "d_propertyName";
            this.d_propertyName.Size = new System.Drawing.Size(179, 26);
            this.d_propertyName.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "属性名称：";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BindDataField = null;
            this.lblProductName.BindDataTag = null;
            this.lblProductName.BindDataText = null;
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProductName.Location = new System.Drawing.Point(132, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(64, 16);
            this.lblProductName.TabIndex = 80;
            this.lblProductName.Text = "mLabel1";
            // 
            // d_propertyUnit
            // 
            this.d_propertyUnit.BindDataField = "property_Unit";
            this.d_propertyUnit.BindDataTag = null;
            this.d_propertyUnit.BindDataText = null;
            this.d_propertyUnit.Location = new System.Drawing.Point(132, 97);
            this.d_propertyUnit.Name = "d_propertyUnit";
            this.d_propertyUnit.Size = new System.Drawing.Size(179, 26);
            this.d_propertyUnit.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "属性单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(45, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "属性序号：";
            // 
            // d_propertySeq
            // 
            this.d_propertySeq.BindDataField = "property_Seq";
            this.d_propertySeq.BindDataTag = null;
            this.d_propertySeq.BindDataText = null;
            this.d_propertySeq.Location = new System.Drawing.Point(132, 136);
            this.d_propertySeq.Name = "d_propertySeq";
            this.d_propertySeq.Size = new System.Drawing.Size(179, 26);
            this.d_propertySeq.TabIndex = 84;
            this.d_propertySeq.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // d_isSpec
            // 
            this.d_isSpec.AutoSize = true;
            this.d_isSpec.BindDataField = "is_Spec";
            this.d_isSpec.BindDataTag = null;
            this.d_isSpec.BindDataText = null;
            this.d_isSpec.ForeColor = System.Drawing.Color.Blue;
            this.d_isSpec.Location = new System.Drawing.Point(132, 178);
            this.d_isSpec.Name = "d_isSpec";
            this.d_isSpec.Size = new System.Drawing.Size(107, 20);
            this.d_isSpec.TabIndex = 85;
            this.d_isSpec.Text = "是规格属性";
            this.d_isSpec.UseVisualStyleBackColor = true;
            // 
            // FmProductPropertyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 278);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmProductPropertyInfo";
            this.Text = "产品属性信息";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Miles.Framework.UI.Controls.MCheckBox d_isSpec;
        private Miles.Framework.UI.Controls.MDecimalInput d_propertySeq;
        private System.Windows.Forms.Label label3;
        private Miles.Framework.UI.Controls.MTextInput d_propertyUnit;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MTextInput d_propertyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        public Miles.Framework.UI.Controls.MLabel lblProductName;
    }
}