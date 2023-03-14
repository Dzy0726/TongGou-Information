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
    public partial class Form_TransMoneyResult : UIForm
    {
        public Form_TransMoneyResult()
        {
            InitializeComponent();
        }

        public string year, month, day;
        public TransInfoStatis TransInfo = new TransInfoStatis();

        private void Form_TransMoneyResult_Load(object sender, EventArgs e)
        {
            if (day != "-1")
            {
                lbl_date.Text = lbl_date.Text.ToString() + year + "年" + month + "月" + day + "日";
            }
            else if(month!="-1")
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
            for (int i = 0; i < TransInfo.transInfoList.Count(); i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = TransInfo.transInfoList[i].id.ToString();
                uiDataGridView1.Rows[i].Cells[1].Value = TransInfo.transInfoList[i].departure;
                uiDataGridView1.Rows[i].Cells[2].Value = TransInfo.transInfoList[i].destination;
                uiDataGridView1.Rows[i].Cells[3].Value = TransInfo.transInfoList[i].fare.ToString();

            }
        }


    }
}
