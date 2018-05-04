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

namespace FrmAll
{
    public partial class FrmLiBiao : Form
    {
        public FrmLiBiao()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmZengJia jia = new FrmZengJia();
            jia.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            show();
        }
        public void fill()
        {
            try
            {
                DBHelper db = new DBHelper();
                SqlConnection conn = new SqlConnection(db.str);
                //if (treeView1.SelectedNode.Level == 1)
                //{
                //拼接sql语句
                string sql = @"  select c.CommodityID,c.CommodityName,s.SortName,c.CommodityPrice,
                      c.IsDiscount,c.ReducedPrice from commodity as c ,CommoditySort as s where c.SortID=s.SortID";

                //创建临时数据集
                DataSet ds = new DataSet();
                //创建适配器
                SqlDataAdapter sa = new SqlDataAdapter(sql, conn);
                sa.Fill(ds, "commodity");//填充数据
                //重新绑定数据源
                this.dataGridView1.DataSource = ds.Tables["commodity"];
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void FrmLiBiao_Load(object sender, EventArgs e)
        {
            fill();
         

        }
        public void show()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(db.str);
            if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 1)
            {
                //StringBuilder sql = new StringBuilder();
                string ss = "  select * from Commodity as c,CommoditySort as s where c.SortID=s.SortID and c.IsDiscount=0";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "com");
                dataGridView1.DataSource = ds.Tables["com"];
            }
            else if (Convert.ToInt32(treeView1.SelectedNode.Tag) == 2)
            {
                string ss = "  select * from Commodity as c,CommoditySort as s where c.SortID=s.SortID and c.IsDiscount=1";
                SqlDataAdapter da = new SqlDataAdapter(ss, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "w");
                dataGridView1.DataSource = ds.Tables["w"];

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmGai gai = new FrmGai();
            //根据编号
            gai.commodityID = Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value);
            if (dataGridView1.Rows.Count > 0) //加这个判断，
            {
                
                gai.name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                gai.leixing = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                gai.jiage1 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                gai.tejia = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[4].Value);
                gai.jiage1 = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            gai.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                DBHelper db = new DBHelper();
                SqlConnection conn = new SqlConnection(db.str);
            try
            {
                conn.Open();
                if (this.dataGridView1.CurrentRow != null)
                {                                                                            //我要删除的东西
                    string message = string.Format("确定要删除商品名称为 {0} 的数据吗?", this.dataGridView1.CurrentRow.Cells[1].Value);

                    // 通过谈出对话框让用户选择                                                                   //返回值
                    if (MessageBox.Show(message, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        StringBuilder sa = new StringBuilder();
                                                                     //获取单元格的一行
                        int num = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                        // 删除语句
                        sa.AppendFormat("DELETE FROM [Commodity] WHERE CommodityID={0}", num);

                        // 执行删除操作
                        SqlCommand command = new SqlCommand(sa.ToString(), conn);
                       
                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                conn.Close();
            }
                }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        }
    }


