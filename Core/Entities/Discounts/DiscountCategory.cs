using Core.Enums;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Discounts
{
    public class DiscountCategory : DiscountBase<int>
    {
        public ItemCategory ItemCategory { get; set; }
        public DiscountCategory()
        {
            DiscountType = DiscountType.Category;
        }

        public override bool IsApplyDiscountForItem(IOrder order, IItem item)
        {
            if (order != null && order.Items != null && order.Items.Count > 0)
            {
                if (item.Category == this.ItemCategory)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
