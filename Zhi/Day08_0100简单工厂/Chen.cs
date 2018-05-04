using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂
{
   public class Chen:FU
    {
       public override int Calc()
       {
           int Result = NumA * NumB;
           return Result;
       }
    }
}
