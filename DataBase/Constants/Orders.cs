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
        public static IEnumerable<IOrder> Orders = new List<IOrder>()
        {
             new Order()
             {
                 Id=1,
                 CustomerId=1,
                 CreateOrder = new DateTime(2023, 7, 20),
                 DeliveryId = 1
             },

             new Order()
             {
                 Id=2,
                 CustomerId=2,
                 CreateOrder = new DateTime(2023, 6, 9),
                 DeliveryId = 3
             },

             new Order()
             {
                 Id=3,
                 CustomerId=2,
                 CreateOrder = new DateTime(2023, 8, 30),
                 DeliveryId = 1
             },

             new Order()
             {
                 Id=4,
                 CustomerId=3,
                 CreateOrder = new DateTime(2023, 9, 10),
                 DeliveryId = 2
             },
             new Order()
             {
                 Id=5,
                 CustomerId=3,
                 CreateOrder = new DateTime(2023, 7, 22),
                 DeliveryId = 2
             },
             new Order()
             {
                 Id=6,
                 CustomerId=3,
                 CreateOrder = new DateTime(2023, 7, 28),
                 DeliveryId = 3
             },

        };
    }
}
