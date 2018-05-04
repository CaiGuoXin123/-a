using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂
{
   public abstract class FU
    {
       public int NumA { get; set; }
       public int NumB { get; set; }
       public abstract int Calc();
    }
}
