using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day07_0300界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        public void Init()
        {
            List<SE> List = new List<SE>();
            SE jack = new SE("001","王小毛",22,Gender.male,100);
            SE joe = new SE("002", "周迅", 27, Gender.male, 300);
            SE ema = new SE("003", "盖茨", 25, Gender.male, 300);
            List.Add(jack);
            List.Add(joe);
            List.Add(ema);
            this.dataGridView1.DataSource = List;
        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
