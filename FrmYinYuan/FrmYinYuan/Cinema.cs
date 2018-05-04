using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmYinYuan
{
   public  class Cinema
    {
      public Dictionary<string, Seat> Seats = new Dictionary<string, Seat>();
       List<Ticket> SoldTicket = new List<Ticket>();

       public List<Ticket> SoldTickets = new List<Ticket>();
       private Schedule schedule;

       public Schedule Schedule
       {
           get { return schedule; }
           set { schedule = value; }
       }
    }
}
