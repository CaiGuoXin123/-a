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
    public partial class FrmPaiHang : Form
    {
        public FrmPaiHang()
        {
            InitializeComponent();
        }

        private void FrmPaiHang_Load(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = @" SELECT s.song_name,t.singer_name,song_play_count FROM dbo.song_info as s, singer_info as t  where s.singer_id = t.singer_id
   
                    ORDER BY song_play_count DESC";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "  select song_url from song_info where song_name='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                string url = cmd.ExecuteScalar().ToString();
                Form1 frm = new Form1();
                frm.name = "\\" + url;
                frm.Show();

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
    }
}
