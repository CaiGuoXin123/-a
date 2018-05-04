using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmYinYuan
{
   public class TicketUtil
    {
       public static Ticket CreateTicket(ScheduleItem scheduleItem, Seat seat,
           int discount, string customerName, string type)
       {
           Ticket newTicket = null;
           switch (type)
           {
               case "student":
                   newTicket = new StudentTicket(scheduleItem, seat, discount);
                   break;
               case "free":
                   newTicket = new FreeTicket(scheduleItem, seat, customerName);
                   break;
               case "":
                   newTicket = new Ticket(scheduleItem, seat);
                   break;
           }
           return newTicket;

       }
    }
}
