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

namespace Main
{
    public partial class Administrator_ShopSale : UITitlePage
    {
        public Administrator_ShopSale()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiLabel1.Visible = true;
            uiLabel2.Visible = true;
            uiLabel3.Visible = true;
            uiLabel4.Visible = true;
            uiLabel9.Visible = true;
            uiAvatar3.Visible = true;
            uiComboBox2.Visible = true;
            uiComboBox3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            if(uiComboBox1.SelectedIndex==0)//选择年-月-日
            {
                dtp_AllSale.Visible = true;
                dtp_AllSalemoney.Visible = true;
                dtp_sale.Visible = true;
                dtp_salemoney.Visible = true;
                dtp_AllSale.DateFormat = "yyyy - MM - dd";
                dtp_AllSalemoney.DateFormat = "yyyy - MM - dd";
                dtp_sale.DateFormat = "yyyy - MM - dd";
                dtp_salemoney.DateFormat = "yyyy - MM - dd";
                uiAvatar1.Visible = true;
                uiAvatar2.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
                uiLabel6.Visible = true;
                uiLabel6.Text = "日期(年-月-日)";
                button1.Location = new System.Drawing.Point(535, 182);
                button2.Location = new System.Drawing.Point(535, 247);
                button3.Location = new System.Drawing.Point(685, 365);
                button4.Location = new System.Drawing.Point(685, 440);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                dtp_AllSale.Visible = true;
                dtp_AllSalemoney.Visible = true;
                dtp_sale.Visible = true;
                dtp_salemoney.Visible = true;
                dtp_AllSale.DateFormat = "yyyy - MM";
                dtp_AllSalemoney.DateFormat = "yyyy - MM";
                dtp_sale.DateFormat = "yyyy - MM";
                dtp_salemoney.DateFormat = "yyyy - MM";
                uiAvatar1.Visible = true;
                uiAvatar2.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                uiLabel6.Visible = true;
                uiLabel6.Text = "日期(年-月)";
                button1.Location = new System.Drawing.Point(535, 182);
                button2.Location = new System.Drawing.Point(535, 247);
                button3.Location = new System.Drawing.Point(685, 365);
                button4.Location = new System.Drawing.Point(685, 440);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                dtp_AllSale.Visible = true;
                dtp_AllSalemoney.Visible = true;
                dtp_sale.Visible = true;
                dtp_salemoney.Visible = true;
                dtp_AllSale.DateFormat = "yyyy";
                dtp_AllSalemoney.DateFormat = "yyyy";
                dtp_sale.DateFormat = "yyyy";
                dtp_salemoney.DateFormat = "yyyy";
                uiAvatar1.Visible = true;
                uiAvatar2.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                uiLabel6.Visible = true;
                uiLabel6.Text = "日期(年)";
                button1.Location = new System.Drawing.Point(535, 182);
                button2.Location = new System.Drawing.Point(535, 247);
                button3.Location = new System.Drawing.Point(685, 365);
                button4.Location = new System.Drawing.Point(685, 440);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                dtp_AllSale.Visible = false;
                dtp_AllSalemoney.Visible = false;
                dtp_sale.Visible = false;
                dtp_salemoney.Visible = false;
                uiAvatar1.Visible = false;
                uiAvatar2.Visible = false;
                uiLabel5.Visible = false;
                uiLabel6.Visible = false;
                button1.Location= new System.Drawing.Point(277,182);
                button2.Location= new System.Drawing.Point(277, 247);
                button3.Location = new System.Drawing.Point(467, 365);
                button4.Location = new System.Drawing.Point(467, 440);
            }
        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                button3.Visible = true;
        }

