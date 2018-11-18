namespace GaoShan.Sales.UI.Carriage
{
    partial class FmCarriageCreate
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
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTextInput1 = new Miles.Framework.UI.Controls.MTextInput();
            this.mTextInput2 = new Miles.Framework.UI.Controls.MTextInput();
            this.cmbCarriageType1 = new GaoShan.Sales.UI.Ctr.CmbCarriageType();
            this.mTextInput3 = new Miles.Framework.UI.Controls.MTextInput();
            this.label3 = new System.Windows.Forms.Label();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.mTextInput3);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.mTextInput2);
            this.panelClient.Controls.Add(this.mTextInput1);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.cmbCarriageType1);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.label34);
            this.panelClient.Size = new System.Drawing.Size(394, 183);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(36, 113);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 16);
            this.label34.TabIndex = 93;
            this.label34.Text = "运输类型：";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "合同编号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "项目名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mTextInput1
            // 
            this.mTextInput1.BindDataField = "odr_No";
            this.mTextInput1.BindDataTag = null;
            this.mTextInput1.BindDataText = null;
            this.mTextInput1.EmptyValue = null;
            this.mTextInput1.IsGetBind = true;
            this.mTextInput1.IsSetBind = true;
            this.mTextInput1.IsValid = false;
            this.mTextInput1.Location = new System.Drawing.Point(123, 18);
            this.mTextInput1.Name = "mTextInput1";
            this.mTextInput1.ReadOnly = true;
            this.mTextInput1.Size = new System.Drawing.Size(248, 21);
            this.mTextInput1.TabIndex = 97;
            this.mTextInput1.ValidEmptyMsg = null;
            // 
            // mTextInput2
            // 
            this.mTextInput2.BindDataField = "linkBill_Name";
            this.mTextInput2.BindDataTag = null;
            this.mTextInput2.BindDataText = null;
            this.mTextInput2.EmptyValue = null;
            this.mTextInput2.IsGetBind = true;
            this.mTextInput2.IsSetBind = true;
            this.mTextInput2.IsValid = false;
            this.mTextInput2.Location = new System.Drawing.Point(123, 49);
            this.mTextInput2.Name = "mTextInput2";
            this.mTextInput2.ReadOnly = true;
            this.mTextInput2.Size = new System.Drawing.Size(248, 21);
            this.mTextInput2.TabIndex = 98;
            this.mTextInput2.ValidEmptyMsg = null;
            // 
            // cmbCarriageType1
            // 
            this.cmbCarriageType1.BindDataField = null;
            this.cmbCarriageType1.BindDataTag = null;
            this.cmbCarriageType1.BindDataText = "carriage_Type";
            this.cmbCarriageType1.EmptyValue = null;
            this.cmbCarriageType1.IsGetBind = true;
            this.cmbCarriageType1.IsSetBind = true;
            this.cmbCarriageType1.IsValid = false;
            this.cmbCarriageType1.Location = new System.Drawing.Point(125, 111);
            this.cmbCarriageType1.Name = "cmbCarriageType1";
            this.cmbCarriageType1.Size = new System.Drawing.Size(248, 20);
            this.cmbCarriageType1.TabIndex = 95;
            this.cmbCarriageType1.ValidEmptyMsg = null;
            // 
            // mTextInput3
            // 
            this.mTextInput3.BindDataField = "carriage_Name";
            this.mTextInput3.BindDataTag = null;
            this.mTextInput3.BindDataText = null;
            this.mTextInput3.EmptyValue = null;
            this.mTextInput3.IsGetBind = true;
            this.mTextInput3.IsSetBind = true;
            this.mTextInput3.IsValid = true;
            this.mTextInput3.Location = new System.Drawing.Point(125, 80);
            this.mTextInput3.Name = "mTextInput3";
            this.mTextInput3.Size = new System.Drawing.Size(248, 21);
            this.mTextInput3.TabIndex = 101;
            this.mTextInput3.ValidEmptyMsg = "名称不能为空";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "运输单名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FmCarriageCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 230);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmCarriageCreate";
            this.Text = "运输单新建";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label34;
        private Ctr.CmbCarriageType cmbCarriageType1;
        private Miles.Framework.UI.Controls.MTextInput mTextInput2;
        private Miles.Framework.UI.Controls.MTextInput mTextInput1;
        private System.Windows.Forms.Label label2;
        private Miles.Framework.UI.Controls.MTextInput mTextInput3;
        private System.Windows.Forms.Label label3;
    }
}