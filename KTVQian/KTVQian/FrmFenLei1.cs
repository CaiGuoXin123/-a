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
    public partial class FrmFenLei1 : Form
    {
       
        public FrmFenLei1()
        {
            
            InitializeComponent();
        }

       
        public string sql;
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
        //public string fen;

        public string Str;

        private void FrmFenLei1_Load(object sender, EventArgs e)
        {
            
            
            string sql = @"select o.song_name,i.singer_name from song_info as o,song_type as t,singer_info as i 
          where o.songtype_id = t.songtype_id and o.singer_id = i.singer_id and t.songtype_name = '" + Str + "'";

            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
      
        }
    }
}
