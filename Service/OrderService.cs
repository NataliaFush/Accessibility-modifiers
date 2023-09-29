using Core;
using Core.Entities;
using Core.Entities.Discounts;
using Core.Enums;
using Core.Interfaces;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService
    {
        protected IRepository _repository;

        public OrderService(IRepository repository)
        {
            _repository = repository;
        }

        public IOrder GetOrderById(int id)
        {
            var order = _repository.GetOrderById(id);
            
            ApplyDiscounts(order);
            return order;
        }

        private void ApplyDiscounts(IOrder order)
        {
            var discountList = _repository.GetAllDiscount().OrderBy(x => x.IsOrderDiscount);

            foreach (var discount in discountList)
            {
                discount.SetDiscount(order);
            }
        }
    }
}
