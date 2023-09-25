using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static IEnumerable<OrderItems> OrderItems = new List<OrderItems>
        {
            new OrderItems {OrderId = 1, ItemId = 1},
            new OrderItems {OrderId = 1, ItemId = 2},
            new OrderItems {OrderId = 1, ItemId = 2},
            new OrderItems {OrderId = 1, ItemId = 4},
            new OrderItems {OrderId = 2, ItemId = 5},
            new OrderItems {OrderId = 3, ItemId = 3},
            new OrderItems {OrderId = 3, ItemId = 5},
            new OrderItems {OrderId = 3, ItemId = 1},
            new OrderItems {OrderId = 4, ItemId = 3},
            new OrderItems {OrderId = 4, ItemId = 4},
            new OrderItems {OrderId = 5, ItemId = 5},
            new OrderItems {OrderId = 5, ItemId = 2},
            new OrderItems {OrderId = 5, ItemId = 1},
            new OrderItems {OrderId = 6, ItemId = 4}
           
        };
    }
}
