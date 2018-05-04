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

namespace ShouJi
{
    public partial class FrmChaXun : Form
    {
        public FrmChaXun()
        {
            InitializeComponent();
        }

        private void FrmChaXun_Load(object sender, EventArgs e)
        {
            show();
            DBHepler db = new DBHepler();
            string name = comboBox1.Text;
            string sql = " select * from MobileBrand,MoblieInfo where MobileBrand.BrandId = MoblieInfo.BrandID";
            MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string brand = reader["Brand"].ToString();
                    string type = reader["Type"].ToString();
                    string price = reader["Price"].ToString();
                    string size = reader["Size"].ToString();
                    string weight = reader["Weight"].ToString();
                    string style = reader["Style"].ToString();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(brand);
                        item.SubItems.Add(type);
                        item.SubItems.Add(price);
                        item.SubItems.Add(size);
                        item.SubItems.Add(weight);
                        item.SubItems.Add(style);
                        listView1.Items.Add(item);
                    }
                    reader.Close();

                }
                MessageBox.Show("Test");
                
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

        private void show()
        {
            comboBox1.Items.Add("请选择");
            comboBox1.Items.IndexOf(0);
            comboBox1.SelectedIndex = 0;

            //DBHepler db = new DBHepler();
            //SqlConnection conn = new SqlConnection(db.str);
            //string sql = "select *from MobileBrand";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //DataSet ds = new DataSet();
            //da.Fill(ds, "ss");
            //DataRow row = ds.Tables["ss"].NewRow();
            //row["BrandId"] = -1;
            //row["Brand"] = "请选着";
            //ds.Tables["ss"].Rows.InsertAt(row, 0);
            //comboBox1.DataSource = ds.Tables["ss"];
            //comboBox1.DisplayMember = "Brand";
            //comboBox1.ValueMember = "BrandId";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
