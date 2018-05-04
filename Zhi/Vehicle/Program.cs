using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck t = new Truck("奔驰G级","德国");
            t.VehicleRun();
            t.TruckRun();
            Console.ReadLine();
        }
    }
}
