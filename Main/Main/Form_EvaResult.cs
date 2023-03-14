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
    public partial class Form_EvaResult : UIForm
    {
        public Form_EvaResult()
        {
            InitializeComponent();
        }

        public struct info_result
        {
            public int id;//店铺ID
            public string name;//店铺名称
            public double assessment;//店铺评价
        };
        public List<info_result> result = new List<info_result>();

        static public string date;//年月日
        static public string type;//店铺类型

        private void Form_EvaResult_Load(object sender, EventArgs e)
        {
            //this.Owner.Hide();//隐藏所有者窗体
            lbl_date.Text = lbl_date.Text + date;//年月日
            lbl_type.Text = lbl_type.Text + type;//店铺类型
            int num = result.Count;//获取查询结果有多少项
            for (int i = 0; i < num; i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();//序号
                uiDataGridView1.Rows[i].Cells[1].Value = result[i].id.ToString();//店铺ID
                uiDataGridView1.Rows[i].Cells[2].Value = result[i].name;//店铺名称
                uiDataGridView1.Rows[i].Cells[3].Value = result[i].assessment.ToString();//店铺评价
            }
        }



    }
}
