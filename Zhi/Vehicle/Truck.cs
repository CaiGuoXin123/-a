using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Truck : Vehicle
    {
        public Truck() { }

        public Truck(string type, string place): base(type,place)
        {

        }
        public void TruckRun()
        {
            Console.WriteLine(string.Format("型号为{0}，产地{1}的卡车在行使！",this.Type,this.Place));
        }
    }
}
