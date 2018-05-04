using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVQian
{
    public enum songPlayState
    {
        //未播放  //播放 //重唱 //切歌
        unplayed, played, again, cut
    }
    public class Song
    {
        private string songName;

        public string SongName
        {
            get { return songName; }
            set { songName = value; }
        }

        private string songURl;

        public string SongURl
        {
            get { return songURl; }
            set { songURl = value; }
        }
        //未播放
        private songPlayState PlayState = songPlayState.unplayed;

        internal songPlayState PlayStatel
        {
            get { return PlayState; }
            set { PlayState = value; }
        }
        //把歌曲状态改为已播放
        public void SetSongPlayed()
        {
            this.PlayState = songPlayState.played;
        }
        //把歌曲状态改为再播放一次
        public void SetPlayAgain()
        {
            this.PlayState = songPlayState.again;
        }
        //把歌曲状态改为切歌
        public void SetSongCut()
        {
            this.PlayState = songPlayState.cut;
        }

    }

}
