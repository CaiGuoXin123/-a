using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTVQian
{
    public partial class FrmYiDian : Form
    {
        public FrmYiDian()
        {
            InitializeComponent();
        }

        private void FrmYiDian_Load(object sender, EventArgs e)
        {
            Insert();
        }
        private void Insert()
        {
            //清空ListView里面的项
            listView1.Items.Clear();
            //循环数组里的长度
            for (int i = 0; i < PlayList.SongList.Length; i++)
            {
                //判断数组里面是否有数据
                if (PlayList.SongList[i] != null)
                {
                    //创建LIstViewItem对象
                    ListViewItem item = new ListViewItem();
                    //向LIstView里添加子项
                    item.SubItems.Add(PlayList.SongList[i].SongName);
                    //循环赋值
                    item.Tag = i;
                    //三元表达式判断是否为已播
                    string playstate = PlayList.SongList[i].PlayStatel == songPlayState.unplayed ? "未播放" : "已播";
                    //添加到子项里面
                    item.SubItems.Add(playstate);
                    //把Item添加到项里面
                    listView1.Items.Add(item);
                }
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            this.Insert();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }







    }
}
