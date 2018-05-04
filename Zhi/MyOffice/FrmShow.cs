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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }
      public static SE[] pingjia;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FrmJudge jui = new FrmJudge();
            //jui.Show();
        }
       
        public void UdateView()
        {
            pingjia = new SE[3];
            SE i = new SE();
            i.Id = 111;
            i.Name = "王小毛";
            i.Age = 26;
            i.Jinping = "未评价";
            i.Deifen = 0;
            pingjia[0] = i;


         
            SE q = new SE();
            q.Id = 112;
            q.Name = "周新雨";
            q.Age = 22;
            q.Jinping = "未评价";
            q.Deifen = 0;
            pingjia[1] = q;


         
            SE w = new SE();
            w.Id = 111;
            w.Name = "王小毛";
            w.Age = 26;
            w.Jinping = "未评价";
            w.Deifen = 0; 
            pingjia[2] = w;
        }
        public void UpdateView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < pingjia.Length;i++ )
            {
               if(pingjia[i]!=null)
               {
                   ListViewItem item = new ListViewItem(pingjia[i].Id.ToString());
               
                   item.SubItems.Add(pingjia[i].Name.ToString());
                   item.SubItems.Add(pingjia[i].Age.ToString());
                   item.SubItems.Add(pingjia[i].Jinping.ToString());
                   item.SubItems.Add(pingjia[i].Deifen.ToString());
                   listView1.Items.Add(item);
               }
            }
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            UdateView();
            UpdateView();
        }

        private void FrmShow_DoubleClick(object sender, EventArgs e)
        {
            
        }

        
            
        private void listView1_DoubleClick(object sender, EventArgs e)
        {


            //if (this.listView1.SelectedItems.Count == 0)
            //{
            //    return;
            //}
        
            //int index = 0;
            //for (int i = 1; i < pingjia.Length; i++)
            //{

            //    if (pingjia[i].Id .Equals( this.listView1.SelectedItems[0].Text.Trim()))
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //FrmJudge ju = new FrmJudge();
            //ju.Show();
            ListViewItem selectItem=listView1.SelectedItems[0];
            FrmJudge frm=new FrmJudge();
            frm.selectItem = selectItem;
            frm.Show();
        }
    }
}
