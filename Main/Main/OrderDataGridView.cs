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
    public partial class OrderDataGridView : UIForm
    {
        public OrderDataGridView()
        {
            InitializeComponent();
            uiDataGridView1.ReadOnly = true;

        }

        public OrderInfo orderInfo1 = new OrderInfo();

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(uiDataGridView1.CurrentCell.FormattedValue.ToString()=="简介")
            {
                OrderPage.date = uiDataGridView1.CurrentRow.Cells[1].Value.ToString();
                OrderPage.order_id = int.Parse(uiDataGridView1.CurrentRow.Cells[0].Value.ToString());
                OrderPage form1 = new OrderPage();
                form1.Show();
            }
            if (uiDataGridView1.CurrentCell.FormattedValue.ToString() == "详情")
            {
                OrderPageDetails.date = uiDataGridView1.CurrentRow.Cells[1].Value.ToString();
                OrderPageDetails.order_id = int.Parse(uiDataGridView1.CurrentRow.Cells[0].Value.ToString());
                OrderPageDetails form1 = new OrderPageDetails();
                form1.Show();
            }
        }

        private void OrderDataGridView_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (orderInfo1.OrderTime[i] != null)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = orderInfo1.OrderID[i].ToString();
                uiDataGridView1.Rows[i].Cells[1].Value = orderInfo1.OrderTime[i].ToString();
                uiDataGridView1.Rows[i].Cells[2].Value = "简介";
                uiDataGridView1.Rows[i].Cells[3].Value = "详情";
                i++;
            }
        }
    }
}
