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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string path;
        public static Form2 onlyone;
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void PlaySong()
        {
            axWindowsMediaPlayer1.URL = path;
        }
        public static Form2 get()
        {
            if(onlyone==null)
            {
                onlyone=new Form2();
            }
            return onlyone;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("qu"))
            {
            }
        }
    }
}
