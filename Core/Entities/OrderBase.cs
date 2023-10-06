using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public delegate void MyDel(IItem it, string msg);
    public abstract class OrderBase : IOrder
    {
        public int Id { get; set; }
        public event MyDel EventAddItem;
        public int DeliveryId { get; set; }
        public IDelivery Delivery { get; set; }

        public List<IDiscount<int>> Discounts { get; set; }
        public List<IItem> Items { get; set; }
        public int CustomerId { get; set; }
        public ICustomer Customer { get; set; }
        public DateTime CreateOrder { get; set; }

        public void AddItem(IItem item)
        {
            if (item != null)
            {
                Items.Add(item);
                EventAddItem?.Invoke(item, "You add new Item in your order");
            }
        }
        public double Price
        {
            get
            {
                return Sum<IItem>(x => x.TotalPrice, Items);
            }
        }
        public double TotalPrice
        {
            get
            {
                return Price - Sum<IDiscount<int>>(Get1, Discounts) * Price / 100;
            }
        }


        public double Sum<T>(Func<T, double> GetElement, IEnumerable<T> items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += GetElement(item);
            }
            return sum;
        }

        private double Get1(IDiscount<int> discount)
        {
            return discount.Amount;
        }

        public void SetDiscounts(IEnumerable<IDiscount<int>> discounts)
        {
            foreach (var discount in discounts)
            {
                if (discount.IsOrderDiscount)
                {
                    if (discount.IsApplyDiscountForOrder(this)) Discounts.Add(discount);
                }
                else
                {
                    foreach (var item in Items)
                    {
                        if (discount.IsApplyDiscountForItem(this, item)) AddDiscountToItem(item, discount);
                    }
                }
            }
        }

        protected void AddDiscountToItem(IItem item, IDiscount<int> discount)
        {
            if (item.Discounts.ContainsKey(discount.DiscountType) && item.Discounts[discount.DiscountType].Amount < discount.Amount)
            {
                item.Discounts[discount.DiscountType] = discount;
            }
            else if (!item.Discounts.ContainsKey(discount.DiscountType))
            {
                item.Discounts.Add(discount.DiscountType, discount);
            }
        }
    }
}
