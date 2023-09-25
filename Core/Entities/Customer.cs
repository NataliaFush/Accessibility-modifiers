using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer : UserBase, ICustomer
    {
        public Customer() : base(UserType.Customer)
        {
        }

        public IEnumerable<IOrder> Orders { get ; set ; }
        public Address DeliveryAddress { get ; set; }
    }
}
