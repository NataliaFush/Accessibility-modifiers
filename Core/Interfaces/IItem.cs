using Core.Entities;
using Core.Enums;
using Core.Interfaces;

namespace Core
{
    public interface IItem
    {
        List<IDiscount> Discounts { get; set; }
        int Id { get; set; }
        string ItemName { get; set; }
        double Price { get; set; }
        string Unit { get; set; }
        public ItemCategory Category { get; set; }
        public IItem Clone();
    }
}