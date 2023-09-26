using Core.Enums;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class ItemBase : IItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public ItemCategory Category { get; set; }
        public double Price { get; set; }
        public List<IDiscount> Discounts { get; set; }
        public string Unit { get; set; }
        public abstract IItem Clone();
    }
}
