using Administrator;
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
    public partial class Form_Customer : UIHeaderAsideMainFrame
    {
        public Form_Customer()
        {
            InitializeComponent();
            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 61451);
            TreeNode parent = Aside.CreateNode("我的信息", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent, 61447, 24, AddPage(new MyInformation(), ++pageIndex));

            pageIndex = 2000;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 61674);
            parent = Aside.CreateNode("我的订单", 61674, 24, pageIndex);
            Aside.CreateChildNode(parent, 61674, 24, AddPage(new Customer_Order(), ++pageIndex));

            pageIndex = 3000;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 61474);
            parent = Aside.CreateNode("消费记录", 61474, 24, pageIndex);
            Aside.CreateChildNode(parent, 61474, 24, AddPage(new Customer_BuyHistory(), ++pageIndex));

            Header.SetNodeSymbol(Header.Nodes[3], 61502);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[3], style.DisplayText(), style.Value());
            }

            Aside.SelectFirst();
        }

        private void FMain_WindowStateChange(object sender, FormWindowState state)
        {
            state.ConsoleWriteLine("WindowState");
        }

        private void Header_MenuItemClick(string text, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                case 1:
                case 2:
                    Aside.SelectPage(pageIndex);
                    break;
                case 3:
                    UIStyle style = (UIStyle)pageIndex;
                    StyleManager.Style = style;
                    break;

            }
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            AdmInfoStatis query = new AdmInfoStatis();
            int user_id = Form_login.id_global;//用户ID
            string user_type = Form_login.type_global;//用户类型
            query.AdmInfo(user_id);
            label_wel.Text = "欢迎登录," + query.result.name;
        }

        private void label_wel_MouseEnter(object sender, EventArgs e)
        {
            uiToolTip1.SetToolTip(label_wel, label_wel.Text);
        }

        private void uiAvatar_Click(object sender, EventArgs e)
        {
            uiContextMenuStrip1.Show(uiAvatar, 0, uiAvatar.Height);
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.IsDisposed)
            {
                Form_login.maincurse.Show();
                this.Dispose();//销毁当前窗体

            }
        }
    }
}
