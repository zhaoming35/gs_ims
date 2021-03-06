﻿using GaoShan.Sales.UI.Order;

namespace GaoShan.Sales.UI.Admin
{
    partial class FmOrderTermination
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
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beginDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucOrderList1 = new GaoShan.Sales.UI.Order.UCOrderList();
            this.navGroupPanel1 = new Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel();
            this.mRichEditOnly1 = new Miles.Dev.Controls.MRichEditOnly();
            this.panelClient.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.navGroupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.splitContainer1);
            this.panelClient.Controls.Add(this.panelTop);
            this.panelClient.Location = new System.Drawing.Point(0, 25);
            this.panelClient.Size = new System.Drawing.Size(800, 425);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.endDate);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.beginDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 39);
            this.panelTop.TabIndex = 0;
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(302, 12);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(157, 21);
            this.endDate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "截止时间";
            // 
            // beginDate
            // 
            this.beginDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.beginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDate.Location = new System.Drawing.Point(68, 12);
            this.beginDate.Name = "beginDate";
            this.beginDate.Size = new System.Drawing.Size(157, 21);
            this.beginDate.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucOrderList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.navGroupPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 386);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 3;
            // 
            // ucOrderList1
            // 
            this.ucOrderList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderList1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucOrderList1.FontSize = 12F;
            this.ucOrderList1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderList1.Name = "ucOrderList1";
            this.ucOrderList1.Size = new System.Drawing.Size(211, 386);
            this.ucOrderList1.TabIndex = 0;
            // 
            // navGroupPanel1
            // 
            this.navGroupPanel1.AssociatedSplitter = null;
            this.navGroupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.navGroupPanel1.CaptionFont = new System.Drawing.Font("微软雅黑", 11.75F, System.Drawing.FontStyle.Bold);
            this.navGroupPanel1.CaptionHeight = 27;
            this.navGroupPanel1.Controls.Add(this.mRichEditOnly1);
            this.navGroupPanel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.navGroupPanel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel1.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navGroupPanel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.navGroupPanel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.navGroupPanel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.navGroupPanel1.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.navGroupPanel1.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.navGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navGroupPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navGroupPanel1.Image = null;
            this.navGroupPanel1.Location = new System.Drawing.Point(0, 0);
            this.navGroupPanel1.MinimumSize = new System.Drawing.Size(27, 27);
            this.navGroupPanel1.Name = "navGroupPanel1";
            this.navGroupPanel1.PanelStyle = Miles.Framework.UI.Controls.NavBarGroup.PanelStyle.Office2007;
            this.navGroupPanel1.Size = new System.Drawing.Size(585, 386);
            this.navGroupPanel1.TabIndex = 0;
            this.navGroupPanel1.Text = "合同内容";
            this.navGroupPanel1.ToolTipTextCloseIcon = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.navGroupPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // mRichEditOnly1
            // 
            this.mRichEditOnly1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mRichEditOnly1.Location = new System.Drawing.Point(1, 28);
            this.mRichEditOnly1.Margin = new System.Windows.Forms.Padding(4);
            this.mRichEditOnly1.Name = "mRichEditOnly1";
            this.mRichEditOnly1.ReadOnly = true;
            this.mRichEditOnly1.Size = new System.Drawing.Size(583, 357);
            this.mRichEditOnly1.TabIndex = 0;
            // 
            // FmOrderQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FmOrderQuery";
            this.ShowNavPanel = false;
            this.Text = "FmOrderQuery";
            this.panelClient.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.navGroupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UCOrderList ucOrderList1;
        private Miles.Framework.UI.Controls.NavBarGroup.NavGroupPanel navGroupPanel1;
        private Miles.Dev.Controls.MRichEditOnly mRichEditOnly1;
        protected System.Windows.Forms.DateTimePicker endDate;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.DateTimePicker beginDate;
    }
}