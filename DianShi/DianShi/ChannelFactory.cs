using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianShi
{
   public class ChannelFactory
    {
       public static ChannelBase CreateChannel(string type)
       {

           ChannelBase channel = null;
           switch(type)
           {
               case"TypeA":
                   channel = new TypeAChannel();
                   break;
               case "TypeB":
                   channel = new TypeBChannel();
                   break;
               default:
                   break;
           }

           return channel;
       }
    }
}
