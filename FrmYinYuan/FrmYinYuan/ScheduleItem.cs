using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmYinYuan
{
   public class ScheduleItem
    {
        private string time;  //放映时间

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private Movie movie;   //本场所放映电影的

        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }
    }
}
