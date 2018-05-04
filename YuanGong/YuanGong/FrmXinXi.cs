using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuanGong
{
    public partial class FrmXinXi : Form
    {
        public FrmXinXi()
        {
            InitializeComponent();
        }
        //列表，用于保存SE对象
        public List<SE> list= new List<SE>();
        //刷新DataGridView数据
        public void BinGrid(List<SE>list)
        {
            this.dataGridView1.DataSource = new BindingList<SE>(list);
        }
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXinZeng zeng = new FrmXinZeng();
            zeng.FrmParent = this;
            zeng.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmXinXi_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //存储查找的结果
            List<SE> temList = new List<SE>();
            //查找并填充集合
            foreach (SE item in this.list)
            {
                if(item.ID1.IndexOf(this.textBox1.Text.Trim())!=-1)
                {
                    temList.Add(item);
                }
            }
            //刷新数据
            this.dataGridView1.DataSource = new BindingList<SE>(temList);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count>0)
            {
                DialogResult ch=MessageBox.Show("确定要删除么？","提示",MessageBoxButtons.OKCancel);
                if (ch == DialogResult.OK)
                {
                    string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].ID1 == id)
                        {
                            list.Remove(list[i]);
                            BinGrid(list);
                            MessageBox.Show("删除成功");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择一行！");
                    return;
                }
            }
        }

        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<string, Record> rec = new Dictionary<string, Record>();
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("请选中一行");
                return;
            }
            string woekNo = dataGridView1.CurrentRow.Cells["workNp"].Value.ToString();
            foreach(string id in rec.Keys)
            {
                if(woekNo==id)
                {
                    MessageBox.Show("你已经签到！！！");

                    return;
                }
                Record qq = new Record();
                qq.ID = woekNo;
                qq.Name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                qq.SignInTime = DateTime.Now;

                this.rec.Add(qq.ID,qq);
                MessageBox.Show("签到成功!!!");
            }
        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("请选中一行");
                return;
            }
            string id = dataGridView1.CurrentRow.Cells["workNo"].Value.ToString();
            bool isOut = false;
            foreach (string key in rec.Keys)
            {
                if(key==id)
                {
                    //this.rec[key].SignOuntTime == DateTime.Now;
                    MessageBox.Show("签退成功");
                    isOut = true;
                    break;
                }
            }
            if(!isOut)
            {
                MessageBox.Show("很抱歉，尚未签到！");

            }
        }
    }
}
