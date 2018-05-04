using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0600
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> ing = new Dictionary<string, Book>();
            Book dd = new Book();
            dd.BookName = "桃花源记";
            dd.BookPrcion = 55;
            Book ss = new Book();
            ss.BookName = "四世同堂";
            ss.BookPrcion = 21;
            
            ing.Add(dd.BookName, ss);
            ing.Add(ss.BookName, dd);
            foreach (Book value in ing.Values)
            {
                Console.WriteLine(value);
            }




            Console.ReadLine();
        }
    }
}
