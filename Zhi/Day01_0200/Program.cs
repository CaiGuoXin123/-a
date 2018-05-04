using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_0200
{
    class Program
    {
        static void ChangeNum(int num1, int num2)
        {
            //int temp = num1;
            //num1 = num2;
            //num2 = temp;
            //Console.WriteLine("交换方法内部{0}\t{1}", num1, num2);
        }
        static void Main(string[] args)
        {
            //int num1 = 5;
            //int num2 = 10;
            //ChangeNum(num1, num2);
            //Console.WriteLine("{0}\t{1}", num1, num2);
            //Console.ReadLine();    
            //MyStruct qq;
            //qq.age = 19;
            //qq.name = "李四";
            //qq.Show();
            
            Student en = new Student();
            en.age = 18;
            find(en);
            Console.WriteLine(en.age);
            Console.ReadLine();
        }
        static void find(Student en)
        {
          en.age = 22;
        }
    }
}
