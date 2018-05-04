using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实例9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            //调用登录方法，到数据库中去查找用户名和密码是否存在，admin'表
            chikinto();
           
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        private void LoginMethod()
        {
            Class1 cl = new Class1();
            SqlConnection conn = new SqlConnection(Class1.str);
            string name = textBox1.Text;//2.准备sql语句接受文本框件上输入的文本值
            string pwd = textBox2.Text;
            if ((name.Equals(string.Empty)) || pwd == "")//非空验证书20页：str=null
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {//用户和密码都不为空拼接sql语句 执行操作
                string sql = "select COUNT(*)from admin where name='" + name + "'and pwd=" + pwd + "";
                try
                {
                    conn.Open();//3.打开链接
                    SqlCommand cmd = new SqlCommand(sql, conn);//4.创建命令对象
                    int count = (int)cmd.ExecuteScalar();//5.执行方法
                    if (count > 0)//6.处理返回值
                    {
                        MessageBox.Show("登录成功");
                        Form2 frm = new Form2();
                        frm.name = textBox1.Text;
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("异常信息");
                }
                finally
                {
                    conn.Close();//关闭连接
                }
            }
        }



        private bool CheckInput()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show("确定要退出么");
            DialogResult re = MessageBox.Show("确定要退出么", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                this.Close();
            }
        }

         /// <summary>
         /// 验证用户名 密码 登录类型等是否为空 也叫非空验证
         /// </summary>
                       
        public const string caption = "温馨";
        //非空验证
        public bool chikinto()
        {

            //用户名 .Trim()字符串    去掉两端空格方法，.Empty 字符串内容为空 null 没有引用对象
            if (this.textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("必须输入用户名", caption);
                textBox1.Focus();//设置焦点
                return false;
            }
                //密码为空
            else if (this.textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("必须输入密码", caption);
                textBox2.Focus();//Focus() 把输入的光标定位到用户名的文本框上
                return false;
            }
            else if (comboBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选者登录类型", "提示");
                comboBox1.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
     
    }
}
