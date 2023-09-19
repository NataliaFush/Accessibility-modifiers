using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class ItemBase : IItemBase
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string catagories;
        public uint Price { get; set; }
        public uint Discount { get; set; }
        public string Unit { get; set; }
        public double GetTotalPrice()
        {
            return Price - Discount * Price / 100;
        }
    }
}
