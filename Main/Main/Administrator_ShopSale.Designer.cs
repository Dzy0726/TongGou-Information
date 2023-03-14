namespace Main
{
    partial class Administrator_ShopSale
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
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiAvatar3 = new Sunny.UI.UIAvatar();
            this.button4 = new Sunny.UI.UIButton();
            this.button3 = new Sunny.UI.UIButton();
            this.button2 = new Sunny.UI.UIButton();
            this.button1 = new Sunny.UI.UIButton();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.dtp_sale = new Sunny.UI.UIDatetimePicker();
            this.dtp_salemoney = new Sunny.UI.UIDatetimePicker();
            this.dtp_AllSalemoney = new Sunny.UI.UIDatetimePicker();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.dtp_AllSale = new Sunny.UI.UIDatetimePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiComboBox3 = new Sunny.UI.UIComboBox();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiComboBox3);
            this.PagePanel.Controls.Add(this.uiComboBox2);
            this.PagePanel.Controls.Add(this.uiLabel7);
            this.PagePanel.Controls.Add(this.uiComboBox1);
            this.PagePanel.Controls.Add(this.uiAvatar3);
            this.PagePanel.Controls.Add(this.button4);
            this.PagePanel.Controls.Add(this.button3);
            this.PagePanel.Controls.Add(this.button2);
            this.PagePanel.Controls.Add(this.button1);
            this.PagePanel.Controls.Add(this.uiLabel9);
            this.PagePanel.Controls.Add(this.uiAvatar2);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.dtp_sale);
            this.PagePanel.Controls.Add(this.dtp_salemoney);
            this.PagePanel.Controls.Add(this.dtp_AllSalemoney);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.dtp_AllSale);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiLine1);
            this.PagePanel.Size = new System.Drawing.Size(800, 504);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(37, 75);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(186, 34);
            this.uiLabel7.TabIndex = 74;
            this.uiLabel7.Text = "请先选择日期类型:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiComboBox1.Location = new System.Drawing.Point(275, 75);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 39);
            this.uiComboBox1.TabIndex = 73;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "请选择日期类型";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiAvatar3
            // 
            this.uiAvatar3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar3.Location = new System.Drawing.Point(277, 314);
            this.uiAvatar3.Name = "uiAvatar3";
            this.uiAvatar3.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar3.Symbol = 61481;
            this.uiAvatar3.TabIndex = 72;
            this.uiAvatar3.Text = "uiAvatar3";
            this.uiAvatar3.Visible = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button4.Location = new System.Drawing.Point(685, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 71;
            this.button4.Text = "查询";
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button3.Location = new System.Drawing.Point(685, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 70;
            this.button3.Text = "查询";
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.Location = new System.Drawing.Point(535, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 69;
            this.button2.Text = "查询";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.Location = new System.Drawing.Point(535, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 68;
            this.button1.Text = "查询";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(320, 315);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(102, 34);
            this.uiLabel9.TabIndex = 65;
            this.uiLabel9.Text = "店铺种类";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel9.Visible = false;
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar2.Location = new System.Drawing.Point(500, 314);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar2.Symbol = 61555;
            this.uiAvatar2.TabIndex = 64;
            this.uiAvatar2.Text = "uiAvatar2";
            this.uiAvatar2.Visible = false;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel6.Location = new System.Drawing.Point(550, 314);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(152, 35);
            this.uiLabel6.TabIndex = 63;
            this.uiLabel6.Text = "日期";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.Visible = false;
            // 
            // dtp_sale
            // 
            this.dtp_sale.DateFormat = "yyyy";
            this.dtp_sale.FillColor = System.Drawing.Color.White;
            this.dtp_sale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_sale.Location = new System.Drawing.Point(500, 365);
            this.dtp_sale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_sale.MaxLength = 4;
            this.dtp_sale.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_sale.Name = "dtp_sale";
            this.dtp_sale.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_sale.Size = new System.Drawing.Size(150, 39);
            this.dtp_sale.SymbolDropDown = 61555;
            this.dtp_sale.SymbolNormal = 61555;
            this.dtp_sale.TabIndex = 61;
            this.dtp_sale.Text = "2020";
            this.dtp_sale.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_sale.Value = new System.DateTime(2020, 9, 12, 9, 7, 4, 905);
            this.dtp_sale.Visible = false;
            // 
            // dtp_salemoney
            // 
            this.dtp_salemoney.DateFormat = "yyyy";
            this.dtp_salemoney.FillColor = System.Drawing.Color.White;
            this.dtp_salemoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_salemoney.Location = new System.Drawing.Point(500, 440);
            this.dtp_salemoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_salemoney.MaxLength = 4;
            this.dtp_salemoney.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_salemoney.Name = "dtp_salemoney";
            this.dtp_salemoney.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_salemoney.Size = new System.Drawing.Size(150, 39);
            this.dtp_salemoney.SymbolDropDown = 61555;
            this.dtp_salemoney.SymbolNormal = 61555;
            this.dtp_salemoney.TabIndex = 60;
            this.dtp_salemoney.Text = "2020";
            this.dtp_salemoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_salemoney.Value = new System.DateTime(2020, 9, 12, 9, 7, 4, 905);
            this.dtp_salemoney.Visible = false;
            // 
            // dtp_AllSalemoney
            // 
            this.dtp_AllSalemoney.DateFormat = "yyyy-MM-dd";
            this.dtp_AllSalemoney.FillColor = System.Drawing.Color.White;
            this.dtp_AllSalemoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_AllSalemoney.Location = new System.Drawing.Point(277, 247);
            this.dtp_AllSalemoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_AllSalemoney.MaxLength = 10;
            this.dtp_AllSalemoney.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_AllSalemoney.Name = "dtp_AllSalemoney";
            this.dtp_AllSalemoney.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_AllSalemoney.Size = new System.Drawing.Size(200, 39);
            this.dtp_AllSalemoney.SymbolDropDown = 61555;
            this.dtp_AllSalemoney.SymbolNormal = 61555;
            this.dtp_AllSalemoney.TabIndex = 62;
            this.dtp_AllSalemoney.Text = "2020-08-10";
            this.dtp_AllSalemoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_AllSalemoney.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_AllSalemoney.Visible = false;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(277, 139);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 59;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // dtp_AllSale
            // 
            this.dtp_AllSale.DateFormat = "yyyy-MM-dd";
            this.dtp_AllSale.FillColor = System.Drawing.Color.White;
            this.dtp_AllSale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_AllSale.Location = new System.Drawing.Point(277, 182);
            this.dtp_AllSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_AllSale.MaxLength = 10;
            this.dtp_AllSale.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_AllSale.Name = "dtp_AllSale";
            this.dtp_AllSale.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_AllSale.Size = new System.Drawing.Size(200, 39);
            this.dtp_AllSale.SymbolDropDown = 61555;
            this.dtp_AllSale.SymbolNormal = 61555;
            this.dtp_AllSale.TabIndex = 58;
            this.dtp_AllSale.Text = "2020-08-10";
            this.dtp_AllSale.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_AllSale.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_AllSale.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(325, 142);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(164, 35);
            this.uiLabel5.TabIndex = 57;
            this.uiLabel5.Text = "日期(年/月/日)";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(37, 438);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(214, 32);
            this.uiLabel4.TabIndex = 56;
            this.uiLabel4.Text = "单类店铺销售额降序统计";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Visible = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(37, 363);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(225, 36);
            this.uiLabel3.TabIndex = 55;
            this.uiLabel3.Text = "单类店铺销量降序统计:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Visible = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(37, 247);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(225, 28);
            this.uiLabel2.TabIndex = 54;
            this.uiLabel2.Text = "各种类店铺销售额统计:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Visible = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(37, 178);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 35);
            this.uiLabel1.TabIndex = 53;
            this.uiLabel1.Text = "各种类店铺销量统计:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(30, 22);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 52;
            this.uiLine1.Text = "店铺销售";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox2.Location = new System.Drawing.Point(277, 364);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox2.Size = new System.Drawing.Size(175, 39);
            this.uiComboBox2.TabIndex = 82;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Visible = false;
            this.uiComboBox2.Watermark = "请选择店铺种类";
            this.uiComboBox2.SelectedIndexChanged += new System.EventHandler(this.uiComboBox2_SelectedIndexChanged);
            // 
            // uiComboBox3
            // 
            this.uiComboBox3.FillColor = System.Drawing.Color.White;
            this.uiComboBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox3.Location = new System.Drawing.Point(277, 440);
            this.uiComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox3.Name = "uiComboBox3";
            this.uiComboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox3.Size = new System.Drawing.Size(175, 39);
            this.uiComboBox3.TabIndex = 83;
            this.uiComboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox3.Visible = false;
            this.uiComboBox3.Watermark = "请选择店铺种类";
            this.uiComboBox3.SelectedIndexChanged += new System.EventHandler(this.uiComboBox3_SelectedIndexChanged);
            // 
            // Administrator_ShopSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Name = "Administrator_ShopSale";
            this.Text = "店铺销售";
            this.Load += new System.EventHandler(this.Administrator_ShopSale_Load);
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIAvatar uiAvatar3;
        private Sunny.UI.UIButton button4;
        private Sunny.UI.UIButton button3;
        private Sunny.UI.UIButton button2;
        private Sunny.UI.UIButton button1;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDatetimePicker dtp_sale;
        private Sunny.UI.UIDatetimePicker dtp_salemoney;
        private Sunny.UI.UIDatetimePicker dtp_AllSalemoney;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIDatetimePicker dtp_AllSale;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIComboBox uiComboBox3;
        private Sunny.UI.UIComboBox uiComboBox2;
    }
}