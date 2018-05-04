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

namespace KTVQian
{
    public partial class FrmGeXing1 : Form
    {

        public string name = "hehe";
        public FrmGeXing1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认返回么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmGeXing1_Load(object sender, EventArgs e)
        {
            listView3.Dock = DockStyle.Fill;
            listView1.Visible = false;
            listView2.Visible = false;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmGeXing1_Click(object sender, EventArgs e)
        {


        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {

                listView1.Visible = true;
                listView3.Visible = false;
                listView2.Visible = false;

                listView2.Location = listView1.Location;
                listView2.Dock = DockStyle.Fill;
                listView3.LargeImageList = imageList3;

                gender = listView3.SelectedItems[0].Text;
            }
        }
        string city;

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                listView1.Visible = false;
                listView2.Visible = true;
                city = listView1.SelectedItems[0].Text;
                DBHelper db = new DBHelper();
                SqlConnection conn = new SqlConnection(db.str);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" select * from singer_info,singer_type");
                sql.AppendLine(" where singer_info.singertype_id = singer_type.singertype_id");
                sql.AppendFormat(" and singer_gender = '{0}' and singertype_name = '{1}'", gender, city);

                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql.ToString(), conn);
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        int i = 0;
                        string path = "F:\\蔡国鑫\\实训相关学生版\\image";
                        while (reader.Read())
                        {
                            StringBuilder url = new StringBuilder();
                            url.AppendLine(path + "\\" + reader["singer_photo_url"].ToString());
                            imageList2.Images.Add(Image.FromFile(url.ToString()));
                            ListViewItem item = new ListViewItem();
                            item.ImageIndex = i;
                            item.Text = reader["singer_name"].ToString();
                            listView2.Items.Add(item);
                            i++;
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("没有有效数据");
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("异常"+ex);
                }
                finally
                {
                    conn.Close();
                }
            }


        }

        string gender;
        private void listView3_Click(object sender, EventArgs e)
        {


        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmLieBiao bia = new FrmLieBiao(this);
            bia.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGeXing1 frm = new FrmGeXing1();
            if (listView3.Visible == true)
            {
                this.Close();
            }
            else if (listView1.Visible == true)
            {
                frm.Show();
                this.Close();
            }
            else if (listView2 .Visible == true)
            {
                frm.Show();
                this.Close();
            }

        }
    }
}
