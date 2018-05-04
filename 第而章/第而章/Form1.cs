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

namespace 第而章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string str = "Data Source=.;Initial Catalog=DB_Myschool;User ID=sa;Password=695139150";
      
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectGradeName();//
            
        }
        /// <summary>
        /// 
        /// </summary>
        private void SelectGradeName()
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "select GradeName from Grade";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                if (dr != null)
                {
                    if (dr.HasRows)
                    {
                        comboBox1.Items.Add("请选择");
                        comboBox1.SelectedIndex = 0;
                        while (dr.Read())
                        {
                            string sr = dr["GradeName"].ToString();
                            comboBox1.Items.Add(sr);
                        }
                    }
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gName"></param>
        /// <returns></returns>
        public int FindGradeIDByGradeName(string gName)
        {

            SqlConnection conn = new SqlConnection(str);

            int gid = 0;
            try
            {
                conn.Open();
                string sql = " select GradeId  from  Grade where GradeName='" + gName + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(dr["GradeId"].ToString());
                   gid = Convert.ToInt32( dr["GradeId"]);
                  
                }

                return gid;
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("异常");
                return gid;
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }
      

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                   
        



          //  FindGradeIDByGradeName(con);
        }

        public void add()
        {
            int stuNo = Convert.ToInt32();
        }
        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
