namespace Main
{
    partial class Administrator_Customer
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
            this.btn_avg = new Sunny.UI.UIButton();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.dtp_avg = new Sunny.UI.UIDatetimePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btn_day = new Sunny.UI.UIButton();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btn_month = new Sunny.UI.UIButton();
            this.uiAvatar3 = new Sunny.UI.UIAvatar();
            this.uiDatetimePicker2 = new Sunny.UI.UIDatetimePicker();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.btn_month);
            this.PagePanel.Controls.Add(this.uiAvatar3);
            this.PagePanel.Controls.Add(this.uiDatetimePicker2);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.btn_day);
            this.PagePanel.Controls.Add(this.uiAvatar2);
            this.PagePanel.Controls.Add(this.uiDatetimePicker1);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel7);
            this.PagePanel.Controls.Add(this.uiComboBox1);
            this.PagePanel.Controls.Add(this.btn_avg);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.dtp_avg);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(44, 285);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(361, 34);
            this.uiLabel7.TabIndex = 59;
            this.uiLabel7.Text = "查询顾客平均开销,请先选择日期类型:";
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
            this.uiComboBox1.Location = new System.Drawing.Point(425, 285);
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
            // btn_avg
            // 
            this.btn_avg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_avg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_avg.Location = new System.Drawing.Point(542, 390);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(100, 35);
            this.btn_avg.TabIndex = 57;
            this.btn_avg.Text = "查询";
            this.btn_avg.Visible = false;
            this.btn_avg.Click += new System.EventHandler(this.btn_avg_Click);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(284, 349);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 56;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // dtp_avg
            // 
            this.dtp_avg.DateFormat = "yyyy-MM-dd";
            this.dtp_avg.FillColor = System.Drawing.Color.White;
            this.dtp_avg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_avg.Location = new System.Drawing.Point(284, 392);
            this.dtp_avg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_avg.MaxLength = 10;
            this.dtp_avg.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtp_avg.Name = "dtp_avg";
            this.dtp_avg.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dtp_avg.Size = new System.Drawing.Size(200, 34);
            this.dtp_avg.SymbolDropDown = 61555;
            this.dtp_avg.SymbolNormal = 61555;
            this.dtp_avg.TabIndex = 55;
            this.dtp_avg.Text = "2020-08-10";
            this.dtp_avg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtp_avg.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dtp_avg.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(332, 352);
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
            this.uiLabel1.Location = new System.Drawing.Point(44, 388);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(214, 35);
            this.uiLabel1.TabIndex = 53;
            this.uiLabel1.Text = "顾客平均开销:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(28, 20);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 52;
            this.uiLine1.Text = "顾客统计信息";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_day
            // 
            this.btn_day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_day.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_day.Location = new System.Drawing.Point(542, 109);
            this.btn_day.Name = "btn_day";
            this.btn_day.Size = new System.Drawing.Size(100, 35);
            this.btn_day.TabIndex = 64;
            this.btn_day.Text = "查询";
            this.btn_day.Click += new System.EventHandler(this.btn_day_Click);
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar2.Location = new System.Drawing.Point(284, 68);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar2.Symbol = 61555;
            this.uiAvatar2.TabIndex = 63;
            this.uiAvatar2.Text = "uiAvatar2";
            // 
            // uiDatetimePicker1
            // 
            this.uiDatetimePicker1.DateFormat = "yyyy-MM";
            this.uiDatetimePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDatetimePicker1.Location = new System.Drawing.Point(284, 111);
            this.uiDatetimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker1.MaxLength = 7;
            this.uiDatetimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker1.Name = "uiDatetimePicker1";
            this.uiDatetimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiDatetimePicker1.Size = new System.Drawing.Size(200, 34);
            this.uiDatetimePicker1.SymbolDropDown = 61555;
            this.uiDatetimePicker1.SymbolNormal = 61555;
            this.uiDatetimePicker1.TabIndex = 62;
            this.uiDatetimePicker1.Text = "2020-08";
            this.uiDatetimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker1.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel2.Location = new System.Drawing.Point(332, 71);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(164, 35);
            this.uiLabel2.TabIndex = 61;
            this.uiLabel2.Text = "日期(年/月)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(44, 107);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(214, 35);
            this.uiLabel3.TabIndex = 60;
            this.uiLabel3.Text = "顾客日度开销:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_month
            // 
            this.btn_month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_month.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_month.Location = new System.Drawing.Point(542, 205);
            this.btn_month.Name = "btn_month";
            this.btn_month.Size = new System.Drawing.Size(100, 35);
            this.btn_month.TabIndex = 69;
            this.btn_month.Text = "查询";
            this.btn_month.Click += new System.EventHandler(this.btn_month_Click);
            // 
            // uiAvatar3
            // 
            this.uiAvatar3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar3.Location = new System.Drawing.Point(284, 164);
            this.uiAvatar3.Name = "uiAvatar3";
            this.uiAvatar3.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar3.Symbol = 61555;
            this.uiAvatar3.TabIndex = 68;
            this.uiAvatar3.Text = "uiAvatar3";
            // 
            // uiDatetimePicker2
            // 
            this.uiDatetimePicker2.DateFormat = "yyyy";
            this.uiDatetimePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDatetimePicker2.Location = new System.Drawing.Point(284, 207);
            this.uiDatetimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker2.MaxLength = 4;
            this.uiDatetimePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker2.Name = "uiDatetimePicker2";
            this.uiDatetimePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiDatetimePicker2.Size = new System.Drawing.Size(200, 34);
            this.uiDatetimePicker2.SymbolDropDown = 61555;
            this.uiDatetimePicker2.SymbolNormal = 61555;
            this.uiDatetimePicker2.TabIndex = 67;
            this.uiDatetimePicker2.Text = "2020";
            this.uiDatetimePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker2.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel4.Location = new System.Drawing.Point(332, 167);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(164, 35);
            this.uiLabel4.TabIndex = 66;
            this.uiLabel4.Text = "日期(年)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(44, 203);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(214, 35);
            this.uiLabel6.TabIndex = 65;
            this.uiLabel6.Text = "顾客月度开销:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Administrator_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Administrator_Customer";
            this.Text = "顾客统计信息";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton btn_avg;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIDatetimePicker dtp_avg;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIButton btn_month;
        private Sunny.UI.UIAvatar uiAvatar3;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btn_day;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
    }
}