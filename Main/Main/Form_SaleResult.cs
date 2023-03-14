using GoodInfoStatis;
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
    public partial class Form_SaleResult : UIForm
    {
        public Form_SaleResult()
        {
            InitializeComponent();
        }

        public string year, month, day;

        

        public GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();

        private void Form_SaleResult_Load(object sender, EventArgs e)
        {
            if (day != "-1")
            {
                lbl_date.Text = lbl_date.Text.ToString() + year + "年" + month + "月" + day + "日";
            }
            else if (month != "-1")
            {
                lbl_date.Text = lbl_date.Text.ToString() + year + "年" + month + "月";
            }
            else if (year != "-1")
            {
                lbl_date.Text = lbl_date.Text.ToString() + year + "年";
            }
            else
            {
                lbl_date.Text = "统计结果为历史累计";
            }
            for (int i = 0; i < GoodsInfo.GoodsStatInfo.Count(); i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = i.ToString();
                uiDataGridView1.Rows[i].Cells[1].Value = GoodsInfo.GoodsStatInfo[i].type.ToString();
                uiDataGridView1.Rows[i].Cells[2].Value = GoodsInfo.GoodsStatInfo[i].quantity.ToString();

            }
            //将查询出的销售量通过listview控件的方法加入到对应的列表框中，需要得到商品的类型和其对应的销售量两个值
        }
    }
}
