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
    public partial class FrmGai : Form
    {
        public FrmGai()
        {
            InitializeComponent();
        }
        public int commodityID;//编码号
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string name;
        public string leixing;
        public string jiage1;
        public Boolean tejia;
        public string jiage2;

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                int flag = 0;
                if (checkBox1.Checked)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
                string sql = @" update Commodity set CommodityName='" + textBox1.Text + "', SortID='" + comboBox1.SelectedValue + "', CommodityPrice='" + numericUpDown1.Value + "' ,IsDiscount='" + flag + "',ReducedPrice='" + numericUpDown2.Value + "' where CommodityID=" + commodityID ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = cmd.ExecuteNonQuery();
                if (num >0)   
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

        private void FrmGai_Load(object sender, EventArgs e)
        {
            find();
            textBox1.Text = name;
            comboBox1.Text = leixing;
            numericUpDown1.Value = Convert.ToDecimal(jiage1);
            checkBox1.Checked = tejia;
            numericUpDown2.Value = Convert.ToDecimal(jiage2);
        }
        public void find()
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
        /// <summary>
        /// 是否特价
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认取消么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
