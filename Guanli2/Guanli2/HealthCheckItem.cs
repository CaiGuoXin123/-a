using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guanli2
{
   public class HealthCheckItem
    {
        public HealthCheckItem()
        {

        }
        public HealthCheckItem(string name, string description, int price)
        {
            this.description=description;
            this.name=name;
            this.price=price;
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
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
    }
}
