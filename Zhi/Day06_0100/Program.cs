using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0100
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child(25, "哒哒", "呵呵");
            Console.WriteLine(c.HomeAddress);
            Console.ReadLine();
        }
    }
}
