using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实例9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fa = new Form3();
            fa.ShowDialog();
        }
    }
}
