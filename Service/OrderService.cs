using Core;
using Core.Entities;
using Core.Enums;
using Core.Interfaces;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService
    {
        protected IRepository _repository;

        public OrderService(IRepository repository)
        {
            _repository = repository;
        }

        public IOrder GetOrderById(int id)
        {
            return _repository.GetOrderById(id);
        }

        public void SetDiscountsToOrders(IEnumerable<IOrder> orders)
        {
            if (orders != null && orders.Count() > 0)
            {
                foreach (var order in orders)
                {
                    SetDiscountsToOrder(order);
                }
            }
        }

        public void SetPriceToOrders(IEnumerable<IOrder> orders)
        {
            if (orders != null && orders.Count() > 0)
            {
                foreach (var order in orders)
                {
                    SetPriceToOrder(order);
                }
            }
        }

        public void SetDiscountsToOrder(IOrder order)
        {
            var discounts = _repository.GetCurrentDateDiscounts();
            if (order != null)
            {
                order.Discounts = new List<IDiscount>();
                foreach (var discount in discounts)
                {
                    switch (discount.DiscountType)
                    {
                        case DiscountType.Date:
                            SetDateDiscount(discount, order);
                            break;
                        case DiscountType.Category:
                            SetCategoryDiscount(discount, order);
                            break;
                        case DiscountType.ItemsCount:
                            SetItemCountDiscount(discount, order);
                            break;
                        case DiscountType.OrderPrice:
                            SetOrderPriceDiscount(discount, order);
                            break;
                        case DiscountType.Item:
                            SetItemDiscount(discount, order);
                            break;
                        case DiscountType.Selebrate:
                            SetSelebrateDiscount(discount, order);
                            break;
                        default: break;
                    }

                }
            }
        }

        public void SetPriceToOrder(IOrder order)
        {
            if (order != null)
            {
                double price = 0;
                foreach (var item in order.Items)
                {
                    price += GetItemPrice(item);
                }

                var count = 0;
                if (order.Discounts != null && order.Discounts.Count > 0)
                {
                    foreach (var discount in order.Discounts)
                    {
                        if (discount.DiscountType != DiscountType.OrderPrice) count += discount.Amount;
                    }
                }
                order.Price = price - count * price / 100;
                SetOrderPriceDiscount(order);
            }
        }

        private void SetOrderPriceDiscount(IOrder order)
        {
            int count = 0;
            foreach (var discount in order.Discounts)
            {
                if (discount.DiscountType == DiscountType.OrderPrice &&
                    discount.MinValue.HasValue &&
                    order.Price >= discount.MinValue &&
                    count < discount.Amount)
                {
                    count = discount.Amount;
                }
            }
            order.Price = order.Price - count * order.Price / 100;
        }

        private double GetItemPrice(IItem item)
        {
            if (item != null)
            {
                var count = 0;
                if (item.Discounts != null && item.Discounts.Count > 0)
                {
                    foreach (var discount in item.Discounts)
                    {
                        count += discount.Amount;
                    }
                }
                return item.Price - count * item.Price / 100;
            }
            return default(double);
        }

        private void SetDateDiscount(IDiscount discount, IOrder order)
        {
            order.Discounts.Add(discount);
        }

        private void SetCategoryDiscount(IDiscount discount, IOrder order)
        {
            foreach (var item in order.Items)
            {
                if (discount.Category.HasValue && item.Category == discount.Category)
                {
                    item.Discounts.Add(discount);
                }
            }
        }

        private void SetItemCountDiscount(IDiscount discount, IOrder order)
        {
            foreach (var item in order.Items)
            {
                var count = 0;
                foreach (var item2 in order.Items)
                {
                    if (item.Id == item2.Id) count++;
                }

                if (count >= discount.MinValue)
                {
                    item.Discounts.Add(discount);
                }
            }
        }

        private void SetOrderPriceDiscount(IDiscount discount, IOrder order)
        {
            order.Discounts.Add(discount);
        }

        private void SetItemDiscount(IDiscount discount, IOrder order)
        {
            foreach (var item in order.Items)
            {
                if (discount.ItemId.HasValue && item.Id == discount.ItemId)
                {
                    item.Discounts.Add(discount);
                }
            }
        }

        private void SetSelebrateDiscount(IDiscount discount, IOrder order)
        {
            order.Discounts.Add(discount);
        }

    }
}
