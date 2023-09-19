
using Core.Entities;

namespace Core
{
    public interface IOrderBase
    {
        ICustomer Customer { get; set; }
        int DeliveryId { get; set; }
        string DeliveryName { get; }
        int DeliveryPrice { get; set; }
        List<ItemBase> Items { get; set; }
        double Price { get; }
        DateTime CreateOrder { get; set; }

        int GetDiscount(double Price);
        double GetTotalPrice();
    }
}