using Core.Interfaces;
using System;
using System.Collections.Generic;


namespace Core.Entities.Discounts
{
    public class DiscountDate : DiscountBase<int>
    {
        public DiscountDate()
        {
            DiscountType = Enums.DiscountType.Date;
            IsOrderDiscount = true;
        }

        public override bool IsApplyDiscountForOrder(IOrder order)
        {
            if (order != null)
            {
                if (IsAdditionalDiscount)
                {
                    var dis = order.Discounts.FirstOrDefault(x => x.DiscountType == this.DiscountType);
                    if (dis != null)
                    {
                        if (dis.Amount < this.Amount)
                        {
                            order.Discounts.Remove(dis);
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (!order.Discounts.Any(x => !x.IsAdditionalDiscount))
                    {
                        return true;
                    }
                    else
                    {
                        if (order.Discounts.Any(x => !x.IsAdditionalDiscount && x.Amount < this.Amount))
                        {
                            order.Discounts.RemoveAll(x => !x.IsAdditionalDiscount);
                            return true;
                        }
                    }
                }

            }
            return false;
        }
    }
}
