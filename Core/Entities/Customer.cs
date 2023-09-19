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
        public Customer(string firstName, string lastName) : base(firstName, lastName, UserType.Customer)
        {
        }

        public ICollection<IOrderBase> Orders { get ; set ; }
        public Address DeliveryAddress { get ; set; }
        public int Discount { get; set; }
    }
}
