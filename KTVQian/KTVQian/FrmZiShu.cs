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
    public partial class FrmZiShu : Form
    {
        public FrmZiShu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 3;
            v.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 1;
            v.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 2;
            v.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 4;
            v.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 5;
            v.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num =6;
            v.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 7;
            v.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FrmZiShu1 v = new FrmZiShu1();
            v.num = 8;
            v.Show();
        }

        private void FrmZiShu_Load(object sender, EventArgs e)
        {

        }
    }
}
