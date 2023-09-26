
using Core.Entities;
using Core.Interfaces;

namespace Core
{
    public interface IOrder
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int DeliveryId { get; set; }
        ICustomer Customer { get; set; }
        IDelivery Delivery { get; set; }
        List<IItem> Items { get; set; }
        double Price { get; set; }
        DateTime CreateOrder { get; set; }
        List<IDiscount> Discounts { get; set; }
    }
}