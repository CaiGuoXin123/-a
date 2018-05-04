using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class FrmGuanLi : Form
    {
        public FrmGuanLi()
        {
            InitializeComponent();
        }

        private void 增加歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZengJia jia = new FrmZengJia();
            jia.Show(); 
        }

        private void 查询歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaXun xun = new FrmChaXun();
            xun.Show();
        }

        private void 修改歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmGuanLi_Load(object sender, EventArgs e)
        {
            DBHelper.path = "F:\\蔡国鑫\\实训相关学生版\\image\\";
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXiuGai gai = new FrmXiuGai();
            gai.Show();
        }

        private void 歌手管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
