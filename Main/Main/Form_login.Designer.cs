namespace Main
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.Button_back = new Sunny.UI.UIImageButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.button_login = new Sunny.UI.UISymbolButton();
            this.uiAvatar5 = new Sunny.UI.UIAvatar();
            this.uiAvatar4 = new Sunny.UI.UIAvatar();
            this.textBox_password = new Sunny.UI.UITextBox();
            this.textBox_id = new Sunny.UI.UITextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            ((System.ComponentModel.ISupportInitialize)(this.Button_back)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_back
            // 
            this.Button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_back.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button_back.Image = ((System.Drawing.Image)(resources.GetObject("Button_back.Image")));
            this.Button_back.Location = new System.Drawing.Point(3, 466);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(85, 35);
            this.Button_back.TabIndex = 21;
            this.Button_back.TabStop = false;
            this.Button_back.Text = "返回";
            this.Button_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.button_login);
            this.uiPanel1.Controls.Add(this.uiAvatar5);
            this.uiPanel1.Controls.Add(this.uiAvatar4);
            this.uiPanel1.Controls.Add(this.textBox_password);
            this.uiPanel1.Controls.Add(this.textBox_id);
            this.uiPanel1.Controls.Add(this.uiLine1);
            this.uiPanel1.Controls.Add(this.uiAvatar2);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(418, 121);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(224, 250);
            this.uiPanel1.TabIndex = 22;
            this.uiPanel1.Text = null;
            // 
            // button_login
            // 
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_login.Location = new System.Drawing.Point(72, 207);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(86, 29);
            this.button_login.TabIndex = 19;
            this.button_login.Text = "登录";
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // uiAvatar5
            // 
            this.uiAvatar5.AvatarSize = 55;
            this.uiAvatar5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar5.Location = new System.Drawing.Point(7, 159);
            this.uiAvatar5.Name = "uiAvatar5";
            this.uiAvatar5.Size = new System.Drawing.Size(40, 40);
            this.uiAvatar5.Symbol = 57345;
            this.uiAvatar5.SymbolSize = 48;
            this.uiAvatar5.TabIndex = 18;
            this.uiAvatar5.Text = "uiAvatar5";
            // 
            // uiAvatar4
            // 
            this.uiAvatar4.AvatarSize = 55;
            this.uiAvatar4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar4.Location = new System.Drawing.Point(7, 113);
            this.uiAvatar4.Name = "uiAvatar4";
            this.uiAvatar4.Size = new System.Drawing.Size(40, 40);
            this.uiAvatar4.SymbolSize = 48;
            this.uiAvatar4.TabIndex = 15;
            this.uiAvatar4.Text = "uiAvatar4";
            // 
            // textBox_password
            // 
            this.textBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_password.FillColor = System.Drawing.Color.White;
            this.textBox_password.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox_password.Location = new System.Drawing.Point(61, 165);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password.Maximum = 2147483647D;
            this.textBox_password.Minimum = -2147483648D;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(163, 34);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.Watermark = "请输入密码";
            // 
            // textBox_id
            // 
            this.textBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_id.FillColor = System.Drawing.Color.White;
            this.textBox_id.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox_id.Location = new System.Drawing.Point(61, 119);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_id.Maximum = 2147483647D;
            this.textBox_id.Minimum = -2147483648D;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_id.Size = new System.Drawing.Size(163, 34);
            this.textBox_id.TabIndex = 2;
            this.textBox_id.Watermark = "请输入ID";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(27, 83);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(184, 29);
            this.uiLine1.TabIndex = 1;
            this.uiLine1.Text = "用户登录";
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar2.Location = new System.Drawing.Point(83, 6);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar2.TabIndex = 0;
            this.uiAvatar2.Text = "uiAvatar2";
            // 
            // Form_login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(776, 504);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.Button_back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_login";
            this.Text = "用户登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Button_back)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIImageButton Button_back;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIAvatar uiAvatar5;
        private Sunny.UI.UIAvatar uiAvatar4;
        private Sunny.UI.UITextBox textBox_password;
        private Sunny.UI.UITextBox textBox_id;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UISymbolButton button_login;
    }
}