        private void uiComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {          
                button4.Visible = true;
        }
        //各种类店铺销量查询
        private void button1_Click(object sender, EventArgs e)
        {
            int year = -1;//年，初始为空
            int month = -1;//月，初始为空
            int day = -1;//日，初始为空
            string date = "历史累计";//年月日，初始为历史累计
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)//选择了“年”
            {
                year = dtp_AllSale.Value.Year;//获取所选年份
                date = year.ToString() + "年";
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)//选择了“月”
            {
                month = dtp_AllSale.Value.Month;//获取所选月份
                date = date + month.ToString() + "月";
            }
            if (uiComboBox1.SelectedIndex == 0)//选择了“日”
            {
                day = dtp_AllSale.Value.Day;//获取所选天数
                date = date + day.ToString() + "日";
            }
            //调用StoreInfoStatis进行查询
            StoreInfoStatis query = new StoreInfoStatis();
            query.StoreSpecifyDate(year, month, day, 1);
            Form_QuaResult QuaResult = new Form_QuaResult();//创建“各种类店铺销量查询结果”窗体实例
            Form_QuaResult.info_result info = new Form_QuaResult.info_result();
            int num = 0;
            num = query.StoreStatInfo.Count();//获取查询结果有多少项
            for (int i = 0; i < num; i++)//复制查询结果
            {
                info.type = query.StoreStatInfo[i].type;//店铺类型
                info.quantity = query.StoreStatInfo[i].quantity;//销量
                QuaResult.result.Add(info);
            }
            Form_QuaResult.date = date;//复制年月日
            QuaResult.Show();//打开“各种类店铺销量查询结果”窗体
        }
        //各种类店铺销售额查询
        private void button2_Click(object sender, EventArgs e)
        {
            int year = -1;//年，初始为空
            int month = -1;//月，初始为空
            int day = -1;//日，初始为空
            string date = "历史累计";//年月日，初始为历史累计
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)//选择了“年”
            {
                year = dtp_AllSalemoney.Value.Year;//获取所选年份
                date = year.ToString() + "年";
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)//选择了“月”
            {
                month = dtp_AllSalemoney.Value.Month;//获取所选月份
                date = date + month.ToString() + "月";
            }
            if (uiComboBox1.SelectedIndex == 0)//选择了“日”
            {
                day = dtp_AllSalemoney.Value.Day;//获取所选天数
                date = date + day.ToString() + "日";
            }
            //调用StoreInfoStatis进行查询
            StoreInfoStatis query = new StoreInfoStatis();
            query.StoreSpecifyDate(year, month, day, 2);
            Form_ProResult ProResult = new Form_ProResult();//创建“各种类店铺销售额查询结果”窗体实例
            Form_ProResult.info_result info = new Form_ProResult.info_result();
            int num = 0;
            num = query.StoreStatInfo.Count();//获取查询结果有多少项
            for (int i = 0; i < num; i++)//复制查询结果
            {
                info.type = query.StoreStatInfo[i].type;//店铺类型
                info.proceeds = query.StoreStatInfo[i].proceeds;//销售额
                ProResult.result.Add(info);
            }
            Form_ProResult.date = date;//复制年月日
            ProResult.Show();//打开“各种类店铺销售额查询结果”窗体
        }
        //店铺销量查询
        private void button3_Click(object sender, EventArgs e)
        {
            int year = -1;//年，初始为空
            int month = -1;//月，初始为空
            int day = -1;//日，初始为空
            string date = "历史累计";//年月日，初始为历史累计
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)//选择了“年”
            {
                year = dtp_AllSalemoney.Value.Year;//获取所选年份
                date = year.ToString() + "年";
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)//选择了“月”
            {
                month = dtp_AllSalemoney.Value.Month;//获取所选月份
                date = date + month.ToString() + "月";
            }
            if (uiComboBox1.SelectedIndex == 0)//选择了“日”
            {
                day = dtp_AllSalemoney.Value.Day;//获取所选天数
                date = date + day.ToString() + "日";
            }
            string store_type = null;//店铺种类，初始为空
            store_type = uiComboBox2.SelectedItem.ToString();//获取店铺种类
            //调用StoreInfoStatis进行查询
            StoreInfoStatis query = new StoreInfoStatis();
            query.StoreSalesRank(year, month, day, store_type, 1);
            Form_TypeQuaResult TypeQuaResult = new Form_TypeQuaResult();//创建“店铺销量查询结果”窗体实例
            Form_TypeQuaResult.info_result info = new Form_TypeQuaResult.info_result();
            int num = 0;
            num = query.StoreStatInfo.Count();//获取查询结果有多少项
            for (int i = 0; i < num; i++)//复制查询结果
            {
                info.name = query.StoreStatInfo[i].name;//店铺名称
                info.quantity = query.StoreStatInfo[i].quantity;//销量
                TypeQuaResult.result.Add(info);
            }
            Form_TypeQuaResult.date = date;//复制年月日
            Form_TypeQuaResult.type = store_type;//复制店铺种类
            TypeQuaResult.Show();//打开“店铺销量查询结果”窗体
        }
        //店铺销售额查询
        private void button4_Click(object sender, EventArgs e)
        {
            int year = -1;//年，初始为空
            int month = -1;//月，初始为空
            int day = -1;//日，初始为空
            string date = "历史累计";//年月日，初始为历史累计
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)//选择了“年”
            {
                year = dtp_AllSalemoney.Value.Year;//获取所选年份
                date = year.ToString() + "年";
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)//选择了“月”
            {
                month = dtp_AllSalemoney.Value.Month;//获取所选月份
                date = date + month.ToString() + "月";
            }
            if (uiComboBox1.SelectedIndex == 0)//选择了“日”
            {
                day = dtp_AllSalemoney.Value.Day;//获取所选天数
                date = date + day.ToString() + "日";
            }
            string store_type = null;//店铺种类，初始为空
            store_type = uiComboBox3.SelectedItem.ToString();//获取店铺种类
            //调用StoreInfoStatis进行查询
            StoreInfoStatis query = new StoreInfoStatis();
            query.StoreSalesRank(year, month, day, store_type, 2);
            Form_TypeProResult TypeProResult = new Form_TypeProResult();//创建“店铺销售额查询结果”窗体实例
            Form_TypeProResult.info_result info = new Form_TypeProResult.info_result();
            int num = 0;
            num = query.StoreStatInfo.Count();//获取查询结果有多少项
            for (int i = 0; i < num; i++)//复制查询结果
            {
                info.name = query.StoreStatInfo[i].name;//店铺名称
                info.proceeds = query.StoreStatInfo[i].proceeds;//销售额
                TypeProResult.result.Add(info);
            }
            Form_TypeProResult.date = date;//复制年月日
            Form_TypeProResult.type = store_type;//复制店铺种类
            TypeProResult.Show();//打开“店铺销售额查询结果”窗体
        }

        private void Administrator_ShopSale_Load(object sender, EventArgs e)//在单选框中添加店铺种类
        {
            StoreInfoStatis type = new StoreInfoStatis();
            type.AllStoreType();
            int num = type.all_store_type.Count;
            for (int i = 0; i < num; i++)
            {
                uiComboBox2.Items.Add(type.all_store_type[i]);
                uiComboBox3.Items.Add(type.all_store_type[i]);
            }
        }
    }
}
