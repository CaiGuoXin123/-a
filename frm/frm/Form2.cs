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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
        }
        public void chaxue()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();//打开数据库
                string str = "select id,name,greadid,rr from Student where name like '%" + this.comboBox1.Text + "%' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            int xue = Convert.ToInt32(dr["id"]);
                            string name = dr["name"].ToString();
                            int greadid = Convert.ToInt32(dr["greadid"]);
                            DateTime br = Convert.ToDateTime(dr["rr"]);
                            ListViewItem item = new ListViewItem(xue.ToString(), 0);

                            item.SubItems.Add(name);
                            item.SubItems.Add(greadid.ToString());
                            item.SubItems.Add(br.ToString());

                            listView1.Items.Add(item);

                        }
                        dr.Close();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("异常");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chaxue(); 
        }
        private void find()
        {
          

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(this.listView1.SelectedItems[0].Text);
            //MessageBox.Show("学号为："+id);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int id = Convert.ToInt32(this.listView1.SelectedItems[0].Text);
            MessageBox.Show("学号为：" + id);
        }


     
        }
       
    }

