using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DBTest.GoodsInfoStatis;
using MySql.Data.MySqlClient;


namespace DBTest
{
    class CustomerInfoStatis
    {
        static double total_costs;
        static int customer_count;
        static double avg_costs;

        /*  顾客平均开销  可指定日期查询  
         *  举例2020年8月 2020，8，-1   
         *  历史全部信息   -1，-1，-1   */
        static public void CustomerAvgCost(int year,int month,int day)
        {
            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=dzy123.0";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(num*cost),count(customer_id),sum(num*cost)/count(customer_id) from assess natural join goods_order natural join `order` where date like @date";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    total_costs = reader.GetDouble(0);
                    customer_count = reader.GetInt32(1);
                    avg_costs = reader.GetDouble(2);
                 //   MessageBox.Show("总花费：" + total_costs.ToString());
                 //   MessageBox.Show("顾客总数：" + customer_count.ToString());
                //  MessageBox.Show("平均花费：" + avg_costs.ToString());

                }
            }

        }

        static public double[] customer_day_costs = new double[32];//下标对应日期，存放指定月每日顾客开销

        /*  查询顾客消费 月报表  
         *  参数 指定某年某月   */
        static public void CostForEachDay(int year,int month)
        {
            customer_day_costs[0] = -1.0;
            string date = Date(year, month, -1);
            string connString = "server=localhost;database=db_mall;uid=root;pwd=dzy123.0";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(num*cost),day(date) from assess natural join goods_order natural join `order` where date like @date group by day(date) order by day(date)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer_day_costs[reader.GetInt32(1)] = reader.GetDouble(0);
                }
            }
        }

        static public double[] customer_month_costs = new double[13];//下标对应月份，存放指定年每月顾客开销

        /*  查询顾客消费 年报表  
         *  参数 指定某年   */
        static public void CostForEachMonth(int year)
        {
            customer_month_costs[0] = -1.0;
            string date = Date(year, -1, -1);
            string connString = "server=localhost;database=db_mall;uid=root;pwd=dzy123.0";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(num*cost),month(date) from assess natural join goods_order natural join `order` where date like @date group by month(date) order by month(date)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer_month_costs[reader.GetInt32(1)] = reader.GetDouble(0);
                }
            }
        }
    }
}
