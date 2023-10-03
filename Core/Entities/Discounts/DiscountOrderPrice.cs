using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    public class DiscountOrderPrice : DiscountBase<int>
    {
        public double MinPrice { get; set; }
        public DiscountOrderPrice()
        {
            DiscountType = Enums.DiscountType.OrderPrice;
            IsOrderDiscount = true;
        }

        public override bool IsApplyDiscountForOrder(IOrder order)
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
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
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
