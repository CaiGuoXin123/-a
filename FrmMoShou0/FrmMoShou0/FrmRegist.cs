using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMoShou0
{
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            regist();
         
        }
        public static LoginInfo[] num = new LoginInfo[20];
        private void regist()
        {
            LoginInfo.Name1 = textBox1.Text;
            LoginInfo.Id1= textBox2.Text;
            LoginInfo.Email1=textBox3.Text;
            LoginInfo.Password1=textBox4.Text;
            LoginInfo.Ema11 = textBox5.Text;
            LoginInfo.Pwd11 = textBox6.Text;
            if (LoginInfo.Name1.Equals(""))
            {
                MessageBox.Show("姓名不能为空","提示");
                textBox1.Focus();
            }
            else if (LoginInfo.Id1.Equals(""))
            {
                MessageBox.Show("身份证不能为空", "提示");
                textBox2.Focus();
            }
            else if (LoginInfo.Email1.Equals(""))
            {
                MessageBox.Show("邮箱不能为空", "提示");
                textBox3.Focus();
            }
            else if (LoginInfo.Password1.Equals(""))
            {
                MessageBox.Show("密码不能为空", "提示");
                textBox4.Focus();
            }
            else if (LoginInfo.Ema11.Equals(""))
            {
                MessageBox.Show("确认邮箱不能为空", "提示");
                textBox5.Focus();
            }
            else if (LoginInfo.Pwd11.Equals(""))
            {
                MessageBox.Show("确认密码不能为空", "提示");
                textBox6.Focus();
            }
            else
            {
                MessageBox.Show("注册成功","提示");
            }
        }
    }
}
