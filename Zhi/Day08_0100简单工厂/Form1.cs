using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0100简单工厂
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox2.Text);
            int num2 = Convert.ToInt32(textBox1.Text);
            string oper = comboBox1.Text;
            FU cal = CaculatorFactory.get(oper);
            cal.NumA = num1;
            cal.NumB = num2;
            try
            {
                int res = cal.Calc();
                textBox3.Text =res.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                textBox2.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入退格键、回车键、小数点和数字  
            if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("请输入数字和小数点", "友情提示");
                textBox2.Focus();
                return;
            }
            //<span style="color:#ff0000;">小数点不能在开头</span>  
            if (e.KeyChar == (char)46 && textBox2.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("请先输入数字", "友情提示");
                return;
            }

            int a = 0; //计算小数点的个数的变量  
            a = textBox2.Text.ToString().Trim().Split('.').Length;
            if (e.KeyChar == (char)46 && a > 1)
            {
                e.Handled = true;
                MessageBox.Show("注意只能输入一个小数点", "友情提示");
                return;
            }  
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入退格键、回车键、小数点和数字  
            if (e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)46 && !(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("请输入数字和小数点", "友情提示");
                textBox1.Focus();
                return;
            }
            //<span style="color:#ff0000;">小数点不能在开头</span>  
            if (e.KeyChar == (char)46 && textBox1.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("请先输入数字", "友情提示");
                return;
            }

            int a = 0; //计算小数点的个数的变量  
            a = textBox1.Text.ToString().Trim().Split('.').Length;
            if (e.KeyChar == (char)46 && a > 1)
            {
                e.Handled = true;
                MessageBox.Show("注意只能输入一个小数点", "友情提示");
                return;
            }  
        }
    }
}
