using Core.Entities;
using Core.Enums;

namespace Core
{
    public interface IItem
    {
        List<Discount> Discounts { get; set; }
        int Id { get; set; }
        string ItemName { get; set; }
        uint Price { get; set; }
        string Unit { get; set; }
        public ItemCategory Category { get; set; }
    }
}