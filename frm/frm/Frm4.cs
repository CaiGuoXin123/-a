using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm
{
    public partial class Frm4 : Form
    {
        public Frm4()
        {
            InitializeComponent();
        }

        int index =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(index<3)
            {
                index++;
            }
            else
            {
                    index=0;
            }
            this.pictureBox1.Image=imageList1.Images[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
