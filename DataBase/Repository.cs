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
                order.Delivery = GetPrivateDeliveryById(order.DeliveryId);
                order.Customer = GetPrivateCustomerById(order.CustomerId);
                order.Items = GetPrivateItemsByOrderId(order.Id);
            }
            return order;
        }

        public List<IItem> GetItemsByOrderId(int id)
        {
            return GetPrivateItemsByOrderId(id);
        }



        public List<IDiscount> GetCurrentDateDiscounts()
        {
            var discounts = MyDbContext.Discounts;
            var result = new List<IDiscount>();

            foreach (var item in discounts)
            {
                if (item.StartDate.HasValue && item.EndDate.HasValue)
                {
                    if (item.StartDate <= DateTime.Now && item.EndDate >= DateTime.Now)
                    {
                        result.Add(item);
                    }
                }
                else
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public double GetPriceByOrderId(int id)
        {
            double price = 0;
            var orderItems = GetPrivateItemsByOrderId(id);
            foreach (var item in orderItems)
            {
                price += item.Price;
            }

            return price;
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

        private List<IItem> GetPrivateItemsByOrderId(int id)
        {
            var orderItems = MyDbContext.OrderItems;
            var items = MyDbContext.Items;

            List<IItem> resItems = new List<IItem>();

            foreach (var orderItem in orderItems)
            {
                if (orderItem.OrderId == id)
                {
                    foreach (var item in items)
                    {
                        if (orderItem.ItemId == item.Id)
                        {
                            resItems.Add(item.Clone());
                        }
                    }
                }
            }
            return resItems;
        }

        public ICustomer GetCustomerWithOrdersById(int id)
        {
            var customer = GetPrivateCustomerById(id);
            if (customer != null)
            {
                var orders = MyDbContext.Orders;

                List<IOrder> resOrders = new List<IOrder>();

                foreach (var order in orders)
                {
                    if (order.CustomerId == customer.Id)
                    {
                        resOrders.Add(GetOrderById(order.Id));
                    }
                }
                customer.Orders = resOrders;

            }
            return customer;
        }
    }
}