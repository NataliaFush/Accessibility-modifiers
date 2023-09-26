using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    internal abstract class DiscountBase
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public DiscountType DiscountType { get; }
        public abstract void SetDiscount(IOrder order);
    }
}
