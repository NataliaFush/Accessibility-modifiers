using Core;
using Core.Entities;
using Core.Enums;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static IEnumerable<IDiscount> Discounts = new List<IDiscount>()
        {
            new Discount()
            {
                Id = 1,
                DiscountType = DiscountType.Category,
                Category = ItemCategory.Food,
                Amount = 3,
                StartDate= new DateTime(2023, 10, 01),
                EndDate= new DateTime(2023, 10, 08),
                Description="Discount for currently catagory"
            },

            new Discount()
            {
                Id = 2,
                DiscountType=DiscountType.Item,
                ItemId = 3,
                Amount = 10,
                Description="Discount for currently items",
            },

            new Discount()
            {   Id = 3,
                DiscountType = DiscountType.OrderPrice,
                Amount = 5,
                MinValue = 5000,
                Description="Discount for orders up to 5000 price",
            },

            new Discount()
            {   Id = 4,
                DiscountType = DiscountType.OrderPrice,
                Amount = 10,
                MinValue = 10000,
                Description="Discount for orders up to 10000",
            },

            new Discount()
            {   Id = 5,
                DiscountType=DiscountType.Selebrate,
                Amount= 25,
                Description="Black Friday discounts",
                StartDate= new DateTime(2023, 11, 20),
                EndDate= new DateTime(2023, 11, 25)
            },

            new Discount()
            {   Id = 6,
                DiscountType = DiscountType.ItemsCount,
                Amount = 10,
                MinValue = 3,
                Description="Discount for orders with 3 items",
            },

            new Discount()
            {
                Id = 7,
                DiscountType = DiscountType.Date,
                Amount = 3,
                StartDate= new DateTime(2023, 9, 01),
                EndDate= new DateTime(2023, 10, 08),
                Description="Discount for date"
            },
            new Discount()
            {
                Id = 8,
                DiscountType = DiscountType.Category,
                Category = ItemCategory.Technics,
                Amount = 2,
                Description="Discount for currently catagory"
            }
        };
    }
}
