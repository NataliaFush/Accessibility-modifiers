using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository
    {
        IOrder GetOrderById(int id);
        ICustomer GetCustomerWithOrdersById(int id);
        List<IItem> GetItemsByOrderId(int id);
        List<IDiscount> GetCurrentDateDiscounts();
    }
}
