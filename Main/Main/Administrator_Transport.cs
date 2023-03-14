using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransInfo;

namespace Main
{
    public partial class Administrator_Transport : UITitlePage
    {
        public Administrator_Transport()
        {
            InitializeComponent();
        }

        private void btn_avgmoney_Click(object sender, EventArgs e)
        {

            int year = -1, month = -1, day = -1;
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)
            {
                year = int.Parse(dtp_avgmoney.Value.Year.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)
            {
                month = int.Parse(dtp_avgmoney.Value.Month.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0)
            {
                day = int.Parse(dtp_avgmoney.Value.Day.ToString());
            }
            TransInfoStatis TransInfo = new TransInfoStatis();
            TransInfo.TransfareSpecifyDate(year, month, day);
            this.ShowInfoDialog("所有商品的平均运费为:" + TransInfo.avg_trandfare.ToString() + "元",Style);
            //MessageBox.Show("所有商品的平均运费为:" + TransInfo.avg_trandfare.ToString() + "元");
        }

        private void btn_transmoney_Click(object sender, EventArgs e)
        {
            int year = -1, month = -1, day = -1;
            if(uiComboBox1.SelectedIndex==0 || uiComboBox1.SelectedIndex==1 || uiComboBox1.SelectedIndex==2)
            {
                year = int.Parse(dtp_transmoney.Value.Year.ToString());
            }
            if(uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)
            {
                month = int.Parse(dtp_transmoney.Value.Month.ToString());
            }
            if(uiComboBox1.SelectedIndex == 0)
            {
                day = int.Parse(dtp_transmoney.Value.Day.ToString());
            } 
            TransInfoStatis TransInfo = new TransInfoStatis();
            TransInfo.TransfareRank(year, month, day);
            Form_TransMoneyResult FormResult = new Form_TransMoneyResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = year.ToString();
            FormResult.month = month.ToString();
            FormResult.day = day.ToString();
            FormResult.TransInfo.transInfoList = TransInfo.transInfoList;
            FormResult.Show(this);//用formmain唤醒formresult
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiLabel1.Visible = true;
            uiLabel2.Visible = true;
            if(uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                dtp_avgmoney.DateFormat = "yyyy - MM - dd";
                dtp_transmoney.DateFormat = "yyyy - MM - dd";
                btn_transmoney.Visible = true;
                btn_avgmoney.Visible = true;
                dtp_avgmoney.Visible = true;
                dtp_transmoney.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
                btn_avgmoney.Location = new System.Drawing.Point(538, 172);
                btn_transmoney.Location = new System.Drawing.Point(538, 240);
            }
            else if(uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                btn_transmoney.Visible = true;
                btn_avgmoney.Visible = true;
                dtp_avgmoney.DateFormat = "yyyy - MM";
                dtp_transmoney.DateFormat = "yyyy - MM";
                dtp_avgmoney.Visible = true;
                dtp_transmoney.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                btn_avgmoney.Location = new System.Drawing.Point(538, 172);
                btn_transmoney.Location = new System.Drawing.Point(538, 240);
            }
            else if(uiComboBox1.SelectedIndex == 2)//选择年
            {
                btn_transmoney.Visible = true;
                btn_avgmoney.Visible = true;
                dtp_avgmoney.DateFormat = "yyyy";
                dtp_transmoney.DateFormat = "yyyy";
                dtp_avgmoney.Visible = true;
                dtp_transmoney.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                btn_avgmoney.Location = new System.Drawing.Point(538, 172);
                btn_transmoney.Location = new System.Drawing.Point(538, 240);
            }
            else if(uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                btn_transmoney.Visible = true;
                btn_avgmoney.Visible = true;
                dtp_avgmoney.Visible = false;
                dtp_transmoney.Visible = false;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
                btn_avgmoney.Location= new System.Drawing.Point(280, 174);
                btn_transmoney.Location= new System.Drawing.Point(280, 239);
            }
            
        }
    }
}
