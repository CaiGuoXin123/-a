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
    public partial class FrmHang : Form
    {
        public FrmHang()
        {
            InitializeComponent();
        }

        private void FrmHang_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            ine();
            Find();

        }
        public void Find()
        {
            DBHelper db = new DBHelper();
            string sql = "select Id,CityName from CityInfo  ";
            MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(db.str);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();

            da.Fill(ds, "s");

            //增加“全部”到查询数据的前面
            DataRow rows = ds.Tables["s"].NewRow();
            // rows["Id"] = -1;
            rows["CityName"] = "请选择";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "CityName";
            comboBox1.ValueMember = "Id";

        }
        public void ine()
        {
            DBHelper db = new DBHelper();
            string sql = "select Id,CityName from CityInfo  ";
            MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(db.str);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();

            da.Fill(ds, "s");

            //增加“全部”到查询数据的前面
            DataRow rows = ds.Tables["s"].NewRow();
            //rows["Id"]=-1;
            rows["CityName"] = "请选择";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox2.DataSource = ds.Tables["s"];
            comboBox2.DisplayMember = "CityName";
            comboBox2.ValueMember = "Id";
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findall();
        }
        public void findall()
        {
            DBHelper db = new DBHelper();
            int fromCityNum = Convert.ToInt32(comboBox1.SelectedValue);
            int toCityNum = Convert.ToInt32(comboBox2.SelectedValue);
            string sql = @"select * from AirwaysInfo as A,FlightInfo as F where A.Id = F.AirwaysId 
                           and LeaveCity = '" + fromCityNum + "' and Destination = '" + toCityNum + "'";
            SqlConnection conn = new SqlConnection(db.str);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //string xue = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string yes = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string qw = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string ew = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //string rw = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string aw = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox1.Text = no;
            textBox2.Text = comboBox2.Text;
            textBox3.Text = yes;
            textBox4.Text = qw;
            textBox5.Text = ew;
            textBox6.Text = comboBox1.Text;
            textBox7.Text = aw;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ding();
            //DBHelper db = new DBHelper();
            //string date = textBox7.Text.ToString();
            //Random rd = new Random();
            //int num1 = rd.Next(10000, 10000000);//随机数
            //SqlConnection conn = new SqlConnection(db.str);
            //conn.Open();
            //string sql = "insert into OrderInfo values('"+num1+"','"+textBox1.Text+"','"+date+"','"+numericUpDown1+"') ";
            //try
            //{
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    int num = cmd.ExecuteNonQuery();
            //    if (num > 0)
            //    {
            //        MessageBox.Show("增加'" + numericUpDown1.Text + "'张成功！");

            //    }
            //    else
            //    {
            //        MessageBox.Show("增加失败！！！");

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(sql);
            //    MessageBox.Show("异常！" + ex, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
        public void ding()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            if ((textBox1.Text).Equals(string.Empty))
            {
                MessageBox.Show("请选择正确的航班！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                if (Convert.ToDateTime(dateTimePicker1.Text) < Convert.ToDateTime(DateTime.Now.ToString()))
                {
                    MessageBox.Show("请输入正确日期", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    if (numericUpDown1.Value > 0)
                    {
                        Random r = new Random();
                        int a = r.Next(10000, 1000000);
                        string sql = @"insert into OrderInfo(OrderId,FlightNo,LeaveDate,Number) Values
                ('" + a + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToString() + "','" + numericUpDown1.Value.ToString() + "')";

                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        int b = cmd.ExecuteNonQuery();
                        if (b == 1)
                        {
                            MessageBox.Show("成功，您的机票编号为:" + a, "提示", MessageBoxButtons.OK);
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("乘坐人数为0！", "警告", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

