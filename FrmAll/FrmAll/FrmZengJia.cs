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
    public partial class FrmZengJia : Form
    {
        public FrmZengJia()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmZengJia_Load(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            string sql = " select * from CommoditySort ";
            SqlConnection conn = new SqlConnection(db.str);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();

            da.Fill(ds, "s");

            //增加“全部”到查询数据的前面
            DataRow rows = ds.Tables["s"].NewRow();
            rows["SortID"] = -1;
            rows["SortName"] = "请选择";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "SortName";
            comboBox1.ValueMember = "SortID";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertShopInfo();
            //DBHelper db = new DBHelper();
            //SqlConnection conn = new SqlConnection(db.str);
            //if ((comboBox1.Text).Equals(string.Empty))
            //{
            //    MessageBox.Show("请选择正确的类别！", "提示", MessageBoxButtons.OK);

            //}
            //if (numericUpDown2.Value>0)
            //{
            //    StringBuilder sql=new StringBuilder();

            //    sql.AppendLine(" insert into  [Commodity] ");
            //    sql.AppendFormat("values ('{0}',{1},{3},{4})",
            //    this.textBox1.Text, Convert.ToInt32(this.comboBox1.SelectedValue),
            //    this.numericUpDown1.Value, this.Checked ? 1 : 0,
            //    this.numericUpDown1.Value);
            //    conn.Open();
            //    SqlCommand cmd=new SqlCommand(sql.ToString(),conn);
            //     int b = cmd.ExecuteNonQuery();
            //     if (b == 1)
            //     {
            //         MessageBox.Show("添加成功");
            //         conn.Close();
            //     }
            //     else
            //     {
            //         MessageBox.Show("添加失败");
            //     }
            //}
        }
        public void InsertShopInfo()
        {
           
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" insert into Commodity");
            sql.AppendFormat(" values('{0}',{1},{2},{3},{4})", this.textBox1.Text,
                Convert.ToInt32(this.comboBox1.SelectedValue), this.numericUpDown1.Value, this.checkBox1.Checked ? 1 : 0,
                this.numericUpDown2.Value);
            try
            {
                SqlCommand comm = new SqlCommand(sql.ToString(), conn);
                conn.Open();
                int result = comm.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("添加成功!");
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 是否为特价的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = numericUpDown1.Value;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消登录么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //public void find()
        //{
           
        //    DBHelper db = new DBHelper();
        //    SqlConnection conn = new SqlConnection(db.str);
        //    try
        //    {
        //        //拼接sql语句
        //        StringBuilder sql = new StringBuilder();

        //        sql.AppendLine("insert into [Commodity]");

        //        sql.AppendFormat("values('{0}',{1},{2},{3},{4})",
        //        this.textBox1, Convert.ToInt32(this.checkBox1.), this.numericUpDown1.Value, this.radioButton2.Checked ? 1 : 0, this.numericUpDown1.Value);

        //        SqlCommand cmd = new SqlCommand(sql, conn);
                
        //        //接受命令
        //        int result = cmd.ExecuteNonQuery();
        //        //判断
        //        if (result > 0)
        //        {
        //            MessageBox.Show("添加成功！");
        //        }
        //        else
        //        {
        //            MessageBox.Show("添加失败！");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //    finally
        //    {
        //        sb.CloseConnection();
        //    }

        //}

    }
}
