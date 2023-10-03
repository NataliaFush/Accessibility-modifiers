using Core.Entities;
using Core.Enums;
using Core.Interfaces;

namespace Core
{
    public interface IItem
    {
        Dictionary<DiscountType, IDiscount<int>> Discounts { get; set; }
        int Id { get; set; }
        string ItemName { get; set; }
        double Price { get; set; }
        double TotalPrice { get; }
        public ItemCategory Category { get; set; }
        public IItem Clone();
    }
}