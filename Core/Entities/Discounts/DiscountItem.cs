using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    public class DiscountItem : DiscountBase
    {
        public int ItemId { get; set; }
        public DiscountItem()
        {
            DiscountType = Enums.DiscountType.Item;
        }

        public override void SetDiscount(IOrder order)
        {
            if (order != null && order.Items != null && order.Items.Count > 0)
            {
                foreach (var item in order.Items)
                {
                    if (item.Id == ItemId)
                    {
                        AddDiscountToItem(item);
                    }
                }
            }
        }
    }
}
