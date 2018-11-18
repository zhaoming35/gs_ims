namespace GaoShan.Sales.UI.Order
{
    partial class FmOrderInfo
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
            this.cmbOrderType1 = new GaoShan.Sales.UI.Ctr.CmbOrderType();
            this.label34 = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panelClient.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Size = new System.Drawing.Size(239, 425);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.panelOrder);
            this.panelClient.Controls.Add(this.panelTop);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelTop.Controls.Add(this.cmbOrderType1);
            this.panelTop.Controls.Add(this.label34);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 30);
            this.panelTop.TabIndex = 73;
            // 
            // cmbOrderType1
            // 
            this.cmbOrderType1.BindDataField = null;
            this.cmbOrderType1.BindDataTag = null;
            this.cmbOrderType1.BindDataText = null;
            this.cmbOrderType1.EmptyValue = null;
            this.cmbOrderType1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOrderType1.IsGetBind = true;
            this.cmbOrderType1.IsSetBind = true;
            this.cmbOrderType1.IsValid = false;
            this.cmbOrderType1.Location = new System.Drawing.Point(93, 3);
            this.cmbOrderType1.Name = "cmbOrderType1";
            this.cmbOrderType1.Size = new System.Drawing.Size(153, 22);
            this.cmbOrderType1.TabIndex = 71;
            this.cmbOrderType1.ValidEmptyMsg = null;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(8, 6);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 16);
            this.label34.TabIndex = 70;
            this.label34.Text = "合同类型：";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelOrder
            // 
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 30);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(800, 395);
            this.panelOrder.TabIndex = 74;
            // 
            // FmOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmOrderInfo";
            this.ShowNavPanel = false;
            this.Text = "合同编辑";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelClient.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Ctr.CmbOrderType cmbOrderType1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panelOrder;
    }
}