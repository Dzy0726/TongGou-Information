using Sunny.UI;

namespace Main
{
    partial class MyInformation
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
            this.label_ID = new Sunny.UI.UILabel();
            this.label_adm_name = new Sunny.UI.UILabel();
            this.label_ID_data = new Sunny.UI.UILabel();
            this.label_adm_name_data = new Sunny.UI.UILabel();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.label_adm_name_data);
            this.PagePanel.Controls.Add(this.label_ID_data);
            this.PagePanel.Controls.Add(this.label_adm_name);
            this.PagePanel.Controls.Add(this.label_ID);
            this.PagePanel.Controls.Add(this.uiLine1);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(30, 20);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(670, 20);
            this.uiLine1.TabIndex = 19;
            this.uiLine1.Text = "我的信息";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ID
            // 
            this.label_ID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_ID.Location = new System.Drawing.Point(51, 100);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(145, 40);
            this.label_ID.TabIndex = 20;
            this.label_ID.Text = "ID：";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_adm_name
            // 
            this.label_adm_name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_adm_name.Location = new System.Drawing.Point(51, 200);
            this.label_adm_name.Name = "label_adm_name";
            this.label_adm_name.Size = new System.Drawing.Size(145, 40);
            this.label_adm_name.TabIndex = 21;
            this.label_adm_name.Text = "用户名：";
            this.label_adm_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ID_data
            // 
            this.label_ID_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_ID_data.Location = new System.Drawing.Point(380, 100);
            this.label_ID_data.Name = "label_ID_data";
            this.label_ID_data.Size = new System.Drawing.Size(125, 40);
            this.label_ID_data.TabIndex = 22;
            this.label_ID_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_adm_name_data
            // 
            this.label_adm_name_data.AutoSize = true;
            this.label_adm_name_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_adm_name_data.Location = new System.Drawing.Point(380, 200);
            this.label_adm_name_data.Name = "label_adm_name_data";
            this.label_adm_name_data.Size = new System.Drawing.Size(0, 27);
            this.label_adm_name_data.TabIndex = 23;
            this.label_adm_name_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MyInformation";
            this.Text = "我的信息";
            this.PagePanel.ResumeLayout(false);
            this.PagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UILine uiLine1;
        private UILabel label_ID;
        private UILabel label_adm_name_data;
        private UILabel label_ID_data;
        private UILabel label_adm_name;
    }
}