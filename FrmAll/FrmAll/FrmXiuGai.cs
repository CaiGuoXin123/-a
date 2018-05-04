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
    public partial class FrmXiuGai : Form
    {
        public FrmXiuGai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fin();
        }
        public void fin()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                string str = "update [User] set PassWord='" + textBox2.Text + "' where PassWord='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                int num = cmd.ExecuteNonQuery();
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    MessageBox.Show("修改成功");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败" + ex);

            }
            finally
            {
                conn.Close();
            }

        }

        private void FrmXiuGai_Load(object sender, EventArgs e)
        {

        }
    }
}
