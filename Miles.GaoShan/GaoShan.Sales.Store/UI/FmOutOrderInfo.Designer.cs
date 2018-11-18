namespace GaoShan.Sales.Store.UI
{
    partial class FmOutOrderInfo
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.mTextInput3 = new Miles.Framework.UI.Controls.MTextInput();
            this.mTextInput4 = new Miles.Framework.UI.Controls.MTextInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucOutOrderItem1 = new GaoShan.Sales.Store.UI.UC.UCOutOrderItem();
            this.panelClient.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.ucOutOrderItem1);
            this.panelClient.Controls.Add(this.panelTop);
            this.panelClient.Size = new System.Drawing.Size(841, 369);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.mTextInput3);
            this.panelTop.Controls.Add(this.mTextInput4);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(839, 47);
            this.panelTop.TabIndex = 0;
            // 
            // mTextInput3
            // 
            this.mTextInput3.BindDataField = "linkBill_Name";
            this.mTextInput3.BindDataTag = null;
            this.mTextInput3.BindDataText = null;
            this.mTextInput3.EmptyValue = null;
            this.mTextInput3.IsGetBind = true;
            this.mTextInput3.IsSetBind = true;
            this.mTextInput3.IsValid = false;
            this.mTextInput3.Location = new System.Drawing.Point(445, 11);
            this.mTextInput3.Name = "mTextInput3";
            this.mTextInput3.ReadOnly = true;
            this.mTextInput3.Size = new System.Drawing.Size(248, 21);
            this.mTextInput3.TabIndex = 104;
            this.mTextInput3.ValidEmptyMsg = null;
            // 
            // mTextInput4
            // 
            this.mTextInput4.BindDataField = "odr_No";
            this.mTextInput4.BindDataTag = null;
            this.mTextInput4.BindDataText = null;
            this.mTextInput4.EmptyValue = null;
            this.mTextInput4.IsGetBind = false;
            this.mTextInput4.IsSetBind = true;
            this.mTextInput4.IsValid = false;
            this.mTextInput4.Location = new System.Drawing.Point(101, 11);
            this.mTextInput4.Name = "mTextInput4";
            this.mTextInput4.ReadOnly = true;
            this.mTextInput4.Size = new System.Drawing.Size(208, 21);
            this.mTextInput4.TabIndex = 103;
            this.mTextInput4.ValidEmptyMsg = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(355, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "项目名称：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "合同编号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucOutOrderItem1
            // 
            this.ucOutOrderItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOutOrderItem1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucOutOrderItem1.FontSize = 12F;
            this.ucOutOrderItem1.Location = new System.Drawing.Point(0, 47);
            this.ucOutOrderItem1.Name = "ucOutOrderItem1";
            this.ucOutOrderItem1.Size = new System.Drawing.Size(839, 320);
            this.ucOutOrderItem1.TabIndex = 1;
            // 
            // FmOutOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 416);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmOutOrderInfo";
            this.Text = "新建出库单";
            this.panelClient.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Miles.Framework.UI.Controls.MTextInput mTextInput3;
        private Miles.Framework.UI.Controls.MTextInput mTextInput4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private UC.UCOutOrderItem ucOutOrderItem1;
    }
}