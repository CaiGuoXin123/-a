using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dada
{
    class Program
    {
        static void Main(string[] args)
        {

            Client wang = new Client();
            Waitress wa = new Waitress();
            Waitress aa = new Waitress();
            Chef chef=new Chef();
            Order er = new Order();
            er.der = wang;
            er.id = 100;
            er.mealList = "水煮鱼";
            wang.Order(wa,er);
            wa.SendOrder(chef);
            chef.Cook();
            chef.SenAlert(wa);
            wa.TransCook();
            Console.Read();
        }
    }
}
