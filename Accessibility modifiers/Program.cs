using Core;
using Core.Entities;
using DataBase;
using Service;
using System;
using System.Runtime.ConstrainedExecution;

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

            order.EventAddItem += foo1;
            var item = orderService.GetItemById(1);
            order.AddItem(item);

        }
        static void foo1(IItem it, string msg)
        {
            Console.WriteLine(msg);

        }
    }
}