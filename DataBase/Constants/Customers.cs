using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                FirstName = "Iryna",
                LastName = "Bilan",
                DeliveryAddress = new Address()
                {
                    City = "Lviv",
                    Street = "street8",
                    House = 5
                },
                BirthDay = new DateTime(2000, 5, 23)
            },
            new Customer()
            {
                Id = 2,
                FirstName = "Mykola",
                LastName = "Gavryluk",
                DeliveryAddress = new Address()
                {
                    City = "Rivne",
                    Street = "Street11",
                    House = 8
                },
                BirthDay = new DateTime(2001, 7, 30)
            },
            new Customer()
            {
                Id = 3,
                FirstName = "Oleg",
                LastName = "Smyk",
                DeliveryAddress = new Address()
                {
                    City = "Kalush",
                    Street = "Stret6",
                    House = 23
                },
                BirthDay = new DateTime(1996, 10, 8)
            }
        };
    }
}