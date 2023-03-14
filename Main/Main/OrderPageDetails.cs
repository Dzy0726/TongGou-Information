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
    public partial class OrderPageDetails : UIForm
    {
        public OrderPageDetails()
        {
            InitializeComponent();
            uiDataGridView1.ReadOnly = true;

        }

        public static string date;
        public static int order_id;
        public static int customer_id = Form_login.id_global;

        private void OrderPageDetails_Load(object sender, EventArgs e)
        {
            string[] date_split1 = date.Split(' ');
            string[] date_split = date_split1[0].Split('/');

            int year = int.Parse(date_split[0]);
            int month = int.Parse(date_split[1]);
            int day = int.Parse(date_split[2]);
            OrderInfo orderInfo1 = new OrderInfo();
            orderInfo1.OrderDetail(customer_id, order_id, year, month, day);
            int i = 0;
            while (orderInfo1.GoodsName[i] != null)
            {
                uiDataGridView1.Rows[i].Cells[0].Value = orderInfo1.GoodsName[i].ToString();
                uiDataGridView1.Rows[i].Cells[1].Value = orderInfo1.StoreName[i].ToString();
                uiDataGridView1.Rows[i].Cells[2].Value = orderInfo1.GoodsPrice[i].ToString();
                uiDataGridView1.Rows[i].Cells[3].Value = orderInfo1.GoodsNum[i].ToString();

                i++;

            }
        }
    }
}
