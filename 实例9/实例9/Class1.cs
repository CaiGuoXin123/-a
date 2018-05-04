using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实例9
{
    class Class1
    {
        public static string str = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Password=695139150";
        //数据库连接Connection对象
        private SqlConnection conn;
        /// <summary>
        /// Connection
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(str);

                }
                return conn;
            }
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)//如果链接状态是 关闭
            {
                Connection.Open();//打开数据库连接
            }
            else if (Connection.State == ConnectionState.Broken) //如果链接转太 是断开
            {
                //先关闭再打开，防止之前打开忘了关闭的异常处理
                Connection.Close();
                Connection.Open();
            }
        }
        public void CloseConnection()
        {
            //如果链接状态是打开 或 中断
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                //两种情况都将关闭数据库
                Connection.Close();
            }
        }
    }
}