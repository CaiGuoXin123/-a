using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0400
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入价格");
            double pay = Convert.ToDouble(Console.ReadLine());
            if (pay < 100)
            {
                Console.WriteLine("付款:{0}", pay);
            }
            else
            {
                Console.WriteLine("付款：{0}",pay-50);
            }
            Console.ReadLine();
        }
    }
}
