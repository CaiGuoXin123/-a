using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm汽车
{
    public class Truck : Vehicle
    {
        private int load;

        public int Load
        {
            get { return load; }
            set { load = value; }
        }
        public  Truck()
        {
        }
        public  Truck(string licenseno, double dailyrent, string name, string color, int rentdate,int load)
            :base(color, dailyrent, licenseno, name, rentdate)
        {
            this.load = load;
        }
    }
}
