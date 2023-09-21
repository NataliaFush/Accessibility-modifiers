using Core;
using Core.Entities;
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
        public static IEnumerable<Delivery> Deliverys = new List<Delivery>()
        {
            new Delivery()
            {
                Id = 1,
                Name = "Nova Poshta",
                Price = 100

            },

            new Delivery()
            {
                Id= 2,
                Name = "Meast",
                Price= 50
            },

            new Delivery()
            {
                Id =3,
                Name="UkrPoshta",
                Price=30
            }

          
            

        };
    }
}
