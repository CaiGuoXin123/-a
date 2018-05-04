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

namespace frm
{
    public partial class Frming : Form
    {
        public Frming()
        {
            InitializeComponent();
        }

        private void Frming_Load(object sender, EventArgs e)
        {
            FindAllStudent();
        }
        public void FindAll()
        {
            dataGridView1.AutoGenerateColumns = false;
            DBHelper db = new DBHelper();
            string sql = "select * from Student";
            SqlConnection conn = new SqlConnection(db.str);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            //ds.Tables.Clear();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
        }

        SqlDataAdapter da;
        DataSet ds;
        private void FindAllStudent()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = "Select * from Student";
            da = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要修改？", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "ss");
            }

        }
    }

}
