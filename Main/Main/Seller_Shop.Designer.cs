namespace Main
{
    partial class Seller_Shop
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("店铺销售");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("店铺商品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("店铺评价");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("店铺员工");
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLogo1 = new Sunny.UI.UILogo();
            this.Header.SuspendLayout();
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
            this.Header.Controls.Add(this.uiLogo1);
            this.Header.Controls.Add(this.uiAvatar1);
            treeNode1.Name = "节点0";
            treeNode1.Text = "店铺销售";
            treeNode2.Name = "节点1";
            treeNode2.Text = "店铺商品";
            treeNode3.Name = "节点2";
            treeNode3.Text = "店铺评价";
            treeNode4.Name = "节点3";
            treeNode4.Text = "店铺员工";
            this.Header.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.Header.Size = new System.Drawing.Size(1060, 110);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(980, 26);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(80, 60);
            this.uiAvatar1.Symbol = 61852;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Showcard Gothic", 32F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(86, 27);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(264, 68);
            this.uiLabel1.TabIndex = 12;
            this.uiLabel1.Text = "TJ Mall";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLogo1
            // 
            this.uiLogo1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLogo1.Location = new System.Drawing.Point(3, 15);
            this.uiLogo1.MaximumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.MinimumSize = new System.Drawing.Size(300, 80);
            this.uiLogo1.Name = "uiLogo1";
            this.uiLogo1.Size = new System.Drawing.Size(300, 80);
            this.uiLogo1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLogo1.TabIndex = 11;
            this.uiLogo1.Text = "uiLogo1";
            // 
            // Seller_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Name = "Seller_Shop";
            this.Text = "卖家店铺";
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILogo uiLogo1;
    }
}