using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm汽车
{
    public class Car : Vehicle
    {
      public  Car()
      {
      }
      public Car(string licenseno, double dailyrent, string name, string color, int rentdate)
          : base(color, dailyrent, licenseno, name, rentdate)
      {

      }
    }
}
