
using Core.Entities;

namespace Core
{
    public interface IOrder
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int DeliveryId { get; set; }
        ICustomer Customer { get; set; }
        Delivery Delivery { get; set; }
        List<ItemBase> Items { get; set; }
        double Price { get;  }
        DateTime CreateOrder { get; set; }
        List<Discount> Discounts { get; set; }
    }
}