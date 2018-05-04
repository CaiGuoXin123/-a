using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShouJi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 增加信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZengJia jia = new ZengJia();
            jia.Show();
            //jia.Hide();
        }

        private void 查询信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaXun xin = new FrmChaXun();
            xin.Show();
        }
    }
}
