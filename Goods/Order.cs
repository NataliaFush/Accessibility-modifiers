﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    public class Order : OrderBase
    {
        public Order() : base(10, 20, 30)
        {

        }

        public int GetBirthDayDiiscount(DateTime UserBirthDay)
        {
            if (UserBirthDay == base.DateOfOrder) 
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
            return totalPrice;
        }
    }
}
