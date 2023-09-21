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
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public UserType UserType { get; }
        public DateTime BirthDay { get; set; }

        protected UserBase( UserType userType)
        {
            this.UserType = userType;
        }

        public string FullName { get { return FirstName + " " + LastName; } }

    }
}
