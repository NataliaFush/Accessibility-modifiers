using Core.Enums;

namespace Core.Interfaces
{
    public interface IDiscount
    {
        public int Id { get; set; }
        string Description { get; set; }
        DiscountType DiscountType { get; set; }
        ItemCategory? Category { get; set; }
        DateTime? EndDate { get; set; }
        int? ItemId { get; set; }
        int? MinValue { get; set; }
        int? OrderId { get; set; }
        DateTime? StartDate { get; set; }
        int Amount { get; set; }
    }
}