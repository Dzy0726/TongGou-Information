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
    public partial class OrderPage : UIForm
    {
        public OrderPage()
        {
            InitializeComponent();            
        }

        public static string date;
        public static int order_id;
        public static int customer_id = Form_login.id_global;

        private void OrderPage_Load(object sender, EventArgs e)
        {

            OrderInfo orderInfo1 = new OrderInfo();

            string[] date_split1 = date.Split(' ');
            string[] date_split = date_split1[0].Split('/');

            int year = int.Parse(date_split[0]);
            int month = int.Parse(date_split[1]);
            int day = int.Parse(date_split[2]);

            orderInfo1.OrderIntro(customer_id, order_id, year, month, day);
            label_order.Text = "订单号:" + orderInfo1.OrderID[0].ToString();
            uiLabel1.Text = "下单时间:" + orderInfo1.OrderTime[0].ToString();
            label_departure.Text = orderInfo1.Departure[0].ToString();
            label_destination.Text = orderInfo1.Destination[0].ToString();
            label_money.Text = "订单金额:"+orderInfo1.OrderCost[0].ToString();
        }
    }
}
