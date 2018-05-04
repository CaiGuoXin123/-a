using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVQian
{
    class PlayList
    {
        public static Song[] SongList =new Song[50];
        public static int SongIndex = 0;
        public static bool AddSong(Song song)
        {
            bool success = false;//记录添加歌曲是否成功
            for (int i = 0; i < SongList.Length; i++)
            {
                //找到数组中第一个为null的位置
                if (SongList[i] == null)
                {
                    SongList[i] = song;
                    Console.WriteLine(song.SongName);
                    success = true;
                    break;
                }
            }
            return success;
        }
        public static Song GetPlaySong()
        {
            if (SongList[SongIndex] != null)
            {
                return SongList[SongIndex];
            }
            else
            {
                return null;
            }
        }



         //<summary>
         //把未播放改为已播放
         //</summary>
        public static void MoveOn()
        {
            if (SongList[SongIndex] != null && SongList[SongIndex].PlayStatel == songPlayState.played)
            {
                SongList[SongIndex].SetSongPlayed();
            }
            else
            {
                SongIndex++;
            }
        }



        //重播
        public static void PlayAgin()
        {
            if (SongList[SongIndex] != null)
            {
                SongList[SongIndex].SetPlayAgain();
            }
        }

        //切歌
        public static void cut()
        {
            if (SongList[SongIndex] != null)
            {
                SongList[SongIndex].PlayStatel = songPlayState.cut;
                SongIndex++;//改变歌曲索引，播放下一首
            }
        }

    }
}
