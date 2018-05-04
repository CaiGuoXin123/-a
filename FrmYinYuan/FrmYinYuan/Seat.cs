using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmYinYuan
{
   public class Seat      //座位信息类
    {
       public Seat()
       {

        }
       public Seat(string seatNum, System.Drawing.Color color)
       {
           this.Color = color;
           this.SeatNum = seatNum;
       }
        private string seatNum;  //座位号

        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }
        private System.Drawing.Color color;

        public System.Drawing.Color Color
        {
            get { return color; }
            set { color = value; }
        }
       
    }
}
