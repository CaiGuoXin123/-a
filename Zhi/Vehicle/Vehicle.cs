using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
  public  class Vehicle
    {
        public string Type { get; set; }
        public string Place { get; set; }
        public Vehicle() { }
        public Vehicle(string type,string place)
        {
            this.Type = type;
            this.Place = place;
        }
        public void VehicleRun()
        {
            Console.WriteLine("汽车在行驶！！");

        }
     
    }
}
