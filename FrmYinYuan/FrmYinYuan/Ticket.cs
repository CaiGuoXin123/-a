using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmYinYuan
{
    [Serializable]
   public class Ticket
    {
        private ScheduleItem scheduleitem;  //放映场次

        public ScheduleItem Scheduleitem
        {
            get { return scheduleitem; }
            set { scheduleitem = value; }
        }
        private Seat seat;    //所属座位对象

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }
        private int price;  //票价

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public virtual void CalcPrice()
        {
        }



        public virtual void Print() //打印数据
        {
            string fileName = this.Scheduleitem.Time.Replace(":", "-") + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("***************************");
            sw.WriteLine("        青鸟影院");
            sw.WriteLine("---------------------------");
            sw.WriteLine(" 电影名：\t{0}",this.Scheduleitem.Movie.Moviename);
            sw.WriteLine(" 时间：  \t{0}", this.Scheduleitem.Time);
            sw.WriteLine(" 座位号：\t{0}", this.Seat.SeatNum);
            sw.WriteLine(" 价格：  \t{0}", this.Price.ToString());
            sw.WriteLine("***************************");
            sw.Close();
            fs.Close();

        }


        public virtual void Show()
        {
            MessageBox.Show("售出");
        }
        
       
        public Ticket() { }
        public Ticket(ScheduleItem scheduleitem, Seat seat)
        {
            this.Scheduleitem = scheduleitem;
            this.Seat = seat;
        
        }
        
        

    }
}
