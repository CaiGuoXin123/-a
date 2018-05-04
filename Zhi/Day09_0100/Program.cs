using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_0100
{
    class Program
    {
        static void Main(string[] args)
        {
            //get();
            show();

        }

        private static void show()
        {
            FileStream aa = new FileStream("F:\\晚自习.txt", FileMode.Open);
            StreamReader ss = new StreamReader(aa, Encoding.ASCII);
           string  words=ss.ReadToEnd();
           Console.WriteLine(words);
           ss.Close();
           aa.Close();
           Console.WriteLine("成功");
           Console.ReadLine();
        }

        private static void get()
        {
            FileStream fs = new FileStream("F:\\晚自习.txt",FileMode.Append);
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            sw.WriteLine("aaasssdddsssddsdsdsdsds");
            sw.Close();
            fs.Close();
            Console.WriteLine("成功");
            Console.ReadLine();
        }
    }
}
