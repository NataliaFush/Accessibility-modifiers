using Core.Enums;
using Core.Interfaces;

namespace Core.Entities.Discounts
{
    public abstract class DiscountBase<T> : IDiscount<T>
    {
        public T Id { get; set; }
        public DiscountType DiscountType { get; protected set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsAdditionalDiscount { get; set; }
        public bool IsOrderDiscount { get; set; }

        public virtual bool IsApplyDiscountForOrder(IOrder order)
        {
            return false;
        }

        public virtual bool IsApplyDiscountForItem(IOrder order, IItem item)
        {
            return false;
        }
    }
}
