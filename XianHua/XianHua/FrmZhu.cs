using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XianHua
{
    public partial class FrmZhu : Form
    {
        public FrmZhu()
        {
            InitializeComponent();
        }

        private void 鲜花销售管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查看鲜花销售信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaKan kan = new FrmChaKan();
            kan.Show();
          
        }
    }
}
