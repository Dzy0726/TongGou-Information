namespace Main
{
    partial class Customer_Order
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
            this.btn_date = new Sunny.UI.UIButton();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.dtp_date = new Sunny.UI.UIDatetimePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiPanel_date = new Sunny.UI.UIPanel();
            this.uiPanel_Order = new Sunny.UI.UIPanel();
            this.TextBox_orderNO = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.btn_order = new Sunny.UI.UIButton();
            this.PagePanel.SuspendLayout();
            this.uiPanel_date.SuspendLayout();
            this.uiPanel_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiPanel_Order);
            this.PagePanel.Controls.Add(this.uiPanel_date);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiComboBox2);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(16, 18);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(186, 34);
            this.uiLabel7.TabIndex = 59;
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
            this.uiComboBox1.Location = new System.Drawing.Point(254, 18);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 34);
            this.uiComboBox1.TabIndex = 58;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "请选择日期类型";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // btn_date
            // 
            this.btn_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_date.Location = new System.Drawing.Point(514, 123);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(100, 35);
            this.btn_date.TabIndex = 57;
            this.btn_date.Text = "查询";
            this.btn_date.Visible = false;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(256, 82);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 56;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // dtp_date
            // 
            this.dtp_date.DateFormat = "yyyy-MM-dd";
            this.dtp_date.FillColor = System.Drawing.Color.White;
            this.dtp_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_date.Location = new System.Drawing.Point(256, 125);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_date.MaxLength = 10;
            this.dtp_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_date.Size = new System.Drawing.Size(200, 34);
            this.dtp_date.SymbolDropDown = 61555;
            this.dtp_date.SymbolNormal = 61555;
            this.dtp_date.TabIndex = 55;
            this.dtp_date.Text = "2020-08-10";
            this.dtp_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_date.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_date.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(304, 85);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(164, 35);
            this.uiLabel5.TabIndex = 54;
            this.uiLabel5.Text = "日期(年/月/日)";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(16, 121);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 35);
            this.uiLabel1.TabIndex = 53;
            this.uiLabel1.Text = "请选择查询日期:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(33, 19);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 52;
            this.uiLine1.Text = "我的订单";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(45, 58);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(186, 34);
            this.uiLabel2.TabIndex = 61;
            this.uiLabel2.Text = "请先选择查询方式:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox2.Items.AddRange(new object[] {
            "按订单号查询",
            "按日期查询"});
            this.uiComboBox2.Location = new System.Drawing.Point(283, 58);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox2.Size = new System.Drawing.Size(150, 34);
            this.uiComboBox2.TabIndex = 60;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "请选择查询方式";
            this.uiComboBox2.SelectedIndexChanged += new System.EventHandler(this.uiComboBox2_SelectedIndexChanged);
            // 
            // uiPanel_date
            // 
            this.uiPanel_date.Controls.Add(this.uiComboBox1);
            this.uiPanel_date.Controls.Add(this.uiLabel1);
            this.uiPanel_date.Controls.Add(this.uiLabel5);
            this.uiPanel_date.Controls.Add(this.btn_date);
            this.uiPanel_date.Controls.Add(this.uiLabel7);
            this.uiPanel_date.Controls.Add(this.dtp_date);
            this.uiPanel_date.Controls.Add(this.uiAvatar1);
            this.uiPanel_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_date.Location = new System.Drawing.Point(33, 132);
            this.uiPanel_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_date.Name = "uiPanel_date";
            this.uiPanel_date.Size = new System.Drawing.Size(653, 176);
            this.uiPanel_date.TabIndex = 62;
            this.uiPanel_date.Text = null;
            this.uiPanel_date.Visible = false;
            // 
            // uiPanel_Order
            // 
            this.uiPanel_Order.Controls.Add(this.TextBox_orderNO);
            this.uiPanel_Order.Controls.Add(this.uiLabel6);
            this.uiPanel_Order.Controls.Add(this.btn_order);
            this.uiPanel_Order.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_Order.Location = new System.Drawing.Point(33, 132);
            this.uiPanel_Order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_Order.Name = "uiPanel_Order";
            this.uiPanel_Order.Size = new System.Drawing.Size(653, 176);
            this.uiPanel_Order.TabIndex = 63;
            this.uiPanel_Order.Text = null;
            this.uiPanel_Order.Visible = false;
            // 
            // TextBox_orderNO
            // 
            this.TextBox_orderNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_orderNO.FillColor = System.Drawing.Color.White;
            this.TextBox_orderNO.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TextBox_orderNO.Location = new System.Drawing.Point(256, 18);
            this.TextBox_orderNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_orderNO.Maximum = 2147483647D;
            this.TextBox_orderNO.Minimum = -2147483648D;
            this.TextBox_orderNO.Name = "TextBox_orderNO";
            this.TextBox_orderNO.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_orderNO.Size = new System.Drawing.Size(150, 34);
            this.TextBox_orderNO.TabIndex = 60;
            this.TextBox_orderNO.Watermark = "请输入订单号";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(16, 18);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(186, 34);
            this.uiLabel6.TabIndex = 59;
            this.uiLabel6.Text = "请输入订单号:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_order
            // 
            this.btn_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_order.Location = new System.Drawing.Point(488, 17);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(100, 35);
            this.btn_order.TabIndex = 57;
            this.btn_order.Text = "查询";
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // Customer_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Customer_Order";
            this.Text = "我的订单";
            this.PagePanel.ResumeLayout(false);
            this.uiPanel_date.ResumeLayout(false);
            this.uiPanel_Order.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton btn_date;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIDatetimePicker dtp_date;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIPanel uiPanel_Order;
        private Sunny.UI.UITextBox TextBox_orderNO;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btn_order;
        private Sunny.UI.UIPanel uiPanel_date;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox uiComboBox2;
    }
}