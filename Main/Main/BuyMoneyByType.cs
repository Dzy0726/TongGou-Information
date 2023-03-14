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
    public partial class BuyMoneyByType : UIForm
    {
        public BuyMoneyByType()
        {
            InitializeComponent();

            
        }

        public static int year, month, day;

        private void BuyMoneyByType_Load(object sender, EventArgs e)
        {
            orderInfo1.CostByType(Form_login.id_global, year, month, day);

            string date;
            if (day != -1)
            {
                date = year.ToString() + "年" + month.ToString() + "月" + day.ToString() + "日";
            }
            else if (month != -1)
            {
                date = year.ToString() + "年" + month.ToString() + "月";
            }
            else if (year != -1)
            {
                date = year.ToString() + "年";
            }
            else
            {
                date = "历史累计";
            }

            lbl_date.Text = "查询日期为:" + date;
            int i = 0;
            while (orderInfo1.GoodsType[i] != null)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                uiDataGridView1.Rows[i].Cells[1].Value = orderInfo1.GoodsType[i];
                uiDataGridView1.Rows[i].Cells[2].Value = orderInfo1.CostForType[i];
                orderInfo1.GoodsType[i] = null;
                orderInfo1.CostForType[i] = 0;
                i++;
            }
        }

        public static OrderInfo orderInfo1 = new OrderInfo();
    }
}
