using Core.Enums;

namespace Core.Interfaces
{
    public interface IDiscount
    {
        public int Id { get; set; }
        string Description { get; set; }
        public DiscountType DiscountType { get; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        int Amount { get; set; }
        bool IsOrderDiscount { get; set; }
        bool IsAdditionalDiscount { get; set; }
        void SetDiscount(IOrder order);
    }

   
}