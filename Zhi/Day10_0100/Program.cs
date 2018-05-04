using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Day10_0100
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> list = new List<Person>();
            //Person p1 = new Person();
            //p1.Name = "张三";
            //p1.Age = 45;

            //Person p2 = new Person();
            //p2.Name = "李四";
            //p2.Age = 35;

            //Person p3 = new Person();
            //p3.Name = "王五";
            //p3.Age = 25;

            //list.Add(p1);
            //list.Add(p2);
            //list.Add(p3);

            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream fs = new FileStream("sas.txt", FileMode.Create);
            //方法， 
            //bf.Serialize(fs,list);
            //fs.Close();
            //Console.WriteLine("成功");
            //Console.ReadLine();

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("sas.txt",FileMode.Open);
           List<Person> list= (List<Person>)bf.Deserialize(fs);
           foreach (Person item in list)
           {
               Console.WriteLine(item.Age);
               
           }
           Console.ReadLine();
        }
    }
}
