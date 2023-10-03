using Core.Entities;
using Core.Enums;

namespace Core.Interfaces
{
    public interface IDiscount<T>
    {
        public T Id { get; set; }
        string Description { get; set; }
        public DiscountType DiscountType { get; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        int Amount { get; set; }
        bool IsOrderDiscount { get; set; }
        bool IsAdditionalDiscount { get; set; }
        bool IsApplyDiscountForOrder(IOrder order);
        bool IsApplyDiscountForItem(IOrder order, IItem item);
    }

   
}