using Core.Enums;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Discount : IDiscount
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public DiscountType DiscountType { get; set; }
        public ItemCategory? Category { get; set; }
        public int? MinValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
    }
}
