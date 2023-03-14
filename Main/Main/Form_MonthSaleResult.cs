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
    public partial class Form_MonthSaleResult : UIForm
    {
        public Form_MonthSaleResult()
        {
            InitializeComponent();
        }

        public string year, GoodsType;
        public GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();

        private void Form_MonthSaleResult_Load(object sender, EventArgs e)
        {
            lbl_date.Text = lbl_date.Text.ToString() + year + "年";
            lbl_type.Text = lbl_type.Text.ToString() + GoodsType;
            this.Text = GoodsType + this.Text.ToString();
            this.uiLine1.Text = GoodsType + this.uiLine1.Text.ToString();
            for (int i = 1; i < 13; i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i-1].Cells[0].Value = i.ToString();
                uiDataGridView1.Rows[i-1].Cells[1].Value = GoodsInfo.goods_month_sales[i].ToString();
            }
            //添加项
        }
    }
}
