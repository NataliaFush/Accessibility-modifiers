using Core;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class UserBase
    {
        private string lastName;
        private string firstName;
        public int Id { get; set; }
        public UserType UserType { get; }
        public DateTime BirthDay { get; set; }

        protected UserBase(string firstName, string lastName, UserType userType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.UserType = userType;
        }

        public string FullName { get { return firstName + " " + lastName; } }

    }
}
