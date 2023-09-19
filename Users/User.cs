using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public abstract class UserBase : ICustomer
    {
        private string lastName;
        private string firstName;
        public Address Address { get; set; }
        public int Id { get; set; }
        private UserType userType;
        public ICollection<IOrderBase> Orders { get; set; }
        public int Discount { get; set; }
        public DateTime UserBirthDay { get; set; }

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

        public string FullName { get { return firstName + " " + lastName; } }
        public int OrderCount { get { return Orders.Count; } }

        public string GetUserType()
        {
            return userType.ToString();
        }




    }
}
