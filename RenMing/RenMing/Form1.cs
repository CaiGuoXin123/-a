using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenMing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Grade gg = new Grade();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            gg.AddButton();
              int i=0;
            int x =165 ;
            int y = 0;
            foreach (var item in gg.list)
            {
                Button on = new Button();
                i++;
                on.Name = string.Format("{0}", i);
               
                on.Location = new System.Drawing.Point(x, y);
                on.Size = new System.Drawing.Size(50, 30);
                on.Text = string.Format("{0}",item.StuName1);
                this.Controls.Add(on);

                y += 50;
               
            }
   }
    }
}
