using Core;
using Core.Entities;
using Core.Entities.Discounts;
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
            new DiscountCategory()
            {
                Id = 1,
                ItemCategory = ItemCategory.Food,
                Amount = 3,
                StartDate= new DateTime(2023, 8, 01),
                EndDate= new DateTime(2023, 10, 08),
                Description="Discount for currently catagory"
            },
            new DiscountCategory()
            {
                Id = 12,
                ItemCategory = ItemCategory.Technics,
                Amount = 12,
                StartDate= new DateTime(2023, 9, 01),
                EndDate= new DateTime(2023, 10, 08),
                Description="Discount for currently catagory"
            },
            new DiscountCategory()
            {
                Id = 11,
                ItemCategory = ItemCategory.Technics,
                Amount = 10,
                StartDate= new DateTime(2023, 9, 01),
                EndDate= new DateTime(2023, 10, 08),
                Description="Discount for currently catagory"
            },
            new DiscountItem()
            {
                Id = 2,
                ItemId = 3,
                Amount = 10,
                Description="Discount for currently items",
            },

            new DiscountOrderPrice()
            {   Id = 3,
                Amount = 5,
                MinPrice = 5000,
                Description="Discount for orders up to 5000 price",
                IsAdditionalDiscount = true,
            },

            new DiscountOrderPrice()
            {   Id = 4,
                Amount = 10,
                MinPrice = 10000,
                Description="Discount for orders up to 10000",
                IsAdditionalDiscount = true
            },

            new DiscountSelebrate()
            {   Id = 5,
                Amount= 25,
                Description="Black Friday discounts",
                StartDate= new DateTime(2023, 8, 20),
                EndDate= new DateTime(2023, 11, 25),
            },
            new DiscountItemsCount()
            {   Id = 66,
                Amount = 10,
                ItemCount  = 5,
                Description="Discount for orders with 5 items",
                IsAdditionalDiscount = true
            },
            new DiscountItemsCount()
            {   Id = 6,
                Amount = 5,
                ItemCount  = 3,
                Description="Discount for orders with 3 items",
                IsAdditionalDiscount = true
            },
            new DiscountDate()
            {
                Id = 7,
                Amount = 3,
                StartDate= new DateTime(2023, 9, 01),
                EndDate= new DateTime(2023, 10, 08),
                Description="Discount for date",
            }
        };
    }
}
