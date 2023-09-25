using DataBase;

namespace Program
{
    class Run
    {
        static void Main()
        {
            var rep = new Repository();

            var order = rep.GetOrderById(1);

            var customer = rep.GetCustomerWithOrdersById(3);

            Console.ReadLine();

        }
    }
}