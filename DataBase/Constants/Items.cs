using Core;
using Core.Entities;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static IEnumerable<IItem> Items = new List<IItem>()
        {
            new Item()
            {
                Id = 1,
                ItemName = "Fridge Samsung",
                Category = ItemCategory.Technics,
                Price = 39999
            },


            new Item()
            {
                Id = 2,
                ItemName = "Dress Gucci",
                Category = ItemCategory.Textile,
                Price = 10000
            },

            new Item()
            {
                Id = 3,
                ItemName = "Salmon Marinero",
                Category = Core.Enums.ItemCategory.Food,
                Price = 400
            },

            new Item()
            {
                Id = 4,
                ItemName = "Keyboard Tosiba",
                Category = Core.Enums.ItemCategory.Technics,
                Price = 39999
            },

            new Item()
            {
                Id = 5,
                ItemName = "Wisky Jeck Daniels",
                Category = Core.Enums.ItemCategory.Food,
                Price = 8000
            }
        };
    }
}




