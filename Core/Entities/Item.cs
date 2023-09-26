using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Item : ItemBase
    {
        public override IItem Clone()
        {
            return new Item()
            {
                Category = Category,
                Discounts = Discounts != null? new List<IDiscount>(Discounts) : new List<IDiscount>(),
                Id = Id,
                ItemName = ItemName,
                Price = Price,
                Unit = Unit != null ? new string(Unit) : string.Empty,
            };
        }
    }
}
