using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_04000
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Interface1> a = new List<Interface1>();
            Br r = new Br();
            fei s=new fei();
            a.Add(r);
            a.Add(s);
            foreach (Interface1 item in a)
            {
                item.viy();
            }
            Console.ReadLine();
        }
    }
}
