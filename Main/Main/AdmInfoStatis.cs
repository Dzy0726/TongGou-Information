using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Administrator
{
    class AdmInfoStatis
    {
        public struct admInfo
        {
            public int id;//管理员id
            public string name;//管理员姓名
        };

        public admInfo result = new admInfo();

        //查询平均运费
        //如果不具备某一参数 则令其为-1 如：2020年8月 则参数2020，8，-1
        public void AdmInfo(int user_id)
        {
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                sql = "select* from user where ID = @user_id;";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@user_id", user_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())
                {
                    //temp.id = reader.GetInt32(0);
                    //temp.name = reader.GetString(1);
                    result.id = reader.GetInt32(0);
                    result.name = reader.GetString(1);
                }
            }
            conn.Close();
        }
    }

    
}
