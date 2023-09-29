using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    public class DiscountOrderPrice : DiscountBase
    {
        public double MinPrice { get; set; }
        public DiscountOrderPrice()
        {
            DiscountType = Enums.DiscountType.OrderPrice;
            IsOrderDiscount = true;
        }

        public override void SetDiscount(IOrder order)
        {
            if (order != null)
            {
                if (IsAdditionalDiscount)
                {
                    var price = order.Price;
                    if (price > this.MinPrice)
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
