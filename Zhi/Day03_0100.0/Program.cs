using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0100._0
{
    class Program
    {
        static void Main(string[] args)
        {

            #region   00ArrayList=========
            //    ArrayList list = new ArrayList();
            //    list.Add("牡丹");
            //    list.Add("樱花");
            //    list.Add("桃花");
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    list.Insert(2,"梨花");
            //    list.Remove("樱花");
            //    //list.RemoveAt(1);

            //    //修改
            //    list[0] = "牡丹花";
            //    //list.Clear();
            //    Console.WriteLine("================");
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();
            //}
            #endregion
            #region   简洁--=--=-=-=-=-=-
     //       ArrayList list = new ArrayList()
     //{
     //    new Book(){book="炼狱"},
     //    new  Book(){book="aaa"},
     //    new Book(){book="sss"}
    
     //};
     //       foreach (Book item in list)
     //       {
     //           Console.WriteLine(item.book);
     //       }
     //       Console.ReadLine();
            #endregion

            Hashtable table = new Hashtable();
            table.Add("CBC","中国建设银行");
            table.Add("ABC","中国农业银行");
            table.Add("ICBC","中国工商银行");
            //通过key获取value
            //foreach (string  value in table.Values)
            //{
            //    Console.WriteLine(value);
                //双列集合如何通过key获取value
                //Console.WriteLine(table[key]);
            //}
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            Console.ReadLine();
        }
    }
}
