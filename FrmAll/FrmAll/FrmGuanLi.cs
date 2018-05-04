using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAll
{
    public partial class FrmGuanLi : Form
    {
        public FrmGuanLi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXiuGai xg = new FrmXiuGai();
            xg.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmLiBiao bi = new FrmLiBiao();
            bi.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出么？", "操作取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuanYu yu = new FrmGuanYu();
            yu.Show();
        }
    }
}
