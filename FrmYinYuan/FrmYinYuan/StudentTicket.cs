using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmYinYuan
{
    public class StudentTicket:Ticket
    {
        public StudentTicket() { }

        public StudentTicket(ScheduleItem scheduleItem, Seat seat, int discount)
            : base(scheduleItem, seat)
        {
            this.Discount = discount;
        }

        private int discount; //学生票的折扣

        public int Discount     
        {
            get { return discount; }
            set { discount = value; }
        }
        public override void CalcPrice() //父类计算票价的 
        {
            this.Price = this.Scheduleitem.Movie.Price * Discount / 10;

           
        }
        public override void Print()//父类打印售票信息
        {
            string fileName = this.Scheduleitem.Time.Replace(":", "-") + " " + this.Seat.SeatNum + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("***************************");
            sw.WriteLine("        青鸟影院");
            sw.WriteLine("---------------------------");
            sw.WriteLine(" 电影名：\t{0}", this.Scheduleitem.Movie.Moviename);
            sw.WriteLine(" 时间：  \t{0}", this.Scheduleitem.Time);
            sw.WriteLine(" 座位号：\t{0}", this.Seat.SeatNum);
            sw.WriteLine(" 价格：  \t{0}", this.Price.ToString());
            sw.WriteLine("***************************");
            sw.Close();
            fs.Close();
        }
        public override void Show()  //显示当前售出票信息
        {
            
        }
    }
}
