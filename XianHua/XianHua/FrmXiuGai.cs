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

namespace XianHua
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
        public string id;
        public string shuliang;
        public string danjia;
        public string beizhu;
        private void button1_Click(object sender, EventArgs e)
        {
           
            DBHepler db = new DBHepler();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = @"update FlowerSale set  SaleCount='" + textBox3.Text + "', SalePrice='" + textBox2.Text + "' ,Remark='" + textBox1.Text + "' where SaleId = '"+id+"'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("修改失败"); ;
            }
            finally
            {
                conn.Close();//关闭
            }
        }

        private void FrmXiuGai_Load(object sender, EventArgs e)
        {
            textBox4.Text = id;
            textBox3.Text = shuliang;
            textBox2.Text = danjia;
            textBox1.Text = beizhu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
