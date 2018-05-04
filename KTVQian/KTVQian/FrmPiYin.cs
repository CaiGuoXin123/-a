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
    public partial class FrmPiYin : Form
    {
        SqlConnection conn = null;

        public FrmPiYin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        

        private void FrmPiYin_Load(object sender, EventArgs e)
        {
            select();
        }

        private void select()
        {
            DBHelper db = new DBHelper();

                try
                {
                    conn = new SqlConnection(db.str);
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine(" select Song.song_name,Singer.singer_name,Song.song_url");
                    sql.AppendLine(" from singer_info as Singer,song_info as Song");
                    sql.AppendLine(" where Singer.singer_id = Song.singer_id");
                    sql.AppendFormat(" and (song.song_ab like '%{0}%' or song.song_name like '%{1}%')",
                        this.textBox1.Text, this.textBox1.Text);

                    listView1.Items.Clear();

                    SqlCommand cmd = new SqlCommand(sql.ToString(), conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr != null)
                    {
                        while (dr.Read())
                        {

                            string Name = dr["song_name"].ToString();
                            string singer = dr["singer_name"].ToString();
                            string songUrl = dr["song_url"].ToString();
                            ListViewItem item = new ListViewItem(songUrl);
                            item.SubItems.Add(Name);
                            item.SubItems.Add(singer);
                            this.listView1.Items.Add(item);

                        }
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("未查询到数据！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            string songUrl = listView1.SelectedItems[0].Text;
            string songName = listView1.SelectedItems[0].SubItems[1].Text;
            Song song = new Song();
            song.SongName = songName;
            song.SongURl = songUrl;
            PlayList.AddSong(song);

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
