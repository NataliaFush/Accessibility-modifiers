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
        public Dictionary<DiscountType, IDiscount<int>> Discounts { get; set; }
        public double TotalPrice
        {
            get
            {
                if (Discounts != null && Discounts.Count > 0)
                {
                    return Price - SumAllAmount(Discounts) * Price / 100;
                }
                return Price;
            }
        }
        public abstract IItem Clone();

        private double SumAllAmount(IEnumerable<KeyValuePair<DiscountType, IDiscount<int>>> discounts)
        {
            double sum = 0;
            foreach (var discount in discounts)
            {
                sum += discount.Value.Amount;
            }
            return sum;
        }
    }
}
