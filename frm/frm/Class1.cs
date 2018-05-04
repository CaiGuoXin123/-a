using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm
{
    class Class1
    {
        int age;
        string name;
        Gender xinngbie;
        public void showInfo()
        {
            Console.WriteLine(name+age+xinngbie);

        }
        public void show()
        {
            Class1 cl = new Class1();
            cl.name = "123";
            cl.age = 10;
            cl.xinngbie = Gender.男;
        }
    }
}
