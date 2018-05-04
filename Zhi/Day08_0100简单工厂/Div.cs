using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂
{
   public class Div:FU
    {
       public override int Calc()
       {
           if (NumB == 0)
           {
               throw new Exception("除数不能为0");
           }
           else
           {
               int Result = NumA / NumB;
               return Result;
           }
         

           
       }
    }
}
