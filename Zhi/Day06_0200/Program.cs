using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0200
{
    class Program
    {
        static void Main(string[] args)
        {
            Zhong z = new Zhong();
            Han h=new Han();
            Mei m = new Mei();

            List<Fu> f = new List<Fu>();
            f.Add(z);
            f.Add(h);
            f.Add(m);

            foreach (Fu item in f)
            {
                item.Show();
            }
        }
    }
}
