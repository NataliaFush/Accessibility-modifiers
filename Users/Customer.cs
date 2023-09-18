using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class Customer : UserBase
    {
        public Customer(string firstName, string lastName) : base(firstName, lastName, UserType.Customer)
        {
        }

        
    }
}
