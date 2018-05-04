using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂
{
   public class CaculatorFactory
    {
       public static FU get(string oper) 
       {

           FU cal = null;
           switch (oper)
           {
               case"+":
                   cal = new Add();
                   break;
               case "-":
                   cal = new JIAN();
                   break;
               case "*":
                   cal = new Chen();
                   break;
               case "/":
                   cal = new Div();
                   break;
               default:
                   break;
           }
           return cal;
       }
    }
}
