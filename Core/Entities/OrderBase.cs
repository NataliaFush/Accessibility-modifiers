using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class OrderBase : IOrder
    {
        public int Id { get; set; }

        public int DeliveryId { get; set; }
        public IDelivery Delivery { get; set; }

        public List<IDiscount> Discounts { get; set; }
        public List<IItem> Items { get; set; }
        public int CustomerId { get; set; }
        public ICustomer Customer { get; set; }
        public DateTime CreateOrder { get; set; }
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
                return Price - Sum<IDiscount>(Get1, Discounts) * Price / 100;
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

        private double Get1 (IDiscount discount)
        {
            return discount.Amount;
        }


        
        //public abstract U Foo<T, U>(T item);

    }
}
