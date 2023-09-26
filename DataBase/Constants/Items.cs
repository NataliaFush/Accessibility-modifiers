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
                Category = ItemCategory.Food,
                Price = 400
            },

            new Item()
            {
                Id = 4,
                ItemName = "Keyboard Tosiba",
                Category = ItemCategory.Technics,
                Price = 400
            },

            new Item()
            {
                Id = 5,
                ItemName = "Wisky Jeck Daniels",
                Category = ItemCategory.Food,
                Price = 800
            }
        };
    }
}




