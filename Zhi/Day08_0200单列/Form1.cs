using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0200单列
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ContextMenuStrip=contextMenuStrip1;
            List<Song> list = new List<Song>()
            {

                new Song("GAI - 给自己的歌 (Live).mp3","F:\\蔡国鑫\\实训相关学生版\\歌曲\\GAI - 给自己的歌 (Live).mp3"),
                new Song("GAI - 萤火虫.mp3","F:\\蔡国鑫\\实训相关学生版\\歌曲\\GAI - 萤火虫.mp3")
            };
            dataGridView1.DataSource = new BindingList<Song>(list);
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = Form2.get();
            string path = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            frm.path = path;
            frm.PlaySong();
            frm.Show();
        }

        
    }
}
