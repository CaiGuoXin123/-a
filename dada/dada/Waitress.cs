using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dada
{
    class Waitress
    {

        private Order order;
        public void GetOrder(Order order)
        {
            this.order = order;
        }
        public void SendOrder(Chef chef)
        {
            Console.WriteLine("服务员将菜{0}传给厨师", order.mealList) ;
            chef.GetOrder(order);
        }
        public void TransCook()
        {
            Console.WriteLine("服务员将菜{0}送给客户{1}",order.mealList,order.id);
            order.der.Eat();

        }
    }
}
