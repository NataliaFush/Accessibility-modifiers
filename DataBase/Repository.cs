using Core;
using Core.Entities;
using Core.Enums;
using Core.Interfaces;
using DataBase.Constants;

namespace DataBase
{
    public class Repository : IRepository
    {
        public IOrder GetOrderById(int id)
        {
            var order = GetPrivateOrderById(id);
            if (order != null)
            {
                order.Customer = GetCustomerWithOrderById(order.CustomerId);
                order.Items = GetPrivateItemsByOrderId(order.Id);
                order.Delivery = GetPrivateDeliveryById(order.DeliveryId);
                order.Discounts = new List<IDiscount<int>>();
            }
            return order;
        }

        private List<IItem> GetPrivateItemsByOrderId(int orderId)
        {
            var items = MyDbContext.Items;
            var orderItems = MyDbContext.OrderItems;
            var result = new List<IItem>();

            foreach (var orderItem in orderItems)
            {
                if (orderItem.OrderId == orderId)
                {
                    foreach (var item in items)
                    {
                        if (orderItem.ItemId == item.Id)
                        {
                            result.Add(new Item()
                            {
                                Id = item.Id,
                                Discounts = new Dictionary<DiscountType, IDiscount<int>>(),
                                Price = item.Price,
                                Category = item.Category,
                                ItemName = item.ItemName,
                            });
                        }
                    }
                }
            }

            return result;
        }

        public IItem GetItemById(int id)
        {
            var items = MyDbContext.Items;
            foreach (var item in items)
            {
                if (item.Id == id)
                {
                    return (new Item()
                    {
                        Id = item.Id,
                        Discounts = new Dictionary<DiscountType, IDiscount<int>>(),
                        Price = item.Price,
                        Category = item.Category,
                        ItemName = item.ItemName,
                    });
                }

            }
            return null;
        }
        private IDelivery GetPrivateDeliveryById(int id)
        {
            var deliverys = MyDbContext.Deliverys;
            foreach (var delivery in deliverys)
            {
                if (delivery.Id == id)
                {
                    return delivery;
                }
            }
            return null;
        }

        public ICustomer GetCustomerByOrderId(int id)
        {
            var orders = MyDbContext.Orders;
            var customers = MyDbContext.Customers;
            foreach (var order in orders)
            {
                foreach (var customer in customers)
                {
                    if (order.CustomerId == customer.Id && order.Id == id)
                    {
                        return customer;
                    }
                }
            }
            return null;
        }



        public List<IDiscount<int>> GetAllDiscount()
        {
            var discounts = MyDbContext.Discounts;
            var results = new List<IDiscount<int>   >();

            foreach (var discount in discounts)
            {
                if (discount.StartDate.HasValue && discount.EndDate.HasValue)
                {
                    if (discount.StartDate <= DateTime.Now && discount.EndDate >= DateTime.Now)
                    {
                        results.Add(discount);
                    }
                }
                else
                {
                    results.Add(discount);
                }
            }
            return results;
        }


        private ICustomer GetPrivateCustomerById(int id)
        {
            var customers = MyDbContext.Customers;
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        private IOrder GetPrivateOrderById(int id)
        {
            var orders = MyDbContext.Orders;
            foreach (var order in orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }

       

        public ICustomer GetCustomerWithOrderById(int id)
        {
            ICustomer result = GetPrivateCustomerById(id);

            if (result != null)
            {
                var orders = MyDbContext.Orders;

                List<IOrder> resOrders = new List<IOrder>();

                foreach (var order in orders)
                {
                    if (order.CustomerId == result.Id)
                    {
                        resOrders.Add(order);
                    }
                }
                result.Orders = resOrders;
            }

            return result;
        }
    }
}