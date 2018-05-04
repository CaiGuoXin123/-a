using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day08_0300XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  单层循环
            //XmlDocument doc = new XmlDocument();
            //doc.Load ("XMLFile1.xml");
            //XmlNode root = doc.DocumentElement;
            //foreach (XmlNode item in root.ChildNodes)
            //{
            //    string book = item.Attributes["id"].Value.ToString();
            //    Console.WriteLine(book);
            //    Console.WriteLine("名称"+item["bookName"].InnerText);
            //    Console.WriteLine("价格" + item["bookPrice"].InnerText);


            //}
            #endregion
            #region   双层循环
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile1.xml");
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                foreach (XmlNode child in item.ChildNodes)
                {
                    if (child.Name == "bookName")
                    {
                        Console.WriteLine("名称"+child.InnerText);
                    }
                    else if(child.Name == "bookPrice")
                    {
                        Console.WriteLine("价格"+child.InnerText);
                    }

                }
            }
            Console.ReadKey();

        }
            #endregion
    }
}
