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

namespace FrmAll
{
    public partial class FrmDenglu : Form
    {
        public FrmDenglu()
        {
            InitializeComponent();
        }

        private void FrmDenglu_Load(object sender, EventArgs e)
        {
            Findeed();
        }

        public bool Findeed()
        {
            bool trus = false;
            string name = this.textBox1.Text;
            string pwd = this.textBox2.Text;
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {


                conn.Open();
                string sql = "select count(*) from [User] where UserName='" + name + "'and PassWord='" + pwd + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                int reader = Convert.ToInt32(cmd.ExecuteScalar());
                if (reader == 1)
                {
                    trus = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGuanLi frm = new FrmGuanLi();
            if (Findeed() == true)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消登录么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
