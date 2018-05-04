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
    public partial class FrmZiShu1 : Form
    {
        public FrmZiShu1()
        {
            InitializeComponent();
        }
        public int num = 0; 
        private void FrmZiShu1_Load(object sender, EventArgs e)
        {


            DBHelper db = new DBHelper();
    
            string sql = @"select song_name,singer_name from song_info,singer_info
             where singer_info.singer_id = song_info.singer_id and song_word_count = " + num + "";
            SqlConnection conn = new SqlConnection(db.str);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];


           
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
                frm.name = "\\"+ url;
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
