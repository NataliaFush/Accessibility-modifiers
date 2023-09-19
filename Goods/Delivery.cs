using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string DeliveryName { get; }
        public int DeliveryPrice { get; set; }

        public Delivery(string DeliveryName, int DeliveryPrice)
        {
            this.DeliveryName = DeliveryName;
            this.DeliveryPrice = DeliveryPrice;

        }
    }
}
