namespace Main
{
    partial class Customer_BuyHistory
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
            this.btn_monthsale = new Sunny.UI.UIButton();
            this.btn_salemoney = new Sunny.UI.UIButton();
            this.btn_sale = new Sunny.UI.UIButton();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.dtp_monthsale = new Sunny.UI.UIDatetimePicker();
            this.dtp_salemoney = new Sunny.UI.UIDatetimePicker();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.dtp_sale = new Sunny.UI.UIDatetimePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiAvatar4 = new Sunny.UI.UIAvatar();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiAvatar4);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiLabel7);
            this.PagePanel.Controls.Add(this.uiComboBox1);
            this.PagePanel.Controls.Add(this.btn_monthsale);
            this.PagePanel.Controls.Add(this.btn_salemoney);
            this.PagePanel.Controls.Add(this.btn_sale);
            this.PagePanel.Controls.Add(this.uiAvatar2);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.dtp_monthsale);
            this.PagePanel.Controls.Add(this.dtp_salemoney);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.dtp_sale);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(30, 72);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(186, 34);
            this.uiLabel7.TabIndex = 70;
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
            this.uiComboBox1.Location = new System.Drawing.Point(268, 72);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 34);
            this.uiComboBox1.TabIndex = 69;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "请选择日期类型";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // btn_monthsale
            // 
            this.btn_monthsale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_monthsale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_monthsale.Location = new System.Drawing.Point(528, 380);
            this.btn_monthsale.Name = "btn_monthsale";
            this.btn_monthsale.Size = new System.Drawing.Size(100, 35);
            this.btn_monthsale.TabIndex = 67;
            this.btn_monthsale.Text = "查询";
            this.btn_monthsale.Click += new System.EventHandler(this.btn_monthsale_Click);
            // 
            // btn_salemoney
            // 
            this.btn_salemoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salemoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_salemoney.Location = new System.Drawing.Point(528, 282);
            this.btn_salemoney.Name = "btn_salemoney";
            this.btn_salemoney.Size = new System.Drawing.Size(100, 35);
            this.btn_salemoney.TabIndex = 66;
            this.btn_salemoney.Text = "查询";
            this.btn_salemoney.Visible = false;
            this.btn_salemoney.Click += new System.EventHandler(this.btn_salemoney_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_sale.Location = new System.Drawing.Point(528, 177);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(100, 35);
            this.btn_sale.TabIndex = 65;
            this.btn_sale.Text = "查询";
            this.btn_sale.Visible = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar2.Location = new System.Drawing.Point(269, 328);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar2.Symbol = 61555;
            this.uiAvatar2.TabIndex = 62;
            this.uiAvatar2.Text = "uiAvatar2";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel6.Location = new System.Drawing.Point(317, 328);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(152, 35);
            this.uiLabel6.TabIndex = 61;
            this.uiLabel6.Text = "年份";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_monthsale
            // 
            this.dtp_monthsale.DateFormat = "yyyy";
            this.dtp_monthsale.FillColor = System.Drawing.Color.White;
            this.dtp_monthsale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_monthsale.Location = new System.Drawing.Point(269, 379);
            this.dtp_monthsale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_monthsale.MaxLength = 4;
            this.dtp_monthsale.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_monthsale.Name = "dtp_monthsale";
            this.dtp_monthsale.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_monthsale.Size = new System.Drawing.Size(200, 34);
            this.dtp_monthsale.SymbolDropDown = 61555;
            this.dtp_monthsale.SymbolNormal = 61555;
            this.dtp_monthsale.TabIndex = 59;
            this.dtp_monthsale.Text = "2020";
            this.dtp_monthsale.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_monthsale.Value = new System.DateTime(2020, 9, 12, 9, 7, 4, 905);
            // 
            // dtp_salemoney
            // 
            this.dtp_salemoney.DateFormat = "yyyy-MM-dd";
            this.dtp_salemoney.FillColor = System.Drawing.Color.White;
            this.dtp_salemoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_salemoney.Location = new System.Drawing.Point(270, 283);
            this.dtp_salemoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_salemoney.MaxLength = 10;
            this.dtp_salemoney.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_salemoney.Name = "dtp_salemoney";
            this.dtp_salemoney.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_salemoney.Size = new System.Drawing.Size(200, 34);
            this.dtp_salemoney.SymbolDropDown = 61555;
            this.dtp_salemoney.SymbolNormal = 61555;
            this.dtp_salemoney.TabIndex = 60;
            this.dtp_salemoney.Text = "2020-08-10";
            this.dtp_salemoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_salemoney.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_salemoney.Visible = false;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(270, 136);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 58;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // dtp_sale
            // 
            this.dtp_sale.DateFormat = "yyyy-MM-dd";
            this.dtp_sale.FillColor = System.Drawing.Color.White;
            this.dtp_sale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_sale.Location = new System.Drawing.Point(270, 179);
            this.dtp_sale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_sale.MaxLength = 10;
            this.dtp_sale.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_sale.Name = "dtp_sale";
            this.dtp_sale.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_sale.Size = new System.Drawing.Size(200, 34);
            this.dtp_sale.SymbolDropDown = 61555;
            this.dtp_sale.SymbolNormal = 61555;
            this.dtp_sale.TabIndex = 57;
            this.dtp_sale.Text = "2020-08-10";
            this.dtp_sale.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_sale.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_sale.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(318, 139);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(164, 35);
            this.uiLabel5.TabIndex = 56;
            this.uiLabel5.Text = "日期(年/月/日)";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(29, 379);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(225, 36);
            this.uiLabel3.TabIndex = 55;
            this.uiLabel3.Text = "月度消费金额";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(30, 282);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(225, 28);
            this.uiLabel2.TabIndex = 54;
            this.uiLabel2.Text = "各类商品消费金额统计:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Visible = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(30, 175);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 35);
            this.uiLabel1.TabIndex = 53;
            this.uiLabel1.Text = "消费金额统计:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(23, 19);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 52;
            this.uiLine1.Text = "我的消费记录";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar4
            // 
            this.uiAvatar4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar4.Location = new System.Drawing.Point(268, 229);
            this.uiAvatar4.Name = "uiAvatar4";
            this.uiAvatar4.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar4.Symbol = 61555;
            this.uiAvatar4.TabIndex = 72;
            this.uiAvatar4.Text = "uiAvatar4";
            this.uiAvatar4.Visible = false;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel4.Location = new System.Drawing.Point(316, 232);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(164, 35);
            this.uiLabel4.TabIndex = 71;
            this.uiLabel4.Text = "日期(年/月/日)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Visible = false;
            // 
            // Customer_BuyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Customer_BuyHistory";
            this.Text = "我的消费记录";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton btn_monthsale;
        private Sunny.UI.UIButton btn_salemoney;
        private Sunny.UI.UIButton btn_sale;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDatetimePicker dtp_monthsale;
        private Sunny.UI.UIDatetimePicker dtp_salemoney;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIDatetimePicker dtp_sale;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIAvatar uiAvatar4;
        private Sunny.UI.UILabel uiLabel4;
    }
}