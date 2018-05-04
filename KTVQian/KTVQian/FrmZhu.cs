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
    public partial class FrmZhu : Form
    {
        public FrmZhu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 K = new Form1();
            K.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGeXing1 xing = new FrmGeXing1();
            xing.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmPiYin v = new FrmPiYin();
            v.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FrmZiShu v = new FrmZiShu();
            v.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmFenLei lei = new FrmFenLei();
            lei.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmPaiHang hang = new FrmPaiHang();
            hang.Show();
            this.Hide();
           
           
        }
    }
}
