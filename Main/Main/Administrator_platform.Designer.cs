namespace Main
{
    partial class Administrator_platform
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
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel_name = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btn_salemoney = new Sunny.UI.UIButton();
            this.btn_sale = new Sunny.UI.UIButton();
            this.dtp_salemoney = new Sunny.UI.UIDatetimePicker();
            this.dtp_sale = new Sunny.UI.UIDatetimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel_customer = new Sunny.UI.UILabel();
            this.tb_customer = new Sunny.UI.UITextBox();
            this.uiLabel_shop = new Sunny.UI.UILabel();
            this.tb_store = new Sunny.UI.UITextBox();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.tb_store);
            this.PagePanel.Controls.Add(this.uiLabel_shop);
            this.PagePanel.Controls.Add(this.tb_customer);
            this.PagePanel.Controls.Add(this.uiLabel_customer);
            this.PagePanel.Controls.Add(this.btn_salemoney);
            this.PagePanel.Controls.Add(this.btn_sale);
            this.PagePanel.Controls.Add(this.dtp_salemoney);
            this.PagePanel.Controls.Add(this.dtp_sale);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel_name);
            this.PagePanel.Controls.Add(this.uiComboBox1);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(30, 20);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 40;
            this.uiLine1.Text = "平台统计信息";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_name
            // 
            this.uiLabel_name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_name.Location = new System.Drawing.Point(37, 73);
            this.uiLabel_name.Name = "uiLabel_name";
            this.uiLabel_name.Size = new System.Drawing.Size(186, 34);
            this.uiLabel_name.TabIndex = 53;
            this.uiLabel_name.Text = "请先选择日期类型:";
            this.uiLabel_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiComboBox1.Location = new System.Drawing.Point(275, 73);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 39);
            this.uiComboBox1.TabIndex = 52;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "请选择日期类型";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(277, 137);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 55;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(325, 140);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(164, 35);
            this.uiLabel5.TabIndex = 54;
            this.uiLabel5.Text = "日期(年/月/日)";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // btn_salemoney
            // 
            this.btn_salemoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salemoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_salemoney.Location = new System.Drawing.Point(503, 248);
            this.btn_salemoney.Name = "btn_salemoney";
            this.btn_salemoney.Size = new System.Drawing.Size(100, 35);
            this.btn_salemoney.TabIndex = 61;
            this.btn_salemoney.Text = "查询";
            this.btn_salemoney.Visible = false;
            this.btn_salemoney.Click += new System.EventHandler(this.btn_salemoney_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_sale.Location = new System.Drawing.Point(503, 180);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(100, 35);
            this.btn_sale.TabIndex = 60;
            this.btn_sale.Text = "查询";
            this.btn_sale.Visible = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // dtp_salemoney
            // 
            this.dtp_salemoney.DateFormat = "yyyy-MM-dd";
            this.dtp_salemoney.FillColor = System.Drawing.Color.White;
            this.dtp_salemoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_salemoney.Location = new System.Drawing.Point(277, 253);
            this.dtp_salemoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_salemoney.MaxLength = 10;
            this.dtp_salemoney.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_salemoney.Name = "dtp_salemoney";
            this.dtp_salemoney.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_salemoney.Size = new System.Drawing.Size(200, 39);
            this.dtp_salemoney.SymbolDropDown = 61555;
            this.dtp_salemoney.SymbolNormal = 61555;
            this.dtp_salemoney.TabIndex = 59;
            this.dtp_salemoney.Text = "2020-08-10";
            this.dtp_salemoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_salemoney.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_salemoney.Visible = false;
            // 
            // dtp_sale
            // 
            this.dtp_sale.DateFormat = "yyyy-MM-dd";
            this.dtp_sale.FillColor = System.Drawing.Color.White;
            this.dtp_sale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_sale.Location = new System.Drawing.Point(277, 184);
            this.dtp_sale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_sale.MaxLength = 10;
            this.dtp_sale.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_sale.Name = "dtp_sale";
            this.dtp_sale.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_sale.Size = new System.Drawing.Size(200, 39);
            this.dtp_sale.SymbolDropDown = 61555;
            this.dtp_sale.SymbolNormal = 61555;
            this.dtp_sale.TabIndex = 58;
            this.dtp_sale.Text = "2020-08-10";
            this.dtp_sale.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_sale.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_sale.Visible = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(37, 253);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(225, 28);
            this.uiLabel2.TabIndex = 57;
            this.uiLabel2.Text = "平台销售额查询";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Visible = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(37, 184);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 35);
            this.uiLabel1.TabIndex = 56;
            this.uiLabel1.Text = "平台销量查询";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = true;
            // 
            // uiLabel_customer
            // 
            this.uiLabel_customer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_customer.Location = new System.Drawing.Point(37, 319);
            this.uiLabel_customer.Name = "uiLabel_customer";
            this.uiLabel_customer.Size = new System.Drawing.Size(186, 34);
            this.uiLabel_customer.TabIndex = 62;
            this.uiLabel_customer.Text = "平台顾客用户数";
            this.uiLabel_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_customer
            // 
            this.tb_customer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_customer.FillColor = System.Drawing.Color.White;
            this.tb_customer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_customer.Location = new System.Drawing.Point(277, 325);
            this.tb_customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customer.Maximum = 2147483647D;
            this.tb_customer.Minimum = -2147483648D;
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Padding = new System.Windows.Forms.Padding(5);
            this.tb_customer.Size = new System.Drawing.Size(129, 39);
            this.tb_customer.TabIndex = 63;
            // 
            // uiLabel_shop
            // 
            this.uiLabel_shop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_shop.Location = new System.Drawing.Point(37, 369);
            this.uiLabel_shop.Name = "uiLabel_shop";
            this.uiLabel_shop.Size = new System.Drawing.Size(167, 34);
            this.uiLabel_shop.TabIndex = 64;
            this.uiLabel_shop.Text = "平台店铺数量";
            this.uiLabel_shop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_store
            // 
            this.tb_store.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_store.FillColor = System.Drawing.Color.White;
            this.tb_store.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_store.Location = new System.Drawing.Point(277, 375);
            this.tb_store.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_store.Maximum = 2147483647D;
            this.tb_store.Minimum = -2147483648D;
            this.tb_store.Name = "tb_store";
            this.tb_store.Padding = new System.Windows.Forms.Padding(5);
            this.tb_store.Size = new System.Drawing.Size(129, 39);
            this.tb_store.TabIndex = 65;
            
            // 
            // Administrator_platform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Administrator_platform";
            this.Text = "平台统计信息";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel_name;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btn_salemoney;
        private Sunny.UI.UIButton btn_sale;
        private Sunny.UI.UIDatetimePicker dtp_salemoney;
        private Sunny.UI.UIDatetimePicker dtp_sale;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel_customer;
        private Sunny.UI.UITextBox tb_customer;
        private Sunny.UI.UITextBox tb_store;
        private Sunny.UI.UILabel uiLabel_shop;
    }
}