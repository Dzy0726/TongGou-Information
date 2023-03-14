
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AD_CostomerInfo
{
    class AD_DATE
    {
        public static int year;
        public static int month;
        public static int day;
        public static int type;
    }
    class CustomerInfoStatis
    {
        static public double total_costs;
        static public int customer_count;
        static public double avg_costs;

        

        /*  顾客平均开销  可指定日期查询  
         *  举例2020年8月 2020，8，-1   
         *  历史全部信息   -1，-1，-1   */

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
        static public void CustomerAvgCost(int year, int month, int day)
        {
            string date = Date(year, month, day);

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(num*cost),count(distinct customer_id),sum(num*cost)/count(customer_id) from consume natural join goods_order natural join `order` where date like @date";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    if (reader.IsDBNull(0))
                    {
                        continue;
                    }
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
        static public void CostForEachDay(int year, int month)
        {
            customer_day_costs[0] = -1.0;
            string date = Date(year, month, -1);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(num*cost),day(date) from consume natural join goods_order natural join `order` where date like @date group by day(date) order by day(date)";
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
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(num*cost),month(date) from consume natural join goods_order natural join `order` where date like @date group by month(date) order by month(date)";
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
