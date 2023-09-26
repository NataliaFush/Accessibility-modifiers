using DataBase;
using Service;

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
            orderService.SetDiscountsToOrder(order);
            orderService.SetPriceToOrder(order);

            var customer = customerService.GetCustomerWithOrdersById(2);
            orderService.SetDiscountsToOrders(customer.Orders);
            orderService.SetPriceToOrders(customer.Orders);

            Console.ReadLine();

        }
    }
}