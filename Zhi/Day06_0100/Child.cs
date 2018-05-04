using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0100
{
 public   class Child:Parent
    {
        private string homeAddress;
        public Child() { }
        public Child(int age1, string name1, string homeAddress):base(name1,age1)
        {
            this.homeAddress = homeAddress;
        }

        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }
        
    }
}
