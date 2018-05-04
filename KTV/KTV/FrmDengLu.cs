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

namespace KTV
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
        public bool find()
        {
            bool trus = false;
            string name = this.textBox1.Text;
            string pwd = this.textBox2.Text;
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                string sql = "  select * from admin_info where admin_name='" + name + "'and admin_pwd='" + pwd + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                int reader = Convert.ToInt32(cmd.ExecuteScalar());
                if (reader >0)
                {
                    trus = true;
                    FrmGuanLi li = new FrmGuanLi();
                    li.Show();
                }
                else
                {
                    trus = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常" + ex);

            }
            finally
            {
                conn.Close();
            }
            return trus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消登录么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmGuanLi li = new FrmGuanLi();
            //li.Show();
            if ( find() == true)
            {
                //li.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
    }
}
