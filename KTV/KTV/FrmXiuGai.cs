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
    public partial class FrmXiuGai : Form
    {
        public FrmXiuGai()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmXiuGai_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                string sql = "  update admin_info set admin_pwd='" + textBox2.Text + "' where admin_name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = cmd.ExecuteNonQuery();
                if (textBox2.Text.Equals(textBox3.Text))
                {

                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
