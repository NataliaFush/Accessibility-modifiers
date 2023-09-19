using Core.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order : OrderBase
    {
        public Order(ICustomer customer) : base(10, 20, 30, customer) { }

        public int GetBirthDayDiiscount(DateTime UserBirthDay)
        {
            if (UserBirthDay.EquilBirthDay(base.CreateOrder))
            {
                return _discountBithDay;
            }
            else return 0;
        }

        public override int GetDiscount(double Price)
        {
            if (Price < 1000) return 0;
            else if (Price < 2000) return _discountOver1000;
            else return _discountOver2000;
        }

        public override double GetTotalPrice()
        {
            var totalPrice = Price;
            totalPrice -= GetDiscount(totalPrice) * totalPrice / 100 - GetBirthDayDiiscount(Customer.BirthDay) * totalPrice / 100;
            return totalPrice;
        }
    }
}
