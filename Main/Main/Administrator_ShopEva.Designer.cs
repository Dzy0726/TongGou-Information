﻿namespace Main
{
    partial class Administrator_ShopEva
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
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.button_query = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.dateTimePicker_date = new Sunny.UI.UIDatetimePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiComboBox2);
            this.PagePanel.Controls.Add(this.uiAvatar2);
            this.PagePanel.Controls.Add(this.button_query);
            this.PagePanel.Controls.Add(this.uiLabel6);
            this.PagePanel.Controls.Add(this.uiAvatar1);
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.dateTimePicker_date);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiComboBox1);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(37, 195);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(186, 34);
            this.uiLabel3.TabIndex = 60;
            this.uiLabel3.Text = "请先选择日期类型:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiComboBox1.Location = new System.Drawing.Point(275, 195);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 39);
            this.uiComboBox1.TabIndex = 59;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "请选择日期类型";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(29, 19);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 50;
            this.uiLine1.Text = "店铺评价";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar2.Location = new System.Drawing.Point(42, 64);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar2.Symbol = 61481;
            this.uiAvatar2.TabIndex = 80;
            this.uiAvatar2.Text = "uiAvatar3";
            // 
            // button_query
            // 
            this.button_query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_query.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_query.Location = new System.Drawing.Point(567, 305);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(100, 35);
            this.button_query.TabIndex = 79;
            this.button_query.Text = "查询";
            this.button_query.Visible = false;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(85, 65);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(102, 34);
            this.uiLabel6.TabIndex = 77;
            this.uiLabel6.Text = "店铺种类";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(277, 255);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(42, 35);
            this.uiAvatar1.Symbol = 61555;
            this.uiAvatar1.TabIndex = 76;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.uiLabel5.Location = new System.Drawing.Point(325, 255);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(152, 35);
            this.uiLabel5.TabIndex = 75;
            this.uiLabel5.Text = "日期";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.DateFormat = "yyyy - MM - dd";
            this.dateTimePicker_date.FillColor = System.Drawing.Color.White;
            this.dateTimePicker_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dateTimePicker_date.Location = new System.Drawing.Point(277, 306);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_date.MaxLength = 14;
            this.dateTimePicker_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker_date.SymbolDropDown = 61555;
            this.dateTimePicker_date.SymbolNormal = 61555;
            this.dateTimePicker_date.TabIndex = 74;
            this.dateTimePicker_date.Text = "2020 - 09 - 12";
            this.dateTimePicker_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTimePicker_date.Value = new System.DateTime(2020, 9, 12, 9, 7, 4, 905);
            this.dateTimePicker_date.Visible = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(37, 306);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(225, 36);
            this.uiLabel1.TabIndex = 73;
            this.uiLabel1.Text = "店铺评价统计:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox2.Location = new System.Drawing.Point(43, 117);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uiComboBox2.Size = new System.Drawing.Size(200, 39);
            this.uiComboBox2.TabIndex = 81;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "请选择店铺种类";
            this.uiComboBox2.SelectedIndexChanged += new System.EventHandler(this.uiComboBox2_SelectedIndexChanged);
            // 
            // Administrator_ShopEva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Administrator_ShopEva";
            this.Text = "店铺评价";
            this.Load += new System.EventHandler(this.Administrator_ShopEva_Load);
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UIButton button_query;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIDatetimePicker dateTimePicker_date;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox uiComboBox2;
    }
}