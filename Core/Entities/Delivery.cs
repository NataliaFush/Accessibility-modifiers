﻿using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Delivery : IDelivery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

       
    }
}
