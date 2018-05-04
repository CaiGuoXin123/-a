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
    public partial class Form1 : Form
    {
        public Song song;

        public Form1()
        {
            InitializeComponent();
        }

        public string URL = "F:\\蔡国鑫\\实训相关学生版\\歌曲\\";
        public string name;

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            play1.URL = URL;
       
        }

        private void PlaySong()
        {
            this.song = PlayList.GetPlaySong();
            if (song != null)
            {
                song.PlayStatel = songPlayState.played;//更改播放状态，改为已播
                play1.URL = KTVUlit.url + this.song.SongURl;//得到当前播放歌曲的路径
            }
        }
          


        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.timer1.Start();
          
            MessageBox.Show(URL + name);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.song == null)
            {
                this.PlaySong();
            }
            if (this.play1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.song = null;
                PlayList.MoveOn();
            }
            //切歌
            if (this.song != null && this.song.PlayStatel == songPlayState.cut)
            {
                this.play1.URL = "";
                this.song = null;
            }
            //重唱
            if (this.song != null && this.song.PlayStatel == songPlayState.again)
            {
                this.PlaySong();
            }
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            FrmYiDian fd = new FrmYiDian();
            fd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定切歌吗?", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PlayList.cut();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgin();//重唱
        }




    }
}