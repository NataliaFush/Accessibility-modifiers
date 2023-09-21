using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class OrderBase : IOrderBase
    {
        public int DeliveryId { get; set; }
        public string DeliveryName { get; }
        public int DeliveryPrice { get; set; }
        protected readonly int _discountOver1000;
        protected readonly int _discountOver2000;
        protected readonly int _discountBithDay;

        protected OrderBase(int discountOver1000, int discountOver2000, int discountBithDay, ICustomer customer)
        {
            _discountOver1000 = discountOver1000;
            _discountOver2000 = discountOver2000;
            _discountBithDay = discountBithDay;
            Customer = customer;
        }

        public long FinalPrice;
        public int Id { get; set; }
        public List<ItemBase> Items { get; set; }
        public string CustomerId;
        public ICustomer Customer { get; set; }
        public DateTime CreateOrder { get; set; }

        public double Price
        {
            get
            {
                if (Items != null && Items.Any())
                {
                    return Items.Sum(x => x.GetTotalPrice());
                }
                else
                {
                    return 0;
                }
            }
        }

        public abstract int GetDiscount(double Price);
        public abstract double GetTotalPrice();

    }
}
