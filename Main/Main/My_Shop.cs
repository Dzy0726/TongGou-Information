using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{

    public class My_Shop
    {
        public struct sellerInfo
        {
            public string seller_NAME;
            public int store_ID;
            public string store_NAME;
        };

        public  List<sellerInfo> seller_store = new List<sellerInfo>();


        public void Seller_Store(string seller_id)     //用卖家id进行店铺查询
        {
            sellerInfo inform = new sellerInfo();

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select seller_name,store_id,store_name from seller natural join seller_store natural join store where seller_id like @seller_id   ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    cmd.Parameters.Add(new MySqlParameter("@seller_id", seller_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        inform.seller_NAME = reader.GetString("seller_name");
                        inform.store_ID = reader.GetInt32("store_id");
                        inform.store_NAME = reader.GetString("store_name");
                        seller_store.Add(inform);
                    }
                }

            }

        }

    }

}
