using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBTest
{
    class platformInfoStatis
    {
        static public int customer_num;
        static public int store_num;
        static public int platform_quantity;
        static public double platform_proceeds;

        static public string Date(int year, int month, int day)//日期处理
        {
            string Year, Month, Day;
            string dateTime = "%";
            if (year == -1)
            {
                return dateTime;
            }
            else
            {
                Year = year.ToString();
            }

            if (month == -1)
            {
                dateTime = Year + dateTime;
                return dateTime;
            }
            else if (month > 0 && month < 10)
            {
                Month = "0" + month.ToString();
            }
            else
            {
                Month = month.ToString();
            }

            if (day == -1)
            {
                dateTime = Year + "-" + Month + dateTime;
                return dateTime;
            }
            else if (day > 0 && day < 10)
            {
                Day = "0" + day.ToString();
            }
            else
            {
                Day = day.ToString();
            }
            dateTime = Year + "-" + Month + "-" + Day + dateTime;
            return dateTime;
        }

        //  查询平台销售额；按年月日查询，可为空；
        static public void Platform_quantity(int year, int month, int day)
        {
            string date = Date(year, month, day);

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                sql = "select sum(num) from `order` natural join goods_order where date like @date;";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                reader.Read();

                if (!reader.IsDBNull(0))
                {
                    platform_quantity = reader.GetInt32(0);
                }
                
            }
            conn.Close();
        }



        //  查询平台销售额；按年月日查询，可为空；
        static public void Platform_proceeds(int year, int month, int day)
        {
            string date = Date(year, month, day);

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                sql = "select sum(cost*num) from `order` natural join goods_order where date like @date;";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                reader.Read();

                if (!reader.IsDBNull(0))
                {
                    platform_proceeds = reader.GetDouble(0);
                }
            }
            conn.Close();
        }

        //查询平台顾客用户数
        static public void Customer_num()
        {
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                sql = "select count(*) from customer;";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    customer_num = reader.GetInt32(0);
                }
            }
            conn.Close();
        }



        //查询平台店铺数
        static public void Store_num()
        {
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                sql = "select count(*) from store;";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    store_num = reader.GetInt32(0);
                }
            }
            conn.Close();
        }
    }
}