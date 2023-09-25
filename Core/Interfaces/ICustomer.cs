
using Core.Entities;
using Core.Enums;

namespace Core
{
    public interface ICustomer
    {
        Address DeliveryAddress { get; set; }
        IEnumerable<IOrder> Orders { get; set; }
        DateTime BirthDay { get; set; }

        int Id { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        UserType UserType { get; }
        
    }
}