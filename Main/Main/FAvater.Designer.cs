namespace Sunny.UI.Demo
{
    partial class FAvatar
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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiAvatar4 = new Sunny.UI.UIAvatar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();

            this.uiButton2 = new Sunny.UI.UIButton();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLine1);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiTextBox1);
            this.PagePanel.Controls.Add(this.uiTextBox2);
            this.PagePanel.Controls.Add(this.uiAvatar4);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.uiButton2);
            this.PagePanel.Text = "";
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 55;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(180, 117);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(40, 40);
            this.uiAvatar1.SymbolSize = 48;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            //uiAvatar4


            this.uiAvatar4.AvatarSize = 55;
            this.uiAvatar4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar4.Location = new System.Drawing.Point(180, 217);
            this.uiAvatar4.Name = "uiAvatar4";
            this.uiAvatar4.Size = new System.Drawing.Size(40, 40);
            this.uiAvatar4.Symbol = 61715;
            this.uiAvatar4.TabIndex = 3;
            this.uiAvatar4.Text = "uiAvatar4";
            //// 
            //// uiLabel1
            //// 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.uiLabel1.Location = new System.Drawing.Point(230, 117);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(42, 21);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "ID:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(300, 117);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Size = new System.Drawing.Size(221, 29);
            this.uiTextBox1.TabIndex = 3;
            this.uiTextBox1.Watermark = "请输入您的ID";

            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.Location = new System.Drawing.Point(300, 217);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.Name = "uiTextBox1";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.Size = new System.Drawing.Size(221, 29);
            this.uiTextBox2.TabIndex = 3;
            this.uiTextBox2.Watermark = "请输入您的密码";

            // uiLabel4

            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.uiLabel4.Location = new System.Drawing.Point(230, 217);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(74, 21);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "密码:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.ForeSelectedColor = System.Drawing.Color.Empty;
            this.uiButton2.Location = new System.Drawing.Point(300, 320);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectSelectedColor = System.Drawing.Color.Empty;
            this.uiButton2.ShowFocusLine = true;
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.StyleCustomMode = true;
            this.uiButton2.TabIndex = 1;
            this.uiButton2.Text = "登录";
            this.uiButton2.Click += new System.EventHandler(this.button_login_Click);

            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(30, 20);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 19;
            this.uiLine1.Text = "登录";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "登录";
            this.Symbol = 61447;
            this.Text = "登录";
            this.Controls.SetChildIndex(this.PagePanel, 0);
            this.PagePanel.ResumeLayout(false);
            this.PagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UILabel uiLabel4;
        private UILabel uiLabel1;
        private UIAvatar uiAvatar4;
        private UIAvatar uiAvatar1;
        private UILine uiLine1;

        private UITextBox uiTextBox1;
        private UITextBox uiTextBox2;

        private UIButton uiButton2;
    }
}