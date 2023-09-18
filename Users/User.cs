using Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal abstract class UserBase
    {
        protected enum UserType
        {
            Admin,
            Customer,
            Manager
        }

        protected UserBase(string firstName, string lastName, UserType userType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;
        }
        private string firstName;
        private string lastName;
        private UserType userType; 
        
        public int Id { get; set; }
        public Address Address { get; set; }
        public ICollection<OrderBase> Orders { get; set; }
        public int Discount { get; set; }
        public string FullName  { get { return firstName + " " + lastName; } }
        public int OrderCount { get { return Orders.Count; } }

        public string GetUserType()
        {
            return userType.ToString();
        }




    }
}
