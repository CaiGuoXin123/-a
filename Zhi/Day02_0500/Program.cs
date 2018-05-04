using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0500
{
    class Program
    {
         
           
        static void Main(string[] args)
        {
            int[] num = new int[] { 55, 60, 63 };
            Console.WriteLine("原分数：");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            up(num);
            Console.WriteLine("\n提分后：");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static void up(int[] num )
        {
            for (int i = 0; i < num.Length;i++ )
            {
                num[i] += 5;

            }
        
        }
    }
}
