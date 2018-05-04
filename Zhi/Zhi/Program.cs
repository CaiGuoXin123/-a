using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhi
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zhang=170;
            int Li = Zhang;
            Console.WriteLine("去年小张的身高是{0}，小李的身高是{1}",Zhang,Li);
            Li = 180;
            Console.WriteLine("今年小张的身高是{0}，小李的身高是{1}",Zhang,Li);
            Console.ReadLine();
        }
    }
}
