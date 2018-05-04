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

namespace KTVQian
{
    public partial class FrmFenLei : Form
    {
        public FrmFenLei()
        {
            InitializeComponent();
        }
            FrmFenLei1 v = new FrmFenLei1();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            v.Str = "热门流行";
            v.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            v.Str = "经典老歌";
            v.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            v.Str = "影视金曲";
            v.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            v.Str = "游戏动漫";
            v.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            v.Str = "京剧戏曲";
            v.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            v.Str = "儿歌";
            v.Show();
            this.Close();
        }
    }
}
