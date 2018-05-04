using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_0200递归
{
    class Program
    {
        static void Main(string[] args)
        {
              if (n <= 0)
              {
                return 0;
              }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fn(n - 1) + Fn(n - 2);
        }

        }
    }
}
