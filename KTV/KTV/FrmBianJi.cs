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
    public partial class FrmBianJi : Form
    {
        
        public FrmBianJi()
        {
            InitializeComponent();
        }
        public string geshou;
        public string sex;
        public string leixing;
        public string miaoshu;
        private void button1_Click(object sender, EventArgs e)
        {
         
            SongInfoAdd();
            FrmChaXun xun = new FrmChaXun();

        }

        string fileName = "";
        //string fullName = "";

        public void SongInfoAdd()
        {
            DBHelper db = new DBHelper();
            string name = textBox1.Text;//歌手姓名
            string type = "";//类别
            if (radioButton1.Checked)
            {
                type = "男";
            }
            else if (radioButton2.Checked)
            {
            }
            else if (radioButton3.Checked)
            {
                type = "组合";
            }
            int id = Convert.ToInt32(comboBox1.SelectedValue);//类型            
            string description = textBox2.Text;//描述
            SqlConnection con = new SqlConnection(db.str);
            string sql = "    update dbo.singer_info set singer_name='" + name + "',songtype_id='" + id + "',songtype_id='" + type + "','" + fileName + "'singer_description='" + description + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
           
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count==1)
                {
                    //File.Copy(fullName, Commod.DBsongurl + "\\" + fileName, true);
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("歌手修改失败");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("修改失败"); ;
            }
            finally
            {
                con.Close();//关闭
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "请选择文件";
            openFileDialog1.Filter = "所有文件(*.jpg)|*jpg"; //设置要选择的文件的类型
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;//返回文件的完整路径        
                pictureBox1.Image = Image.FromFile(file);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox3.Controls.Add(Button3);
        }
        public Control Button3 { get; set; }

        private void FrmBianJi_Load(object sender, EventArgs e)
        {
            
            Showw();
            ss();

            getInfoBySingerId(singerid);
        }

        public void getInfoBySingerId(int id)
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = "select * from   singer_info where singer_id=" + id + "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pictureBox1.Image = Image.FromFile(DBHelper.path + dr["singer_photo_url"].ToString());

            }

        }


        public int singerid;
        public void Showw()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = "  select * from   singer_type";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds, "s");
            DataRow rows = ds.Tables["s"].NewRow();
            rows["singertype_id"] = -1;
            rows["singertype_name"] = "请选择";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "singertype_name";
            comboBox1.ValueMember = "singertype_id";
        }
        public void ss()
        {
            //textBox1.Text = geshou;
            //if (sex.Equals("男"))
            //{
            //    radioButton1.Checked = true;
            //}
            //else if (sex.Equals("女"))
            //{
            //    radioButton2.Checked = true;
            //}
            //else 
            //{
            //    radioButton3.Checked = true;
            //}
            //comboBox1.Text = leixing;
            //textBox2.Text=miaoshu;
           
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string str = "select * from  singer_info as s ,singer_type as a where s.singertype_id=a.singertype_id and s.singer_id='" + singerid + "'";
            try
            {
                conn.Open();
             
                SqlCommand cmd = new SqlCommand(str, conn);

                SqlDataReader da = cmd.ExecuteReader();
               
                while (da.Read())
                {
                    textBox1.Text = da["singer_name"].ToString();
                    if ("男".Equals("singer_gender"))
                    {
                        radioButton1.Checked = true;
                    }
                    else if ("女".Equals("singer_gender"))
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton3.Checked = true;
                    }
                    comboBox1.Text = da["singertype_name"].ToString(); ;
                    textBox2.Text = da["singer_description"].ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
