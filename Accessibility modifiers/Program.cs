using DataBase;
using Service;
using System;

namespace Program
{
    class Run
    {
        static void Main()
        {
            var rep = new Repository();
            var customerService = new CustomerService(rep);
            var orderService = new OrderService(rep);



            var order = orderService.GetOrderById(1);
            var order2 = orderService.GetOrderById(2);
            var order3 = orderService.GetOrderById(3);

        }
    }
}