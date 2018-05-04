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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

            listView1.LargeImageList = this.imageList1;
            listView1.SmallImageList = this.imageList2;

            ListViewItem itemc = new ListViewItem("本地",0);
            itemc.SubItems.Add("本地磁盘");
            itemc.SubItems.Add("15G");
            itemc.SubItems.Add("5G");
            listView1.Items.Add(itemc);


            ListViewItem itemd = new ListViewItem("本地", 1);
            itemd.SubItems.Add("本地磁盘");
            itemd.SubItems.Add("15G");
            itemd.SubItems.Add("5G");
            listView1.Items.Add(itemd);


            ListViewItem itema = new ListViewItem("本地", 0);
            itema.SubItems.Add("本地磁盘");
            itema.SubItems.Add("15G");
            itema.SubItems.Add("5G");
            listView1.Items.Add(itema);

        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
