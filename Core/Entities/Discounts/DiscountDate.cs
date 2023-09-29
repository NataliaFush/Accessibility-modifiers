using Core.Interfaces;
using System;
using System.Collections.Generic;


namespace Core.Entities.Discounts
{
    public class DiscountDate : DiscountBase
    {
        public DiscountDate()
        {
            DiscountType = Enums.DiscountType.Date;
            IsOrderDiscount = true;
        }

        public override void SetDiscount(IOrder order)
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
                            order.Discounts.Add(this);
                        }
                    }
                    else
                    {
                        order.Discounts.Add(this);
                    }
                }
                else
                {
                    if (!order.Discounts.Any(x => !x.IsAdditionalDiscount))
                    {
                        order.Discounts.Add(this);
                    }
                    else
                    {
                        if (order.Discounts.Any(x => !x.IsAdditionalDiscount && x.Amount < this.Amount))
                        {
                            order.Discounts.RemoveAll(x => !x.IsAdditionalDiscount);
                            order.Discounts.Add(this);
                        }
                    }
                }

            }
        }
    }
}
