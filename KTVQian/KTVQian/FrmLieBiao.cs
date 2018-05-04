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
    public partial class FrmLieBiao : Form
    {

        private static FrmGeXing1 x;
        public FrmLieBiao(FrmGeXing1 v)
        {

            x = v;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public FrmLieBiao()
        {
            // TODO: Complete member initialization
        }

        private void FrmLieBiao_Load(object sender, EventArgs e)
        {
            finf();
        }


     
        public void finf()
        {
            string name = x.listView2.SelectedItems[0].Text;
            //MessageBox.Show(name);
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            string sql = "select*  from  singer_info as s , song_info as c where	s.singer_id=c.singer_id and singer_name='" + name + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ds.Tables.Clear();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "  select song_url from song_info where song_name='"+dataGridView1.SelectedRows[0].Cells[1].Value.ToString()+"'";
            
            DBHelper db = new DBHelper();
           SqlConnection conn = new SqlConnection(db.str);
            SqlCommand cmd = new SqlCommand(sql,conn);
            //int a = C(cmd.ExecuteReader());
           SqlDataAdapter da = new SqlDataAdapter(sql, conn);
           DataSet ds = new DataSet();
           
           da.Fill(ds, "ss");
           string a = ds.Tables[0].Rows[0]["song_url"].ToString();         
            Form1 ff = new Form1();
            ff.name = a;
            ff.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
