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
    public partial class FrmChaXun : Form
    {
        public FrmChaXun()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            show();
            find();
            da();
        }

        #region 层级
        public void show()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            ////string parent = treeView1.SelectedNode.Parent.Text;
            //string gender = treeView1.SelectedNode.Text;
            //switch (parent)
            //{
            //    case "大陆":
            //        string ss = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='1'";
            //        break;
            //    default:
            //        break;
            //}




            if (treeView1.SelectedNode.Text == "大陆")
            {
                //StringBuilder sql = new StringBuilder();
                string ss = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='1'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];

             
            }
            if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 0)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='1' and singer_gender = '女'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 1)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='1' and singer_gender = '男'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
                }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag)==2)
            {
                string ss = "  select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id= '1' and singer_gender = '组合'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "w");
                dataGridView1.DataSource = ds.Tables[0];

            }
           
        }
        public void find()
        {
             DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            if (treeView1.SelectedNode.Text == "香港")
            {
                //StringBuilder sql = new StringBuilder();
                string ss = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='2'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];


            }
            if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 0)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='2' and singer_gender = '女'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 1)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='2' and singer_gender = '男'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 2)
            {
                string ss = "  select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id= '2' and singer_gender = '组合'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "w");
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        public void da()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            if (treeView1.SelectedNode.Text == "台湾")
            {
                //StringBuilder sql = new StringBuilder();
                string ss = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='3'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];


            }
            if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 0)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='3' and singer_gender = '女'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 1)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='3' and singer_gender = '男'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 2)
            {
                string ss = "  select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id= '3' and singer_gender = '组合'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "w");
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        public void a()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            if (treeView1.SelectedNode.Text == "欧美")
            {
                //StringBuilder sql = new StringBuilder();
                string ss = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='4'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];


            }
            if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 0)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='4' and singer_gender = '女'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 1)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='4' and singer_gender = '男'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 2)
            {
                string ss = "  select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id= '4' and singer_gender = '组合'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "w");
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        public void q()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            if (treeView1.SelectedNode.Text == "日韩")
            {
                //StringBuilder sql = new StringBuilder();
                string ss = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='5'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];


            }
            if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 0)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='5' and singer_gender = '女'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 1)
            {
                string sql = "select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id='5' and singer_gender = '男'";
                SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da1.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 2)
            {
                string ss = "  select * from singer_info as c,singer_type as s where c.singertype_id=s.singertype_id and s.singertype_id= '5' and singer_gender = '组合'";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "w");
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.Rows.Clear();

        }

        private void FrmChaXun_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            gong();
        }
        public void gong()
        {
            DBHelper db = new DBHelper();
            string sql = " select * from dbo.song_type ";
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
            rows["songtype_name"] = "请选择";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "songtype_name";
            comboBox1.ValueMember = "songtype_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findall();
            //dataGridView1.AutoGenerateColumns = false;
        }
       
        public void findall()
        {
            DBHelper db = new DBHelper();
            string fromCityNum = textBox1.Text;
            string toCityNum = comboBox1.Text ;
            string sql = @"select * from dbo.song_type as A,dbo.singer_info as F where A.songtype_id = F.singertype_id
          and singer_name = '" + fromCityNum + "' and songtype_name = '" + toCityNum + "' ";
            SqlConnection conn = new SqlConnection(db.str);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void 修改歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBianJi ji = new FrmBianJi();
            ji.singerid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
           // MessageBox.Show(ji.singerId.ToString());
            ji.Show();
            this.Hide();





            //ji.geshou = dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString();
            //ji.sex = dataGridView1.SelectedRows[0].Cells["Column3"].Value.ToString();
            //ji.leixing = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
            //ji.miaoshu = dataGridView1.SelectedRows[0].Cells["Column4"].Value.ToString();
            
        }
        public string id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           // MessageBox.Show(id);


        }
        #region   删除歌手信息
        private void 删除歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                if (this.dataGridView1.CurrentRow != null)
                {
                    string message = string.Format("确定要删除歌手为 {0} 的数据吗?", this.dataGridView1.CurrentRow.Cells[1].Value);

                    if (MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        StringBuilder sa = new StringBuilder();
                        //获取单元格的一行
                        int num = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                        // 删除语句
                        sa.AppendFormat("DELETE FROM  singer_info  WHERE singer_id={0}", num);

                        // 执行删除操作
                        SqlCommand command = new SqlCommand(sa.ToString(), conn);

                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("删除失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

