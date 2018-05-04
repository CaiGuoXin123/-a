using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day07_0100
{
    public partial class Form1 : Gdu.WinFormUI.GMForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int con = this.Controls.Count;
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    TextBox b  = item as TextBox;
                    b.Text = "";
                }
            }
        }

        private void userControl11_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_KeyPress(object sender, KeyPressEventArgs e)
        {
           
       
            //只能输入退格键、回车键、小数点和数字  
            if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("请输入数字和小数点", "友情提示");
                userControl11.Focus();
                return;
            }
            //<span style="color:#ff0000;">小数点不能在开头</span>  
            if (e.KeyChar == (char)46 && userControl11.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("请先输入数字", "友情提示");
                return;
            }

            int a = 0; //计算小数点的个数的变量  
            a = userControl11.Text.ToString().Trim().Split('.').Length;
            if (e.KeyChar == (char)46 && a > 1)
            {
                e.Handled = true;
                MessageBox.Show("注意只能输入一个小数点", "友情提示");
                return;
            }  

            //if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            //    e.Handled = true;
            ////小数点的处理。
            //if ((int)e.KeyChar == 46)                           //小数点
            //{
            //    if (textBox1.Text.Length <= 0)
            //        e.Handled = true;   //小数点不能在第一位
            //}

        }

        private void dfd(object sender, EventArgs e)
        {

        }
    }
}
