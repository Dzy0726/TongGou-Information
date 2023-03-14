namespace Main
{
    partial class OrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.label_destination = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_departure = new Sunny.UI.UILabel();
            this.label_order = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.label_money = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.label_destination);
            this.uiPanel1.Controls.Add(this.pictureBox1);
            this.uiPanel1.Controls.Add(this.label_departure);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(-1, 93);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(803, 268);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            // 
            // label_destination
            // 
            this.label_destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_destination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_destination.Location = new System.Drawing.Point(647, 108);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(109, 42);
            this.label_destination.Style = Sunny.UI.UIStyle.Custom;
            this.label_destination.TabIndex = 2;
            this.label_destination.Text = "终点";
            this.label_destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_departure
            // 
            this.label_departure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_departure.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_departure.Location = new System.Drawing.Point(73, 108);
            this.label_departure.Name = "label_departure";
            this.label_departure.Size = new System.Drawing.Size(109, 42);
            this.label_departure.Style = Sunny.UI.UIStyle.Custom;
            this.label_departure.TabIndex = 0;
            this.label_departure.Text = "起点";
            this.label_departure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_order.ForeColor = System.Drawing.Color.White;
            this.label_order.Location = new System.Drawing.Point(12, 65);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(77, 27);
            this.label_order.Style = Sunny.UI.UIStyle.Custom;
            this.label_order.TabIndex = 1;
            this.label_order.Text = "订单号:";
            this.label_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.label_money);
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(-1, 359);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(803, 92);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_money.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_money.Location = new System.Drawing.Point(312, 23);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(153, 27);
            this.label_money.Style = Sunny.UI.UIStyle.Custom;
            this.label_money.TabIndex = 0;
            this.label_money.Text = "订单金额:100元";
            this.label_money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(479, 65);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(97, 27);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "下单时间:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(327, 35);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(155, 43);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "订单简介";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.uiPanel1);
            this.MaximizeBox = false;
            this.Name = "OrderPage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "订单简介";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel label_departure;
        private Sunny.UI.UILabel label_order;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel label_destination;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel label_money;
    }
}