using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Discount
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public DiscountType DiscountType { get; set; }
        public ItemCategory Category { get; set; }
        public int? MinCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? OrderId { get; set; }
        public int? ItelId { get; set; }
    }
}
