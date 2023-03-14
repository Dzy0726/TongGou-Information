namespace Main
{
    partial class Administrator_Transport
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
            this.btn_transmoney = new Sunny.UI.UIButton();
            this.btn_avgmoney = new Sunny.UI.UIButton();
            this.dtp_transmoney = new Sunny.UI.UIDatetimePicker();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.dtp_avgmoney = new Sunny.UI.UIDatetimePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiComboBox1);
            this.PagePanel.Controls.Add(this.btn_transmoney);
            this.PagePanel.Controls.Add(this.btn_avgmoney);
            this.PagePanel.Controls.Add(this.dtp_transmoney);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.dtp_avgmoney);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // btn_transmoney
            // 
            this.btn_transmoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transmoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_transmoney.Location = new System.Drawing.Point(538, 240);
            this.btn_transmoney.Name = "btn_transmoney";
            this.btn_transmoney.Size = new System.Drawing.Size(100, 35);
            this.btn_transmoney.TabIndex = 47;
            this.btn_transmoney.Text = "查询";
            this.btn_transmoney.Visible = false;
            this.btn_transmoney.Click += new System.EventHandler(this.btn_transmoney_Click);
            // 
            // btn_avgmoney
            // 
            this.btn_avgmoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_avgmoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_avgmoney.Location = new System.Drawing.Point(538, 172);
            this.btn_avgmoney.Name = "btn_avgmoney";
            this.btn_avgmoney.Size = new System.Drawing.Size(100, 35);
            this.btn_avgmoney.TabIndex = 46;
            this.btn_avgmoney.Text = "查询";
            this.btn_avgmoney.Visible = false;
            this.btn_avgmoney.Click += new System.EventHandler(this.btn_avgmoney_Click);
            // 
            // dtp_transmoney
            // 
            this.dtp_transmoney.DateFormat = "yyyy-MM-dd";
            this.dtp_transmoney.FillColor = System.Drawing.Color.White;
            this.dtp_transmoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_transmoney.Location = new System.Drawing.Point(280, 239);
            this.dtp_transmoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_transmoney.MaxLength = 10;
            this.dtp_transmoney.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_transmoney.Name = "dtp_transmoney";
            this.dtp_transmoney.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_transmoney.Size = new System.Drawing.Size(200, 34);
            this.dtp_transmoney.SymbolDropDown = 61555;
            this.dtp_transmoney.SymbolNormal = 61555;
            this.dtp_transmoney.TabIndex = 45;
            this.dtp_transmoney.Text = "2020-08-10";
            this.dtp_transmoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_transmoney.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_transmoney.Visible = false;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(278, 131);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 44;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // dtp_avgmoney
            // 
            this.dtp_avgmoney.DateFormat = "yyyy-MM-dd";
            this.dtp_avgmoney.FillColor = System.Drawing.Color.White;
            this.dtp_avgmoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_avgmoney.Location = new System.Drawing.Point(280, 174);
            this.dtp_avgmoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_avgmoney.MaxLength = 10;
            this.dtp_avgmoney.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_avgmoney.Name = "dtp_avgmoney";
            this.dtp_avgmoney.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_avgmoney.Size = new System.Drawing.Size(200, 34);
            this.dtp_avgmoney.SymbolDropDown = 61555;
            this.dtp_avgmoney.SymbolNormal = 61555;
            this.dtp_avgmoney.TabIndex = 43;
            this.dtp_avgmoney.Text = "2020-08-10";
            this.dtp_avgmoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_avgmoney.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_avgmoney.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(326, 134);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(164, 35);
            this.uiLabel5.TabIndex = 42;
            this.uiLabel5.Text = "日期(年/月/日)";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(40, 239);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(225, 28);
            this.uiLabel2.TabIndex = 41;
            this.uiLabel2.Text = "运费降序统计:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Visible = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(40, 170);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 35);
            this.uiLabel1.TabIndex = 40;
            this.uiLabel1.Text = "平均运费统计:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(30, 20);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 39;
            this.uiLine1.Text = "运输统计信息";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "年-月-日",
            "年-月",
            "年",
            "历史累计"});
            this.uiComboBox1.Location = new System.Drawing.Point(278, 73);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 34);
            this.uiComboBox1.TabIndex = 48;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "请选择日期类型";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(40, 73);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(186, 34);
            this.uiLabel3.TabIndex = 49;
            this.uiLabel3.Text = "请先选择日期类型:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Administrator_Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Administrator_Transport";
            this.Text = "运输统计信息";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btn_transmoney;
        private Sunny.UI.UIButton btn_avgmoney;
        private Sunny.UI.UIDatetimePicker dtp_transmoney;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIDatetimePicker dtp_avgmoney;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel3;
    }
}