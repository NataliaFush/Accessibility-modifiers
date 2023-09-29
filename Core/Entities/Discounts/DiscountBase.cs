using Core.Enums;
using Core.Interfaces;

namespace Core.Entities.Discounts
{
    public abstract class DiscountBase : IDiscount
    {
        public int Id { get; set; }
        public DiscountType DiscountType { get; protected set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsAdditionalDiscount { get; set; }
        public bool IsOrderDiscount { get; set; }

        public virtual void SetDiscount(IOrder order)
        {
           
        }

        protected void AddDiscountToItem(IItem item)
        {
            if (item.Discounts.ContainsKey(this.DiscountType) && item.Discounts[this.DiscountType].Amount < this.Amount)
            {
                item.Discounts[this.DiscountType] = this;
            }
            else if (!item.Discounts.ContainsKey(this.DiscountType))
            {
                item.Discounts.Add(this.DiscountType, this);
            }
        }
    }
}
