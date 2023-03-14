﻿namespace Main
{
    partial class Form_Customer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("我的信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("我的订单");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("消费记录");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("主题");
            this.uiLogo1 = new Sunny.UI.UILogo();
            this.uiAvatar = new Sunny.UI.UIAvatar();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.label_wel = new Sunny.UI.UILabel();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Header.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Size = new System.Drawing.Size(250, 575);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Controls.Add(this.label_wel);
            this.Header.Controls.Add(this.uiAvatar);
            this.Header.Controls.Add(this.uiLogo1);
            treeNode1.Name = "MyInfo";
            treeNode1.Text = "我的信息";
            treeNode2.Name = "MyOrder";
            treeNode2.Text = "我的订单";
            treeNode3.Name = "MyHistory";
            treeNode3.Text = "消费记录";
            treeNode4.Name = "Style";
            treeNode4.Text = "主题";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.Header.Size = new System.Drawing.Size(1060, 110);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // uiLogo1
            // 
            this.uiLogo1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLogo1.Location = new System.Drawing.Point(5, 14);
            this.uiLogo1.MaximumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.MinimumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.Name = "uiLogo1";
            this.uiLogo1.Size = new System.Drawing.Size(300, 80);
            this.uiLogo1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLogo1.TabIndex = 4;
            this.uiLogo1.Text = "uiLogo1";
            // 
            // uiAvatar
            // 
            this.uiAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar.Location = new System.Drawing.Point(975, 3);
            this.uiAvatar.Name = "uiAvatar";
            this.uiAvatar.Size = new System.Drawing.Size(66, 70);
            this.uiAvatar.TabIndex = 5;
            this.uiAvatar.Text = "uiAvatar1";
            this.uiAvatar.Click += new System.EventHandler(this.uiAvatar_Click);
            // 
            // label_wel
            // 
            this.label_wel.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label_wel.Location = new System.Drawing.Point(960, 73);
            this.label_wel.Name = "label_wel";
            this.label_wel.Size = new System.Drawing.Size(97, 34);
            this.label_wel.TabIndex = 6;
            this.label_wel.Text = "欢迎登录,1234";
            this.label_wel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wel.MouseEnter += new System.EventHandler(this.label_wel_MouseEnter);
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(125, 36);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.LogoutToolStripMenuItem.Text = "注销";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Showcard Gothic", 32F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(88, 26);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(264, 68);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "TJ Mall";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Name = "Form_Customer";
            this.Text = "购物网站信息统计管理系统-顾客";
            this.Load += new System.EventHandler(this.Form_Customer_Load);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.Header.ResumeLayout(false);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILogo uiLogo1;
        private Sunny.UI.UIAvatar uiAvatar;
        private Sunny.UI.UIStyleManager StyleManager;
        private Sunny.UI.UILabel label_wel;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private Sunny.UI.UILabel uiLabel1;
    }
}