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

namespace ShouJi
{
    public partial class ZengJia : Form
    {
        public ZengJia()
        {
            InitializeComponent();
        }

        private void ZengJia_Load(object sender, EventArgs e)
        {
            DBHepler db = new DBHepler();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = "select *from MobileBrand";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds,"ss");
            DataRow row = ds.Tables["ss"].NewRow();
            row["BrandId"] = -1;
            row["Brand"] = "请选着";
            ds.Tables["ss"].Rows.InsertAt(row,0);
            comboBox1.DataSource=ds.Tables["ss"];
            comboBox1.DisplayMember = "Brand";
            comboBox1.ValueMember = "BrandId";
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            DBHepler db = new DBHepler();
            int id = Convert.ToInt32(comboBox1.SelectedValue);//类型  
            SqlConnection conn=new SqlConnection(db.str);
            string sql = "insert into MoblieInfo values('"+id+"','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                if (textBox1.Text == null && textBox2.Text == null || textBox4.Text == null && textBox5.Text == null && textBox3.Text == null)
                {
                    MessageBox.Show("请完成所有信息");
                }
                else if (count > 0)
                {
                    MessageBox.Show("添加歌手成功");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("添加歌手失败");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
