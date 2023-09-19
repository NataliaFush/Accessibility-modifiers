
using Core.Entities;

namespace Core
{
    public interface ICustomer
    {
        Address DeliveryAddress { get; set; }
        int Discount { get; set; }
        ICollection<IOrderBase> Orders { get; set; }
        DateTime BirthDay { get; set; }
    }
}