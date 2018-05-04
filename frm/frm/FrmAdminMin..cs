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
    public partial class FrmAdminMin : Form
    {
        public FrmAdminMin()
        {
            InitializeComponent();
        }

        private void FrmAdminMin_Load(object sender, EventArgs e)
        {
            FindAll();
        }

         ///<summary>
         ///方式一
         ///</summary>u
        public void Find()
        {
            DBHelper db = new DBHelper();
            string sql = "select*from Student";
            SqlConnection conn = new SqlConnection(db.str);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "s");
            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "greadid";
        }


        public void dong()
        {
            DBHelper db = new DBHelper();
            string sql = "select name,greadid from Student";
            MessageBox.Show(sql);

            SqlConnection conn = new SqlConnection(db.str);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();

            da.Fill(ds, "s");

            //增加“全部”到查询数据的前面
            DataRow rows = ds.Tables["s"].NewRow();
            rows["greadid"] = -1;
            rows["name"] = "全部";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "greadid";
            comboBox1.ValueMember = "name";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FindAll()
        {
            dataGridView1.AutoGenerateColumns = false;
            DBHelper db = new DBHelper();
            string sql = "select id,name,greadid,rr from Student where name like '%" + this.comboBox1.Text + "%'";
            SqlConnection conn = new SqlConnection(db.str);
            
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {                 
                                  //选中节点    文本
            string str = treeView1.SelectedNode.Text;
            int num = treeView1.SelectedNode.Level;//Level查级别
            MessageBox.Show(str + ":" + num);
            if(num==0)
            {
                DBHelper db = new DBHelper();
                string sql = "";
                SqlConnection conn = new SqlConnection(db.str);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
            }
        }


        SqlDataAdapter da;
        DataSet ds;
        private void FindAllStudent()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = "Select*from Student";
            da = new SqlDataAdapter(sql,conn);
            ds = new DataSet();
            da.Fill(ds,"qw");
            dataGridView1.DataSource=ds.Tables["qw"];
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要修改？","提示",MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                da.Update(ds, "qw");
            }
        }
    }
}
