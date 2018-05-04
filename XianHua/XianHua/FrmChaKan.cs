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

namespace XianHua
{

    public partial class FrmChaKan : Form
    {
        public FrmChaKan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DBHepler db = new DBHepler();
            //try
            //{
                
                SqlConnection conn = new SqlConnection(db.str);//链接数据库

                StringBuilder sql = new StringBuilder();
                 sql.AppendLine("  select * from dbo.Flower as Singer,dbo.FlowerSale as Song");//sql语句
                 sql.AppendLine("  where Singer.FloweerId= Song.FlowerId");
                 sql.AppendFormat("  and (Singer.FlowerName like '%{0}%' or Singer.FlowerName like '%{1}%')",
                               this.textBox1.Text, this.textBox1.Text);
                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);//命令


                SqlDataAdapter da = new SqlDataAdapter(sql.ToString(), conn);//适配器
                DataSet ds = new DataSet();//数据集
                ds.Tables.Clear();//清除数据
                da.Fill(ds, "ss");
                dataGridView1.DataSource = ds.Tables["ss"];//
           // }
        
           // catch (Exception ex)
           // {

           //     MessageBox.Show("异常" + ex);
           // }
           //finally{
                
           
           // }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXiuGai f = new FrmXiuGai();
           
            f.id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            f.shuliang = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            f.danjia = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            f.beizhu = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            f.Show();
        }
        }
}

