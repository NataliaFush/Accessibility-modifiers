using Core.Enums;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    public class DiscountItemsCount : DiscountBase
    {
        public int ItemCount { get; set; }
        public DiscountItemsCount()
        {
            DiscountType = Enums.DiscountType.ItemsCount;
        }

        public override void SetDiscount(IOrder order)
        {
            if (order != null && order.Items != null && order.Items.Count > 0)
            {
                foreach (var item in order.Items)
                {
                    var count = 0;
                    foreach (var item2 in order.Items)
                    {
                        if (item.Id == item2.Id) count++;
                    }

                    if (count >= ItemCount)
                    {
                        AddDiscountToItem(item);
                    }
                }
            }
        }
    }
}
