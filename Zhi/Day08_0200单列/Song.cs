using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0200单列
{
   public class Song
    {
        public string SongName { get; set; }
        public string  SongPlay { get; set; }


        public Song() { }
        public Song(string songname,string songplay)
        {
            this.SongName = songname;
            this.SongPlay = songplay;
        }
    }
}
