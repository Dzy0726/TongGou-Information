namespace Sunny.UI.Demo
{
    partial class FMain
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
            System.Windows.Forms.TreeNode treeNode0 = new System.Windows.Forms.TreeNode("主页");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("登录");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("注册");
            //System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("窗体");
            //System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("图表");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("主题");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.uiLogo1 = new Sunny.UI.UILogo();
            this.uiAvatar = new Sunny.UI.UIAvatar();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Aside.ItemHeight = 36;
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Black;
            this.Aside.ShowOneNode = true;
            this.Aside.ShowTips = true;
            this.Aside.Size = new System.Drawing.Size(250, 575);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Controls.Add(this.uiAvatar);
            this.Header.Controls.Add(this.uiLogo1);
            treeNode0.Name = "节点0";
            treeNode0.Text = "主页";
            treeNode1.Name = "节点1";
            treeNode1.Text = "登录";
            treeNode2.Name = "节点2";
            treeNode2.Text = "注册";
            treeNode3.Name = "节点3";
            treeNode3.Text = "主题";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode0,
            treeNode1,
            treeNode2,
            treeNode3});
            this.Header.SelectedIndex = 0;
            this.Header.Size = new System.Drawing.Size(1024, 110);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
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
            this.uiLogo1.TabIndex = 3;
            this.uiLogo1.Text = "uiLogo1";

            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Showcard Gothic", 32F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(88, 26);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(264, 68);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "TJ Mall";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar
            // 
            this.uiAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar.Location = new System.Drawing.Point(943, 25);
            this.uiAvatar.Name = "uiAvatar";
            this.uiAvatar.Size = new System.Drawing.Size(66, 70);
            this.uiAvatar.TabIndex = 4;
            this.uiAvatar.Text = "uiAvatar1";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.Text = "购物网站信息统计管理系统";
            //this.WindowStateChange += new Sunny.UI.UIForm.OnWindowStateChange(this.FMain_WindowStateChange);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UILogo uiLogo1;
        private UIAvatar uiAvatar;
        private UIStyleManager StyleManager;
        private UILabel uiLabel1;
    }
}