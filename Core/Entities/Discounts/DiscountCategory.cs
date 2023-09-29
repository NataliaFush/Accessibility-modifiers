using Core.Enums;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    public class DiscountCategory : DiscountBase
    {
        public ItemCategory ItemCategory { get; set; }
        public DiscountCategory()
        {
            DiscountType = DiscountType.Category;
        }

        public override void SetDiscount(IOrder order)
        {
            if (order != null && order.Items != null && order.Items.Count > 0)
            {
                foreach (var item in order.Items)
                {
                    if (item.Category == this.ItemCategory)
                    {
                        AddDiscountToItem(item);
                    }
                }
            }
        }
    }
}
