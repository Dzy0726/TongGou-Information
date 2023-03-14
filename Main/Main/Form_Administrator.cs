using Administrator;
using Sunny.UI;
using Sunny.UI.Demo;
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
    public partial class Form_Administrator : UIHeaderAsideMainFrame
    {
        public Form_Administrator()
        {
            InitializeComponent();
            //设置侧边栏的按键
            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 61451);
            TreeNode parent = Aside.CreateNode("我的信息", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent, 61447, 24, AddPage(new MyInformation(), ++pageIndex));

            pageIndex = 2000;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 61468);
            parent = Aside.CreateNode("平台信息", 61468, 24, pageIndex);
            Aside.CreateChildNode(parent, 61468, 24, AddPage(new Administrator_platform(), ++pageIndex));//平台统计信息

            pageIndex = 3000;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 62146);
            parent = Aside.CreateNode("顾客信息", 62146, 24, pageIndex);
            Aside.CreateChildNode(parent, 62146, 24, AddPage(new Administrator_Customer(), ++pageIndex));//顾客统计信息

            pageIndex = 4000;
            Header.SetNodePageIndex(Header.Nodes[3], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[3], 61474);
            parent = Aside.CreateNode("店铺信息", 61474, 24, pageIndex);
            Aside.CreateChildNode(parent, 61977, 24, AddPage(new Administrator_ShopSale(), ++pageIndex));//  店铺销售
            Aside.CreateChildNode(parent, 62104, 24, AddPage(new Administrator_ShopEva(), ++pageIndex));  //店铺评价

            pageIndex = 5000;
            Header.SetNodePageIndex(Header.Nodes[4], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[4], 61975);
            parent = Aside.CreateNode("商品信息", 61975, 24, pageIndex);
            Aside.CreateChildNode(parent, 61976, 24, AddPage(new Administrator_Goods(), ++pageIndex));
            Aside.CreateChildNode(parent, 61912, 24, AddPage(new Administrator_Transport(), ++pageIndex));

            Header.SetNodeSymbol(Header.Nodes[5], 61502);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[5], style.DisplayText(), style.Value());
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
                case 3:
                case 4:
                    Aside.SelectPage(pageIndex);
                    break;
                case 5:
                    UIStyle style = (UIStyle)pageIndex;
                    StyleManager.Style = style;
                    break;

                    
                
            }
        }

        private void Form_Administrator_Load(object sender, EventArgs e)
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

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)//实现注销
        {
            
            if(!this.IsDisposed)
            {
                Form_login.maincurse.Show();
                this.Dispose();//销毁当前窗体

            }
        }
    }
}
