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
        public double Price { get; set; }
    }
}
