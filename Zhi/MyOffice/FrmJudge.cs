using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class FrmJudge : Form
    {
        public ListViewItem selectItem = null;
        public FrmJudge()
        {
            InitializeComponent();
        }
        //private SE se;
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PM pm = new PM();
            //    pm.Judge(pm, this.textBox1.Text.Trim(), Int32.Parse(this.richTextBox1.Text.Trim()));
            //    this,mypa
            //}
            //catch (Exception)
            //{
                
            //    throw;
            //}
            selectItem.SubItems[3].Text = textBox1.Text;
            selectItem.SubItems[4].Text = textBox2.Text;
            this.Close();
        }

        private void FrmJudge_Load(object sender, EventArgs e)
        {
            textBox1.Text=selectItem.SubItems[1].Text;
            textBox1.ReadOnly = true;
        }

    }
}
