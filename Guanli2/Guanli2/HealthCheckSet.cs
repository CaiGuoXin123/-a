using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guanli2
{
   public class HealthCheckSet
    {
        public HealthCheckSet() { }
        public HealthCheckSet(string name, Dictionary<string, HealthCheckItem>healthSet) 
        {
            this.Name = name;
            this.Price = price;

        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private Dictionary<string, HealthCheckItem> healthItem = new Dictionary<string, HealthCheckItem>();

        public Dictionary<string, HealthCheckItem> HealthItem
        {
            get { return healthItem; }
            set { healthItem = value; }
        }
     
    }
}
