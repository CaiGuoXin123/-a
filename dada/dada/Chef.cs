using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dada
{
    class Chef
    {

        private Order order;
        public void GetOrder(Order order)
        {
            this.order = order;

        }
        public void Cook()
        {
            Console.WriteLine("厨师烹饪{0}",order.mealList);
            Console.WriteLine("制作完成");
        }
        public void SenAlert(Waitress waitress)
        {
            Console.WriteLine("厨师提示服务员取菜");
            waitress.GetOrder(order);
        }
    }
}
